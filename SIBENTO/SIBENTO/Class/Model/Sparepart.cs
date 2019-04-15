using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIBENTO.Class.Model
{
    class Sparepart
    {
        public string id { get; set; }
        public string name { get; set; }
        public string brand { get; set; }
        public string type { get; set; }
        public string stock { get; set; }
        public string min_stock { get; set; }
        public string buy_price { get; set; }
        public string sell_price { get; set; }
        public string placement { get; set; }
        public string placement_position { get; set; }
        public string placement_place { get; set; }
        public string placement_number { get; set; }
        public string image { get; set; }

        public Sparepart()
        {
            this.id = id;
            this.name = name;
            this.brand = brand;
            this.type = type;
            this.stock = stock;
            this.min_stock = min_stock;
            this.buy_price = buy_price;
            this.sell_price = sell_price;
            this.placement = placement;
            this.placement_position = placement_position;
            this.placement_place = placement_place;
            this.placement_number = placement_number;
            this.image = image;
        }

        public Sparepart(string id, string name, string brand, string type, string stock, string min_stock, string buy_price, 
            string sell_price, string placement, string placement_position, string placement_place, string placement_number,
            string image)
        {
            this.id = id;
            this.name = name;
            this.brand = brand;
            this.type = type;
            this.stock = stock;
            this.min_stock = min_stock;
            this.buy_price = buy_price;
            this.sell_price = sell_price;
            this.placement = placement;
            this.placement_position = placement_position;
            this.placement_place = placement_place;
            this.placement_number = placement_number;
            this.image = image;
        }

        public override bool Equals(object obj)
        {
            var sparepart = obj as Sparepart;
            return sparepart != null &&
                   id == sparepart.id;
        }

        public void Update(Sparepart sparepart)
        {
            this.id = sparepart.id;
            this.name = sparepart.name;
            this.brand = sparepart.brand;
            this.type = sparepart.type;
            this.stock = sparepart.stock;
            this.min_stock = sparepart.min_stock;
            this.buy_price = sparepart.buy_price;
            this.sell_price = sparepart.sell_price;
            this.placement = sparepart.placement;
            this.placement_position = sparepart.placement_position;
            this.placement_place = sparepart.placement_place;
            this.placement_number = sparepart.placement_number;
            this.image = sparepart.image;
        }
    }
}
