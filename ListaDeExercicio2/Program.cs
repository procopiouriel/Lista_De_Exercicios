using System;

class ListaExercicio2
{
    public static void Main(string[] args)
    {
        Passageiro conexao = new Passageiro(2000, new DateTime(2023 , 03 , 03).Date);
        
        
        while (true)
        {
            
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1- Verificar assentos disponiveis ");
            Console.WriteLine("2- Consultar todas as vagas disponiveis!");
            Console.WriteLine("3- Ver numero do seu voo, e a data");
            Console.WriteLine("4- Reserve um assento: ");
            Console.WriteLine("5- Proximo assento livre");
            int opcao = Convert.ToInt32(Console.ReadLine());
          
            switch (opcao)
            {
               
                case 1:
                    Console.WriteLine("Digite o numero do assento: ");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    conexao.Verifica(numero);
                    break;

                case 2:
                    conexao.Vagas();
                    break;

                case 3:
                    Console.WriteLine("Numero do Voo: "  + conexao.GetVoo());
                    Console.WriteLine("Data: " + conexao.GetData());
                    break;

                case 4:
                    Console.WriteLine("Digite o numero do seu assento: ");
                    int assento = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine("Numero do seu voo: " + conexao.GetVoo() + " Data e hora do seu voo: " + conexao.GetData());
                    conexao.Ocupa(assento);
                    assento = conexao.assento;
                    break;

                case 5:
                    conexao.ProximaCadeira();
                    break;
            }
        }
    }
}