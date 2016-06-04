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
        Utilizador nutricionista;

        public CriarConsultaController(Appl app, Utilizador nutricionista)
        {
            this.nutricionista = nutricionista;
            this.app = app;
        }


       

        public List<Utilizador> getUtilizadores()
        {
            return app.getUtilizadores();
        }

        public bool marcarConsulta(String username, DateTime date)
        {
            Consulta consulta = new Consulta(nutricionista, app.getUtilizadorByUser(username), date);
            app.getConsultas().addConsulta(consulta);
            return true;
        }
       
    }
}
