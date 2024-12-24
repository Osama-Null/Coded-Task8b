using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleT8b.Models
{
    public class Class1
    {
        public float Add(float a, float b)
        {
            return a + b;
        }
        public float Add(float a, float b, float c)
        {
            return a + b + c;
        }
        public float Add(float a, float b, string c)
        {
            float d = float.Parse(c);
            return a + b + d;
        }
        public float Add(float salary, string bonus)
        {
            const int rate = 10;
            return salary + (float.Parse(bonus) * rate);
        }
    }
}
