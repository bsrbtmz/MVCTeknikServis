using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeknikServis.BLL.Service;

namespace TeknikServis.UI.Services
{
    public sealed class DataService
    {
        private static readonly EntityService service = new EntityService();
        private DataService() { }
        public static EntityService Service
        {
            get
            {
                return service;
            }
        }
    }
}