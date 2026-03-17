using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokempo.Core;

public class Jogo
{
    private readonly Random _rng = new();
    public List<Jogador> Jogadores { get; } = new();

    public Jogador ObterOuCriarJogador(string nome)
    {
        var jogador = Jogadores.FirstOrDefault(j => j.Nome == nome);
        if (jogador == null)
        {
            jogador = new Jogador(nome);
            Jogadores.Add(jogador);
        }
        return jogador;
    }

    public Rodada Jogar(Jogador jogador, Escolha escolha)
    {
        var escolhaPC = (Escolha)_rng.Next(3);
        var rodada = new Rodada(escolha, escolhaPC);

        var e = jogador.Estatisticas;
        switch (rodada.Resultado)
        {
            case ResultadoRodada.Vitoria: e.Vitorias++; break;
            case ResultadoRodada.Empate: e.Empates++; break;
            case ResultadoRodada.Derrota: e.Derrotas++; break;
        }

        return rodada;
    }
}
