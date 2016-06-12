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
        EstadoConsulta estado;
        DateTime date;

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

        public Consulta getConsultabyDateandUser(DateTime date, Utilizador user)
        {
            return app.getConsultas().getConsultabyUserandDate(date, user);
        }
        public Utilizador getUtilizadorbyUsername(String username)
        {
            return app.getUtilizadorByUser(username);
        }
        public Utilizador getNutricionista()
        {
            return this.nutricionista;
        }
        public Appl getApp()
        {
            return this.app;
        }

    }
}
