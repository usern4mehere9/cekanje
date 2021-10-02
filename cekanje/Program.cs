using System;

namespace ponoc
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, m, s, h2, m2, s2, sph, spm, sps, aux, pv, dv;

            h = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            s = int.Parse(Console.ReadLine());
            h2 = int.Parse(Console.ReadLine());
            m2 = int.Parse(Console.ReadLine());
            s2 = int.Parse(Console.ReadLine());

            pv = (h * 3600) + (m * 60) + s;
            dv = (h2 * 3600) + (m2 * 60) + s2;

            aux = Math.Abs(dv - pv);

            sph = aux / 3600;
            spm = (aux - sph * 3600) / 60;
            sps = (aux - sph * 3600 - spm * 60);


            Console.WriteLine("{0}:{1}:{2}", sph, spm, sps);
        }
    }
}