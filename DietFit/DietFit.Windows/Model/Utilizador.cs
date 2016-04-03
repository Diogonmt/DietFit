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
        private String pNome;
        private String uNome;
        private String username;
        private String password;
        private String objetivo;
        private String eMail;
        private Plano plano;
        private bool isnutricionista;
        private bool ispt;
        private String notas;

        public Utilizador()
        {
            peso = 0;
            altura = 0;
            pNome = "";
            uNome = "";
            username = "";
            password = "";
            objetivo = "";
            eMail = "";
            plano = new Plano();
            isnutricionista = false;
            ispt = false;
            notas = "";
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
        public void setPnome(String pNome)
        {
            this.pNome = pNome;
        }
        public void setUnome(String uNome)
        {
            this.uNome = uNome;
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
        public void setNotas(String notas)
        {
            this.notas = notas;
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
        public String getPnome()
        {
            return this.pNome;
        }
        public String getUnome()
        {
            return this.uNome;
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
        public void setIsnutricionista(bool b)
        {
            isnutricionista = b;
        }
        public bool getIsnutricionista()
        {
            return isnutricionista;
        }
        public void setIspt(bool b)
        {
            ispt = b;
        }
        public bool getIspt()
        {
            return ispt;
        }
        public String getNotas()
        {
            return this.notas;
        }
        public String toString()
        {
            return this.pNome + " "+this.uNome;
        }
    }
}