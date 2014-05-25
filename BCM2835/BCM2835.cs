using System;
using System.Runtime.InteropServices;

namespace PInvoke
{
    public class BCM2835
    {
        public const Byte HIGH = 0x1;
        public const Byte LOW = 0x0;

        public const Int32 BCM2835_CORE_CLK_HZ = 250000000;
        public const Int32 BCM2835_PERI_BASE = 0x20000000;
        public const Int32 BCM2835_ST_BASE = (BCM2835_PERI_BASE + 0x3000);
        public const Int32 BCM2835_GPIO_PADS = (BCM2835_PERI_BASE + 0x100000);
        public const Int32 BCM2835_CLOCK_BASE = (BCM2835_PERI_BASE + 0x101000);
        public const Int32 BCM2835_GPIO_BASE = (BCM2835_PERI_BASE + 0x200000);
        public const Int32 BCM2835_SPI0_BASE = (BCM2835_PERI_BASE + 0x204000);
        public const Int32 BCM2835_BSC0_BASE = (BCM2835_PERI_BASE + 0x205000);
        public const Int32 BCM2835_GPIO_PWM = (BCM2835_PERI_BASE + 0x20C000);
        public const Int32 BCM2835_BSC1_BASE = (BCM2835_PERI_BASE + 0x804000);
        public const Int32 BCM2835_PAGE_SIZE = (4 * 1024);
        public const Int32 BCM2835_BLOCK_SIZE = (4 * 1024);

        public const Int32 BCM2835_GPFSEL0 = 0x0000;
        public const Int32 BCM2835_GPFSEL1 = 0x0004;
        public const Int32 BCM2835_GPFSEL2 = 0x0008;
        public const Int32 BCM2835_GPFSEL3 = 0x000c;
        public const Int32 BCM2835_GPFSEL4 = 0x0010;
        public const Int32 BCM2835_GPFSEL5 = 0x0014;

        public const Int32 BCM2835_GPSET0 = 0x001c;
        public const Int32 BCM2835_GPSET1 = 0x0020;
        public const Int32 BCM2835_GPCLR0 = 0x0028;
        public const Int32 BCM2835_GPCLR1 = 0x002c;
        public const Int32 BCM2835_GPLEV0 = 0x0034;
        public const Int32 BCM2835_GPLEV1 = 0x0038;
        public const Int32 BCM2835_GPEDS0 = 0x0040;
        public const Int32 BCM2835_GPEDS1 = 0x0044;
        public const Int32 BCM2835_GPREN0 = 0x004c;
        public const Int32 BCM2835_GPREN1 = 0x0050;
        public const Int32 BCM2835_GPFEN0 = 0x0058;
        public const Int32 BCM2835_GPFEN1 = 0x005c;
        public const Int32 BCM2835_GPHEN0 = 0x0064;
        public const Int32 BCM2835_GPHEN1 = 0x0068;
        public const Int32 BCM2835_GPLEN0 = 0x0070;
        public const Int32 BCM2835_GPLEN1 = 0x0074;
        public const Int32 BCM2835_GPAREN0 = 0x007c;
        public const Int32 BCM2835_GPAREN1 = 0x0080;
        public const Int32 BCM2835_GPAFEN0 = 0x0088;
        public const Int32 BCM2835_GPAFEN1 = 0x008c;

        public const Int32 BCM2835_GPPUD = 0x0094;
        public const Int32 BCM2835_GPPUDCLK0 = 0x0098;
        public const Int32 BCM2835_GPPUDCLK1 = 0x009c;

        public const Int32 BCM2835_PADS_GPIO_0_27 = 0x002c;
        public const Int32 BCM2835_PADS_GPIO_28_45 = 0x0030;
        public const Int32 BCM2835_PADS_GPIO_46_53 = 0x0034;

