using System;

namespace Practica__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1050;

            Laptop miLaptop = new Laptop();
            Laptop miLaptopFabrica = new Laptop(x);

            PC miPC = new PC();

            miLaptop.Turn_On();

        Carmen:
            while (true)
            {

                Console.WriteLine("\n Elige una de las siguientes opciones:");
                Console.WriteLine("\t a) Desplegar Informacion");
                Console.WriteLine("\t b) Habilitar 165 Hz");
                Console.WriteLine("\t c) Actualizar Controladores");
                Console.WriteLine("\t d) Cambiar Informacion");
                Console.WriteLine("\t e) Instalar dGPU");
                Console.WriteLine("\t f) Vender Laptop");
                Console.WriteLine("\t g) Apagar Laptop");
                Console.WriteLine("\t h) Ver Informacion de Fabrica");
                Console.WriteLine("\t i) Gestionar mi PC");

                Console.WriteLine();

                Console.Write("Opcion: ");
                string option = Console.ReadLine();

                Console.WriteLine();

                switch (option)
                {
                    case "A":
                    case "a":
                    case "1":
                        miLaptop.Print_Settings();
                        break;

                    case "B":
                    case "b":
                    case "2":
                        miLaptop.Upgrade_Hz();
                        break;

                    case "C":
                    case "c":
                    case "3":
                        miLaptop.Update_Drivers();
                        break;

                    case "D":
                    case "d":
                    case "4":
                        miLaptop.Update_Settings();
                        break;

                    case "E":
                    case "e":
                    case "5":
                        miLaptop.Install_dGPU();
                        break;

                    case "F":
                    case "f":
                    case "6":
                        miLaptop.Sell_Laptop();
                        break;

                    case "G":
                    case "g":
                    case "7":
                        miLaptop.Turn_Off();
                        break;
                    
                    case "H":
                    case "h":
                    case "8":
                        miLaptopFabrica.Print_Settings();
                        break;

                    case "I":
                    case "i":
                    case "9":
                        Console.WriteLine("\t *** Accediste a tu PC ***");
                        goto PC;

                    default:
                        Console.WriteLine("\t *** Opcion Invalida ***");
                        goto Carmen;
                }
            }
           PC:
            while (true)
            {
                Console.WriteLine("\n Elige una de las siguientes opciones:");
                Console.WriteLine("\t a) Desplegar Informacion");
                Console.WriteLine("\t b) Instalar Sistema de Enfriamiento");
                Console.WriteLine("\t c) Apagar PC");
                Console.WriteLine("\t d) Gestionar mi Laptop");

                Console.WriteLine();

                Console.Write("Opcion: ");
                string option2 = Console.ReadLine();

                Console.WriteLine();


                switch (option2)
                {
                    case "A":
                    case "a":
                    case "1":
                        miPC.Print_Settings();
                        break;

                    case "B":
                    case "b":
                    case "2":
                        miPC.Install_Cooling_System();
                        break;

                    case "C":
                    case "c":
                    case "3":
                        miPC.Turn_Off();
                        break;

                    case "D":
                    case "d":
                    case "4":
                        Console.WriteLine("\t *** Accediste a tu Laptop ***");
                        goto Carmen;

                    default:
                        Console.WriteLine("\t *** Opcion Invalida ***");
                        goto PC;
                }
            }
        }
    }
}
