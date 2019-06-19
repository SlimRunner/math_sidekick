using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace math_sidekick.libraries
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
    }
}
