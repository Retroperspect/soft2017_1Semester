using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3___Set_Theory
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] B = new int[] { 1, 2, 3, 4, 5 };
            int[] C = new int[] { 5, 6, 7, 8, 9 };
            int[] D = new int[] { 1, 2, 3, 6, 7, 8 };
            int[] E = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] F = new int[] { };

            SetAPI API = new SetAPI();
            Console.WriteLine("intersection of A {0} and B {1} == {2}",string.Join(",",A), string.Join(",", B), string.Join(",",API.Intersection(A, B)));
            Console.WriteLine("intersection of B {0} and A {1} == {2}", string.Join(",", B), string.Join(",", A), string.Join(",", API.Intersection(B, A)));
            Console.WriteLine("Union of C {0} and B {1} == {2}", string.Join(",", C), string.Join(",", B), string.Join(",", API.Union(C, B)));
            Console.WriteLine("Union of B {0} and C {1} == {2}", string.Join(",", B), string.Join(",", C), string.Join(",", API.Union(B, C)));
            Console.WriteLine("Difference of C {0} too D {1} == {2}", string.Join(",", C), string.Join(",", D), string.Join(",", API.Difference(C, D)));
            Console.WriteLine("Difference of D {0} too C {1} == {2}", string.Join(",", D), string.Join(",", C), string.Join(",", API.Difference(D, C)));
            Console.WriteLine("Is B {0} a member of A? {1} == {2}", string.Join(",", B), string.Join(",", A), API.Membership(new HashSet<int>(B), new HashSet<int>(A)));
            Console.WriteLine("Is A {0} a member of B? {1} == {2}", string.Join(",", A), string.Join(",", B), API.Membership(new HashSet<int>(A), new HashSet<int>(B)));
            Console.WriteLine("what is the Complement of E {0} too B {1} == {2}", string.Join(",", E), string.Join(",", B), string.Join(",", API.Complement(E, B)));
            Console.WriteLine("what is the Complement of B {0} too E {1} == {2}", string.Join(",", B), string.Join(",", E), string.Join(",", API.Complement(B, E)));
            Console.WriteLine("now to compare");
            Console.WriteLine("Comparing {0} and {1} which is = {2}", string.Join(",", A), string.Join(",", B), API.Comparison(new HashSet<int>(A), new HashSet<int>(B)));
            Console.WriteLine("Comparing {0} and {1} which is = {2}", string.Join(",", B), string.Join(",", C), API.Comparison(new HashSet<int>(B), new HashSet<int>(C)));
            Console.WriteLine("Comparing {0} and {1} which is = {2}", string.Join(",", C), string.Join(",", D), API.Comparison(new HashSet<int>(C), new HashSet<int>(D)));
            Console.WriteLine("Comparing {0} and {1} which is = {2}", string.Join(",", D), string.Join(",", E), API.Comparison(new HashSet<int>(D), new HashSet<int>(E)));
            Console.WriteLine("Comparing {0} and {1} which is = {2}", string.Join(",", E), string.Join(",", F), API.Comparison(new HashSet<int>(E), new HashSet<int>(F)));
            Console.WriteLine("Comparing {0} and {1} which is = {2}", string.Join(",", F), string.Join(",", F), API.Comparison(new HashSet<int>(F), new HashSet<int>(F)));
            Console.WriteLine("Comparing {0} and {1} which is = {2}", string.Join(",", A), string.Join(",", A), API.Comparison(new HashSet<int>(A), new HashSet<int>(A)));
            Console.ReadKey();
        }
    }
}
