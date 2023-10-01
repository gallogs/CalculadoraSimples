// Calculadora com +, -, *, /.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("====================Calculadora=====================");

        Console.WriteLine("Escolha: 1: + | 2: - | 3: * | 4: %");
        int? escolha = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o primeiro numero: ");
        int? numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        int? numero2 = Convert.ToInt32(Console.ReadLine());

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
