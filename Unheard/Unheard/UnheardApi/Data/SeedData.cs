using System.Linq;
using UnheardApi.Models;

namespace UnheardApi.Data
{
    public class SeedData
    {
        public static void Initialize(UnheardApiContext context)
        {
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new Models.User
                    {
                        UserName = "Kaylen",
                        Email = "@gmail.com",
                        Gender = "Female",
                        Password = "123",

                    }
                );
                context.SaveChanges();
            }
        }
    }
}