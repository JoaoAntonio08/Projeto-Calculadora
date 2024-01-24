// Declarando Variavéis
int numero1, numero2;
char operacao;
int resultado = 0;
string simOuNao = string.Empty;

do
{
    System.Console.WriteLine("Vamos começar a nossa calculadora");
    System.Console.WriteLine("-----------------------------------");
    
    System.Console.WriteLine("Por Favor, digite o primeiro número:");
    numero1 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("-----------------------------------");
    
    System.Console.WriteLine("Agora, digite o segundo número");
    numero2 = int.Parse(Console.ReadLine());
    System.Console.WriteLine("-----------------------------------");
    
    System.Console.WriteLine("Informe a operação que vai ser utilizada");
    operacao = char.Parse(Console.ReadLine());

    // Verficicando qual operação foi utilizada e chamando as funções para cada operação
    if (operacao == '+')
    {
        resultado = Soma(numero1, numero2);
        System.Console.WriteLine($"O valor da soma é de {resultado}");
    }
    else if (operacao == '-')
    {
        resultado = Diminuir(numero1, numero2);
        System.Console.WriteLine($"O valor da subtração é de {resultado}");
    }
    else if (operacao == '*')
    {
        resultado = Multiplicar(numero1, numero2);
        System.Console.WriteLine($"O valor da multiplicaço é de {resultado}");
    }
    else if (operacao == '/')
    {
        if (numero2 == 0)
        {
            System.Console.WriteLine("O valor 0 é inválido"); //Para prevenir que o número que vai ser dividir seja 0
        }
        else
        {
            resultado = Dividir(numero1, numero2);
            System.Console.WriteLine($"O valor da divisao é de {resultado}");
        }
    }
    else
    {
        System.Console.WriteLine("Operador númerico desconhecido"); // Quando o usuário escreve o operador inválido
    }

    System.Console.WriteLine("Você deseja fazer outra conta? Digite S ou N");
    simOuNao = Console.ReadLine();

} while (simOuNao == "S" || simOuNao == "s");
// while usando caso o usuário queira fazer uma nova conta

//Funções
static int Soma(int parametroNumero, int parametroNumero2)
{
    int resultado = parametroNumero + parametroNumero2;
    return resultado;
}

static int Diminuir(int parametroNumero, int paremtroNumero2)
{
    int resultado = parametroNumero - paremtroNumero2;
    return resultado;
}

static int Multiplicar(int parametroNumero, int paremtroNumero2)
{
    int resultado = parametroNumero * paremtroNumero2;
    return resultado;
}

static int Dividir(int parametroNumero, int paremtroNumero2)
{
    int resultado = parametroNumero / paremtroNumero2;
    return resultado;
}