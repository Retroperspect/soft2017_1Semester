using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3___Set_Theory
{
    class SetAPI
    {
        public SetAPI()
        {

        }

        /// <summary>
        /// membership function that checks if X is subset of Y
        /// </summary>
        /// <param name="X">Set value to test</param>
        /// <param name="Y">Set value to test</param>
        /// <returns>true or false statement</returns>
        public bool Membership(HashSet<int> X, HashSet<int> Y)
        {
            bool statement = false;
            if (Comparison(X,Y) == -1)
            {
                statement = true;
            }
            return statement;
        }

        /// <summary>
        /// Intersection function
        /// </summary>
        /// <param name="X">Set value to test</param>
        /// <param name="Y">Set value to test</param>
        /// <returns>All values that both X and Y shares</returns>
        public int[] Intersection(int[] X, int[] Y)
        {
            return X.Intersect(Y).ToArray();
        }

        /// <summary>
        /// Union function
        /// </summary>
        /// <param name="X">Set value to test</param>
        /// <param name="Y">Set value to test</param>
        /// <returns>both X and Y combined</returns>
        public int[] Union(int[] X, int[] Y)
        {
            return X.Union(Y).ToArray();
        }

        /// <summary>
        /// Difference fucntion
        /// </summary>
        /// <param name="X">Set value to test</param>
        /// <param name="Y">Set value to test</param>
        /// <returns>all X without the values that interesect with Y</returns>
        public int[] Difference(int[] X, int[] Y)
        {
            return X.Except(Y).ToArray();
        }

        /// <summary>
        /// Complement function
        /// </summary>
        /// <param name="X">Set Value to test</param>
        /// <param name="Y">Contextual value - infinite</param>
        /// <returns>everything but X</returns>
        public int[] Complement(int[] X, int[] Y)
        {
            return Y.Except(X).ToArray();
        }

        /// <summary>
        /// Comparison function that checks the two set values and return a statement value between (-2,-1,0,1,2) depending on the result
        /// </summary>
        /// <param name="X">Set value to test</param>
        /// <param name="Y">Set value to test</param>
        /// <returns>-2 is default, -1 means X is a subset of Y, 0 means X == Y, 1 means X is a superset of Y, 2 is undetermined</returns>
        public int Comparison(HashSet<int> X, HashSet<int> Y)
        {
            int Z;
            if (X.IsSubsetOf(Y) && !X.SetEquals(Y))
            {
                Z = -1;
            }
            else if (X.SetEquals(Y))
            {
                Z = 0;
            }
            else if (X.IsSupersetOf(Y))
            {
                Z = 1;
            }
            else if (X.IsSubsetOf(Y) && Y.IsSubsetOf(X))
            {
                Z = 2;
            }
            else
            {
                Z = -2;
            }

            return Z;
        }

    }
}
