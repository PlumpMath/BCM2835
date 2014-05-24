using System;
using PInvoke;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            BCM2835.bcm2835_init();
            BCM2835.bcm2835_close();
        }
    }
}
