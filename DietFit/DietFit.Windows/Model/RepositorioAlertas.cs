using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietFit.Model
{
    public class RepositorioAlertas
    {
        private List<Alerta> alertas;

        public RepositorioAlertas()
        {
            alertas = new List<Alerta>();
        }

        public void addAlerta(Alerta a)
        {
            alertas.Add(a);
        }
        

        public Alerta getAlertaByUsername(Utilizador user)
        {
            foreach (Alerta alerta in alertas)
            {
                if (alerta.getUser().Equals(user))
                {
                    return alerta;
                }
            }
            return null;
        }
    }
}
