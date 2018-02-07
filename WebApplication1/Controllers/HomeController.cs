using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(usuarios usuario)
    
        {
            
            string connstring = @"Data Source=NACHOGRIGNOLA;Initial Catalog = nueva; Integrated Security = True; MultipleActiveResultSets=True;Application Name = EntityFramework";
            using (SqlConnection sqlcon = new SqlConnection(connstring))
            {              
                string commandString = "SELECT *  FROM usuarios WHERE [nameuser]=@user  AND [pw]= @pass";
                SqlCommand cmd = new SqlCommand(commandString, sqlcon);
                cmd.Parameters.AddWithValue("@user", usuario.nameuser);
                cmd.Parameters.AddWithValue("@pass", usuario.pw);
                sqlcon.Open();
                int output = Convert.ToInt32(cmd.ExecuteScalar());

                if (output == 0)
                {
                    usuario.loginErrorMensaje = "Usuario o Contraseña incorrectos";
                    return View("Index");
                }
                else
                {
                    return RedirectToAction("Notas/Crear");
                }
            }  
        }

    }
}