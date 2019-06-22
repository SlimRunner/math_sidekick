using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace math_sidekick.libraries
{
    public static class ExpressionParser
    {
        public static string ComposeComplex(Complex input)
        {
            const double LOWER_NUMERIC_BOUND = 0.00000001;
            string outputFormat;

            if (Math.Abs(input.Imaginary) < LOWER_NUMERIC_BOUND)
            {//input has only real part [bi]
                return input.Real.ToString("0.###");
            }
            else if (Math.Abs(input.Real) < LOWER_NUMERIC_BOUND)
            {//input has only imaginary part [a]
                return input.Imaginary.ToString("0.###i");
            }
            else
            {//input is a complex number
                if (input.Imaginary < 0)
                {//imaginary part is negative [a - bi]
                    outputFormat = "{0:0.###} - {1:0.###i;0.###i}";
                }
                else
                {//imaginary part is positive [a + bi]
                    outputFormat = "{0:0.###} + {1:0.###i}";
                }

                //formats complex number correctly
                return string.Format(outputFormat, input.Real, input.Imaginary);
            }
        }
    }
}
