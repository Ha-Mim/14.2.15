using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AjaxApp.Models
{
    public class Department
    {
        public int Id { set; get; }
        [Required]
        public String Code { set; get; }
        [Required]
        public String Name { set; get; }
    }
}