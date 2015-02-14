using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AjaxApp.Models
{
    public class DepartmentDbContext:DbContext

    {
        public DepartmentDbContext():base("myAjax")
        {
            
        }
        public DbSet<Department> Departments { set; get; }
    }
}