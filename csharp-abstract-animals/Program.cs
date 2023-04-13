﻿using System.Reflection.Metadata;

namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*interfacce Alcuni degli animali che abbiamo creato volano, altri nuotano.
            Gli animali che volano hanno il seguente metodo :
            void Vola() (mostra a video “Sto volando!!!”)
            Gli animali che nuotano hanno il seguente metodo :
            void Nuota() (mostra a video “Sto nuotando!!!”)

            Scrivere un programma avente 2 metodi:
            void FaiVolare(IVolante animale)
            void FaiNuotare(INuotante animale)
            Questi metodi prendono come parametro un animale che può o volare / nuotare e richiamano il corrispondente metodo Vola() / Nuota().
            Scrivere un programma che istanzi animali che volano o nuotano e richiamare i metodi FaiVolare / FaiNuotare passandoglieli come parametro.*/

            Animale labrador, passerotto, aquilaReale, delfino;

            Console.WriteLine("--Cane--");
            labrador = new Cane();
            labrador.Dormi();
            labrador.Mangia();
            labrador.Verso();

            Console.WriteLine("--Passerotto--");
            passerotto = new Passerotto();
            passerotto.Dormi();
            passerotto.Mangia();
            passerotto.Verso();

            Console.WriteLine("--Aquila--");
            aquilaReale = new Aquila();
            aquilaReale.Dormi();
            aquilaReale.Mangia();
            aquilaReale.Verso();

            Console.WriteLine("--Delfino--");
            delfino = new Delfino();
            delfino.Dormi();
            delfino.Mangia();
            delfino.Verso();

            // ESERCIZIO 2 

        }
    }
}