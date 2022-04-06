using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    public class MarinaAlreadyHaveException : Exception
    {
        public MarinaAlreadyHaveException() : base("На пристани уже есть такое судно") { }
    }
}
