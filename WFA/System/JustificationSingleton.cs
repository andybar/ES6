using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    public class JustificationSingleton
    {
        private static JustificationSingleton instance;
        public static string justificationBuffer = string.Empty;
        private JustificationSingleton() { }

        public static JustificationSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new JustificationSingleton();
                }
                return instance;
            }
        }

        public static void WriteLine(string line)
        {
            justificationBuffer += line;
        }

        public static void Clear()
        {
            justificationBuffer = string.Empty;
        }
    }
}
