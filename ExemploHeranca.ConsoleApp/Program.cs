namespace ExemploHeranca.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.EmitirSom();

            Console.ReadLine();
        }

        class Animal
        {
            public void EmitirSom()
            {
                Console.WriteLine("Som indistinto...");
            }
        }

        class Cachorro : Animal
        {
        }
    }
}
