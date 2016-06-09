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
        EstadoConsulta estado;


        public Consulta(Utilizador nutricionista, Utilizador cliente, DateTime data)
        {
            this.nutricionista = nutricionista;
            this.cliente = cliente;
            this.data = data;
            this.estado = EstadoConsulta.NaoFeita;
        }


        public DateTime getDate()
        {
            return data;
        }


        public Utilizador getUser()
        {
            return cliente;
        }

        public EstadoConsulta getState()
        {
            return estado;
        }

        public void cancelarConsulta()
        {
            this.estado = EstadoConsulta.Cancelada;
        }
        public void consultaFeita()
        {
            this.estado = EstadoConsulta.Feita;
        }

    }
}
