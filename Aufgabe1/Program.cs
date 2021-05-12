using System;
using System.Text;

namespace Aufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            object input;
            int number;

            while (true)
            {
                try
                {
                    Console.Write("Geben Sie bitte eine natürliche Zahl ein: ");
                    input = Console.ReadLine();
                    if (Convert.ToString(input) == "")
                        break;
                    number = Convert.ToInt32(input);
                    if (number > 0)
                        Console.WriteLine($"Dualzahl: {ToBinary(number)}");
                    else
                        Console.WriteLine("Ungültige Eingabe.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Ungültige Eingabe.");
                }
            }
        }

        public static string ToBinary(int x)
        {
            StringBuilder sb = new StringBuilder();
            char temp;
            int end;
            int start;

            while (x > 0)
            {
                sb = sb.Append(x % 2);
                x /= 2;
            }
            end = sb.Length - 1;
            start = 0;
            while (end - start > 0)
            {
                temp = sb[end];
                sb[end] = sb[start];
                sb[start] = temp;
                start++;
                end--;
            }
            return Convert.ToString(sb);
        }
    }
}
