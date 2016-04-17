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
        private double massaM;
        private double imc;
        private double massaG;
        private int metabolismo;
        private int idadeM;
        private String hiPnome;
        private double hiPeso;
        private double hiMassaM;
        private double hiImc;
        private double hiMassaG;
        private int hiIdadeM;
        private int hiMetabolismo;
        private Fisico planoTreino;
        private Fisico planoAnterior;
        private Plano plano;
        private Plano plano2;
        private Plano plano3;
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
            massaM = 0;
            massaG = 0;
            metabolismo = 0;
            idadeM = 0;
            imc = 0;
            eMail = "";
            plano = new Plano();
            plano2 = new Plano();
            plano3 = new Plano();
            planoTreino = new Fisico();
            isnutricionista = false;
            ispt = false;
            notas = "";
            hiPnome = "";
            hiPeso=0;
            hiMassaM=0;
            hiImc=0;
            hiMassaG=0;
            hiIdadeM=0;
            hiMetabolismo=0;
    }

        public void setUsername(String username)
        {
            this.username = username;
        }
        public void setPeso(double peso)
        {
            this.hiPeso = this.peso;
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
        public void setMassaM(double massaM)
        {
            this.hiMassaM = this.massaM;
            this.massaM = massaM;
        }
        public void setImc(double imc)
        {
            this.hiImc = this.imc;
            this.imc = imc;
        }
        public void setMassaG(double massaG)
        {
            this.hiMassaG = this.massaG;
            this.massaG = massaG;
        }
        public void setMetablismo(int metabolismo)
        {
            this.hiMetabolismo = this.metabolismo;
            this.metabolismo = metabolismo;
        }
        public void setIdadeM(int idadeM)
        {
            this.hiIdadeM = this.idadeM;
            this.idadeM = idadeM;
        }
        public void setPlano(Plano plano)
        {
            this.plano = plano;
        }
        public void setPlano2(Plano plano2)
        {
            this.plano2 = plano2;
        }
        public void setPlano3(Plano plano3)
        {
            this.plano3 = plano3;
        }
        public void setPlanoTreino(Fisico planoTreino)
        {
            this.planoAnterior = this.planoTreino;
            this.planoTreino = planoTreino;
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
        public double getMassaM()
        {
            return this.massaM;
        }
        public double getImc()
        {
            return this.imc;
        }
        public double getMassaG()
        {
            return this.massaG;
        }
        public int getMetabolismo()
        {
            return this.metabolismo;
        }
        public int getIdadeM()
        {
            return this.idadeM;
        }
        public Plano getPlano()
        {
            return this.plano;
        }
        public Plano getPlano2()
        {
            return this.plano2;
        }
        public Plano getPlano3()
        {
            return this.plano3;
        }
        public Fisico getPlanoTreino()
        {
            return this.planoTreino;
        }
        public Fisico getPlanoAnterior()
        {
            return this.planoAnterior;
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
        public double getHiPeso()
        {
            return this.hiPeso;
        }
        public double getHiMassaM()
        {
            return this.hiMassaM;
        }
        public double getHiImc()
        {
            return this.hiImc;
        }
        public double getHiMassaG()
        {
            return this.hiMassaG;
        }
        public int getHiIdadeM()
        {
            return this.hiIdadeM;
        }
        public int getHiMetabolismo()
        {
            return this.hiMetabolismo;
        }
    }
}