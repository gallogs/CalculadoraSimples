// Calculadora com +, -, *, /.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("====================Calculadora=====================");

        Console.WriteLine("Escolha: 1: + | 2: - | 3: * | 4: %");
        int? escolha = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro numero: ");
        int? numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        int? numero2 = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                Console.WriteLine($"Resultado: {numero1 + numero2}");
                break;
            case 2:
                Console.WriteLine($"Resultado: {numero1 - numero2}");
                break;
            case 3:
                Console.WriteLine($"Resultado: {numero1 * numero2}");
                break;
            case 4:
                Console.WriteLine($"Resultado: {numero1 / numero2}");
                break;
        }
    }
}
