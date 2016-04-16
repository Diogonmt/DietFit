using DietFit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietFit.Controllers
{
    public class CriarPlanoNutricionalController
    {

        private Appl app;
        private Utilizador nutricionista, user;
        

        public CriarPlanoNutricionalController(Appl app, Utilizador nutri)
        {
            this.app = app;
            this.nutricionista = nutri;
        }

        public void setUtilizador(String username)
        {
            this.user=this.app.getUtilizadorByUser(username);
        }

        public void plano1(Plano p)
        {
            this.user.setPlano(p); 
        }

        public void plano2(Plano p)
        {
            this.user.setPlano2(p);
        }

        public void plano3(Plano p)
        {
            this.user.setPlano3(p);
        }

        public Utilizador getUtilizador()
        {
            return user;
        }

        public Utilizador getNutricionista()
        {
            return nutricionista;
        }

        public Appl getApp()
        {
            return app;
        }

    }
}
