
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