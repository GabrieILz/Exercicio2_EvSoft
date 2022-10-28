int y;

Console.WriteLine("Digite 1 para executar o exercício 2.1 ou 2 para executar o 2.2:");
y = Int32.Parse(Console.ReadLine());

if (y == 1)
{
    int num;
    int resultado;

    Console.WriteLine("Digite um número para realizar a soma:");
    num = Int32.Parse(Console.ReadLine());

    resultado = somaNumero(num);

    Console.WriteLine("A soma dos números de 1 até o numero dado é:" + resultado);

    static int somaNumero(int x)
    {
        int soma = 0;
        for (int i = 1; i <= x; i++)
        {
            soma = soma + i;
        }
        return soma;

    }
}
else
{

    string palavra = "";

    Console.WriteLine(RemoverLetrasDuplicadas(palavra));

    static String RemoverLetrasDuplicadas(string palavra)
    {

        int n = palavra.Length;

        string resultado = "";
        for (int i = 0; i < n; i++)
        {
            int j;
            for (j = i + 1; j < n; j++)
                if (palavra[i] == palavra[j])
                    break;

            if (j == n)
                resultado = resultado + palavra[i];
        }

        return resultado;
    }
}

