using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietFit.Model
{
    public static class Appl
    {

        private static List<Utilizador> utilizadores = new List<Utilizador>();
        private static Utilizador lastLoggedUser;

        public static void addUser(Utilizador user)
        {
            utilizadores.Add(user);
        }

        public static List<Utilizador> getUtilizadores()
        {
            return utilizadores;
        }

        public static Utilizador getUtilizadorByUser(String username)
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

        public static void setLastLoggedUser(Utilizador user)
        {
            lastLoggedUser = user;
        }
        public static Utilizador getLastLoggedUser()
        {
            return lastLoggedUser;
        }
      
        
    }
}
