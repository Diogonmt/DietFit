using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietFit.Model
{
    public class Plano
    {

        private String pAlmoço;
        private String lManha;
        private String almoço;
        private String lTarde;
        private String jantar;
        private String ceia;

        public Plano()
        {
            pAlmoço = "";
            lManha = "";
            almoço = "";
            lTarde = "";
            jantar = "";
            ceia = "";
        }

        public void setPalmoço(String pAlmoço)
        {
            this.pAlmoço = pAlmoço;
        }
        public void setLmanha(String lManha)
        {
            this.lManha = lManha;
        }
        public void setAlmoço(String almoço)
        {
            this.almoço = almoço;
        }
        public void setLtarde(String lTarde)
        {
            this.lTarde = lTarde;
        }
        public void setJantar(String jantar)
        {
            this.jantar = jantar;
        }
        public void setCeia(String ceia)
        {
            this.ceia = ceia;
        }

        public String getPalmoço()
        {
            return this.pAlmoço;
        }
        public String getLmanha()
        {
            return this.lManha;
        }
        public String getAlmoço()
        {
            return this.almoço;
        }
        public String getLtarde()
        {
            return this.lTarde;
        }
        public String getJantar()
        {
            return this.jantar;
        }
        public String getCeia()
        {
            return this.ceia;
        }
    }
}