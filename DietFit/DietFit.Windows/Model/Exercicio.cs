using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietFit.Model
{
    public class Exercicio
    {
        public String exercicio;
        public String zonaMuscular;
        public String seRep;

        public Exercicio()
        {
            exercicio = "";
            zonaMuscular = "";
            seRep = "";
        }

        public Exercicio(String exercicio, String seRep, String zonaMuscular)
        {
            this.exercicio = exercicio;
            this.seRep = seRep;
            this.zonaMuscular = zonaMuscular;
        }

        public void setExercicio(String exercicio)
        {
            this.exercicio = exercicio;
        }
        public void setZonaMuscular(String zonaMuscular)
        {
            this.zonaMuscular = zonaMuscular;
        }
        public void setSeries(String seRep)
        {
            this.seRep = seRep;
        }
      

        public String getExercicio()
        {
            return this.exercicio;
        }
        public String getZonaMuscular()
        {
            return this.zonaMuscular;
        }
        public String getSeRep()
        {
            return this.seRep;
        }
       
    }
}
