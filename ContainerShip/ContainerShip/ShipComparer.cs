using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerShip
{
    public class ShipComparer : IComparer<ITransport>
    {
        public int Compare(ITransport x, ITransport y)
        {
            if (x != null && y != null && x.GetType() == y.GetType())
            {
                if (x is Ship dx && y is Ship dy) return ComparerShip(dx, dy);
                if (x is SuperShip dx1 && y is SuperShip dy1) return ComparerSuperShip(dx1, dy1);
                return string.Compare(x.GetType().Name, y.GetType().Name, StringComparison.Ordinal);
            }
            
            else if (x == null || y == null)
            {
                return 0;
            }
            else
            {
                return string.Compare(x.GetType().Name, y.GetType().Name, StringComparison.Ordinal);
            }
        }
        private int ComparerShip(Ship x, Ship y)
        {
            if (x.MainColor != y.MainColor)
            {
                x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerSuperShip(SuperShip x, SuperShip y)
        {
            if (x.MainColor != y.MainColor)
            {
                x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            if (x.DopColor != y.DopColor)
            {
                x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Crane != y.Crane)
            {
                x.Crane.CompareTo(y.Crane);
            }
            if (x.Container != y.Container)
            {
                x.Container.CompareTo(y.Container);
            }
            return 0;
        }

    }
}
