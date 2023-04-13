namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Creiamo quindi una classe astratta Animale e delle classi che la estendono : Cane, Passerotto, Aquila, Delfino
            Vogliamo che gli animali abbiano i seguenti metodi
            void Dormi() (mostra a video “Zzz”)
            void Verso() (mostra a video il verso fatto dall'animale specifico)
            void Mangia() (mostra a video quello che mangia: erba, carne, ...?)
            Quali di questi metodi devono essere implementati nella classe astratta e quali devono essere lasciati astratti e implementati dalle classi che la estendono?
            Una volta create le classi, nel programma istanziare alcuni animali e utilizzare i metodi implementati.*/

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



        }
    }
}