using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UnheardApi.Models
{
    public class PicturesUpLoad
    {
        [Key]
        public int UserId { get; set; }
        public PicturesUpLoad pictures { get; set; }

    }

}

