using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietFit.Model
{
    public class UserApp
    {
        Utilizador user;
        Appl app;
        public UserApp(Utilizador user, Appl app)
        {
            this.user = user;
            this.app = app;
        }

        public Utilizador getUser()
        {
            return this.user;
        }
        public Appl getApp()
        {
            return this.app;
        }
    }
}
