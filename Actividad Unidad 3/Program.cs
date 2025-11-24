class Program
{
    static void Main(string[] args)
    {
        string? cmd;
        Console.WriteLine("Bienvenido al programa para gestionar un instituto. ACTIVIDAD 3");
        Console.WriteLine("Victor Robles baraza");
        Console.WriteLine("Salvador Robles Ruiz");
        Menu();
        do
        {
            cmd = Console.ReadLine();
            switch (cmd?.ToLower())
            {
                case "exit":
                    break;
                case "menu":
                    Menu();
                    break;
                default:
                    if (int.TryParse(cmd, out int num))
                    {
                        switch (num)
                        {
                            case 1:
                                Ejercicio1();
                                break;
                            case 2:
                                Ejercicio2();
                                break;
                            case 3:
                                Ejercicio3();
                                break;
                            case 4:
                                Ejercicio4();
                                break;
                            default:
                                Console.WriteLine(
                                    "Comando no permitido.\nEscriba un nÚmero del 1 al 4, para ejecutar el ejercicio.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Comando no permitido.");
                        Console.WriteLine("Escriba un nÚmero del 1 al 4 para ejecutar el ejercicio.");
                        Console.WriteLine("Escriba EXIT para salir.");
                        Console.WriteLine("Escriba MENU para mostar el menu principal.");
                    }

                    break;
            }
        } while (cmd?.ToLower() != "exit");
        Console.WriteLine("Gracias por usar el programa.");
    }

    static void Menu()
    {
        Console.WriteLine("======== MENU PRINCIPAL ========");
        Console.WriteLine("1. Añadir Alumno");
        Console.WriteLine("2. Añadir Profesor");
        Console.WriteLine("3. Añadir Ciclo Formativo");
        Console.WriteLine("4. Añadir Modulo");
        Console.WriteLine("Escriba EXIT para salir.");
        Console.WriteLine("Escriba MENU para mostrar el menu principal.");
        Console.WriteLine("================================");
    }

    static void Ejercicio1()
    {
        Console.WriteLine("Hola Mundo!");

    }
    static void Ejercicio2()
    {
        Console.WriteLine("Hola Mundo!");
    }
    static void Ejercicio3()
    {
        Console.WriteLine("Hola Mundo!");
    }
    static void Ejercicio4()
    {
        Console.WriteLine("Hola Mundo!");
    }
}
