using Common.DataBase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Common.DataBase
{
    public class DbContxt : DbContext
    {
        public DbSet<Person> Person { get; set; }
    }
}