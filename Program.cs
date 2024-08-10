namespace Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            Console.WriteLine(p);

            p.SetNome("TV 4K");

            Console.WriteLine(p.GetNome());
        }
    }
}
