using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    public class MarinaNotFoundException : Exception
    {
        public MarinaNotFoundException(int i) : base("Не найдено судно по месту " + i) { }

    }
}
