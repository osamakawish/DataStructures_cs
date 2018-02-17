using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_cs
{
    public class Tree
    {
        private Tree Parent { get; set; }
        private HashSet<Tree> Children { get; set; }

        public Tree()
        {
            Children = new HashSet<Tree>();
        }

        /// <summary>
        /// Return true iff obj has the same root and children as this.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (!(obj is Tree))
            {
                return false;
            }

            obj = (Tree)obj;

            // Want to ch
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
