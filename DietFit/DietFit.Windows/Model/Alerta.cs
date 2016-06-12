using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietFit.Model
{
    public class Alerta
    {
        Utilizador user;
        String alerta;

        public Alerta(Utilizador user, String alerta)
        {
            this.user = user;
            this.alerta = alerta;
        }

        public String getAlerta()
        {
            return this.alerta;
        }

        public void addAlerta(String alerta)
        {
            this.alerta += "\n\r" + alerta;
        }

        public Utilizador getUser()
        {
            return user;
        }

        
    }
}
