using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_cs
{
    public class Path<T>
    {
        private LinkedList<Tree<T>> PathContent { get; }

        public Path() { }

        public void AddFirst(Tree<T> tree) => PathContent.AddFirst(new LinkedListNode<Tree<T>>(tree));

        public void AddLast(Tree<T> tree) => PathContent.AddLast(new LinkedListNode<Tree<T>>(tree));

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
