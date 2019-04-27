/******************************************************************************
* Created By: Sumit Choudhary
* Created On: 27th April 2019
* Purpose: Creates User. 
********************************************************************************/
using BackendExercise.Utility.commonClass;
using BackendExercise.Utility.models;
using System;
using System.Web.Services;

namespace BackendExercise
{
    public partial class CreateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Logs the user cretaed.
        /// </summary>
        /// <param name="userObj"></param>
        /// <returns></returns>
        [WebMethod]
        public static bool CreatesUser(User userObj)
        {
            bool returnFlag = false;
            try
            {
                if (Validator.ValidateEmail(userObj.Email) && Validator.ValidatePhoneNumber(userObj.PhoneNumber)
                    && !string.IsNullOrWhiteSpace(userObj.Name))
                {
                    //Log file
                    returnFlag = new FileLogger().LogFile(Constants.CommonConstants.UserCreatedMsg, Constants.CommonConstants.UserLogFileName);
                }
            }
            catch (Exception)
            {
                //Log the error here.
            }
            return returnFlag;
        }
    }
}