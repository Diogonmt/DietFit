using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietFit.Model
{
    public class Fisico
    {
        private List<Exercicio> dia1;
        private List<Exercicio> dia2;
        private List<Exercicio> dia3;
        private List<Exercicio> dia4;
        private List<Exercicio> dia5;
        private List<Exercicio> dia6;
        private List<Exercicio> dia7;

        public Fisico()
        {
            dia1 = new List<Exercicio>();
            dia2 = new List<Exercicio>();
            dia3 = new List<Exercicio>();
            dia4 = new List<Exercicio>();
            dia5 = new List<Exercicio>();
            dia6 = new List<Exercicio>();
            dia7 = new List<Exercicio>();
        }

        public List<Exercicio> pDia1()
        {
            return dia1;
        }
        public List<Exercicio> pDia2()
        {
            return dia2;
        }
        public List<Exercicio> pDia3()
        {
            return dia3;
        }
        public List<Exercicio> pDia4()
        {
            return dia4;
        }
        public List<Exercicio> pDia5()
        {
            return dia5;
        }
        public List<Exercicio> pDia6()
        {
            return dia6;
        }
        public List<Exercicio> pDia7()
        {
            return dia7;
        }

        public void setDia1(List<Exercicio> dia1)
        {
            this.dia1 = dia1;
        }
        public void setDia2(List<Exercicio> dia2)
        {
            this.dia2 = dia2;
        }
        public void setDia3(List<Exercicio> dia3)
        {
            this.dia3 = dia3;
        }
        public void setDia4(List<Exercicio> dia4)
        {
            this.dia4 = dia4;
        }
        public void setDia5(List<Exercicio> dia5)
        {
            this.dia5 = dia5;
        }
        public void setDia6(List<Exercicio> dia6)
        {
            this.dia6 = dia6;
        }
        public void setDia7(List<Exercicio> dia7)
        {
            this.dia7 = dia7;
        }
    }

}