        public const Int32 BCM2835_PAD_PASSWRD = (0x5A << 24);
        public const Int32 BCM2835_PAD_SLEW_RATE_UNLIMITED = 0x10;
        public const Int32 BCM2835_PAD_HYSTERESIS_ENABLED = 0x08;
        public const Int32 BCM2835_PAD_DRIVE_2mA = 0x00;
        public const Int32 BCM2835_PAD_DRIVE_4mA = 0x01;
        public const Int32 BCM2835_PAD_DRIVE_6mA = 0x02;
        public const Int32 BCM2835_PAD_DRIVE_8mA = 0x03;
        public const Int32 BCM2835_PAD_DRIVE_10mA = 0x04;
        public const Int32 BCM2835_PAD_DRIVE_12mA = 0x05;
        public const Int32 BCM2835_PAD_DRIVE_14mA = 0x06;
        public const Int32 BCM2835_PAD_DRIVE_16mA = 0x07;

        public const Int32 BCM2835_SPI0_CS = 0x0000;
        public const Int32 BCM2835_SPI0_FIFO = 0x0004;
        public const Int32 BCM2835_SPI0_CLK = 0x0008;
        public const Int32 BCM2835_SPI0_DLEN = 0x000c;
        public const Int32 BCM2835_SPI0_LTOH = 0x0010;
        public const Int32 BCM2835_SPI0_DC = 0x0014;
        public const Int32 BCM2835_SPI0_CS_LEN_LONG = 0x02000000;
        public const Int32 BCM2835_SPI0_CS_DMA_LEN = 0x01000000;
        public const Int32 BCM2835_SPI0_CS_CSPOL2 = 0x00800000;
        public const Int32 BCM2835_SPI0_CS_CSPOL1 = 0x00400000;
        public const Int32 BCM2835_SPI0_CS_CSPOL0 = 0x00200000;
        public const Int32 BCM2835_SPI0_CS_RXF = 0x00100000;
        public const Int32 BCM2835_SPI0_CS_RXR = 0x00080000;
        public const Int32 BCM2835_SPI0_CS_TXD = 0x00040000;
        public const Int32 BCM2835_SPI0_CS_RXD = 0x00020000;
        public const Int32 BCM2835_SPI0_CS_DONE = 0x00010000;
        public const Int32 BCM2835_SPI0_CS_TE_EN = 0x00008000;
        public const Int32 BCM2835_SPI0_CS_LMONO = 0x00004000;
        public const Int32 BCM2835_SPI0_CS_LEN = 0x00002000;
        public const Int32 BCM2835_SPI0_CS_REN = 0x00001000;
        public const Int32 BCM2835_SPI0_CS_ADCS = 0x00000800;
        public const Int32 BCM2835_SPI0_CS_INTR = 0x00000400;
        public const Int32 BCM2835_SPI0_CS_INTD = 0x00000200;
        public const Int32 BCM2835_SPI0_CS_DMAEN = 0x00000100;
        public const Int32 BCM2835_SPI0_CS_TA = 0x00000080;
        public const Int32 BCM2835_SPI0_CS_CSPOL = 0x00000040;
        public const Int32 BCM2835_SPI0_CS_CLEAR = 0x00000030;
        public const Int32 BCM2835_SPI0_CS_CLEAR_RX = 0x00000020;
        public const Int32 BCM2835_SPI0_CS_CLEAR_TX = 0x00000010;
        public const Int32 BCM2835_SPI0_CS_CPOL = 0x00000008;
        public const Int32 BCM2835_SPI0_CS_CPHA = 0x00000004;
        public const Int32 BCM2835_SPI0_CS_CS = 0x00000003;

