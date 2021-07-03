using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PhoneMarket.Models
{
    /// <summary>
    /// Класс реализующий структуру таблиц БД для ООП
    /// </summary>
    public class PhoneContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }

        public DbSet<Purchase> Purchases {get;set;}
    }
}