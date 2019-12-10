using Unheard.Services.Interfaces;
using PrismMapsExample;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace Unheard.Services
{
    public class ZipContentPackage : IContentPackage
    {

        public void ExtractResourceFiles(string source,  string destination, string zipFileName)
        {
            var sourcePath = Path.Combine(source, zipFileName);

         //   if (!Directory.Exists(destination))
                Directory.CreateDirectory(destination);

            try
            {
                Directory.Delete(destination, true);

                if (File.Exists(sourcePath))
                {
                    using (var zip = ZipFile.Open(sourcePath, ZipArchiveMode.Read))
                    {
                      //  var resourceContentPath = GetContentResourceStorePath();

                        foreach (var entry in zip.Entries)
                        {
                            var fullName = Path.Combine(destination, entry.FullName);

                            if (string.IsNullOrEmpty(entry.Name))
                                Directory.CreateDirectory(fullName);
                            else
                                entry.ExtractToFile(fullName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               
            }


        }
    }
}
