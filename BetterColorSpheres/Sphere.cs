using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Sphere
    {
        private readonly Color cor;
        private float raio;
        private int nvezes;

        public Sphere(Color cor, float raio, int nvezes = 0)
        {
            this.cor = cor;
            this.raio = raio;

        }

        public void Pop()
        {
            raio = 0;
        }

        public void Throw()
        {
            if (raio > 0)
            {
                nvezes++;
            }
        }

        public int GetTimesThrown() => nvezes;
    }
}