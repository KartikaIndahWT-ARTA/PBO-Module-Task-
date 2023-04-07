//NAMA  : Kartika Indah Widyas Tantri
//NIM   : 222410102001
//KELAS : Praktikum PBO - A

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TugasModulPraktikumPBO.laptop;

namespace TugasModulPraktikumPBO
{
    //PROCESSOR
    public class Processor
    {
        public string merk, tipe;
    }
    public class Intel : Processor
    {
        public Intel()
        {
            base.merk = "Intel";
        }
    }
    public class AMD : Processor
    {
        public AMD()
        {
            base.merk = "AMD";
        }
    }
    public class CoreI3 : Intel
    {
        public CoreI3()
        {
            base.tipe = "Core I3";
        }
    }
    public class CoreI5 : Intel
    {
        public CoreI5()
        {
            base.tipe = "Core I5";
        }
    }
    public class CoreI7 : Intel
    {
        public CoreI7()
        {
            base.tipe = "Core I7";
        }
    }
    public class Ryzen : AMD
    {
        public Ryzen()
        {
            base.tipe = "RYZEN";
        }
    }
    public class Athlon : AMD
    {
        public Athlon()
        {
            base.tipe = "ATHLON";
        }
    }

    //VGA
    public class VGA
    {
        public string merk;
    }
    public class Nvidia : VGA
    {
        public Nvidia()
        {
            base.merk = "Nvidia";
        }
    }
    public class amd : VGA
    {
        public amd()
        {
            base.merk = "AMD";
        }
    }

    //LAPTOP
    public class laptop
    {
        public class Laptop
        {
            public string merk, tipe;
            public VGA vga;
            public Processor processor;

            public void LaptopDinyalakan()
            {
                Console.WriteLine($"Laptop {merk} {tipe} menyala");
            }
            public void LaptopDimatikan()
            {
                Console.WriteLine($"Laptop {merk} {tipe} mati");
            }
        }
        public class ASUS : Laptop
        {
            public ASUS()
            {
                base.merk = "ASUS";
            }
        }
        public class ACER : Laptop
        {
            public ACER()
            {
                base.merk = "ACER";
            }
        }
        public class LENOVO : Laptop
        {
            public LENOVO()
            {
                base.merk = "LENOVO";
            }
        }
        public class ROG : ASUS
        {
            public ROG()
            {
                base.tipe = "ROG";
            }
        }
        public class VivoBook : ASUS
        {
            public VivoBook()
            {
                base.tipe = "VivoBook";
            }
            public void Ngoding()
            {
                Console.WriteLine("Ctak Ctak Ctak error lagi!!!");
            }
        }
        public class Swift : ACER
        {
            public Swift()
            {
                base.tipe = "Swift";
            }
        }
        public class Predator : ACER
        {
            public Predator()
            {
                base.tipe = "Predator";
            }
            public void BermainGame()
            {
                Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
            }
        }
        public class Ideapad : LENOVO
        {
            public Ideapad()
            {
                base.tipe = "Ideapad";
            }
        }
        public class Legion : LENOVO
        {
            public Legion()
            {
                base.tipe = "Legion";
            }
        }

        internal class program
        {
            private static Laptop laptop1;
            private static Laptop laptop2;
            private static Predator predator;
            private static ACER Acer;

            static void Main(string[] args)
            {
                //SOAL 1
                Laptop laptop2 = new Ideapad();
                laptop2.vga = new amd();
                laptop2.processor = new Ryzen();

                Console.WriteLine("\nSOAL 1");
                laptop2.LaptopDinyalakan();
                laptop2.LaptopDimatikan();

                //SOAL 2
                Laptop laptop1 = new VivoBook();
                laptop1.vga = new Nvidia();
                laptop1.processor = new CoreI5();

                Console.WriteLine("\nSOAL 2");

                //SOAL 3
                Console.WriteLine("\nSOAL 3");
                Console.WriteLine($"Merk VGA: {laptop1.vga.merk}");
                Console.WriteLine($"Merk Prosesor: {laptop1.processor.merk}");
                Console.WriteLine($"Tipe Prosesor: {laptop1.processor.tipe}");

                //SOAL 4
                Predator predator = new Predator();
                predator.vga = new Nvidia();
                predator.processor = new Ryzen();

                Console.WriteLine("\nSOAL 4");
                predator.BermainGame();

                //SOAL 5
                Console.WriteLine("\nSOAL 5");
                ACER acer = new Predator();
                //acer.BermainGame();
            }
        }
    }
}