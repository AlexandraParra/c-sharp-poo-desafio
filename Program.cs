using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
List<Smartphone> smartphones = new List<Smartphone>();

Console.Write("Quantos smartphones deseja cadastrar? ");
int quantidade = int.Parse(Console.ReadLine());

for (int i = 0; i < quantidade; i++)
{
    Console.WriteLine($"\nCadastro do smartphone #{i + 1}");
    Console.Write("Digite o tipo (Nokia ou iPhone): ");
    string tipo = Console.ReadLine().Trim().ToUpper();
    Console.Write("Digite o número: ");
    string numero = Console.ReadLine();
    Console.Write("Digite o modelo: ");
    string modelo = Console.ReadLine();
    Console.Write("Digite o IMEI: ");
    string imei = Console.ReadLine();
    Console.Write("Digite a memória (em GB): ");
    int memoria = int.Parse(Console.ReadLine());

    Smartphone celular;
    if (tipo == "NOKIA")
    {
        celular = new Nokia(numero, modelo, imei, memoria);
        celular.Ligar();
    }
    else if (tipo == "IPHONE")
    {
        celular = new Iphone(numero, modelo, imei, memoria);
        celular.ReceberLigacao();
    }
    else
    {
        Console.WriteLine("Tipo inválido. Pulando este cadastro.");
        continue;
    }

    Console.Write("Digite o nome do aplicativo para instalar: ");
    string app = Console.ReadLine();
    celular.InstalarAplicativo(app);
    smartphones.Add(celular);
}