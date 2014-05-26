using System;
using System.Runtime.InteropServices;

using PInvoke;

namespace ConsoleApplication1
{
    class Program
    {
        [DllImport("librht03")]
        public static extern int rht03_read(out double rh, out double tp);

        static void Main(string[] args)
        {
            double rh, tp;
            var result = rht03_read(out rh, out tp);
            if (result == 0)
                Console.WriteLine("T: {0}\nH: {1}", tp, rh);
            else
                Console.WriteLine("rht03_read(): {0}", result);

            //BCM2835.bcm2835_init();
            //{
            //    BCM2835.bcm2835_gpio_fsel(BCM2835.RPiGPIOPin.RPI_V2_GPIO_P1_11, BCM2835.bcm2835FunctionSelect.BCM2835_GPIO_FSEL_OUTP);
            //    Console.WriteLine("Press <L> set to set pin to LOW or <H> to HIGH and <Q> to quit.");
            //    while (true)
            //    {
            //        var key = Console.ReadKey(true).Key;
            //        if (key == ConsoleKey.Q)
            //            break;
            //        else if (key == ConsoleKey.L)
            //            BCM2835.bcm2835_gpio_clr(BCM2835.RPiGPIOPin.RPI_V2_GPIO_P1_11);
            //        else if (key == ConsoleKey.H)
            //            BCM2835.bcm2835_gpio_set(BCM2835.RPiGPIOPin.RPI_V2_GPIO_P1_11);
            //    }
            //}
            //BCM2835.bcm2835_close();
        }
    }
}
