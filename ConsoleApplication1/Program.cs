using System;
using PInvoke;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            BCM2835.bcm2835_init();
            {
                BCM2835.bcm2835_gpio_fsel((byte)BCM2835.RPiGPIOPin.RPI_V2_GPIO_P1_11, (byte)BCM2835.bcm2835FunctionSelect.BCM2835_GPIO_FSEL_OUTP);
                Console.WriteLine("Press <L> set to set pin to LOW or <H> to HIGH and <Q> to quit.");
                while (true)
                {
                    var key = Console.ReadKey(true).Key;
                    if (key == ConsoleKey.Q)
                        break;
                    else if (key == ConsoleKey.L)
                        BCM2835.bcm2835_gpio_clr((byte)BCM2835.RPiGPIOPin.RPI_V2_GPIO_P1_11);
                    else if (key == ConsoleKey.H)
                        BCM2835.bcm2835_gpio_set((byte)BCM2835.RPiGPIOPin.RPI_V2_GPIO_P1_11);

                }
            }
            BCM2835.bcm2835_close();
        }
    }
}
