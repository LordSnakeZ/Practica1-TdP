using System;

namespace Practica__1
{
    internal class Laptop
    {
        private string brand;
        private byte gen;
        private string model;
        private string dGPU;
        private protected bool High_Hz;
        private protected bool Drivers;

        private protected string Brand
        {
            get => brand;
            set
            {
                if (value.Length <= 0 || value.Length > 15)
                    brand = "Lenovo";
                else brand = value;
            }
        }
        private protected byte Gen
        {
            get => gen;
            set
            {
                if (value > 0 && value <= 7)
                    gen = value;
                else gen = 5;
            }
        }

        private protected string Model
        {
            get => model;
            set
            {
                if (value.Length <= 0 && value.Length > 20)
                    model = "Legion";
                else model = value;
            }
        }

        private protected string DGPU
        {
            get => dGPU;
            set
            {
                if (value.Length <= 0 && value.Length > 30)
                    dGPU = "NVIDIA RTX 3070";
                else dGPU = value;
            }
        }

        protected internal Laptop()
        {
            Brand = "Lenovo";
            Gen = 5;
            Model = "Legion";
        }

        protected internal Laptop(int input)
        {
            Brand = "Lenovo";
            Gen = 5;
            Model = "Legion";
            DGPU = "NVIDIA GTX " + input.ToString();
            High_Hz = true;
        }

        protected internal void Turn_On()
        {
            Console.WriteLine("Tu laptop ha sido encendida...");
        }

        protected internal virtual void Turn_Off()
        {
            Console.WriteLine("Tu laptop ha sido apagada...");
            Console.ReadLine();
            Environment.Exit(0);
        }

        protected internal virtual void Print_Settings()
        {
            Console.WriteLine("Marca: {0}", Brand);
            Console.WriteLine("Generacion: {0}", Gen);
            Console.WriteLine("Modelo: {0}", Model);
            if (DGPU != null) Console.WriteLine("dGPU: {0}", DGPU);
            if (High_Hz) Console.WriteLine("165 Hz");
            if (Drivers) Console.WriteLine("Drivers: Actualizados");
        }

        protected internal void Upgrade_Hz()
        {
            Console.WriteLine("¿Quieres habilitar los 165 Hz en la pantalla de tu laptop?");
           
            Console.WriteLine();
            Console.Write("Decision: ");
            string decision = Console.ReadLine();

            Console.WriteLine();
          

            if (decision != null) High_Hz = true;

            Console.WriteLine();
            Console.WriteLine("La nueva configuracion de tu laptop es:");
            Console.WriteLine();

            Print_Settings();
        }

        protected internal void Update_Drivers()
        {
            Console.WriteLine("¿Quieres actualizar los controladores de tu laptop?");
           
            Console.WriteLine();
            Console.Write("Decision: ");
            string decision = Console.ReadLine();

            Console.WriteLine();
            if (decision != null) Drivers = true;

            Console.WriteLine();
            Console.WriteLine("La nueva configuracion de tu laptop es:");
            Console.WriteLine();
            Print_Settings();
        }

        protected internal void Install_dGPU()
        {
            Console.WriteLine("¿Quieres instalar una dGPU a tu laptop?");

            Console.WriteLine();
            Console.Write("Decision: ");
            string decision = Console.ReadLine();

            Console.WriteLine();
            if (decision != null) {
                Console.Write("dGPU: NVIDIA RTX ");
                string modeldGPU = Console.ReadLine();
                DGPU = "NVIDIA RTX" + modeldGPU;
            }

            Console.WriteLine();
            Console.WriteLine("La nueva configuracion de tu laptop es:");
            Console.WriteLine();
            Print_Settings();
        }

        protected internal void Update_Settings()
        {
            Console.WriteLine("Ingresa la nueva configuracion de tu laptop:");
            Console.Write("\t - Marca: ");
            Brand = Console.ReadLine();
            Console.Write("\t - Generacion: ");
            Gen = byte.Parse(Console.ReadLine());
            Console.Write("\t - Modelo: ", Model);
            Model = Console.ReadLine();
            Console.Write("\t - dGPU: NVIDIA RTX ");
            DGPU = "NVIDIA RTX " + Console.ReadLine();
            Console.Write("\t - Hz (True or False): ");
            string change = Console.ReadLine();
            if (change == "True") High_Hz = true;
            else High_Hz = false;
            Console.Write("\t - Drivers (True or False):");
            string change2 = Console.ReadLine();
            if (change2 == "True") Drivers = true;
            else Drivers = false;

            Console.WriteLine();
            Console.WriteLine("La nueva configuracion de tu laptop es:");
            Console.WriteLine();
            Print_Settings();
        }
        protected internal void Sell_Laptop()
        {
            Console.WriteLine("¿Quieres vender tu laptop?");
            string decision2 = Console.ReadLine();

            if (decision2 != null)
            {
                Console.WriteLine("Te quedaste sin compu...");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }
    }
}
