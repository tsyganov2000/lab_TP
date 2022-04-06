using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    public class MarinaOverflowException : Exception
    {
        public MarinaOverflowException() : base("На пристани нет свободных мест") { }

    }
}
