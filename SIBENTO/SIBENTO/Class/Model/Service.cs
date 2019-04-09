using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIBENTO.Class.Model
{
    class Service
    {
        public int id_service { get; set; }
        public string name_service { get; set; }
        public string price_service { get; set; }

        public Service(int id_service, string name_service, string price_service)
        {
            this.id_service = id_service;
            this.name_service = name_service;
            this.price_service = price_service;
        }

        public override bool Equals(object obj)
        {
            var service = obj as Service;
            return service != null &&
                   id_service == service.id_service;
        }

        public void Update(Service service)
        {
            this.id_service = service.id_service;
            this.name_service = service.name_service;
            this.price_service = service.price_service;
        }
    }
}
