using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiotAPIFrontEnd.Models.Champions;
using System.IO;

namespace Core
{
    public class StandardList
    {
        private static StandardList instance = new StandardList();
        public Dictionary<int,String> coreList { get; }
        public static StandardList Instance
        {
            get
            {
                return instance;
            }
        }
        private StandardList()
        {
            coreList = new Dictionary<int, String>();
            using (StreamReader sr = new StreamReader(@"Models\championFile.txt"))
            {
                
                String line = sr.ReadLine();
                do
                {
                    String[] words = line.Split(',');
                    coreList[Int32.Parse(words[0])] = words[1];
                    line = sr.ReadLine();
                } while (line != null);
            }
            
        }
    }
}
