using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    

    

        
    public partial class Airplane
    {
        public static int GlobalId = 0;
        public int Id { get; set; }
        public string Model { get; set; }

        public int Passengers { get; set; }

        public Airplane()
        {
            Id = ++GlobalId;
        }


        partial void TakeOff();

        partial void TakeOn();

        partial void FoodService();
    }
}
