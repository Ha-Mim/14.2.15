using System.Collections.Generic;
using AjaxApp.Models;

namespace AjaxApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AjaxApp.Models.DepartmentDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AjaxApp.Models.DepartmentDbContext context)
        {
            var departments = new List<Department>
            {
                new Department() { Code = "CSE",   Name = "Computer Science"},
                 new Department() { Code = "BBA",   Name = "Business"},
                 new Department() { Code = "PHY",   Name = "Physics"},
                
            };
            departments.ForEach(s => context.Departments.AddOrUpdate(s));
            context.SaveChanges();
        }
    }
}
