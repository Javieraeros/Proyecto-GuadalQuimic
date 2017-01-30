using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSiteGuadalQuimic.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        /// <summary>
        ///     Es cuando el usuario pulsa alguno de los botones login o signup.
        ///         Comprobara si es login o signup, en caso de que sea login comprobara que sea
        ///         correcto,
        ///         en caso de que sea sign up, irá a una vista de registro.
        /// </summary>
        /// <param name="btnLogin"></param>
        /// <param name="contraseña"></param>
        /// <param name="correo"></param>
        /// <returns></returns>
        [HttpPost, ActionName("Index")]
        public ActionResult Login(String btnIndex, String contraseña,String correo)
        {

            String actionreturn="error";

            if(btnIndex.Equals("Log in"))
            {

                //Comprobar que el correo y la contraseña sean correcto
                if(correo.Equals("correoPrueba@gmail.com") && contraseña.Equals("123456"))
                {
                    actionreturn="PrincipalPrueba";
                }

            }
            else
            {
                //enviar a la pagina de registro

            }

        
            return RedirectToAction(actionreturn);
        }


        public ActionResult PrincipalPrueba()
        {
            return View();
        }

    }
}