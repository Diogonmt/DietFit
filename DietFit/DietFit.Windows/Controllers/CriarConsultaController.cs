using DietFit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietFit.Controllers
{
    public class CriarConsultaController
    {
        Appl app;
        Utilizador nutricionista, u;
        Consulta consulta;

        public CriarConsultaController(Appl app, Utilizador u)
        {
            this.app = app;
            this.nutricionista = u;
        }

        public void SetUser(String username)
        {
            this.u= this.app.getUtilizadorByUser(username);
        }

        public List<Utilizador> getUtilizadores()
        {
            return app.getUtilizadores();
        }
        //public bool SetConsulta(//Enviar a data)
        //{
        //    // new Consulta(nutricionista, u, data);
        //}
    }
}
