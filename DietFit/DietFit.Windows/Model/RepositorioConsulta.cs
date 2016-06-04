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

    
    }
}
