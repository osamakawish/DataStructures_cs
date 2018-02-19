using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_cs
{
    interface ICollection<T>
    {
        void Add(T item);
        void Add(ICollection<T> dataStructure);

        void Remove(T item);
        void Remove(ICollection<T> dataStructure);

        bool Contains(T item);

        T GetRandom();
    }
}
