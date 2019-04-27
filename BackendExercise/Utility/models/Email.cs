/*****************************************************
* Created By: Sumit Choudhary
* Created On: 26th April 2019
* Purpose: Email model. 
*******************************************************/

namespace BackendExercise.Utility.models
{
    public class Email
    {
        public string ToEmail { get; set; }
        public string FromEmail { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}