using System.Text.RegularExpressions;

namespace uc_9emailvalidation
{
    internal class ninthemail
    {
        public static string Regex_Pincode = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]*)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        
        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, Regex_Pincode);
        }
    }
}
