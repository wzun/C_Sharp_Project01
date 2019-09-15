
using System.Text.RegularExpressions;

namespace Mybikes.bus
{
  public  class Validator
    {
        /*********   -1-   
        * IsDigit(string param1)
		*  ^([1-9]+)$
		* ^ represents beginning of the pattern
        * $ represents end of the pattern
        * Here range is between 1 and 9 
        * ^([1-9]+)$
        * [1-9] covering 1 to 9 more than once
        *********************/
        public static bool IsDigit(string text)
        {
            Regex pattern = new Regex(@"^([1-9]+)$");
			
            return pattern.IsMatch(text);
        }

        /*********   -2- 
      * IsAlphabetLetters(string param1)
      * ^([a-zA-Z|\s]+)$
      * ^ represents begining
      * $ represents ending
      * a-zA-Z represents alphabet letters 
      * \s is for adding space
      * + sign represents that we can have more than one space and more than one alphabet
      *********************/
        public static bool IsLetter(string text)
        {
            Regex name = new Regex(@"^([a-zA-Z|\s]+)$");
            return name.IsMatch(text);
        }
    }
}
 