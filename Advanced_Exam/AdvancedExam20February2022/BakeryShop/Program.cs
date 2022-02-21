using System;
using System.Collections.Generic;
using System.Linq;

namespace BakeryShop
{
           
                internal class Program
           {
            static void Main(string[] args)
            {
                System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
                customCulture.NumberFormat.NumberDecimalSeparator = ".";

                System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
                List<double> waterList = Console.ReadLine().Split().Select(double.Parse).ToList();
                List<double> flourList = Console.ReadLine().Split().Select(double.Parse).ToList();

                Queue<double> water = new Queue<double>(waterList);
                Stack<double> flour = new Stack<double>(flourList);

                int Croissant = 0;
                int Muffin = 0;
                int Baguette = 0;
                int Bagel = 0;

                double currFlourLeft = 0;
                while (water.Count > 0 && flour.Count > 0)
                {
                    double currWater = water.Peek();
                    double currFlour = flour.Peek();
                    double result = currWater + currFlour;
                    if ((currWater * 100) / result == 40)
                    {
                        Muffin++;
                        water.Dequeue();
                        flour.Pop();
                        continue;
                    }
                    else if ((currWater * 100) / result == 50)
                    {
                        Croissant++;
                        water.Dequeue();
                        flour.Pop();
                        continue;
                    }
                    else if ((currWater * 100) / result == 30)
                    {
                        Baguette++;
                        water.Dequeue();
                        flour.Pop();
                        continue;
                    }
                    else if ((currWater * 100) / result == 20)
                    {
                        Bagel++;
                        water.Dequeue();
                        flour.Pop();
                        continue;
                    }
                    else
                    {

                        if (currWater < currFlour)
                        {
                            currFlourLeft = currFlour - currWater;
                            Croissant++;
                            water.Dequeue();
                            flour.Pop();
                            flour.Push(currFlourLeft);

                        }
                        else if (currFlour < currWater)
                        {
                            water.Dequeue();
                            flour.Pop();

                        }


                    }
                    if (!water.Any() || !flour.Any())
                    {
                        break;
                    }

                }
                string croissantName = "Croissant";
                string muffinName = "Muffin";
                string baguetteName = "Baguette";
                string bagelName = "Bagel";
                Dictionary<string, int> counts = new Dictionary<string, int>();
                if (Croissant > 0)
                {
                    counts.Add(croissantName, Croissant);
                }
                if (Muffin > 0)
                {
                    counts.Add(muffinName, Muffin);
                }
                if (Baguette > 0)
                {
                    counts.Add(baguetteName, Baguette);
                }
                if (Bagel > 0)
                {
                    counts.Add(bagelName, Bagel);
                }
                var ordered = counts.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);


                foreach (var x in ordered)
                {
                    Console.WriteLine($"{x.Key}: {x.Value}");
                }

                if (water.Count == 0)
                {
                    Console.WriteLine("Water left: None");
                }
                else if (water.Count > 0)
                {
                    Console.WriteLine($"Water left: {String.Join(", ", water)}");
                }
                if (flour.Count == 0)
                {
                    Console.WriteLine("Flour left: None");
                }
                else if (flour.Count > 0)
                {
                    Console.WriteLine($"Flour left: {String.Join(", ", flour)}");
                }

            }
        }
    }
    

