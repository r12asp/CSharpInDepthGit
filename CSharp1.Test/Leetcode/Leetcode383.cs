using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Leetcode383
    {
        public static Boolean CanConstruct(string randomNote, string magazine)
        {
            List<char> randomSet = new List<char>();
            List<char> magazineSet = new List<char>();
            foreach (char iChar in randomNote)
            {
                randomSet.Add(iChar);
            }
            foreach (char iChar in magazine)
            {
                magazineSet.Add(iChar);
            }

            foreach (char iChar in randomSet)
            {
                if (magazineSet.Contains(iChar)) magazineSet.Remove(iChar);
            }

            if (magazineSet.Count == magazine.Length - randomNote.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
