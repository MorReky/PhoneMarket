using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using PhoneMarket.Models;
using System.Data.Entity;

namespace PhoneMarket
{
   /// <summary>
   /// Ќеоб€зательный класс, используемый дл€ регистрации обработчиков событий
   /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //«адает инициализатор базы данных. »нициализатор базы данных вызываетс€, когда данный DbContext тип используетс€ дл€ доступа к базе данных в первый раз
            Database.SetInitializer(new DBInitialazer());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
