using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace work3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=0;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine("Для ввода данных из файла введите 1, для ручного ввода введите 0!");
            
            try { i = Convert.ToInt32(Console.ReadLine()); }
            catch {
                Console.WriteLine("Неверный ввод!");
                Main(args);
            }
            if (i == 1)
            {
                inputFile();
            }
            else if (i == 0)
            {

                inputConsole();
            }
            else
            {
                Console.WriteLine("Неверный ввод!");
                Main(args);
            }

        }
        static void inputConsole()
        {
            Console.WriteLine("Введите координаты через запятую, не более 2-х координат в строку! Введите END чтобы закончить!");
            string input = "";
            string[] data = { };
            int d = 1;
            int i = 0;
            while (d == 1)
            {
                input = Console.ReadLine();
                if (input == "END") { break; }
                input = input.Replace(" ", "");
                data = input.Split(',');
            for(i=0; i<data.Length; i++)
            {
                    Console.WriteLine("X:" + data[i++] + " " + "Y:" + data[i]);
            }
                
            }
            
            
        }
        
        static void inputFile()
        {
            StreamReader fileIn = new StreamReader("1.txt");
            string input = "";
            string[] str;
            string[] data;
            try
            {
                input = fileIn.ReadToEnd();
                str = input.Split('\n');
                for(int c=0; c<str.Length; c++) { 
                    while(str[c].Contains(" ")) { str[c] = str[c].Replace(" ", "");}
                data = str[c].Split(',');
                for (int i = 0; i < data.Length; i++)
                {
                    Console.WriteLine("X:" + data[i++] + " "+ "Y:" + data[i]);
                }
                }
            }
            catch
            {
                Console.WriteLine("Неверный ввод!");
                inputConsole();
            }
            fileIn.Close();
            Console.ReadLine();
        }
    }
}
