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
        RepositorioConsulta consultas;
        private List<Utilizador> utilizadores;

        public Appl()
        {
            utilizadores = new List<Utilizador>();
            consultas = new RepositorioConsulta();

        }

        public void addUser(Utilizador user)
        {
            utilizadores.Add(user);
        }

        public List<Utilizador> getUtilizadores()
        {
            return utilizadores;
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
    }
}
