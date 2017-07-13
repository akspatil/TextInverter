using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;

namespace TextInverterService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        /// <summary>
        /// Reverses order of each word in a string
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public string ReverseEachWord(string text)
        {
            var textList = Regex.Split(text, @"([.,;\s-])");
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var textItem in textList)
            {
                char[] textArray = textItem.ToCharArray();
                Array.Reverse(textArray);
                string output = new string(textArray);
                stringBuilder.Append(output);
            }
            return stringBuilder.ToString();
        }
    }
}
