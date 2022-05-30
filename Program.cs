
class program
{
    static void Main(string []args)
    {
            Menu();
    }


    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("O que voce deseja fazer? ");
        Console.WriteLine("1 - Abrir arquivo");
        Console.WriteLine("2 - Criar novo Arquivo");
        Console.WriteLine("0 - sair");

        short option = short.Parse(Console.ReadLine());

        switch(option)
        {
            case 0 : System.Environment.Exit(0); break;
            case 1 : Abrir(); break;
            case 2 : Editar(); break;
            default: Menu(); break;
        }

    }
    static void Abrir()
    {
            Console.Clear();
            Console.WriteLine("Qual o Caminho do Arquivo? ");
            string caminho = Console.ReadLine();

            using(var arquivo = new StreamReader(caminho))
            {
                string texto = arquivo.ReadToEnd();
                Console.WriteLine(texto);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
    }

    static void Editar()

    {
        Console.Clear();
        Console.WriteLine("Digite seus texto abaixo (ESC para sair)");
        Console.WriteLine("------------------------------------------");

        string texto = "";

        do 
        {
            texto += Console.ReadLine();
            texto += Environment.NewLine;
        }
        while(Console.ReadKey().Key != ConsoleKey.Escape);

        Salvar(texto);
    }   

    static void Salvar(string texto)
    {
        Console.Clear();
        Console.WriteLine("Qual caminho você Deseja Salvar?");

        var Caminho = Console.ReadLine();

        using(var arquivo = new StreamWriter(Caminho))
        {
            arquivo.Write(texto);
        }

        Console.WriteLine($"Arquivo {Caminho} salvo com sucesso!");
        Console.ReadLine();
        Menu();

    }
}
