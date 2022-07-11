namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operadores
            /*
            Operadores de asignación
                =
            Operadores aritméticos (devuelven un número)
                +
                -
                *
                /
                %
            Operadores lógicos (true / false)
                >
                >=
                <
                <=
                ==
                !=
                &&
                Ejemplo => true && false && true = false
                ||
                Ejemplo => true && false && true = true
            Operador unario negación
                !loquesea
                Ejemplo => !(2 == 2) = false
            */
            #endregion

            #region Uso básico de variables y operadores
            /*
                int n1 = 2;// Declaro e inicializo asignando valor
                int n2 = 2;// Declaro e inicializo asignando valor
                int n3 = n1 + n2;// Declaro e inicializo asignando valor con la operación +
                string resultado = n3.ToString();// Declaro e inicializo asignando valor con ToString()
                Console.WriteLine(resultado);//Escribo por la salida estándar

                Console.WriteLine(2 + 2);// O todo a la vez
             */
            #endregion

            #region Tipos primitivos
            /*
            Tipos primitivos enteros: byte, short, int, long
            Tipos primivitos coma flotante: float, double, decimal
            Tipos primitivos booleano: bool (true / false)
            Tipos primitivos caracter: char
            Tipo object
            */
            char c = 'c';

            #endregion

            #region Estructuras de control
            // if / else
            Console.Write("Introduce un número entero: ");
            int n = int.Parse(Console.ReadLine());

            if (n % 2 != 0)
            {
                Console.WriteLine("Es impar");
            }
            else
            {
                if (n == 0)
                {
                    Console.WriteLine("Es cero");
                }
                else
                {
                    Console.WriteLine("Es par");
                }
            }

            // else if
            Console.Write("Introduce una calificación (con coma): ");
            double calificacion = double.Parse(Console.ReadLine());

            if (calificacion >= 0 && calificacion <= 10)
            {
                if (calificacion < 5)
                {
                    Console.WriteLine("Suspenso");
                }
                else if (calificacion < 7)
                {
                    Console.WriteLine("Aprobado");
                }
                else if (calificacion < 9)
                {
                    Console.WriteLine("Notable");
                }
                else if (calificacion < 10)
                {
                    Console.WriteLine("Sobresaliente");
                }
                else
                {
                    Console.WriteLine("Matrícula");
                }
            }
            else
            {
                Console.WriteLine("La nota introducida parece errónea.");
            }

            // switch
            Console.Write("Introduce una opción: a, b, c o d: ");
            char option = char.Parse(Console.ReadLine());
            string msg = "";
            
            switch (option)
            {
                case 'a':
                    msg = "Opción a";
                    break;
                case 'b':
                    msg = "Opción b";
                    break;
                case 'c':
                    msg = "Opción c";
                    break;
                case 'd':
                    msg = "Opción d";
                    break;
                default:
                    Console.WriteLine("La opción seleccionada no existe");
                    break;
            }

            Console.WriteLine(msg);
            #endregion
        }
    }
}