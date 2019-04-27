/******************************************************************************
* Created By: Sumit Choudhary
* Created On: 26th April 2019
* Purpose: Constants are defined here. 
********************************************************************************/

namespace BackendExercise.Utility.commonClass
{
    public class Constants
    {
        /// <summary>
        /// Common constants here.
        /// </summary>
        public struct CommonConstants
        {
            public const string EmailSentMsg = "Email Sent";
            public const string UserCreatedMsg = "User Created";
            public const string EmailLogFileName = "EmailSent";
            public const string UserLogFileName = "UserCreated";
        }

        /// <summary>
        /// Constants related to webConfig.
        /// </summary>
        public struct WebConfigConstants
        {
            public const string ConnString = "ConnectionString";
            public const string AppSetting = "AppSetting";
        }

        /// <summary>
        /// Regex
        /// </summary>
        public struct RegexString
        {
            public const string Email = @"^(.+)@([^\.].*)\.([a-z]{2,})$";
            public const string Phone = @"^[0-9]{10}$";
        }
    }
}