        public const Int32 BCM2835_BSC_C = 0x0000;
        public const Int32 BCM2835_BSC_S = 0x0004;
        public const Int32 BCM2835_BSC_DLEN = 0x0008;
        public const Int32 BCM2835_BSC_A = 0x000c;
        public const Int32 BCM2835_BSC_FIFO = 0x0010;
        public const Int32 BCM2835_BSC_DIV = 0x0014;
        public const Int32 BCM2835_BSC_DEL = 0x0018;
        public const Int32 BCM2835_BSC_CLKT = 0x001c;
        public const Int32 BCM2835_BSC_C_I2CEN = 0x00008000;
        public const Int32 BCM2835_BSC_C_INTR = 0x00000400;
        public const Int32 BCM2835_BSC_C_INTT = 0x00000200;
        public const Int32 BCM2835_BSC_C_INTD = 0x00000100;
        public const Int32 BCM2835_BSC_C_ST = 0x00000080;
        public const Int32 BCM2835_BSC_C_CLEAR_1 = 0x00000020;
        public const Int32 BCM2835_BSC_C_CLEAR_2 = 0x00000010;
        public const Int32 BCM2835_BSC_C_READ = 0x00000001;
        public const Int32 BCM2835_BSC_S_CLKT = 0x00000200;
        public const Int32 BCM2835_BSC_S_ERR = 0x00000100;
        public const Int32 BCM2835_BSC_S_RXF = 0x00000080;
        public const Int32 BCM2835_BSC_S_TXE = 0x00000040;
        public const Int32 BCM2835_BSC_S_RXD = 0x00000020;
        public const Int32 BCM2835_BSC_S_TXD = 0x00000010;
        public const Int32 BCM2835_BSC_S_RXR = 0x00000008;
        public const Int32 BCM2835_BSC_S_TXW = 0x00000004;
        public const Int32 BCM2835_BSC_S_DONE = 0x00000002;
        public const Int32 BCM2835_BSC_S_TA = 0x00000001;
        public const Int32 BCM2835_BSC_FIFO_SIZE = 16;

        public const Int32 BCM2835_ST_CS = 0x0000;
        public const Int32 BCM2835_ST_CLO = 0x0004;
        public const Int32 BCM2835_ST_CHI = 0x0008;

        public enum bcm2835FunctionSelect : byte
        {
            BCM2835_GPIO_FSEL_INPT = 0, // 0b000
            BCM2835_GPIO_FSEL_OUTP = 1, // 0b001
            BCM2835_GPIO_FSEL_ALT0 = 4, // 0b100
            BCM2835_GPIO_FSEL_ALT1 = 5, // 0b101
            BCM2835_GPIO_FSEL_ALT2 = 6, // 0b110
            BCM2835_GPIO_FSEL_ALT3 = 7, // 0b111
            BCM2835_GPIO_FSEL_ALT4 = 3, // 0b011
            BCM2835_GPIO_FSEL_ALT5 = 2, // 0b010
            BCM2835_GPIO_FSEL_MASK = 7, // 0b111
        }

        public enum bcm2835PUDControl : byte
        {
            BCM2835_GPIO_PUD_OFF = 0,   // 0b00
            BCM2835_GPIO_PUD_DOWN = 1,  // 0b01
            BCM2835_GPIO_PUD_UP = 2,    // 0b10
        }

        public enum bcm2835PadGroup : byte
        {
            BCM2835_PAD_GROUP_GPIO_0_27 = 0,
            BCM2835_PAD_GROUP_GPIO_28_45 = 1,
            BCM2835_PAD_GROUP_GPIO_46_53 = 2
        }

        public enum RPiGPIOPin : byte
        {
            // Rev. A
            RPI_GPIO_P1_03 = 0,
            RPI_GPIO_P1_05 = 1,
            RPI_GPIO_P1_07 = 4,
            RPI_GPIO_P1_08 = 14,
            RPI_GPIO_P1_10 = 15,
            RPI_GPIO_P1_11 = 17,
            RPI_GPIO_P1_12 = 18,
            RPI_GPIO_P1_13 = 21,
            RPI_GPIO_P1_15 = 22,
            RPI_GPIO_P1_16 = 23,
            RPI_GPIO_P1_18 = 24,
            RPI_GPIO_P1_19 = 10,
            RPI_GPIO_P1_21 = 9,
            RPI_GPIO_P1_22 = 25,
            RPI_GPIO_P1_23 = 11,
            RPI_GPIO_P1_24 = 8,
            RPI_GPIO_P1_26 = 7,
            // Rev. B
            RPI_V2_GPIO_P1_03 = 2,
            RPI_V2_GPIO_P1_05 = 3,
            RPI_V2_GPIO_P1_07 = 4,
            RPI_V2_GPIO_P1_08 = 14,
            RPI_V2_GPIO_P1_10 = 15,
            RPI_V2_GPIO_P1_11 = 17,
            RPI_V2_GPIO_P1_12 = 18,
            RPI_V2_GPIO_P1_13 = 27,
            RPI_V2_GPIO_P1_15 = 22,
            RPI_V2_GPIO_P1_16 = 23,
            RPI_V2_GPIO_P1_18 = 24,
            RPI_V2_GPIO_P1_19 = 10,
            RPI_V2_GPIO_P1_21 = 9,
            RPI_V2_GPIO_P1_22 = 25,
            RPI_V2_GPIO_P1_23 = 11,
            RPI_V2_GPIO_P1_24 = 8,
            RPI_V2_GPIO_P1_26 = 7,
            RPI_V2_GPIO_P5_03 = 28,
            RPI_V2_GPIO_P5_04 = 29,
            RPI_V2_GPIO_P5_05 = 30,
            RPI_V2_GPIO_P5_06 = 31
        }

