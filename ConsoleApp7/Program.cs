using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane()
            {
                Id = 0,
                Model = "Boeng747",
                Passengers = 20,

            };
            

            

            airplane.CallTakeOff();
            airplane.CallTakeOn();
            airplane.CallFoodService();
        }
        

    }
}
