/******************************************************************************
* Created By: Sumit Choudhary
* Created On: 26th Al 2019
* Purpose: All the common fuctions used from different classes are here. 
********************************************************************************/

using System;
using System.Configuration;

namespace BackendExercise.Utility.commonClass
{
    public class CommonFunctions
    {
        /// <summary>
        /// Getting the key and returning the value from config file.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetAppSetting(string key, string type)
        {
            try
            {
                return (type == Constants.WebConfigConstants.ConnString)
                            ? (ConfigurationManager.ConnectionStrings[key].ConnectionString)
                            : (ConfigurationManager.AppSettings[key].ToString());
            }
            catch (Exception)
            {
                //Log error here..
                return string.Empty;
            }
        }
    }
}