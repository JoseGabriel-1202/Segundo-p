using System;

namespace Maquina_Dispensadora
{
    class Program
    {
          class Producto
        {
            string producto;
            int existencia, precio;
            
            public void Productos()
            {
                Console.WriteLine(" 1- Papas Fritas" +
                    "\n 2- Refrescos" +
                    "\n 3- Agua" +
                    "\n 4- Jugo de carton" +
                    "\n 5- Cafe" +
                    "\n 6- Leche con azucar" +
                    "\n 7- Galletas" +
                    "\n 8- Chicarron" +
                    "\n 9- Barras de chocolate" +
                    "\n 10- Palomitas");
            }
            
            public void Precios()
            {
                Console.WriteLine(" 1- Papas Fritas 30$" +
                   "\n 2- Refrescos 20$" +
                   "\n 3- Agua 10$" +
                   "\n 4- Jugo de carton 15$" +
                   "\n 5- Cafe 50$" +
                   "\n 6- Leche con azucar 15$" +
                   "\n 7- Galletas 5$" +
                   "\n 8- Chicarron 20$" +
                   "\n 9- Barras de chocolate 25$" +
                   "\n 10- Palomitas 10$");
            }

          }
        static void Main(string[] args)
        {
            string a;
            int Numero = 0;
            int cantidad = 0;
            int N1;
            int resta = 0;
            Producto P = new Producto();

            int[] Existencias;
            Existencias = new int[10];

            Existencias[0] = 10;
            Existencias[1] = 10;
            Existencias[2] = 10;
            Existencias[3] = 3;
            Existencias[4] = 20;
            Existencias[5] = 4;
            Existencias[6] = 10;
            Existencias[7] = 6;
            Existencias[8] = 4;
            Existencias[9] = 8;

            string[] producto;
            producto = new string[10];
            producto[0] = "Papas Fritas";
            producto[1] = "Refresco";
            producto[2] = "Agua";
            producto[3] = "Jugo";
            producto[4] = "Cafe";
            producto[5] = "Leche";
            producto[6] = "Galletas";
            producto[7] = "Chicarron";
            producto[8] = "Chocolates";
            producto[9] = "Palomitas";


            Console.WriteLine("---Bienvenido---");

            Console.WriteLine("---Que desea realizar:---");
            

            do
            {
               
                Console.WriteLine();
                Console.WriteLine("---seleccione una opcion---" +
                "\n 1- para seleccionar producto" +
                "\n 2- para saber precio" +
                "\n 3- salir" +
                "\n 4- informe");
                a = Console.ReadLine();
                N1 = int.Parse(a); 
                  
                switch (N1)
                {

                    case 1:
                        P.Productos();
                        Console.WriteLine("Seleccione el producto");

                        Numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("Cuantos/as quiere");
                        cantidad = int.Parse(Console.ReadLine());
                        Console.Write("Usted compro " + cantidad);
                        break;

                    case 2:
                        P.Precios();
                        break;

                    case 3:
                        Console.WriteLine("---Pase Buen Dia---");
                        break;

                    case 4:
                        Console.WriteLine("---Este es el Informe---");
                        Console.WriteLine(" ");
                       
                            if (Numero == 1)
                            {

                                resta = Existencias[0] - cantidad;
                                Console.WriteLine("Quedan " + resta + " " + producto[0]);
                                Console.WriteLine("Quedan " + Existencias[1] + " " + producto[1]);
                                Console.WriteLine("Quedan " + Existencias[2] + " " + producto[2]);
                                Console.WriteLine("Quedan " + Existencias[3] + " " + producto[3]);
                                Console.WriteLine("Quedan " + Existencias[4] + " " + producto[4]);
                                Console.WriteLine("Quedan " + Existencias[5] + " " + producto[5]);
                                Console.WriteLine("Quedan " + Existencias[6] + " " + producto[6]);
                                Console.WriteLine("Quedan " + Existencias[7] + " " + producto[7]);
                                Console.WriteLine("Quedan " + Existencias[8] + " " + producto[8]);
                                Console.WriteLine("Quedan " + Existencias[9] + " " + producto[9]);
                            }
                        if (Numero == 2)
                        {
                            resta = Existencias[1] - cantidad;
                            Console.WriteLine("Quedan " + Existencias[0] + " " + producto[0]);
                            Console.WriteLine("Quedan " + resta + " " + producto[1]);
                            Console.WriteLine("Quedan " + Existencias[2] + " " + producto[2]);
                            Console.WriteLine("Quedan " + Existencias[3] + " " + producto[3]);
                            Console.WriteLine("Quedan " + Existencias[4] + " " + producto[4]);
                            Console.WriteLine("Quedan " + Existencias[5] + " " + producto[5]);
                            Console.WriteLine("Quedan " + Existencias[6] + " " + producto[6]);
                            Console.WriteLine("Quedan " + Existencias[7] + " " + producto[7]);
                            Console.WriteLine("Quedan " + Existencias[8] + " " + producto[8]);
                            Console.WriteLine("Quedan " + Existencias[9] + " " + producto[9]);

                        }
                        if (Numero == 3)
                        {
                            resta = Existencias[2] - cantidad;
                            Console.WriteLine("Quedan " + Existencias[0] + " " + producto[0]);
                            Console.WriteLine("Quedan " + Existencias[1] + " " + producto[1]);
                            Console.WriteLine("Quedan " + resta + " " + producto[2]);
                            Console.WriteLine("Quedan " + Existencias[3] + " " + producto[3]);
                            Console.WriteLine("Quedan " + Existencias[4] + " " + producto[4]);
                            Console.WriteLine("Quedan " + Existencias[5] + " " + producto[5]);
                            Console.WriteLine("Quedan " + Existencias[6] + " " + producto[6]);
                            Console.WriteLine("Quedan " + Existencias[7] + " " + producto[7]);
                            Console.WriteLine("Quedan " + Existencias[8] + " " + producto[8]);
                            Console.WriteLine("Quedan " + Existencias[9] + " " + producto[9]);
                        }
                        if (Numero == 4)
                        {
                            resta = Existencias[3] - cantidad;

                            Console.WriteLine("Quedan " + Existencias[0] + " " + producto[0]);
                            Console.WriteLine("Quedan " + Existencias[1] + " " + producto[1]);
                            Console.WriteLine("Quedan " + Existencias[2] + " " + producto[2]);
                            Console.WriteLine("Quedan " + resta + " " + producto[3]);
                            Console.WriteLine("Quedan " + Existencias[4] + " " + producto[4]);
                            Console.WriteLine("Quedan " + Existencias[5] + " " + producto[5]);
                            Console.WriteLine("Quedan " + Existencias[6] + " " + producto[6]);
                            Console.WriteLine("Quedan " + Existencias[7] + " " + producto[7]);
                            Console.WriteLine("Quedan " + Existencias[8] + " " + producto[8]);
                            Console.WriteLine("Quedan " + Existencias[9] + " " + producto[9]);
                        }
                        if (Numero == 5)
                        {
                            resta = Existencias[4] - cantidad;

                            Console.WriteLine("Quedan " + Existencias[0] + " " + producto[0]);
                            Console.WriteLine("Quedan " + Existencias[1] + " " + producto[1]);
                            Console.WriteLine("Quedan " + Existencias[2] + " " + producto[2]);
                            Console.WriteLine("Quedan " + Existencias[3] + " " + producto[3]);
                            Console.WriteLine("Quedan " + resta + " " + producto[4]);
                            Console.WriteLine("Quedan " + Existencias[5] + " " + producto[5]);
                            Console.WriteLine("Quedan " + Existencias[6] + " " + producto[6]);
                            Console.WriteLine("Quedan " + Existencias[7] + " " + producto[7]);
                            Console.WriteLine("Quedan " + Existencias[8] + " " + producto[8]);
                            Console.WriteLine("Quedan " + Existencias[9] + " " + producto[9]);
                        }
                        if (Numero == 6)
                        {
                            resta = Existencias[5] - cantidad;

                            Console.WriteLine("Quedan " + Existencias[0] + " " + producto[0]);
                            Console.WriteLine("Quedan " + Existencias[1] + " " + producto[1]);
                            Console.WriteLine("Quedan " + Existencias[2] + " " + producto[2]);
                            Console.WriteLine("Quedan " + Existencias[3] + " " + producto[3]);
                            Console.WriteLine("Quedan " + Existencias[4] + " " + producto[4]);
                            Console.WriteLine("Quedan " + resta + " " + producto[5]);
                            Console.WriteLine("Quedan " + Existencias[6] + " " + producto[6]);
                            Console.WriteLine("Quedan " + Existencias[7] + " " + producto[7]);
                            Console.WriteLine("Quedan " + Existencias[8] + " " + producto[8]);
                            Console.WriteLine("Quedan " + Existencias[9] + " " + producto[9]);
                        }
                        if (Numero == 7)
                        {
                            resta = Existencias[6] - cantidad;

                            Console.WriteLine("Quedan " + Existencias[0] + " " + producto[0]);
                            Console.WriteLine("Quedan " + Existencias[1] + " " + producto[1]);
                            Console.WriteLine("Quedan " + Existencias[2] + " " + producto[2]);
                            Console.WriteLine("Quedan " + Existencias[3] + " " + producto[3]);
                            Console.WriteLine("Quedan " + Existencias[4] + " " + producto[4]);
                            Console.WriteLine("Quedan " + Existencias[5] + " " + producto[5]);
                            Console.WriteLine("Quedan " + resta + " " + producto[6]);
                            Console.WriteLine("Quedan " + Existencias[7] + " " + producto[7]);
                            Console.WriteLine("Quedan " + Existencias[8] + " " + producto[8]);
                            Console.WriteLine("Quedan " + Existencias[9] + " " + producto[9]);
                        }
                        if (Numero == 8)
                        {
                            resta = Existencias[7] - cantidad;

                            Console.WriteLine("Quedan " + Existencias[0] + " " + producto[0]);
                            Console.WriteLine("Quedan " + Existencias[1] + " " + producto[1]);
                            Console.WriteLine("Quedan " + Existencias[2] + " " + producto[2]);
                            Console.WriteLine("Quedan " + Existencias[3] + " " + producto[3]);
                            Console.WriteLine("Quedan " + Existencias[4] + " " + producto[4]);
                            Console.WriteLine("Quedan " + Existencias[5] + " " + producto[5]);
                            Console.WriteLine("Quedan " + Existencias + " " + producto[6]);
                            Console.WriteLine("Quedan " + resta + " " + producto[7]);
                            Console.WriteLine("Quedan " + Existencias[8] + " " + producto[8]);
                            Console.WriteLine("Quedan " + Existencias[9] + " " + producto[9]);
                        }
                        if (Numero == 9)
                        {
                            resta = Existencias[8] - cantidad;

                            Console.WriteLine("Quedan " + Existencias[0] + " " + producto[0]);
                            Console.WriteLine("Quedan " + Existencias[1] + " " + producto[1]);
                            Console.WriteLine("Quedan " + Existencias[2] + " " + producto[2]);
                            Console.WriteLine("Quedan " + Existencias[3] + " " + producto[3]);
                            Console.WriteLine("Quedan " + Existencias[4] + " " + producto[4]);
                            Console.WriteLine("Quedan " + Existencias[5] + " " + producto[5]);
                            Console.WriteLine("Quedan " + Existencias[6] + " " + producto[6]);
                            Console.WriteLine("Quedan " + Existencias[7] + " " + producto[7]);
                            Console.WriteLine("Quedan " + resta + " " + producto[8]);
                            Console.WriteLine("Quedan " + Existencias[9] + " " + producto[9]);
                        }
                        if (Numero == 10)
                        {
                            resta = Existencias[9] - cantidad;

                            Console.WriteLine("Quedan " + Existencias[0] + " " + producto[0]);
                            Console.WriteLine("Quedan " + Existencias[1] + " " + producto[1]);
                            Console.WriteLine("Quedan " + Existencias[2] + " " + producto[2]);
                            Console.WriteLine("Quedan " + Existencias[3] + " " + producto[3]);
                            Console.WriteLine("Quedan " + Existencias[4] + " " + producto[4]);
                            Console.WriteLine("Quedan " + Existencias[5] + " " + producto[5]);
                            Console.WriteLine("Quedan " + Existencias[6] + " " + producto[6]);
                            Console.WriteLine("Quedan " + Existencias[7] + " " + producto[7]);
                            Console.WriteLine("Quedan " + Existencias[8] + " " + producto[8]);
                            Console.WriteLine("Quedan " +  resta + " " + producto[9]);
                        }
                       
                        break;

                    default:
                        Console.WriteLine(" ---No es una opcion--- ");

                        break;
                }                            
            } while (N1 != 3);                           
        }    
    }
}
