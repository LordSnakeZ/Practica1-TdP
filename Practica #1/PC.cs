using System;

namespace Practica__1
{
    internal class PC: Laptop
    {
        private string Cabinet;
        private bool Cooling_System;

        protected internal PC()
        {
            this.Brand = "Dell";
            this.Gen = 7;
            this.Model = "Plus 69";
            this.DGPU = "NVIDIA RTX 5090TI";
            this.High_Hz = true;
            this.Drivers = true;
            Cabinet = "Corsair iCUE 4000X Mid-Tower";
            Cooling_System = false;
        }

        protected internal void Install_Cooling_System()
        {
            Console.WriteLine("¿Quieres instalar un sistema de enfriado a tu PC?");

            Console.WriteLine();
            Console.Write("Decision: ");
            string decision = Console.ReadLine();

            Console.WriteLine();


            if (decision != null) Cooling_System = true;

            Console.WriteLine();
            Console.WriteLine("La nueva configuracion de tu PC es:");
            Console.WriteLine();

            Print_Settings();
        }

        protected internal override void Print_Settings()
        {
            Console.WriteLine("Marca: {0}", this.Brand);
            Console.WriteLine("Generacion: {0}", this.Gen);
            Console.WriteLine("Modelo: {0}", this.Model);
            if (DGPU != null) Console.WriteLine("dGPU: {0}", this.DGPU);
            if (this.High_Hz) Console.WriteLine("165 Hz");
            if (this.Drivers) Console.WriteLine("Drivers: Actualizados");

            Console.WriteLine("Gabinete: {0}", Cabinet);
            if (Cooling_System) Console.WriteLine("Sistema de enfriamiento instalado");
        }
        protected internal override void Turn_Off()
        {
            Console.WriteLine("Tu PC ha sido apagada...");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