        public enum bcm2835SPIBitOrder : byte
        {
            BCM2835_SPI_BIT_ORDER_LSBFIRST = 0,
            BCM2835_SPI_BIT_ORDER_MSBFIRST = 1
        }

        public enum bcm2835SPIMode : byte
        {
            BCM2835_SPI_MODE0 = 0,
            BCM2835_SPI_MODE1 = 1,
            BCM2835_SPI_MODE2 = 2,
            BCM2835_SPI_MODE3 = 3
        }

        public enum bcm2835SPIChipSelect : byte
        {
            BCM2835_SPI_CS0 = 0,
            BCM2835_SPI_CS1 = 1,
            BCM2835_SPI_CS2 = 2,
            BCM2835_SPI_CS_NONE = 3
        }

        public enum bcm2835SPIClockDivider
        {
            BCM2835_SPI_CLOCK_DIVIDER_65536 = 0,
            BCM2835_SPI_CLOCK_DIVIDER_32768 = 32768,
            BCM2835_SPI_CLOCK_DIVIDER_16384 = 16384,
            BCM2835_SPI_CLOCK_DIVIDER_8192 = 8192,
            BCM2835_SPI_CLOCK_DIVIDER_4096 = 4096,
            BCM2835_SPI_CLOCK_DIVIDER_2048 = 2048,
            BCM2835_SPI_CLOCK_DIVIDER_1024 = 1024,
            BCM2835_SPI_CLOCK_DIVIDER_512 = 512,
            BCM2835_SPI_CLOCK_DIVIDER_256 = 256,
            BCM2835_SPI_CLOCK_DIVIDER_128 = 128,
            BCM2835_SPI_CLOCK_DIVIDER_64 = 64,
            BCM2835_SPI_CLOCK_DIVIDER_32 = 32,
            BCM2835_SPI_CLOCK_DIVIDER_16 = 16,
            BCM2835_SPI_CLOCK_DIVIDER_8 = 8,
            BCM2835_SPI_CLOCK_DIVIDER_4 = 4,
            BCM2835_SPI_CLOCK_DIVIDER_2 = 2,
            BCM2835_SPI_CLOCK_DIVIDER_1 = 1
        }

        public enum bcm2835I2CClockDivider
        {
            BCM2835_I2C_CLOCK_DIVIDER_2500 = 2500,
            BCM2835_I2C_CLOCK_DIVIDER_626 = 626,
            BCM2835_I2C_CLOCK_DIVIDER_150 = 150,
            BCM2835_I2C_CLOCK_DIVIDER_148 = 148
        }

        public enum bcm2835I2CReasonCodes
        {
            BCM2835_I2C_REASON_OK = 0x00,
            BCM2835_I2C_REASON_ERROR_NACK = 0x01,
            BCM2835_I2C_REASON_ERROR_CLKT = 0x02,
            BCM2835_I2C_REASON_ERROR_DATA = 0x04
        }

        [DllImport("libbcm2835.so")]
        public static extern int bcm2835_init();

        [DllImport("libbcm2835.so")]
        public static extern int bcm2835_close();

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_set_debug(Byte debug);

        [DllImport("libbcm2835.so")]
        public static extern UInt32 bcm2835_peri_read(IntPtr paddr);

