using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietFit.Model
{
    class Exercicio
    {
        public String exercicio;
        public String descanso;
        public int series;
        public int repeticoes;

        public Exercicio()
        {
            exercicio = "";
            descanso = "";
            series = 0;
            repeticoes = 0;
        }

        public void setExercicio(String exercicio)
        {
            this.exercicio = exercicio;
        }
        public void setDescanso(String descanso)
        {
            this.descanso = descanso;
        }
        public void setSeries(int series)
        {
            this.series = series;
        }
        public void setRepeticoes(int repeticoes)
        {
            this.repeticoes = repeticoes;
        }

        public String getExercicio()
        {
            return this.exercicio;
        }
        public String getDescanso()
        {
            return this.descanso;
        }
        public int getSeries()
        {
            return this.series;
        }
        public int getRepeticoes()
        {
            return this.repeticoes;
        }
    }
}
