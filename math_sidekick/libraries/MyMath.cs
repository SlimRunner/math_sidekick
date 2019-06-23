using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace math_sidekick.libraries.math
{
    public static class MyMath
    {
        /// <summary>
        /// <para>
        /// Calculates an arbitrary transition using linear interpolation (lerp) of the two values provided.
        /// </para>
        /// 
        /// <para>
        /// When <paramref name="t"/> equals 0, <paramref name="value1"/> is returned.
        /// When <paramref name="t"/> equals 1, <paramref name="value2"/> is returned.
        /// </para>
        /// 
        /// </summary>
        /// <param name="value1">The first value</param>
        /// <param name="value2">The second value</param>
        /// <param name="t">A transition point between [0, 1]</param>
        /// <returns>A linear interpolated blend between <paramref name="value1"/> and <paramref name="value2"/> at the transition point <paramref name="t"/></returns>
        public static float Lerp(float value1, float value2, float t)
        {
            return (1 - t) * value1 + t * value2;
        }

        public static Complex[] FindRootsQuadTrinom(Complex a_term, Complex b_term, Complex c_term)
        {
            //all quadratic trinomials have either one or two answers
            Complex[] x = new Complex[]
            {
                new Complex(0, 0),
                new Complex(0, 0)
            };
            Complex discriminant;

            //calculates the discriminant
            discriminant = Complex.Add(Complex.Pow(b_term, 2), Complex.Multiply(-4, Complex.Multiply(a_term, c_term)));
            
            //calcualtes the root(s)
            if (discriminant.Real != 0)
            {//two roots
                x[0] = Complex.Divide(Complex.Add(Complex.Negate(b_term), Complex.Sqrt(discriminant)), Complex.Multiply(2, a_term));
                x[1] = Complex.Divide(Complex.Subtract(Complex.Negate(b_term), Complex.Sqrt(discriminant)), Complex.Multiply(2, a_term));
            }
            else
            {//one root
                x[0] = Complex.Divide(Complex.Add(Complex.Negate(b_term), Complex.Sqrt(discriminant)), Complex.Multiply(2, a_term));
                x[1] = x[0];
            }

            return x;
        }
    }
}
