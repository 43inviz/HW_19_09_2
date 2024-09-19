using System.Diagnostics;
using System.IO;

namespace HW_19_09_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Process process = new Process();
            

            int input = 0;

            do
            {

                Menu();
                input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        {

                            process.StartInfo.FileName = "notepad.exe";
                            break;
                        }
                    case 2:
                        {
                            process.StartInfo.FileName = "calc.exe";
                            break;
                        }
                    case 3: 
                        {
                            process.StartInfo.FileName = "mspaint.exe";
                            //process.StartInfo.FileName = @"C:\Windows\Sysnative\mspaint.exe";


                            break;
                        }
                    case 4: 
                        {
                            process.StartInfo.FileName = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
                            break;
                        }
                    default:
                        process.Close();
                        break;
                }
                if (input != 0)
                {
                    Console.WriteLine($"Открытие {process.StartInfo.FileName.ToString()}");

                    process.Start();

                }

            } while (input != 0);

            process.Kill();

        }
        public static void Menu()
        {
            Console.WriteLine("1 - Блокнот");
            Console.WriteLine("2 - Калькулятор");
            Console.WriteLine("3 - Paint");
            Console.WriteLine("4 - Chrome");
            Console.WriteLine("0 - EXIT");
        }
    }



}
