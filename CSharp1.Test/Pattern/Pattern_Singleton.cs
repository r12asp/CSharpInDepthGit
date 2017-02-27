using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp1.Test
{
    public class Pattern_Singleton
    {
        private static volatile Pattern_Singleton _instance;
        private static object syncRoot = new object();
        private Pattern_Singleton()
        {
            if(_instance== null)
            {
                lock (syncRoot)
                {
                    if(_instance==null)
                        _instance = new Pattern_Singleton();
                }
            }
        }

        public static Pattern_Singleton Instance
        {
            get { return _instance; }

        }
    }
}
