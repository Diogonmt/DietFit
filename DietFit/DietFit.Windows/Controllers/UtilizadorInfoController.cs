using DietFit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietFit.Controllers
{
    public class UtilizadorInfoController
    {

        private Appl app;
        private Utilizador user;

        public UtilizadorInfoController(Appl app, Utilizador user)
        {
            this.app = app;
            this.user = user;
        }

        public Utilizador getUser()
        {
            return user;
        }

        public Appl getApp()
        {
            return app;
        }

    }
}
