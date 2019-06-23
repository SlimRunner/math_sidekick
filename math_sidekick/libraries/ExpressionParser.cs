using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;

namespace math_sidekick.libraries.parser
{
    public static class ExpressionParser
    {
        public static Complex ParseComplex(string s)
        {
            /* 
             * matches a real, imaginary, or complex number
             * NOTE: it matches too when both are either imaginary or real
             * This is the original Regex in PCRE: [+-]{0,1}(?<num>\.{0,1}\d+\.{0,1}\d+)i{0,1}\x20*[+-]{0,1}\x20*(?P>num)i{0,1}
             */
            Regex complexPattern = 
                new Regex(
                    @"[+-]{0,1}" +              //matches '+' or '-' but not both or nothing at the beginning
                    @"\.{0,1}\d+\.{0,1}\d+" +   //matches the main body of the number with or without decimal part (###. <- only this is invalid)
                    @"i{0,1}" +                 //matches one or no 'i' at the end
                    @"\x20*[+-]{0,1}\x20*" +    //matches the binding operator with or with no spaces in between
                    @"\.{0,1}\d+\.{0,1}\d+" +   //hardcoded recursing of the main body match because C# doesn't offer recursing
                    @"i{0,1}");                 //matches one or no 'i' at the end

            /*
             * Matches individual terms which can be imaginary or real
             */
            Regex numTermPattern =
                new Regex(
                    @"[+-]{0,1}\.{0,1}\d+\.{0,1}\d+i{0,1}");

            /*
             * Matches the operators that are not caught by the numTermPattern
             * Was modified from this: (?<=[\x20\di])[+-](?=[\x20\d.])|(?<=[\x20\di])[+-](?=[\d.])|(?<=[\di])[+-](?=[\x20\d.])
             * to NOT match certain binding operators
             */
            Regex bindOpPattern =
                new Regex(
                    @"(?<=[\x20])[+-](?=[\x20])|" + //matches a binding sign with spaces around it
                    @"(?<=[\x20])[+-]|" +           //matches a binding sign with spaces only to its left
                    @"[+-](?=[\x20])");             //matches a binding sign with spaces only to its right

            string realTerm, imagTerm;

            //Patterns above do not work with spaces at the beginning or end
            s = s.Trim();
            
            if (complexPattern.Match(s).ToString() == s &&  //matches a Regex pattern
                s.Count(f => f == 'i') < 2)                 //makes sure there isn't two imaginary terms
            {
                MatchCollection numericTerms = numTermPattern.Matches(s);
                Match numOperator = bindOpPattern.Match(s);
                

                switch (numericTerms.Count)
                {
                    case 1:
                        //single term can be either imaginary or real
                        if (s.Contains("i"))
                        {//term is imaginary
                            realTerm = "0";
                            imagTerm = numericTerms[1].Value;
                        }
                        else
                        {//term is real
                            realTerm = numericTerms[0].Value;
                            imagTerm = "0";
                        }
                        break;
                    case 2:
                        //this is a bi-term number therefore it must have an imaginary part
                        //otherwise the argument is invalid
                        if (s.Contains("i"))
                        {
                            if (numOperator.Success)
                            {//mid-operator is NOT bound to the second term
                                realTerm = numericTerms[0].Value;
                                imagTerm = numOperator.Value + numericTerms[1].Value;
                            }
                            else
                            {//mid-operator is bound to second term
                                realTerm = numericTerms[0].Value;
                                imagTerm = numericTerms[1].Value;
                            }
                        }
                        else
                        {//bi-term argument does not have imaginary part
                            throw new ArgumentException("Both terms are real numbers.");
                        }
                        break;
                    default:
                        throw new Exception("Unknown exeption was thrown");
                        //break;
                }
            }
            else
            {
                throw new ArgumentException("Argument is not valid.");
            }

            Complex retVal = new Complex(double.Parse(realTerm), double.Parse(imagTerm));
            return retVal;
        }

