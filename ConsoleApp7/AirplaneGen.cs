using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public partial class Airplane
    {

        partial void FoodService()
        {
            Console.WriteLine("Food: sendvich,burger");
        }
        partial void TakeOff()
        {
            Console.WriteLine($"DataTime: {DateTime.Now.AddHours(2)}  will take off");
        }

        partial void TakeOn()
        {
            Console.WriteLine($"DataTime: {DateTime.Now} will take on");
        }

        public void CallFoodService()
        {
            FoodService();
        }

        public void CallTakeOff()
        {
            TakeOff();
        }

        public void CallTakeOn()
        {
            TakeOn();
        }
    }
}
