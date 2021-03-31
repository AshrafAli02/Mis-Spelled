using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mis_Spelled
{
    class Program
    {
        public static List<string> Words = new List<string>();
        public static List<string> Mis_Words = new List<string>();
        static void Main(string[] args)
        {
            #region List Date
            ListDate();
            #endregion
            string A = "spred";
            WordCheck(A);

        }

        public static void WordCheck(string s)
        {
            
            StringBuilder SB = new StringBuilder();
            if(Words.Contains(s)==true)
            {
                SB.Append(s);
                Console.WriteLine(SB.ToString());
                return;
            }
            else if(!Words.Contains(s))
            {
                foreach(var v in Words)
                {
                    int count = 0;
                    if (s.Length == v.Length)
                    {
                        for (int i = 0; i < s.Length; i++)
                        {
                            if (s[i] == v[i])
                            {
                                count++;
                            }
                        }
                        if (count >= 2)
                        {
                            SB.Append(v);
                            Mis_Words.Add(v);
                        }
                    }
                }
                Print();
            }
            else
            {
                Console.WriteLine("Invalid ");
            }
        }
        #region List Data
        public static void ListDate()
        {
            Words.Add("speed");
            Words.Add("apple");
            Words.Add("school");
            Words.Add("college");
            Words.Add("speedy");
        }
        #endregion
        #region Print Suggestion Word
        public static void Print()
        {
            foreach(var v in Mis_Words)
            {
                Console.WriteLine(v);
            }
        }

        #endregion
    }
}
