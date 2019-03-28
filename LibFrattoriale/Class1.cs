using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFrattoriale
{
    public class Class1
    {
        static public long Frattoriale(long a)
        {
            long frat = 1;

            for (int i = 0; i < a; i++)
            {
                frat = frat * i;
            }

            return frat;
        }
    }
}
