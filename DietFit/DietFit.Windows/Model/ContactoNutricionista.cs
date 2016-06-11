using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietFit.Model;

namespace DietFit.Model
{
    class ContactoNutricionista
    {
        Utilizador nutricionista;
        Utilizador cliente;
        String mensagem;

        public ContactoNutricionista(Utilizador nutricionista, Utilizador cliente, String mensagem)
        {
            this.nutricionista = nutricionista;
            this.cliente = cliente;
            this.mensagem = mensagem;
        }

        public String getMensagem()
        {
            return this.mensagem;
        }
        
        public void addMensagem( String mensagem)
        {
            this.mensagem += "\n\r" + mensagem;
        }
    }
}
