/******************************************************************************
* Created By: Sumit Choudhary
* Created On: 27th April 2019
* Purpose: Sends Email. 
********************************************************************************/

using BackendExercise.Utility.commonClass;
using BackendExercise.Utility.models;
using System;
using System.Web.Services;

namespace BackendExercise
{
    public partial class SendEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Logs the email sent.
        /// </summary>
        /// <param name="emailObj"></param>
        /// <returns></returns>
        [WebMethod]
        public static bool SendsEmail(Email emailObj)
        {
            bool returnFlag = false;
            try
            {
                if (Validator.ValidateEmail(emailObj.ToEmail) && Validator.ValidateEmail(emailObj.FromEmail)
                    && !string.IsNullOrWhiteSpace(emailObj.Subject) && !string.IsNullOrWhiteSpace(emailObj.Body))
                {
                    //Log file
                    returnFlag = new FileLogger().LogFile(Constants.CommonConstants.EmailSentMsg, Constants.CommonConstants.EmailLogFileName);
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