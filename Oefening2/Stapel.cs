using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening2
{
    internal class Stapel<T>
    {
        List<T> list = new List<T>();

        public void voegToe(T el)
        {
            list.Add(el);
        }

        public T Verwijderen()
        {
            if (list.Count == 0)
                throw new StackOverflowException();
            T del = list[0];
            list.RemoveAt(0);
            return del;
        }

        public void Leegmaken()
        {
            list.Clear();
        }

        public bool isAanwezig(T el)
        {
            if (list.Contains(el))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Stapel<T> Copy()
        {
            return (Stapel<T>)MemberwiseClone();
        }

        public override string ToString()
        {
            return String.Join(" , ", list);
        }
    }
}
