using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_cs.Data_Structures
{
    /// <summary>
    /// The dual class is a bi-directional dictionary.
    /// </summary>
    public class Dual<S, T>
    {
        Dictionary<S, T> StoT = new Dictionary<S, T>();
        Dictionary<T, S> TtoS = new Dictionary<T, S>();
        int hashCode;

        public Dual()
        {
        }

        public override bool Equals(object obj)
        {
            // Make sure the type is appropriate.
            if (!(obj is Dual<S,T> || obj is Dual<T,S>))
            {
                return false;
            }

            // Make sure the trees are equal

            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void Add(S s, T t)
        {
            StoT.Add(s, t); TtoS.Add(t, s);
        }

        //
        public static bool operator !=(Dual<S, T> dual1, Dual<S, T> dual2)
        {
            return false;
        }

        public static bool operator== (Dual<S,T> dual1, Dual<S,T> dual2)
        {
            return true;
        }
    }
}
