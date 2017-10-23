using FlatPlanetCafe.Data;
using FlatPlanetCafe.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.Extensions.DependencyInjection;
using FlatPlanetCafe.Models.ManageViewModels;

namespace FlatPlanetCafe.Controllers
{
    [Authorize(Roles = "Users")]
    public class LoyaltyController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;

        public LoyaltyController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }

        [DisableCors]
        public async Task<IActionResult> Index([DependencyInject] string userId)
        {
            // Entity framework doesn't support query hints
            userId = userId ?? userManager.GetUserId(User);
            using (var connection = context.Database.GetDbConnection())
            {
                await connection.OpenAsync();
                var cupsOfCoffeePurchased = (await connection
                    .QueryAsync<int>($"SELECT [Purchases] FROM [CoffeeCups] WITH (NOLOCK) WHERE [UserId] = '{userId}'"))
                    .FirstOrDefault();

                ViewData["CupsOfCoffeePurchased"] = cupsOfCoffeePurchased;
                ViewData["CupsOfCoffeeUntilNextFree"] = 10 - (Convert.ToInt32(cupsOfCoffeePurchased) % 10);
            }            

            return View();
        }        
    }
}
