using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_abstract_animals
{
    abstract class Animale
    {
        public void Dormi()
        {
            Console.WriteLine("ZZZZZZ");
        }
        public abstract void Verso();
        public abstract void Mangia();
    }

    class Cane : Animale 
    {
        public override void Verso()
        {
            Console.WriteLine("Bau");
        }

        public override void Mangia()
        {
            Console.WriteLine("croccantini");
        }
    }

    class Passerotto : Animale, IVolante
    {
        public override void Verso()
        {
            Console.WriteLine("cip cip");
        }
        public override void Mangia()
        {
            Console.WriteLine("Semi");
        }
        public void Vola()
        {
            Console.WriteLine("Sto volando!!");
        }
    }

    class Aquila : Animale, IVolante
    {
        public override void Verso()
        {
            Console.WriteLine("screech");
        }
        public override void Mangia()
        {
            Console.WriteLine("carne");
        }

        public void Vola()
        {
            Console.WriteLine("Sto volando!!");
        }
    }

    class Delfino : Animale, INuotante
    {
        public override void Verso()
        {
            Console.WriteLine("siuumm");
        }
        public override void Mangia()
        {
            Console.WriteLine("sardina");
        }

        public void Nuota()
        {
            Console.WriteLine("Sto nuotando!!!");
        }
    }
}
