using System.Linq;

namespace UnheardApi.Data
{
    public class SeedData
    {
        public static void Initialize(UserContext context)
        {
            if (!context.UserInfo.Any())
            {
                context.UserInfo.AddRange(
                    new Models.User
                    {
                        UserName ="Kaylen",
                        Email ="@gmail.com",
                        Gender ="Female",
                        Password = "123",
                      
                    }
                );
                context.SaveChanges();
            }
        }
    }