
Banda slipknot = new Banda("Slipknot");

Album albumSlipknot = new Album("Before Forget");


Musica musica1 = new Musica(slipknot, "Duality")
{
    Duracao = 213,
    Disponivel = true
};



Musica musica2 = new Musica(slipknot, "Spirit it out")
{
    Duracao = 260,
    Disponivel = false
 };



albumSlipknot.AdicionarMusica(musica1);
albumSlipknot.AdicionarMusica(musica2);
slipknot.AdicionarAlbum(albumSlipknot);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumSlipknot.ExibirMusicasDoAlbum();
slipknot.ExibirDiscografia();



Episodio ep1 = new Episodio(1, "Tecnica de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");
Console.WriteLine(ep1.Resumo);


Episodio ep2 = new Episodio(2, "Tecnica de apredizado", 67);
ep2.AdicionarConvidados("Enrique");
ep2.AdicionarConvidados("Marcos");
ep2.AdicionarConvidados("Camila");


Podcast podcast = new("Podcast especoal", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();