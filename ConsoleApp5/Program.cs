using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void m(double price, string name)
        {

            double fpercentage;
            double spercentage;
            double tpercentage;
            double lpercentage;
            double totalprice;

            double discount;
            int number;
            for (int i = 0; i <= 0; i++)
            {
                Console.WriteLine($"name of medicine = ({name}) , price of medicine = ({price})");
                Console.WriteLine(@"<-------------------------------------------------------------->");
                Console.WriteLine("enter the number of the medicine :");
                number = int.Parse(Console.ReadLine());
                if (number < 0 || number > 10000)
                {
                    Console.WriteLine("error enter right number !");
                    number = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("enter the first  percentage :");
                fpercentage = double.Parse(Console.ReadLine());

                if (fpercentage < 0 || fpercentage > 100)
                {
                    Console.WriteLine("enter the right percentage :");
                    fpercentage = double.Parse(Console.ReadLine());
                    totalprice = number * price;
                    discount = totalprice * (100 - fpercentage) / 100;
                    Console.WriteLine($"the value of the first discount = {totalprice * fpercentage / 100} , price after first discount = {discount}");

                }
                else
                {
                    totalprice = number * price;
                    discount = totalprice * (100 - fpercentage) / 100;
                    Console.WriteLine($"the value of the first discount = {totalprice * fpercentage / 100} , price after first discount = {discount}");

                }
                Console.WriteLine("=======================");
                Console.WriteLine("enter the second percentage :");
                spercentage = double.Parse(Console.ReadLine());

                if (spercentage < 0 || spercentage > 100)
                {
                    Console.WriteLine("enter the right percentage :");
                    spercentage = double.Parse(Console.ReadLine());
                    totalprice = discount;
                    discount  = totalprice*(100 - spercentage) / 100;   
                    Console.WriteLine($"the value the second discount = {totalprice * spercentage / 100} , price after second discount = {discount}");

                }
                else
                {
                    totalprice = discount;
                    discount = totalprice * (100 - spercentage) / 100;
                    Console.WriteLine($"the value the second discount = {totalprice * spercentage / 100} , price after second discount = {discount}");
                }
                Console.WriteLine("=======================");
                Console.WriteLine("enter the third percentage :");
                tpercentage = double.Parse(Console.ReadLine());

                if (tpercentage < 0 || tpercentage > 100)
                {
                    Console.WriteLine("enter the right percentage :");
                    tpercentage = double.Parse(Console.ReadLine());
                    totalprice = discount;
                    discount = totalprice * (100 - tpercentage) / 100;
                    Console.WriteLine($" the value of the third discount = {totalprice * tpercentage / 100} , price after third discount = {discount}");

                }
                else
                {
                    totalprice = discount;
                    discount = totalprice * (100 - tpercentage) / 100;
                    Console.WriteLine($" the value of the third discount = {totalprice * tpercentage / 100} , price after third discount = {discount}");

                }
                Console.WriteLine("=======================");
                Console.WriteLine("enter the fourth percentage :");
                lpercentage = double.Parse(Console.ReadLine());

                if (lpercentage < 0 || lpercentage > 100)
                {
                    Console.WriteLine("enter the right percentage :");
                    lpercentage = double.Parse(Console.ReadLine());
                    totalprice = discount;
                    discount = totalprice * (100 - lpercentage) / 100;
                    Console.WriteLine($" the value of the third discount = {totalprice * lpercentage / 100} , price after third discount = {discount}");

                }
                else
                {
                    totalprice = discount;
                    discount = totalprice * (100 - lpercentage) / 100;
                    Console.WriteLine($" the value of the third discount = {totalprice * lpercentage / 100} , price after third discount = {discount}");

                }
                Console.ReadKey();
                Console.WriteLine(@"/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\");

            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine("                                                         *pyramids for medicine*  ");
            Console.WriteLine("                                                          <------------------->  ");


            for (; ; )
            {
                for (int i = 0; i <= 0; i++)
                {
                    double price;
                    int number;
                    string name;
                    Console.WriteLine("please enter a number from 1 to 30");
                    number = int.Parse(Console.ReadLine());
                    Console.WriteLine("<*******************>");
                    if (number > 30 || number < 0)
                    {
                        Console.WriteLine("enter a correct number :");
                        number=int.Parse(Console.ReadLine());
                        Console.WriteLine("<*****************>");
                    }
                    switch (number)
                    {
                        case 1:
                            price = 57.00;
                            name = "Actimar Capsule 30 Cap.";
                            m(price, name);
                            break;
                        case 2:
                            price = 40.00;
                            name = "Asmalair Tablets 10 mg 10 Tab.";
                            m(price, name);
                            break;
                        case 3:
                            price =33.60;
                            name = "Asmalair Tablets 5 mg 10 Tab.";
                            m(price, name);
                            break;
                        case 4:
                            price =38.00;
                            name = "Diet-1 Capsule 30 Cap.";
                            m(price, name);
                            break;
                        case 5:
                            price =22.25;
                            name = "Estraceptive Tablets 21 Tab.";
                            m(price, name);
                            break;
                        case 6:
                            price = 15.00;
                            name = "Flustat Tablets 20 Tab.";
                            m(price, name);
                            break;
                        case 7:
                            price = 75.00;
                            name = "Hi-Glitazone Tablets 15 mg 30 Tab.";
                            m(price, name);
                            break;
                        case 8:
                            price =99.00;
                            name = "Hi-Glitazone Tablets 30 mg 30 Tab.";
                            m(price, name);
                            break;
                        case 9:
                            price =12.00;
                            name = "Histafree tablets 10 tab.";
                            m(price, name);
                            break;
                        case 10:
                            price = 56.25;
                            name = "Lisitens Tablets 30 Tab.";
                            m(price, name);
                            break;
                        case 11:
                            price = 30.00;
                            name = "Lisopril Tablets 10 mg 30 Tab.";
                            m(price, name);
                            break;
                        case 12:
                            price = 10.00;
                            name = "Nasostop Nasal Drop Adult 1 mg/ml 15 ml.";
                            m(price, name);
                            break;
                        case 13:
                            price = 9.00;
                            name = "Nasostop Nasal Drop Pediatric 0.5 mg/ml 15 ml.";
                            m(price, name);
                            break;
                        case 14:
                            price = 18.00;
                            name = "Nestacoran Tablets 2 mg 20 Tab.";
                            m(price, name);
                            break;
                        case 15:
                            price = 50.00;
                            name = "Oestrolone Tablets 2.5 mg 28 Tab.";
                            m(price, name);
                            break;
                        case 16:
                            price = 10.50;
                            name = "Orastatin Oral Suspension 100,000 u/ml  30 ml.";
                            m(price, name);
                            break;
                        case 17:
                            price =13.00;
                            name = "Otocort Ear Drops 10 ml.";
                            m(price,name);
                            break;
                        case 18:
                            price = 13.50;
                            name = "Remowax Ear Drops 15 ml.";
                            m(price, name);
                            break;
                        case 19:
                            price = 19.20;
                            name = "Rheumamax Capsule 100 mg 10 Cap.";
                            m(price, name);
                            break;
                        case 20:
                            price = 30.00;
                            name = "Steronate Tablets 20 Tab.";
                            m(price, name);
                            break;
                        case 21:
                            price = 37.50;
                            name = "Unibiotic Tablets 500 mg 5 Tab.";
                            m(price, name);
                            break;
                        case 22:
                            price =11.75;
                            name = "Vascon Oral Drops 10 mg/ml 15 ml. ";
                            m(price, name);
                            break;
                        case 23:
                            price = 22.00;
                            name = "Vascon Tablets 20 Tab.";
                            m(price, name);
                            break;
                        case 24:
                            price = 45.00;
                            name = "Viavag Tablets 100 mg 10 Tab.";
                            m(price, name);
                            break;
                        case 25:
                            price = 27.00;
                            name = "Viavag Tablets 25 mg 10 Tab.";
                            m(price, name);
                            break;
                        case 26:
                            price = 18.5;
                            name = "Vitamin C 30 mg Oral drops 15 ml.";
                            m(price, name);
                            break;
                        case 27:
                            price =57;
                            name = "Vitamin C 500 mg 30 Chewable Tab. ";
                            m(price, name);
                            break;
                        case 28:
                            price = 75;
                            name = "Vitamin D3 5000 IU 10 HGC";
                            m(price, name);
                            break;
                        case 29:
                            price = 75;
                            name = "Vitamin D3 Oral drops 200 IU 25 ml.";
                            m(price, name);
                            break;
                        case 30:
                            price = 10.5;
                            name = "Wax Out Ear Drops 5 % 15 ml.";
                            m(price, name);
                            break;


                    }
                }
            }

        }

    }
}


