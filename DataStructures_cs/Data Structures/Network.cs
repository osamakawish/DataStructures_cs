using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_cs.Data_Structures
{
    class Network<T> : ICollection<T>
    {
        private Dictionary<T, HashSet<T>> network;

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Add(ICollection<T> dataStructure)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public T GetRandom()
        {
            throw new NotImplementedException();
        }

        public void Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void Remove(ICollection<T> dataStructure)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
