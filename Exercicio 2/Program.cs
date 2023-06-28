using System;

class Exercicio2
{
    static void Main(string[] args)
    {
        Gabarito conexao = new Gabarito();
        Prova conexao1 = new Prova(conexao);
        Console.WriteLine("Digite o seu nome: ");
        string nome = Console.ReadLine();

        while (true)
        {
            int notaaluo = 0;
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1- Verificar gabarito de uma questao");
            Console.WriteLine("2- Fazer a prova");         
            Console.WriteLine("3- Sair do programa");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o numero da questao: ");
                    int questao = int.Parse(Console.ReadLine());
                    Console.WriteLine(conexao.RespostaQuestao(questao)); 
                    break;

                case 2:
                    for (int i = 0; i < conexao1.gabaritoaluno.Length; i++)
                    {
                        Console.WriteLine($"Informe a resposta da questão: {i + 1} ");
                        string resposta = Console.ReadLine();
                        conexao1.respostaAluno(resposta.ToUpper());
                    }
                    Console.WriteLine("Quantidade de acertos: " + conexao1.Acertos());
                    Console.WriteLine("Sua nota foi: " + conexao1.Nota());
                    break;

                case 3:
                    break;
                    break;
            }
        }
    }
}