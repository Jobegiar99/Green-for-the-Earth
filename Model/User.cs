using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_for_the_Earth.Model
{
    public class Use
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public double Casa { get; set; }
        public double Transporte { get; set; }
        public double Comida { get; set; }

        public Use()
        {
            Casa = 0;
            Transporte = 0;
            Comida = 0;
        }
    }
}
