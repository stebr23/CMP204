using System.Web;
using System.Web.Mvc;

namespace TuringAda.Controllers
{
    public class DefaultController : Controller
    {

        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        //public string Welcome()
        //{
        //    return "This is the Welcome action method, " + Hello("Emily") + ", " ;
        //}

        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }

        public string Hello(string name)
        {
            return "Hello, " + name + "! " + Welcome("Emily");
        }

    }
}