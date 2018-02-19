using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_cs
{
    public class Tree<T>
    {
        private Tree<T> Parent { get; set; }
        private HashSet<Tree<T>> Children;
        private int hashValue; private int hashCode;
        private HashSet<T> ToHashSet = new HashSet<T>();

        /// <summary>
        /// Models for initializer methods.
        /// <para>Initializes variables.</para>
        /// </summary>
        private void Initiate(int hash)
        {
            // Initialize variables.
            Parent = this;
            Children = new HashSet<Tree<T>>();
            hashValue = hash; hashCode = hash;
        }

        /// <summary>
        /// Initializer for Tree class
        /// </summary>
        public Tree()
        {
            Initiate(0);
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public Tree(T value)
        {
            Initiate(value.GetHashCode());
        }

        /// <summary>
        /// Return true iff obj has the same root and children as this.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Tree<T>))
            {
                return false;
            }

            obj = (Tree<T>)obj;

            // Want to ch
            return true;
        }

        /// <summary>
        /// Update the hash code.
        /// </summary>
        private void SetHashCode()
        {

        }

        public override int GetHashCode()
        {
            int hashCode = hashValue;
            foreach (Tree<T> t in Children)
            {
                hashCode += 2 * hashCode + t.GetHashCode();
            }

            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void AddChild(Tree<T> tree) => Children.Add(tree);

        public bool IsRoot => Parent == this;

        public Path<T> PathToRoot()
        {
            Path<T> path = new Path<T>();
            Tree<T> tree = this; path.AddFirst(tree);

            while (!tree.IsRoot)
            {
                tree--; path.AddLast(tree);
            }

            return path;
        }

        public static Tree<T> operator --(Tree<T> tree) => tree.Parent;
    }
}
