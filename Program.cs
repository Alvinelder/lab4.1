using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double CRate, ARate, SRate, TicTot, ConTot, discount;
            int TicPur = 0;
            CRate = 0;
            ARate = 0;
            SRate = 0;
            TicTot = 0;
            ConTot = 0;
            discount = 0;

        Start:
            Console.WriteLine("Enter M for Matinee or E for evening show: ");
            string Show = System.Console.ReadLine();
                        
            if (Show.ToUpper() == "M")
            {   CRate = 3.99;
                ARate = 5.99;
                SRate = 4.50;
            }
               else if (Show.ToUpper() == "E")
            {   CRate = 6.99;
                ARate = 10.99;
                SRate = 8.50;
            }
               else
            {   Console.WriteLine("****Incorrect Response****");
             goto Start;
            }
            // caculate ticket
            double ticTot = 0;

            Console.WriteLine("how many Children? ");
            int Kids = int.Parse(Console.ReadLine());
            Console.WriteLine("how many Adults? ");
            int Adul = int.Parse(Console.ReadLine());
            Console.WriteLine("how many Senior Citizens? ");
            int Seni = int.Parse(Console.ReadLine());

            TicPur = Kids + Adul + Seni;


            if (TicPur >= 3 && Show.ToUpper() == "E")
            {
                Console.WriteLine("You get a free bag of Popcorn");
            }
            ticTot = (Kids *CRate) + (Adul * ARate) + (Seni * SRate);

            // Calculate conseesion
            double conTot = 0;

            Console.WriteLine("how many Small sodas? ");
            int Smsoda = int.Parse(Console.ReadLine());
            Console.WriteLine("how many Large Soda? ");
            int Lgsoda = int.Parse(Console.ReadLine());
            Console.WriteLine("how many Hot Dogs? ");
            int HotDog = int.Parse(Console.ReadLine());
            Console.WriteLine("how many Popcorn? ");
            int PopCo = int.Parse(Console.ReadLine());
            Console.WriteLine("how many Candy? ");
            int Candy = int.Parse(Console.ReadLine());

            conTot = (Smsoda * 3.5) + (Lgsoda * 5.99) + (HotDog * 3.99) + (PopCo * 4.5) + (Candy * 1.99);

            if (PopCo > 0 && Lgsoda > 0 && PopCo >= Lgsoda)
            {
                discount = Lgsoda * 2;
                Console.WriteLine("you received a discount of " + discount + " dollars");
            }
            else if (PopCo > 0 && Lgsoda > 0 && Lgsoda >= PopCo)
            {
                discount = PopCo * 2;
                Console.WriteLine("you received a discount of " + discount + " dollars");
            }
            else
            {
                Console.WriteLine("No discount this visit");
            }

            if (Candy >= 3)
            {
                Console.WriteLine("you recieved " + (Candy / 3) + " Candy for free");
            }

            ticTot = ticTot-discount;
            double sum = ticTot + conTot;
            Console.WriteLine("  "+ticTot);
            Console.WriteLine("  "+conTot);
            Console.WriteLine("+_______");
            Console.WriteLine("  "+sum);






            Console.WriteLine("press any key");
            Console.ReadKey();



        }


    }
}
