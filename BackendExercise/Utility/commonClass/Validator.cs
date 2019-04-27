/******************************************************************************
* Created By: Sumit Choudhary
* Created On: 26th April 2019
* Purpose: Valididation of the inputs value like email, phone etc.. 
********************************************************************************/

using System;
using System.Text.RegularExpressions;

namespace BackendExercise.Utility.commonClass
{
    public class Validator
    {
        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool ValidateEmail(string email)
        {
            try
            {
                return Regex.Match(email, Constants.RegexString.Email, RegexOptions.IgnoreCase).Success;
            }
            catch (Exception)
            {
                //Log error here..
                return false;
            }
        }

        /// <summary>
        /// Validates the phone number.
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public static bool ValidatePhoneNumber(string phoneNumber)
        {
            try
            {
                return Regex.Match(phoneNumber, Constants.RegexString.Phone, RegexOptions.IgnoreCase).Success; ;
            }
            catch (Exception)
            {
                //Log error here..
                return false;
            }
        }
    }
}