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
                    UserName="gradjanin",
                    Email="gradjanin@test.com",
                };
                await userManager.CreateAsync(user,"Pa$$w0rd");
                await userManager.AddToRoleAsync(user,"Member");
                var admin=new User{
                    UserName="admin",
                    Email="admin@test.com",
                
                    
                };
                await userManager.CreateAsync(admin,"Pa$$w0rd");
                await userManager.AddToRoleAsync(admin,"Admin");
            }
           
            context.SaveChanges();
        }
    }
}