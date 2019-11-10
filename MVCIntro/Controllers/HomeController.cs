using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro.Controllers
{
    public class HomeController : Controller
    {

        //Action'lar MVC'deki Controller icerisindeki metotlarımızdır.

        //  localhost: 145123/ Home/Index
       

        public ActionResult Index(int? id)
        {
            return View();
        }

        public ActionResult About()
        {
            return View("Index"); //Eger bu sekilde View() metodumuza string bir argüman verirsek gidecegimiz View o argümanın ismindeki View olur.
        }

        //localhost / Home /Index /  4
        //{controller} / {action}  /{id} => buradaki id kısmına yazılan giriş ilgili action'in parametresine gidecektir. Ancak dikkatli olmanız gerekir Action'in parametresinin de ismi burada süslü parantezlerin icerisindeki isimle aynı olmak zorundadır.

        public ActionResult Contact(int id)
        {
            return View();
        }

    }
}