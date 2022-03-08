using System;

namespace UES_Michel_Rosales
{
    class Program
    {

        static int tableWidth = 73;
        static void Main(string[] args)
        {


            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Black;


            Console.Clear();

            PrintLine();
            PrintRow("Nombre","Apellido","Materia","Nota","Estado");

            PrintLine();
            PrintRow("Jeimy", "Lanvaverde", "Programacion", "88.50", "Aprobada");

            PrintLine();
            PrintRow("Andrea", "Urrutia", "Geografia de El Salvador", "100.00", "Aprobada");

            PrintLine();
            PrintRow("Danilo", "Morales", "Informatica Basica", "45.00", "Reprobada");

            PrintLine();
            PrintRow("Maria", "Castro", "Matematicas", "25.00", "Reprobada");





            PrintLine();
            Console.ReadLine();
        }



        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));



        }


        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";
            foreach (string column in columns)

            {
                row += Aligncenter(column, width) + "|";
            }

            Console.WriteLine(row);

        }

        static string Aligncenter(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

           if(string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }

           else
            {
                return text.PadRight(width - (width - text.Length)/2).PadLeft(width);
            }




        


            
        }
    }
}
