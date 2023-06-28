public class Passageiro
{
    private int numeroVoo;
    public int assento;
    private DateTime data;
    public int[] array = new int[99];

    public Passageiro(int numeroVoo, DateTime data)
    {
        this.assento = assento;
        this.data = data;
        this.numeroVoo = numeroVoo;
    }

    public void ProximaCadeira()
    {
        for (int i = this.assento; i < array.Length; i++)
        {
            if (array[i] == 0)
            {
                Console.WriteLine("O próximo assento disponível é: " + (i + 1));
                break;
            }
        }
    }

    public void Ocupa(int assentos)
    {
        array[assento] = 1;
        

        if (array[assento] == 1)
        {
            Console.WriteLine("Assento " + assento+ " reservado com sucesso!");
        }
    }

    public void Verifica(int analise)
    {

        if (array[analise] == 1)
        {
            Console.WriteLine("Este assento esta INDISPONIVEL!");
        }
        else
        {
            Console.WriteLine("Assento DISPONIVEL!");
        }
    }

    public void Vagas()
    {
        Console.WriteLine("Vagas disponiveis: ");
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 0)
            {
                Console.WriteLine(i);

            }
        }
    }

    public int GetVoo()
    {
        return numeroVoo;
    }
    public DateTime GetData()
    {
        return data.Date;
    }
}