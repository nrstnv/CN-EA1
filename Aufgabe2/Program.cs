using System;
using System.Text;

namespace Aufgabe2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Geben Sie eine 8-stellige Hexadezimalzahl ein: ");
                    string input = Console.ReadLine();
                    if (input.Length != 8)
                    {
                        if (input == "")
                            break;
                        else
                            Console.Write("Ungültige Eingabe.\n\n");
                    }
                    else
                        Display(input, HexStringToBinary(input));
                }
                catch (Exception)
                {
                    Console.Write("Ungültige Eingabe.\n\n");
                }
            }
        }

        private static string HexStringToBinary(string hexNumber)
        {
            string binaryVal = Convert.ToString(Convert.ToInt32(hexNumber, 16), 2);
            string output;
            if (binaryVal.Length < 32)
                output = binaryVal.PadLeft(32, '0');
            else
                output = binaryVal;
            return output;
        }

        private static void Display(string hexNumber, string binaryNumber)
        {
            char signBit = binaryNumber[0] == '1' ? '-' : '+';
            int characteristic = Convert.ToInt32(binaryNumber.Substring(1, 8), 2);
            int exponent = characteristic - 127;
            StringBuilder mantissa = new StringBuilder();
            StringBuilder mantissaShortened = new StringBuilder();
            int lastBitIndex = 0;
            float significand;
            float decimalVal;
            for (int bitIndex = binaryNumber.Length - 1; bitIndex >= 0; bitIndex--)
            {
                if (binaryNumber[bitIndex] != '1')
                    continue;
                else
                {
                    lastBitIndex = bitIndex;
                    break;
                }
            }
            for (int i = 9; i <= lastBitIndex; i++)
            {
                mantissaShortened.Append(binaryNumber[i]);
            }
            mantissa.Append("1,");
            mantissa.Append(mantissaShortened);
            significand = 1 + (float)Convert.ToDecimal(value: Convert.ToInt32(binaryNumber.Substring(9, 23), 2)) / (float)Math.Pow(2, 23);
            if (signBit == '-')
                decimalVal = -1 * significand * (float)Math.Pow(2, exponent);
            else
                decimalVal = significand * (float)Math.Pow(2, exponent);
            Console.WriteLine($"0x{hexNumber} als Binärzahl: {binaryNumber}");
            Console.WriteLine($"Vorzeichenbit: {binaryNumber[0]} => \'{signBit}\'");
            Console.WriteLine($"Charakteristik: C={binaryNumber.Substring(1, 8)}={characteristic} => Exponent E=C-127={exponent}");
            Console.WriteLine($"Mantisse: {mantissa}");
            Console.WriteLine($"Normalisierte Darstellung als Binärzahl: {signBit}{mantissa}*2^{exponent}");
            Console.WriteLine($"Als Gleitkommazahl: {decimalVal}");
            Console.WriteLine();
        }
    }
}
