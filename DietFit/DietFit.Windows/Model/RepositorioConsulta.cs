using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietFit.Model
{
    public class RepositorioConsulta
    {
        List<Consulta> consultas ;
        Utilizador user;
        DateTime date;
        Appl app;


        public RepositorioConsulta()
        {
            consultas = new List<Consulta>();
        }

        public void addConsulta(Consulta c)
        {
            consultas.Add(c);
        }
        public void removeConsulta(Consulta c)
        {
            consultas.Remove(c);
        }
        public bool containConsulta(Consulta c)
        {
            if (consultas.Contains(c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       public List<Consulta> getConsultaByUser(Utilizador user)
        {
            List <Consulta> c = new List<Consulta>();

            foreach(Consulta consulta in consultas)
            {
                if (consulta.getUser().Equals(user))
                {
                    c.Add(consulta);
                }
            }

            return c;
        }
        public List<Consulta> getConsultaCanceladas(Utilizador user){
            List<Consulta> c = new List<Consulta>();
            foreach (Consulta consulta in consultas)
            {
                if (consulta.getState() == EstadoConsulta.Cancelada && consulta.getUser().Equals(user))
                {
                    c.Add(consulta);
                }
            }
            return c;
            
        }
        public List<Consulta> getConsultaFeita(Utilizador user)
        {
            List<Consulta> c = new List<Consulta>();
            foreach (Consulta consulta in consultas)
            {
                if (consulta.getState() == EstadoConsulta.Feita && consulta.getUser().Equals(user)) 
                {
                    c.Add(consulta);
                }
            }
            return c;

        }
        public Consulta getConsultabyUserandDate(DateTime date, Utilizador user)
        {
            foreach(Consulta c in consultas)
            {
                if (c.getUser().Equals(user) && c.getDate().Equals(date))
                {
                    return c;
                }
                
            }
            return null;
        }


        public List<Consulta> getConsultaNaoFeita(Utilizador user)
        {
            List<Consulta> c = new List<Consulta>();
            foreach (Consulta consulta in consultas)
            {
                if (consulta.getState() == EstadoConsulta.NaoFeita && consulta.getUser().Equals(user))
                {
                    c.Add(consulta);
                }
            }
            return c;

        }

    }
}
