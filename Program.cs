using System;

namespace ProyectoOpcionB
{
    class Program
    {
        static void Main(string[] args)

        {

            int opcion;
            Console.WriteLine("¿Que opcion quieres?");
            Console.WriteLine(" 1 - Pedir Menu ");
            Console.WriteLine("2 - Pedir hamburguesa ");
            Console.WriteLine("3 - pedir bebida ");
            Console.WriteLine(" 4 - Salir ");
            opcion = int.Parse(Console.ReadLine());
            if (opcion != 4)
            {

                switch (opcion)
                {

                    case 1:
                        Nombres(1);
                        int submenu = int.Parse(Console.ReadLine());
                        Submenu(submenu);
                        break;
                    case 2:
                        Hamburguesa(2);
                        int subhamburgue = int.Parse(Console.ReadLine());
                        Subhamburguesas(subhamburgue);

                        break;
                    case 3:
                        Bebidas(3);
                        int submenuBebidas1 = int.Parse(Console.ReadLine());
                        Submenubebidas(submenuBebidas1);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");

                        break;
                }



            }
        }

        static void Nombres(int opcion)
        {
            string[] nombres = { "Grand Big Boot", "Big Boot", "BootPollo", "Cuarto de libra", "Boot Royale Deluxe" };


            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(i + 1 + " " + nombres[i]);
            }
        }
        static void Hamburguesa(int opcion2)
        {
            string[] hamburguesas = { "Grand Big Boot", "Big Boot", "BootPollo", "Cuarto de libra", "BootRoyal Deluxe" };

            for (int i = 0; i < hamburguesas.Length; i++)
            {
                Console.WriteLine(hamburguesas[i]);
            }
        }
        static void Bebidas(int opcion3)
        {
            string[] bebidas = { "Cocacola", "Fanta", "Agua", "Cerveza" };
            for (int i = 0; i < bebidas.Length; i++)
            {
                Console.WriteLine(bebidas[i]);

            }
        }
        static void Submenu(int submenu1)
        {



            string[] menu1 = { "Grand Big Boot", "Big Boot", "BootPollo", "Cuarto de libra", "Boot Royale Deluxe" };
            if (submenu1 != 4)
                switch (submenu1)
                {
                    case 1:

                        Console.WriteLine("Has elegido " + menu1[0]);
                        break;
                    case 2:

                        Console.WriteLine("Has elegido " + menu1[1]);
                        break;
                    case 3:

                        Console.WriteLine("Has elegido " + menu1[2]);
                        break;
                    case 4:

                        Console.WriteLine("Has elegido " + menu1[3]);
                        break;
                    case 5:

                        Console.WriteLine("Has elegido " + menu1[4]);
                        break;
                }
        }
        static void Submenubebidas(int subbebidas)
        {
            string[] refrescos = { "Cocacola", "Fanta", "Agua", "Cerveza" };
            if (subbebidas != 5)
            {
                switch (subbebidas)
                {
                    case 1:
                        Console.WriteLine("Has elegido" + refrescos[0]);
                        Console.WriteLine("Quieres bebida grande!?");
                        string respuesta1 = (Console.ReadLine());

                        if (respuesta1.ToLower() == "s")
                        {
                            Console.WriteLine("Aqui tienes" + refrescos[0] + " grande ");
                        }
                        else
                        { Console.WriteLine("Aqui tienes tu" + refrescos[0] + " pequeño "); }
                        break;
                    case 2:
                        Console.WriteLine("Has elegido" + refrescos[1]);
                        Console.WriteLine("Quieres bebida grande!?");
                        string respuesta2 = (Console.ReadLine());

                        if (respuesta2.ToLower() == "s")
                        {
                            Console.WriteLine("Aqui tienes" + refrescos[1] + " grande ");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Has elegido" + refrescos[2]);
                        Console.WriteLine("Quieres bebida grande!?");
                        string respuesta3 = (Console.ReadLine());

                        if (respuesta3.ToLower() == "s")
                        {
                            Console.WriteLine("Aqui tienes" + refrescos[2] + " grande ");
                        }
                        break;
                    case 4:
                        Console.WriteLine("test");
                        Console.WriteLine("Has elegido" + refrescos[3]);
                        Console.WriteLine("Quieres bebida grande!?");
                        string respuesta4 = Console.ReadLine();

                        if (respuesta4.ToLower() == "s")
                        {
                            Console.WriteLine("Aqui tienes" + refrescos[3] + " grande ");
                        }
                        break;

                }
            }
        }

        static void Subhamburguesas(int hamburguesaSub)
        {
            string[] hambur = { "Grand Big Boot", "Big Boot", "BootPollo", "Cuarto de libra", "BootRoyal Deluxe" };
            if (hamburguesaSub != 5)

            {
                switch (hamburguesaSub)
                {
                    case 1:
                        Console.WriteLine("Tu menu es" + hambur[0]);
                        Console.WriteLine("¿Quieres patatas?");
                        string respuesta = (Console.ReadLine());
                        bool patatas = false;
                        if (respuesta.ToLower() == "s")
                        {
                            Console.WriteLine("Aqui tienes" + hambur[0] + " con patatas");
                        }
                        else
                        { Console.WriteLine("Aqui tienes tu" + hambur[0] + " sin patatas"); }


                        break;
                    case 2:
                        Console.WriteLine("Has elegido" + hambur[1]);
                        Console.WriteLine("¿Quieres patatas?");
                        string respuesta1 = (Console.ReadLine());
                        bool patatas1 = false;
                        if (respuesta1.ToLower() == "s")
                        {
                            Console.WriteLine("Aqui tienes" + hambur[1] + " con patatas");
                        }
                        else
                        { Console.WriteLine("Aqui tienes tu" + hambur[1] + " sin patatas"); }
                        break;
                    case 3:
                        Console.WriteLine("Has elegido" + hambur[2]);
                        Console.WriteLine("¿Quieres patatas?");
                        string respuesta2 = (Console.ReadLine());
                        bool patatas2 = false;
                        if (respuesta2.ToLower() == "s")
                        {
                            Console.WriteLine("Aqui tienes" + hambur[2] + " con patatas");
                        }
                        else
                        { Console.WriteLine("Aqui tienes tu" + hambur[2] + " sin patatas"); }

                        break;
                    case 4:
                        Console.WriteLine("Has elegido" + hambur[3]);
                        Console.WriteLine("¿Quieres patatas?");
                        string respuesta3 = (Console.ReadLine());
                        bool patatas3 = false;
                        if (respuesta3.ToLower() == "s")
                        {
                            Console.WriteLine("Aqui tienes" + hambur[3] + " con patatas");
                        }
                        else
                        { Console.WriteLine("Aqui tienes tu" + hambur[3] + " sin patatas"); }

                        break;
                    case 5:
                        Console.WriteLine("Has elegido" + hambur[4]);
                        Console.WriteLine("¿Quieres patatas?");

                        string respuesta4 = (Console.ReadLine());

                        bool patatas4 = false;
                        if (respuesta4.ToLower() == "s")
                        {
                            Console.WriteLine("Aqui tienes" + hambur[4] + " con patatas");
                        }
                        else
                        { Console.WriteLine("Aqui tienes tu" + hambur[4] + " sin patatas"); }
                        break;
                }
            }



        }
    }


}

