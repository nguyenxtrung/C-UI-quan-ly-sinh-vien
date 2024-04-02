using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _20t1020610.Model
{
    public class Clothes
    {
        public string MSP { get; set; }
        public string TSP { get; set; }
        public DateTime NSX { get; set; }
        public DateTime NHH { get; set; }

        public int GB { get; set; }
        public int GN { get; set; }
        public int SLN { get; set; }
        public string hinhDaidien { get; set; }

        public List<Clothes> ListClothes { get; set; }
        public override string ToString()
        {
            var json = JsonSerializer.Serialize(this);
            return json;
        }
        public static Clothes FromJson(string json)
        {
            var obj = JsonSerializer.Deserialize<Clothes>(json);
            return obj;
        }
    }
}
