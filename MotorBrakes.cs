using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor
{
    public  class MotorBrakes
    {
        public void Brake()
        {
            Console.WriteLine("Applying brakes...");
            CheckBrakes();
            Console.WriteLine("Brakes applied. Motorcycle is slowing down.");
        }

        private void CheckBrakes()
        {
            Console.WriteLine("Checking brakes...");
            Console.WriteLine("Brakes are in good condition.");
        }
    }
}
