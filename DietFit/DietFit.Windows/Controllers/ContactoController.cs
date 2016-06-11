using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietFit.Model;

namespace DietFit.Controllers
{
    class ContactoController
    {
        Appl app;
        Utilizador nutricionista;
        Utilizador user;


        public ContactoController(Appl app, Utilizador nutricionista)
        {
            this.nutricionista = nutricionista;
            this.app = app;
        }

        public List<Utilizador> getUtilizadores()
        {
            return app.getUtilizadores();
        }

        public Utilizador getUtilizadorbyUsername(String username)
        {
            return app.getUtilizadorByUser(username);
        }

        public void setUtilizador(String username)
        {
            this.user = this.app.getUtilizadorByUser(username);
        }
    }
}
