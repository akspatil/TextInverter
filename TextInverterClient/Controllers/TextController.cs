using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace TextInverterClient.Controllers
{
    public class TextController : Controller
    {   
        // GET: Text
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ReverseTextOrder()
        {
            var remoteAddress = new System.ServiceModel.EndpointAddress("http://localhost:1438/Service1.svc?wsdl");

            using (var textService = new TextInverterServiceReference.Service1Client(new System.ServiceModel.BasicHttpBinding(), remoteAddress))
            {
                //set timeout
                textService.Endpoint.Binding.SendTimeout = new TimeSpan(0, 0, 0, 100000);
                string reversedString = textService.ReverseEachWord(Request["textVal"]);
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("<b>Input Text: </b>" + Request["textVal"]);
                ViewBag.Data = stringBuilder.ToString();
                stringBuilder.Clear();
                stringBuilder.Append("<b>Inverted Text: </b>" + reversedString);
                ViewBag.Message = stringBuilder.ToString();
                //return PartialView("_ReverseTextView", reversedString);
                return View("Index");
            }
        }
    }
}