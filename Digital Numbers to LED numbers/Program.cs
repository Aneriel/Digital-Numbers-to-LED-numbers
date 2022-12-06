using System;

namespace LedNumbers
{
    class Program
    {
        static void Main()
        {
            // liczby
            char[,] zero = new char[,] { { ' ', '_', ' ' }, { '|', ' ', '|' }, { '|', '_', '|' } };
            char[,] jeden = new char[,] { { ' ', ' ', ' ' }, { ' ', ' ', '|' }, { ' ', ' ', '|' } };
            char[,] dwa = new char[,] { { ' ', '_', ' ' }, { ' ', '_', '|' }, { '|', '_', ' ' } };
            char[,] trzy = new char[,] { { ' ', '_', ' ' }, { ' ', '_', '|' }, { ' ', '_', '|' } };
            char[,] cztery = new char[,] { { ' ', ' ', ' ' }, { '|', '_', '|' }, { ' ', ' ', '|' } };
            char[,] piec = new char[,] { { ' ', '_', ' ' }, { '|', '_', ' ' }, { ' ', '_', '|' } };
            char[,] szesc = new char[,] { { ' ', '_', ' ' }, { '|', '_', ' ' }, { '|', '_', '|' } };
            char[,] siedem = new char[,] { { ' ', '_', ' ' }, { ' ', ' ', '|' }, { ' ', ' ', '|' } };
            char[,] osiem = new char[,] { { ' ', '_', ' ' }, { '|', '_', '|' }, { '|', '_', '|' } };
            char[,] dziewiec = new char[,] { { ' ', '_', ' ' }, { '|', '_', '|' }, { ' ', ' ', '|' } };

            String liczba = Console.ReadLine();
            char[] chars = liczba.ToCharArray();


            foreach (char character in chars)
            {
                switch (character)
                {
                    case ('0'):
                        Console.Write(zero[0, 0]);
                        Console.Write(zero[0, 1]);
                        Console.Write(zero[0, 2]);
                        break;
                    case ('1'):
                        Console.Write(jeden[0, 0]);
                        Console.Write(jeden[0, 1]);
                        Console.Write(jeden[0, 2]);
                        break;
                    case ('2'):
                        Console.Write(dwa[0, 0]);
                        Console.Write(dwa[0, 1]);
                        Console.Write(dwa[0, 2]);
                        break;
                    case ('3'):
                        Console.Write(trzy[0, 0]);
                        Console.Write(trzy[0, 1]);
                        Console.Write(trzy[0, 2]);
                        break;
                    case ('4'):
                        Console.Write(cztery[0, 0]);
                        Console.Write(cztery[0, 1]);
                        Console.Write(cztery[0, 2]);
                        break;
                    case ('5'):
                        Console.Write(piec[0, 0]);
                        Console.Write(piec[0, 1]);
                        Console.Write(piec[0, 2]);
                        break;
                    case ('6'):
                        Console.Write(szesc[0, 0]);
                        Console.Write(szesc[0, 1]);
                        Console.Write(szesc[0, 2]);
                        break;
                    case ('7'):
                        Console.Write(siedem[0, 0]);
                        Console.Write(siedem[0, 1]);
                        Console.Write(siedem[0, 2]);
                        break;
                    case ('8'):
                        Console.Write(osiem[0, 0]);
                        Console.Write(osiem[0, 1]);
                        Console.Write(osiem[0, 2]);
                        break;
                    case ('9'):
                        Console.Write(dziewiec[0, 0]);
                        Console.Write(dziewiec[0, 1]);
                        Console.Write(dziewiec[0, 2]);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

                //first switch end ---------------------------------
            }
            Console.WriteLine();
            foreach (char character in chars)
            {
                switch (character)
                {
                    case ('0'):
                        Console.Write(zero[1, 0]);
                        Console.Write(zero[1, 1]);
                        Console.Write(zero[1, 2]);
                        break;
                    case ('1'):
                        Console.Write(jeden[1, 0]);
                        Console.Write(jeden[1, 1]);
                        Console.Write(jeden[1, 2]);
                        break;
                    case ('2'):
                        Console.Write(dwa[1, 0]);
                        Console.Write(dwa[1, 1]);
                        Console.Write(dwa[1, 2]);
                        break;
                    case ('3'):
                        Console.Write(trzy[1, 0]);
                        Console.Write(trzy[1, 1]);
                        Console.Write(trzy[1, 2]);
                        break;
                    case ('4'):
                        Console.Write(cztery[1, 0]);
                        Console.Write(cztery[1, 1]);
                        Console.Write(cztery[1, 2]);
                        break;
                    case ('5'):
                        Console.Write(piec[1, 0]);
                        Console.Write(piec[1, 1]);
                        Console.Write(piec[1, 2]);
                        break;
                    case ('6'):
                        Console.Write(szesc[1, 0]);
                        Console.Write(szesc[1, 1]);
                        Console.Write(szesc[1, 2]);
                        break;
                    case ('7'):
                        Console.Write(siedem[1, 0]);
                        Console.Write(siedem[1, 1]);
                        Console.Write(siedem[1, 2]);
                        break;
                    case ('8'):
                        Console.Write(osiem[1, 0]);
                        Console.Write(osiem[1, 1]);
                        Console.Write(osiem[1, 2]);
                        break;
                    case ('9'):
                        Console.Write(dziewiec[1, 0]);
                        Console.Write(dziewiec[1, 1]);
                        Console.Write(dziewiec[1, 2]);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            Console.WriteLine();
            //second switch end ---------------------------------
            foreach (char character in chars)
            {
                switch (character)
                {
                    case ('0'):
                        Console.Write(zero[2, 0]);
                        Console.Write(zero[2, 1]);
                        Console.Write(zero[2, 2]);
                        break;
                    case ('1'):
                        Console.Write(jeden[2, 0]);
                        Console.Write(jeden[2, 1]);
                        Console.Write(jeden[2, 2]);
                        break;
                    case ('2'):
                        Console.Write(dwa[2, 0]);
                        Console.Write(dwa[2, 1]);
                        Console.Write(dwa[2, 2]);
                        break;
                    case ('3'):
                        Console.Write(trzy[2, 0]);
                        Console.Write(trzy[2, 1]);
                        Console.Write(trzy[2, 2]);
                        break;
                    case ('4'):
                        Console.Write(cztery[2, 0]);
                        Console.Write(cztery[2, 1]);
                        Console.Write(cztery[2, 2]);
                        break;
                    case ('5'):
                        Console.Write(piec[2, 0]);
                        Console.Write(piec[2, 1]);
                        Console.Write(piec[2, 2]);
                        break;
                    case ('6'):
                        Console.Write(szesc[2, 0]);
                        Console.Write(szesc[2, 1]);
                        Console.Write(szesc[2, 2]);
                        break;
                    case ('7'):
                        Console.Write(siedem[2, 0]);
                        Console.Write(siedem[2, 1]);
                        Console.Write(siedem[2, 2]);
                        break;
                    case ('8'):
                        Console.Write(osiem[2, 0]);
                        Console.Write(osiem[2, 1]);
                        Console.Write(osiem[2, 2]);
                        break;
                    case ('9'):
                        Console.Write(dziewiec[2, 0]);
                        Console.Write(dziewiec[2, 1]);
                        Console.Write(dziewiec[2, 2]);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            //third switch end ---------------------------------

        }
    }
}