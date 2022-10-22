using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketSelling
{
    public class Veriler
    {
        public List<Yolcu> YolcuListesi { get; set; } = new List<Yolcu>();
        public List<int> DoluKoltuklar { get; set; }
        public List<int> BosKoltuklar { get; set; }
    }
}
