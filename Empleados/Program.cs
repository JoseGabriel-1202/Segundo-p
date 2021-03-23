using System;

namespace Empleados
{

    class Program
    {
       
        public static void cargar(string[] Empleados, double[] Sueldos)
        {
            
            for (int i = 0; i < Empleados.Length; i++)
            {
                Console.WriteLine("escriba el nombre de los empleados");
                Empleados[i] = Console.ReadLine();
            }
            for (int s = 0; s < Sueldos.Length; s++)
            {
                Console.WriteLine("Escriba el sueldo");
                Sueldos[s] = double.Parse(Console.ReadLine());
            }
        }
        public static void SalarioMayor(double[] Sueldo, string[] Empleados)
        {
            double Mayor =0;
            string Nombre= ""; 
            for (int a = 0; a < Sueldo.Length; a++)
            {
                if (Mayor < Sueldo[a])
                {
                    Mayor = Sueldo[a];
                    Nombre = Empleados[a];
                }
            }
            Console.WriteLine(Nombre + "" +  Mayor);
        }

        static void Main(string[] args)
        {

            String[] Empleados;
            Empleados = new string[5];

            double[] Sueldos;
            Sueldos = new double[5];

            cargar(Empleados, Sueldos);
            SalarioMayor(Sueldos, Empleados);
        }
    }
}