        public static bool TryParseComplex(string s, out Complex result)
        {
            /* 
             * matches a real, imaginary, or complex number
             * NOTE: it matches too when both are either imaginary or real
             * This is the original Regex in PCRE: [+-]{0,1}(?<num>\.{0,1}\d+\.{0,1}\d+)i{0,1}\x20*[+-]{0,1}\x20*(?P>num)i{0,1}
             */
            Regex complexPattern =
                new Regex(
                    @"[+-]{0,1}" +              //matches '+' or '-' but not both or nothing at the beginning
                    @"\.{0,1}\d*\.{0,1}\d*" +   //matches the main body of the number with or without decimal part (###. <- only this is invalid)
                    @"i{0,1}" +                 //matches one or no 'i' at the end
                    @"\x20*[+-]{0,1}\x20*" +    //matches the binding operator with or with no spaces in between
                    @"\.{0,1}\d*\.{0,1}\d+" +   //hardcoded recursing of the main body match because C# doesn't offer recursing
                    @"i{0,1}");                 //matches one or no 'i' at the end

            /*
             * Matches individual terms which can be imaginary or real
             */
            Regex numTermPattern =
                new Regex(
                    @"[+-]{0,1}\.{0,1}\d*\.{0,1}\d+i{0,1}");

            /*
             * Matches the operators that are not caught by the numTermPattern
             * Was modified from this: (?<=[\x20\di])[+-](?=[\x20\d.])|(?<=[\x20\di])[+-](?=[\d.])|(?<=[\di])[+-](?=[\x20\d.])
             * to NOT match certain binding operators
             */
            Regex bindOpPattern =
                new Regex(
                    @"(?<=[\x20])[+-](?=[\x20])|" + //matches a binding sign with spaces around it
                    @"(?<=[\x20])[+-]|" +           //matches a binding sign with spaces only to its left
                    @"[+-](?=[\x20])");             //matches a binding sign with spaces only to its right

            string realTerm, imagTerm;

            //Patterns above do not work with spaces at the beginning or end
            s = s.Trim();

            if (complexPattern.Match(s).ToString() == s &&  //matches a Regex pattern
                s.Count(f => f == 'i') < 2)                 //makes sure there isn't two imaginary terms
            {
                MatchCollection numericTerms = numTermPattern.Matches(s);
                Match numOperator = bindOpPattern.Match(s);


                switch (numericTerms.Count)
                {
                    case 1:
                        //single term can be either imaginary or real
                        if (s.Contains("i"))
                        {//term is imaginary
                            realTerm = "0";
                            imagTerm = numericTerms[0].Value.Replace("i","");
                        }
                        else
                        {//term is real
                            realTerm = numericTerms[0].Value;
                            imagTerm = "0";
                        }
                        break;
                    case 2:
                        //this is a bi-term number therefore it must have an imaginary part
                        //otherwise the argument is invalid
                        if (s.Contains("i"))
                        {
                            if (numOperator.Success)
                            {//mid-operator is NOT bound to the second term
                                realTerm = numericTerms[0].Value;
                                imagTerm = numOperator.Value + numericTerms[1].Value.Replace("i", "");
                            }
                            else
                            {//mid-operator is bound to second term
                                realTerm = numericTerms[0].Value;
                                imagTerm = numericTerms[1].Value.Replace("i", "");
                            }
                        }
                        else
                        {//bi-term argument does not have imaginary part
                            result = Complex.Zero;
                            return false;
                        }
                        break;
                    default:
                        //unknown error
                        result = Complex.Zero;
                        return false;
                        //break;
                }
            }
            else
            {//argument is invalid
                result = Complex.Zero;
                return false;
            }
            
            try
            {//tries to parse the data
                result = new Complex(double.Parse(realTerm), double.Parse(imagTerm));
                return true;
            }
            catch (Exception)
            {//argument is invalid
                result = Complex.Zero;
                return false;
            }
        }

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
