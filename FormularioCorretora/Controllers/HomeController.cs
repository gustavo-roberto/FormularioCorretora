using FormularioCorretora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormularioCorretora.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Perfil()
        {
            PerfilInvestdorModel perfil = new PerfilInvestdorModel() { 
                PerfilInvestidor = "Moderado" ,
                Descricao = "Através de seus dados bancários, analisamos a frequência, a forma e onde você realiza seus gastos! Com isso, você obteve um Score Suitability de 52 pontos, enquadrando-o em um perfil moderado: Aceita ter aguns investimento mais arriscados para aproveitar oportunidades da renda variável, porém, sempre opta por preservar a maior parte do patrimônio já adquirido."
            };

            return View(perfil);
        }

        public ActionResult SalvarDados(FormularioCorretoraModel dados)
        {
            PerfilInvestdorModel perfil = new PerfilInvestdorModel(){ PerfilInvestidor = "Moderado"};

            return View("AceiteOpenBanking", perfil);
        }

        public ActionResult AceiteOpenBanking()
        {
            return View();
        }
    }
}