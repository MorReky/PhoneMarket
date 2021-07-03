using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneMarket.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        public int PhoneId { get; set; }

        public DateTime DateTime { get; set; }

        public string Email { get; set; }

        public string FIO { get; set; }

        public string Adress { get; set; }
    }
}