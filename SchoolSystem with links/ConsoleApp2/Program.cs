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
            School[] School = new School[1];
            Canteen[] Canteen = new Canteen[1];
            Class[] Class = new Class[10];
            People[] People = new People[27];
            int i;
            {
                {
                    for (i = 0; i < School.Length; i++)
                        School[i] = new School();
                    for (i = 0; i < Canteen.Length; i++)
                        Canteen[i] = new Canteen();
                    for (i = 0; i < Class.Length; i++)
                        Class[i] = new Class();
                    for (i = 0; i < People.Length; i++)
                        People[i] = new People();
                }
                Array.Resize(ref School, 1);
                Array.Resize(ref Canteen, 1);
                Array.Resize(ref Class, 10);
                Array.Resize(ref People, 27);
                School[0] = new School("S#0", ref Canteen[0], new Class[] { Class[0], Class[1], Class[2], Class[3], Class[4], Class[5], Class[6], Class[7], Class[8], Class[9] });
                Canteen[0] = new Canteen("C#0", ref School[0], new string[] { "Soup", "Meat" });
                Class[0] = new Class("#1", ref School[0], new People[] { People[0], People[1], People[2] });
                Class[1] = new Class("#2", ref School[0], new People[] { People[3], People[4] });
                Class[2] = new Class("#3", ref School[0], new People[] { People[5]});
                Class[3] = new Class("#4", ref School[0], new People[] { People[6], People[7], People[8], People[9], People[10] });
                Class[4] = new Class("#5", ref School[0], new People[] { People[11], People[12], People[13], People[14] });
                Class[5] = new Class("#6", ref School[0], new People[] { People[15], People[16], People[17] });
                Class[6] = new Class("#7", ref School[0], new People[] { People[18], People[19], People[20] });
                Class[7] = new Class("#8", ref School[0], new People[] { People[21], People[22]});
                Class[8] = new Class("#9", ref School[0], new People[] { People[23], People[24], People[25] });
                Class[9] = new Class("#10", ref School[0], new People[] { People[26]});
                People[0] = new People("A", ref Class[0], ref School[0]);
                People[1] = new People("B", ref Class[0], ref School[0]);
                People[2] = new People("C", ref Class[0], ref School[0]);
                People[3] = new People("D", ref Class[1], ref School[0]);
                People[4] = new People("E", ref Class[1], ref School[0]);
                People[5] = new People("F", ref Class[2], ref School[0]);
                People[6] = new People("G", ref Class[3], ref School[0]);
                People[7] = new People("H", ref Class[3], ref School[0]);
                People[8] = new People("I", ref Class[3], ref School[0]);
                People[9] = new People("J", ref Class[3], ref School[0]);
                People[10] = new People("K", ref Class[3], ref School[0]);
                People[11] = new People("L", ref Class[4], ref School[0]);
                People[12] = new People("M", ref Class[4], ref School[0]);
                People[13] = new People("N", ref Class[4], ref School[0]);
                People[14] = new People("O", ref Class[4], ref School[0]);
                People[15] = new People("P", ref Class[5], ref School[0]);
                People[16] = new People("Q", ref Class[5], ref School[0]);
                People[17] = new People("R", ref Class[5], ref School[0]);
                People[18] = new People("S", ref Class[6], ref School[0]);
                People[19] = new People("T", ref Class[6], ref School[0]);
                People[20] = new People("U", ref Class[6], ref School[0]);
                People[21] = new People("V", ref Class[7], ref School[0]);
                People[22] = new People("W", ref Class[7], ref School[0]);
                People[23] = new People("X", ref Class[8], ref School[0]);
                People[24] = new People("Y", ref Class[8], ref School[0]);
                People[25] = new People("Z", ref Class[8], ref School[0]);
                People[26] = new People("A", ref Class[9], ref School[0]);
            }
            for (i = 0; i < School.Length; i++)
            {
                Console.Write(School[i].Name + " ");
            }
            Console.WriteLine();
            for (i = 0; i < Class.Length; i++)
            {
                Console.Write(Class[i].Name + " ");
            }
            Console.WriteLine();
            for (i = 0; i < School[0].Length; i++)
            {
                Console.Write(School[0][i].Name + " ");
            }
            Console.WriteLine();
            for (i = 0; i < People.Length; i++)
            {
                Console.Write(People[i].Name + " ");
            }
            Console.WriteLine();
            Console.WriteLine("School[0][0].Name " + School[0][0].Name);
            Console.WriteLine("Class[0].Name " + Class[0].Name);


            Console.ReadKey();
        }
    }
}