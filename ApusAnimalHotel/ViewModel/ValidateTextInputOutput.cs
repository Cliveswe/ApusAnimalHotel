using System.Text.RegularExpressions;
/// <summary>
/// Clive Leddy (6710232551)
///
/// Date 2019-03-07
/// </summary>
namespace ApusAnimalHotel.ViewModel
{
    /// <summary>
    /// Determines whether the specified string contains only alphabet 
    /// and white space characters.
    /// </summary>
    class ValidateTextInputOutput
    {
        /// <summary>
        /// Determines whether the specified string is alphabet.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>
        ///   <c>true</c> if the specified string is alphabet; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsAlphabet(string str)
        {
            bool validate = true;
            //pattern of alphabet and space
            Regex regex = new Regex("^[a-zA-Z ]+$");
            if (!regex.IsMatch(str))
            {
                validate = false;
            }

            return validate;
        }

    }
}
