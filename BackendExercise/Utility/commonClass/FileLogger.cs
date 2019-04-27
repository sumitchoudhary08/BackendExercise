/*****************************************************
* Created By: Sumit Choudhary
* Created On: 27th April 2019
* Purpose: Logs the message in text file. 
*******************************************************/

using System;
using System.IO;
using System.Text;
using System.Web;

namespace BackendExercise.Utility.commonClass
{
    public class FileLogger
    {
        /// <summary>
        /// Logs the message in the text file.
        /// </summary>
        /// <param name="strMsg"></param>
        /// <param name="strFileName"></param>
        /// <returns></returns>
        public bool LogFile(string strMsg, string strFileName)
        {
            StringBuilder sbMessage = new StringBuilder();
            string strLogFolderName = string.Empty;
            string strFilePath = string.Empty;

            try
            {
                // Get the log folder name. 
                strLogFolderName = HttpContext.Current.Server.MapPath("") + "\\" + CommonFunctions.GetAppSetting("FileLogPath", Constants.WebConfigConstants.AppSetting);

                //Creates the Log folder if not found
                if (!Directory.Exists(strLogFolderName))
                {
                    Directory.CreateDirectory(strLogFolderName);
                }

                // Create the log file name.
                strFileName = strFileName + "_" + Convert.ToString(DateTime.Now.Month) + "_" + Convert.ToString(DateTime.Now.Year);
                strFilePath = strLogFolderName + "\\" + strFileName + ".txt";

                // Compose the message.
                sbMessage.Append("----------------------------------------------------------------------------" +
                                      Environment.NewLine);
                sbMessage.Append(Convert.ToString(DateTime.Now.ToLocalTime()) + Environment.NewLine);
                sbMessage.Append(strMsg);

                if (!File.Exists(strFilePath))
                {
                    // Create a file if it does not exist.
                    using (StreamWriter strmWriter = new StreamWriter(File.Create(strFilePath)))
                    {
                        // Write the message into the file.
                        strmWriter.WriteLine(sbMessage.ToString());
                    }
                }
                else
                {
                    // Open the file in append mode.
                    using (StreamWriter strmWriter = new StreamWriter(File.Open(strFilePath, FileMode.Append)))
                    {
                        // Write the message into the file.
                        strmWriter.WriteLine(sbMessage.ToString());
                    }
                }
                return true;
            }
            catch (Exception)
            {
                //Log error here..
                return false;
            }
        }
    }
}