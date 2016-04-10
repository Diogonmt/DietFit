﻿using DietFit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietFit.Controllers
{
    class CriarPlanoTreinoController
    {

        private Appl app;
        private Utilizador pt, user;

        public CriarPlanoTreinoController(Appl app, Utilizador pt)
        {
            this.app = app;
            this.pt = pt;
        }

        public void setUtilizador(String username)
        {
            this.user = this.app.getUtilizadorByUser(username);
        }

        public Utilizador getPT()
        {
            return pt;
        }

        public Appl getApp()
        {
            return app;
        }

    }
}
