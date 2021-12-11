using QuangApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuangApp.Data
{
    public class MyDBContext: DbContext
    {
        public MyDBContext():base("name = MyDBContext")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}