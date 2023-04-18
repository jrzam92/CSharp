using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoAuto
{
    public class M3:BMW
    {
        public M3()
        {

        }
        public M3(int hp, string color, string modelo) : base(hp, color,modelo)
        {
            
        }
        public sealed override string FixedCar()
        {
            return base.FixedCar();
        }
    }
}
