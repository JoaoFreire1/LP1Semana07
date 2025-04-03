using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color Red = new Color (255, 0, 0);
            Color InvisaBlue = new Color (0, 0, 255, 175);

            Sphere Bola1 = new Sphere (Red, 3);
            Sphere Bola2 = new Sphere (InvisaBlue, 2);

            Bola1.Throw();
            Bola1.Pop();
            Bola1.GetTimesThrown();
            Bola2.Throw();
            Bola2.Throw();
            Bola2.Pop();
            Bola2.GetTimesThrown();
        }
    }
}
