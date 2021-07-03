using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PhoneMarket.Models
{
    public class DBInitialazer : DropCreateDatabaseAlways<PhoneContext>
    {

        protected override void Seed(PhoneContext context)
        {
            context.Phones.Add(new Phone() { Name = "Huawei P20", Price = 40000, Producer = "Huawei" });
            context.Phones.Add(new Phone() { Name = "Samsung Galaxy S5", Price = 14000, Producer = "Samsung" });
            context.Phones.Add(new Phone() { Name = "Nokia Lumia 630", Price = 8000, Producer = "Nokia" });
            base.Seed(context);
        }
    }
}