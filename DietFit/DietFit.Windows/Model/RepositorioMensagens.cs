using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietFit.Model
{
    public class RepositorioMensagens
    {
        private List<ContactoNutricionista> mensagens;

        public RepositorioMensagens()
        {
            mensagens = new List<ContactoNutricionista>();
        }

        public void addMensagem(ContactoNutricionista m)
        {
            mensagens.Add(m);
        }
        public void removeMensagem(ContactoNutricionista m)
        {
            mensagens.Remove(m);
        }

        public ContactoNutricionista getMensagemByUsername(Utilizador user, Utilizador nutricionista)
        {
            foreach (ContactoNutricionista mensagem in mensagens) {
                if (mensagem.getUser().Equals(user) && mensagem.getNutricionista().Equals(nutricionista))
                {
                    return mensagem;
                }
            }
            return null;
        }
    }
}
