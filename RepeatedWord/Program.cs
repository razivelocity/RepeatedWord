using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RepeatedWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Razi is Boy Boy";
            var value = s.Split(" ");
            Dictionary<String, int> repeatedword = new Dictionary<string, int>();

            for ( int i=0;i<value.Length;i++)
            {
                if (repeatedword.ContainsKey(value[i]))
                {
                    int count = repeatedword[value[i]];
                    repeatedword[value[i]] = count + 1;
                }
                else
                {
                    repeatedword.Add(value[i], 1);
                }
            }
            foreach( KeyValuePair<string,int> kpg in repeatedword)
            {if(kpg.Value>1)

                Console.WriteLine(kpg.Key +""+ kpg.Value);
            }
            
        }
    }
}
