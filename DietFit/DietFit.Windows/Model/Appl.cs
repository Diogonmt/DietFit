using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietFit.Model
{
    public class Appl
    {
        //
        private RepositorioConsulta consultas;
        private List<Utilizador> utilizadores;
        private RepositorioMensagens mensagens;
        private RepositorioAlertas alertas;

        public Appl()
        {
            utilizadores = new List<Utilizador>();
            consultas = new RepositorioConsulta();
            mensagens = new RepositorioMensagens();
            alertas = new RepositorioAlertas();

        }

        public void addUser(Utilizador user)
        {
            utilizadores.Add(user);
        }

        public List<Utilizador> getUtilizadores()
        {
            return utilizadores;
        }
        public List<Utilizador> getNutricionista()
        {
            List<Utilizador> nutricionistas = new List<Utilizador>();
            foreach (Utilizador u in utilizadores)
            {
                if (u.getIsnutricionista())
                {
                    nutricionistas.Add(u);
                }
            }
            return nutricionistas;
        }
       


        public Utilizador getUtilizadorByUser(String username)
        {
            foreach (Utilizador u in utilizadores)
            {
                if (u.getUserName().Equals(username))
                {
                    return u;
                }
            }
            return null;
        }


        public Utilizador getUtilizadorByMail(String mail)
        {
            foreach (Utilizador u in utilizadores)
            {
                if (u.getMail().Equals(mail))
                {
                    return u;
                }
            }
            return null;
        }

        public RepositorioConsulta getConsultas()
        {
            return this.consultas;
        }

        public RepositorioMensagens getMensagens()
        {
            return this.mensagens;
        }

        public RepositorioAlertas getAlertas()
        {
            return this.alertas;
        }
    }
}
