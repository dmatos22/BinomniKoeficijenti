using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinomniKoeficijenti
{
    public class BinomniK
    {
        int n, k;
        public int BinK(int a, int b)
        {
            int r = 1;
            if (b > a)
                return 0;
            if (b < 0)
                return 0;
            if (a <= 0)
                return 0;
            for (int i = 1; i <= b; i++)
            {
                r *= a--;
                r /= i;
            }
            return r;
        }

        public BinomniK()    
        {
            n = 1;
            k = 1;
        }

        public int vrijednostN            
        {
            set { n = value; }
            get { return n; }
        }

        public int vrijednostK           
        {
            set { k = value; }
            get { return k; }
        }

        public int Faktorijel(int a)
        {
            int r = 1;
            if (a < 0)
                return 0;
            for (int i = 1; i <= a; i++)
            {
                r = r * i;
            }
            return r;
        }

    }
}
