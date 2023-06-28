public class Gabarito
{
    public string[] gabarito = { "A", "B", "C", "D", "E", "A", "B", "C", "D", "E", "A", "B", "C", "D", "E" };
    

    public string RespostaQuestao(int questao)
    {
        return gabarito[questao];
        
    }
}