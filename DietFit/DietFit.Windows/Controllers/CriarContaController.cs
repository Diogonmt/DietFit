using DietFit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietFit.Controllers
{
    public class CriarContaController
    {

        Appl app;
        Utilizador user;

        public CriarContaController(Appl app)
        {
            this.app = app;
            this.user = new Utilizador();
        }

        public bool valida(Utilizador u)
        {
            if(app.getUtilizadorByMail(u.getMail())==null && app.getUtilizadorByUser(u.getUserName()) == null)
            {
                this.user = u;
                return true;
            }

            return false;
        }

        public void registaUtilizador()
        {
            app.addUser(user);
        }

        public Appl getApp()
        {
            return this.app;
        }

    }
}
