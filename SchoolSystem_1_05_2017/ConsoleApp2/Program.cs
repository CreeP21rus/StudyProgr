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
            List<School> School = new List<School>();
            List<Canteen> Canteen = new List<Canteen>();
            List<Class> Class = new List<Class>();
            List<People> People = new List<People>();
            {
                School.Add(new School());
                Canteen.Add(new Canteen());
                for (int i = 0; i < 10; i++)
                    Class.Add(new Class());
                for (int i = 0; i < 27; i++)
                    People.Add(new People());
            }

            {
                School[0] = new School("S#0");
                Canteen[0] = new Canteen("C#0"); School[0].Canteen = Canteen[0];
                for (int i = 0; i < 10; i++)
                {
                    Class[i] = new Class("#" + (i + 1));
                    School[0].ClasList.Add(Class[i]);
                }
                for (int i = 0; i < (int)('Z') - (int)('A') + 1; i++)
                    People[i] = new People((char)((int)('A') + i) + "");
                People[26] = new People("A");
                School[0].Canteen.Menu.Add("Soup");
                School[0].Canteen.Menu.Add("Meat");
                School[0].AcceptPeople(Class[0], People[0], People[1], People[2]);
                School[0].AcceptPeople(Class[1], People[3], People[4]);
                School[0].AcceptPeople(Class[2], People[5]);
                School[0].AcceptPeople(Class[3], People[6], People[7], People[8], People[9], People[10]);
                School[0].AcceptPeople(Class[4], People[11], People[12], People[13], People[14]);
                School[0].AcceptPeople(Class[5], People[15], People[16], People[17]);
                School[0].AcceptPeople(Class[6], People[18], People[19], People[20]);
                School[0].AcceptPeople(Class[7], People[21], People[22]);
                School[0].AcceptPeople(Class[8], People[23], People[24], People[25]);
                School[0].AcceptPeople(Class[9], People[26]);
            }

            Console.ReadKey();
        }
    }
}