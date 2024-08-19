using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public class DbInitializer
    {
        public  static async Task Initialize (StoreContext context,UserManager<User> userManager){
            if (!userManager.Users.Any()){
                var user=new User{
                    FirstName = "stefan",
                    LastName = "lalovic",
                    UserName = "lala",
                    Email="stefan@test.com",
                    JMBG = "0307001171672"
                };
                await userManager.CreateAsync(user,"Pa$$w0rd");
                await userManager.AddToRoleAsync(user,"Member");
                var admin=new User{
                    FirstName = "gradska",
                    LastName = "uprava",
                    UserName = "admin",
                    Email = "gradskauprava@test.com",
                    JMBG = "010101010101010"
                    
                };
                await userManager.CreateAsync(admin,"Pa$$w0rd");
                await userManager.AddToRoleAsync(admin,"Admin");
            }
           
            context.SaveChanges();
        }
    }
}