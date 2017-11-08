using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double chislo = double.Parse(Console.ReadLine());
            string bgn = "BGN";
            string usd = "USD";
            string eur = "EUR";
            string gbp = "GBP";
            string inp = Console.ReadLine();
            string outp = Console.ReadLine();
            if (inp == bgn)
            {
                if (outp == usd)
                {
                    Console.WriteLine(Math.Round((chislo / 1.79549), 2) + " " + usd);
                }
                else
                {
                    if (outp == eur)
                    {
                        Console.WriteLine(Math.Round((chislo / 1.95583), 2) + " " + eur);
                    }
                    else
                    {
                        Console.WriteLine(Math.Round((chislo / 2.53405), 2) + " " + gbp);
                    }
                }
            }
            else
            {
                if (inp == usd)
                {
                    if (outp == bgn)
                    {
                        Console.WriteLine(Math.Round((chislo * 1.79549), 2) + " " + bgn);
                    }
                    else
                    {
                        if (outp == eur)
                        {
                            Console.WriteLine(Math.Round((chislo * (1.79549 / 1.95583)), 2) + " " + eur);
                        }
                        else
                        {
                            Console.WriteLine(Math.Round((chislo / (2.53405 / 1.79549)), 2) + " " + gbp);
                        }
                    }
                }
                else
                {
                    if (inp == eur)
                    {
                        if (outp == bgn)
                        {
                            Console.WriteLine(Math.Round((chislo * 1.95583), 2) + " " + bgn);
                        }
                        else
                        {
                            if (outp == usd)
                            {
                                Console.WriteLine(Math.Round((chislo * (1.95583 / 1.79549)), 2) + " " + usd);
                            }
                            else
                            {
                                Console.WriteLine(Math.Round((chislo / (2.53405 / 1.95583)), 2) + " " + gbp);
                            }
                        }
                    }
                    else
                        if (inp == gbp)
                    {
                        if (outp == bgn)
                        {
                            Console.WriteLine(Math.Round((chislo / 2.53405), 2) + " " + bgn);
                        }
                        else
                        {
                            if (outp == usd)
                            {
                                Console.WriteLine(Math.Round((chislo * (2.53405 / 1.79549)), 2) + " " + usd);
                            }
                            else
                            {
                                Console.WriteLine(Math.Round((chislo / (1.95583 / 2.53405)), 2) + " " + eur);
                            }
                        }

                    }
                }
            }

        }
    }
}


