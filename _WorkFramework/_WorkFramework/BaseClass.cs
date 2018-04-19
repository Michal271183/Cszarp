using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _WorkFramework
{
    public class BaseClass
    {
        public int Dodawanie(int x, int y)
        {
            int suma = x + y;

            return suma;       
        }

        public int Odejmowanie(int x, int y)
        {
            int suma = x - y;

            return suma;
        }
    }
}