        [DllImport("libbcm2835.so")]
        public static extern UInt32 bcm2835_peri_read_nb(IntPtr paddr);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_peri_write(IntPtr paddr, UInt32 value);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_peri_write_nb(IntPtr paddr, UInt32 value);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_peri_set_bits(IntPtr paddr, UInt32 value, UInt32 mask);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_fsel(RPiGPIOPin pin, bcm2835FunctionSelect mode);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_set(RPiGPIOPin pin);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_clr(RPiGPIOPin pin);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_set_multi(UInt32 mask);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_clr_multi(UInt32 mask);

        [DllImport("libbcm2835.so")]
        public static extern Byte bcm2835_gpio_lev(RPiGPIOPin pin);

        [DllImport("libbcm2835.so")]
        public static extern Byte bcm2835_gpio_eds(RPiGPIOPin pin);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_set_eds(RPiGPIOPin pin);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_ren(RPiGPIOPin pin);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_clr_ren(RPiGPIOPin pin);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_fen(RPiGPIOPin pin);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_clr_fen(RPiGPIOPin pin);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_hen(RPiGPIOPin pin);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_clr_hen(RPiGPIOPin pin);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_len(RPiGPIOPin pin);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_clr_len(RPiGPIOPin pin);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_aren(RPiGPIOPin pin);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_clr_aren(RPiGPIOPin pin);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_afen(RPiGPIOPin pin);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_clr_afen(RPiGPIOPin pin);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_pud(Byte pud);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_pudclk(RPiGPIOPin pin, Byte on);

        [DllImport("libbcm2835.so")]
        public static extern UInt32 bcm2835_gpio_pad(bcm2835PadGroup group);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_set_pad(bcm2835PadGroup group, UInt32 control);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_delay(UInt32 millis);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_delayMicroseconds(UInt64 micros);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_write(RPiGPIOPin pin, Byte on);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_write_multi(UInt32 mask, Byte on);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_write_mask(UInt32 value, UInt32 mask);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_gpio_set_pud(RPiGPIOPin pin, bcm2835PUDControl pud);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_spi_begin();

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_spi_end();

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_spi_setBitOrder(Byte order);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_spi_setClockDivider(UInt16 divider);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_spi_setDataMode(Byte mode);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_spi_chipSelect(Byte cs);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_spi_setChipSelectPolarity(Byte cs, Byte active);

        [DllImport("libbcm2835.so")]
        public static extern Byte bcm2835_spi_transfer(Byte value);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_spi_transfernb(IntPtr tbuf, IntPtr rbuf, UInt32 len);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_spi_transfern(IntPtr buf, UInt32 len);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_spi_writenb(IntPtr buf, UInt32 len);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_i2c_begin();

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_i2c_end();

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_i2c_setSlaveAddress(Byte addr);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_i2c_setClockDivider(UInt16 divider);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_i2c_set_baudrate(UInt32 baudrate);

        [DllImport("libbcm2835.so")]
        public static extern Byte bcm2835_i2c_write(IntPtr buf, UInt32 len);

        [DllImport("libbcm2835.so")]
        public static extern Byte bcm2835_i2c_read(IntPtr buf, UInt32 len);

        [DllImport("libbcm2835.so")]
        public static extern Byte bcm2835_i2c_read_register_rs(IntPtr regaddr, IntPtr buf, UInt32 len);

        [DllImport("libbcm2835.so")]
        public static extern Byte bcm2835_i2c_write_read_rs(IntPtr cmds, UInt32 cmds_len, IntPtr buf, UInt32 buf_len);

        [DllImport("libbcm2835.so")]
        public static extern UInt64 bcm2835_st_read();

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_st_delay(UInt64 offset_micros, UInt64 micros);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_pwm_set_clock(UInt32 divisor);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_pwm_set_mode(Byte channel, Byte markspace, Byte enabled);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_pwm_set_range(Byte channel, UInt32 range);

        [DllImport("libbcm2835.so")]
        public static extern void bcm2835_pwm_set_data(Byte channel, UInt32 data);
    }
}
