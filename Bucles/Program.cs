namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Explicación bucles
            //Media de las notas. Las notas están entre 0 y 10.
            /*
            int numberOfGrades;
            double grade = 0, result;
            string twoDecimals;

            Console.Write("¿Cuántas notas va a introducir? ");
            numberOfGrades = int.Parse(Console.ReadLine());

            while (numberOfGrades <= 0)
            {
                Console.Write("ERROR: Introduce un número de notas positivo: ");
                numberOfGrades = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numberOfGrades; i++)
            {
                Console.Write("Introduce una nota: ");
                double current = double.Parse(Console.ReadLine());

                if (!(current < 0 || current > 10))
                {
                    grade += current;
                }
                else
                {
                    i--;
                    Console.WriteLine("La nota no es correcta. Es un número entre 0 y 10.");
                }
            }

            result = grade / numberOfGrades;
            twoDecimals = result.ToString(".00");

            Console.WriteLine($"La media es {twoDecimals}.");
            */
            #endregion

            // 16. Escribir todos los números impares entre dos números A y B introducidos por teclado. Antes habrá que comprobar cuál de los dos números A y B es mayor.

            #region Resolución pa la gente
            //Obtengo el user input.
            int a, b, min, max;

            Console.Write("Introduce el valor de a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduce el valor de b: ");
            b = int.Parse(Console.ReadLine());

            //Determinar min y max
            if (a < b)
            {
                min = a;
                max = b;
            }
            else
            {
                min = b;
                max = a;
            }

            //Resolución
            for (int i = min; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion
            #region Resolución agresiva
            /*
            //Obtengo el user input.
            int min, max, temp;

            Console.Write("Introduce el valor de a: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Introduce el valor de b: ");
            max = int.Parse(Console.ReadLine());

            //Determinar min y max
            if (min > max)
            {
                temp = max;
                max = min;
                min = temp;
            }

            //Resolución
            for (int i = min; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
             */
            #endregion
        }
    }
}