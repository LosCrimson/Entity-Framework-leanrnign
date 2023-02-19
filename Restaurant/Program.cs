using Restaurant.BusinessLogic.Services;
using Restaurant.Models;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Restaurant.Repository;
using Restaurant.BusinessLogic.Interfaces;
using Restaurant.Repository.Interfaces;
using Restaurant.Repos;
using System;

namespace Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Second Dependancy implementation--------------------------------

            IHost host = CreateHostBuilder(args).Build();
            var tableService = host.Services.GetRequiredService<ITableService>();

            //First implementation--------------------------------------------
            
            tableService.AddTables();

            var table = (Table)tableService.GetTableByCapacity(20);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Seating capacity: {table.SeatingCapacity} Occupied: {table.Occupied}");

            //Second Dependancy implementation--------------------------------

            host.Run();

            //Original--------------------------------------------------------

            //var uiService = new UiService();
            //var orders = new Orders();
            //var listService = new ListService();
            //var emailService = new EmailService();
            //var menu = new Menu();
            //var tables = new Tables();
            //var menuService = new MenuService();
            //var orderService = new OrderService(uiService, orders, listService, emailService, menu, tables, menuService);
            //orderService.MainMenu();
            Console.ReadLine();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            return Host.CreateDefaultBuilder(args).ConfigureServices((hostContext, services) =>
            {
                services.AddDbContext<RestaurantDbContext>(options => { options.UseSqlServer(hostContext.Configuration.GetConnectionString("DefaultConnection")); }, ServiceLifetime.Scoped);
                services.AddScoped<ITableService, TableService>();
                services.AddScoped<ITables, Tables>();
            });
        }
    }
}