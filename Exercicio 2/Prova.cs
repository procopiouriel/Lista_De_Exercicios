public class Prova
{
    public string[] gabaritoaluno = new string[15];
    private Gabarito gabi;

    public Prova(Gabarito gabi)
    {
        this.gabi = gabi;
    }
    public void respostaAluno(string resposta)
    {
        for (int i = 0; i < this.gabaritoaluno.Length; i++)
        {
            
            if (this.gabaritoaluno[i] == null)//ESTA DESOCUPADO
            {
                this.gabaritoaluno[i] = resposta;
                break;
            }
        }

    }

    public int Acertos()
    {
        int acertos = 0;

        Gabarito conexao = new Gabarito();
        
        for (int i = 0; i < gabaritoaluno.Length; i++)//COMPARAR RESULTADOS
        {
            
            if (this.gabaritoaluno[i] == gabi.RespostaQuestao(i))
            {
                acertos++;
            }
        }
        return acertos;
    }

    public double Nota()
    {
        double nota = 0;

        for (int i = 0; i < this.gabaritoaluno.Length; i++)
        {
            if (this.gabaritoaluno[i] == gabi.RespostaQuestao(i))
            {
                if (i < 10)
                {
                    nota += 0.5;
                }
                else
                {
                    nota += 1;
                }
            }
        }
        return nota;
    }
}