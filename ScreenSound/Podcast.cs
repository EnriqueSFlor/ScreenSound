class Podcast
{

    private List<Episodio> episodios = new();

    public string Nome { get; }
    public string Host { get; }



    public int TotaolEpsodios => episodios.Count;

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
        
    }



    public void AdicionarEpisodio(Episodio episodio) {

     episodios.Add(episodio);

    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresenado por {Host}\n");
        
        foreach (Episodio episodio in episodios)
        {
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine($"\n\nEste podcast possui {TotaolEpsodios} epsodios.");

    }
}
