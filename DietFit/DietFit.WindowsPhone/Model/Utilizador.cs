using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietFit.Model
{
    public class Utilizador
    {
        private double peso;
        private int altura;
        private String nome;
        private String username;
        private String password;
        private String objetivo;
        private String eMail;
        private Plano plano;
        private bool isAdmin;

        public Utilizador()
        {
            peso = 0;
            altura = 0;
            nome = "";
            username = "";
            password = "";
            objetivo = "";
            eMail = "";
            plano = new Plano();
            isAdmin= false;
        }

        public void setUsername(String username)
        {
            this.username = username;
        }
        public void setPeso(double peso)
        {
            this.peso = peso;
        }
        public void setAltura(int altura)
        {
            this.altura = altura;
        }
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public void setPassword(String password)
        {
            this.password = password;
        }
        public void setObjetivo(String objetivo)
        {
            this.objetivo = objetivo;
        }
        public void setMail(String mail)
        {
            this.eMail = mail;
        }
        public void setPlano(Plano plano)
        {
            this.plano = plano;
        }
        public String getUserName()
        {
            return this.username;
        }
        public String getPassword()
        {
            return this.password;
        }
        public Plano getPlano()
        {
            return this.plano;
        }
        public String getNome()
        {
            return this.nome;
        }
        public int getAltura()
        {
            return this.altura;
        }
        public String getMail()
        {
            return this.eMail;
        }
        public double getPeso()
        {
            return this.peso;
        }
        public String getObjetivo()
        {
            return this.objetivo;
        }
        public void setIsAdmin(bool b)
        {
            isAdmin = b;
        }
        public bool getIsAdmin()
        {
            return isAdmin;
        }
    }
}
