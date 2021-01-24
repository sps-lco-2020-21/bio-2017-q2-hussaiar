using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIO2017Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            DotsAndBoxesQ2();
            Console.ReadKey();
        }

        static void DotsAndBoxesQ2()
        {

            int p1 = Convert.ToInt32(Console.ReadLine());
            int p2 = Convert.ToInt32(Console.ReadLine());  //start position
            int m1 = Convert.ToInt32(Console.ReadLine());   
            int m2 = Convert.ToInt32(Console.ReadLine());   //modifier
            int t = Convert.ToInt32(Console.ReadLine());    //number of turns to simulate
            List<string> connections1 = new List<string> { };
            List<string> connections2 = new List<string> { };
            int numturns = 0;
            while (numturns < t)
            {
                p1 = p1 + m1;
                int count = connections1.Count();
                possibleconnection(connections1, p1);
                if (count == connections1.Count())
                {
                    while (count == connections1.Count())
                    {
                        p1++;
                        possibleconnection(connections1, p1);
                    }
                }
                p2 = p2 + m2;
                count = connections2.Count();
                possibleconnection(connections2, p2);
                if (count == connections2.Count())
                {
                    while (count == connections2.Count())
                    {
                        p2++;
                        possibleconnection(connections2, p2);
                    }
                }
                numturns++;

            }
            
            foreach(string s )




        }

        static void possibleconnection(List<string> connections,int p1)
        {
            if ( (connections.Contains((Convert.ToString(p1) + "-" + Convert.ToString(p1 - 6)))) && ( (p1-6)>0 ))
            {
                if (connections.Contains((Convert.ToString(p1) + "-" + Convert.ToString(p1 + 1))) && ((p1 +1) < 37))
                {
                    if (connections.Contains((Convert.ToString(p1) + "-" + Convert.ToString(p1 + 6))) && ((p1 + 6) < 37))
                    {
                        if (connections.Contains((Convert.ToString(p1) + "-" + Convert.ToString(p1 - 1))) && ((p1 - 1) > 0))
                        {
                            
                        }
                        else
                        {
                            connections.Add(Convert.ToString(p1) + "-" + Convert.ToString(p1 - 1));
                        }

                    }
                    else
                    {
                        connections.Add(Convert.ToString(p1) + "-" + Convert.ToString(p1 + 6));
                    }
                }
                else
                {
                    connections.Add(Convert.ToString(p1) + "-" + Convert.ToString(p1 + 1));
                }
            }
            else
            {
                connections.Add(Convert.ToString(p1) + "-" + Convert.ToString(p1 - 6));
            }
            
        }

    }
}
