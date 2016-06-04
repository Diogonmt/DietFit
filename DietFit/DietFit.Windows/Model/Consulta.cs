using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietFit.Model
{
    public class Consulta
    {
        Utilizador nutricionista;
        Utilizador cliente;
        DateTime data;


        public Consulta(Utilizador nutricionista, Utilizador cliente, DateTime data)
        {
            this.nutricionista = nutricionista;
            this.cliente = cliente;
            this.data = data;
        }


        public DateTime getDate()
        {
            return data;
        }


        public Utilizador getUser()
        {
            return cliente;
        }


    }
}
