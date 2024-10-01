//Exemplo de TryCatch com numerador e denominador
//O bloco try-catch em c# permite que voce execulte um bloco de codigo (try) que pode gerar exceções.
//Se uma exeção ocorrer, ela irá ser tratada no bloco catch

/*exemplo 1 com valores inteiro*/
//try
//{
//    Console.Write("digite o numerador:");// "5" == 5
//    int numerador = int.Parse(Console.ReadLine());

//    Console.Write("digite o denominador: ");
//    int denominador = int.Parse(Console.ReadLine());

//    int resultado = numerador / denominador;
//    Console.Write($"O resultado da divisão é: {resultado}");
//} catch (DivideByZeroException)
//{
//    Console.WriteLine("Erro: não é possivel dividir por 0");
//}
//catch(FormatException)
//{
//    Console.WriteLine("Erro, por favor digite números válidos");
//}

/*exemplo 2 com casas decimais utilizando Double e convertendo esses valores com o TryParse*/
using System.Globalization;

try
{
    Console.Write("digite o numerador:");// "5" == 5
    double numerador;
    // ! = diferente
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out numerador))

    Console.WriteLine("Erro: por favor digite um numero valido");

    Console.Write("digite o denominador: ");
    double denominador;
    while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out denominador))
    { 
    Console.WriteLine("Erro: por favor digite um numero valido");
    Console.Write("digite o denominador: ");
    }
    //verifica o calor do denominador e caso seja zero gera uma exceção
    if (denominador == 0)
    {
        throw new DivideByZeroException();
    }

    double resultado = numerador / denominador;
    Console.Write($"O resultado da divisão é: {resultado}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Erro: não é possivel dividir por 0");
}
catch (FormatException)
{
    Console.WriteLine("Erro, por favor digite números válidos");
}

Console.ReadKey();
