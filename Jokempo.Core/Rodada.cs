using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokempo.Core;

public class Rodada
{
    public Escolha EscolhaJogador { get; private set; }
    public Escolha EscolhaPC { get; private set; }
    public ResultadoRodada Resultado { get; private set; }

    public Rodada(Escolha jogador, Escolha pc)
    {
        EscolhaJogador = jogador;
        EscolhaPC = pc;
        Resultado = Calcular(jogador, pc);
    }

    private static ResultadoRodada Calcular(Escolha j, Escolha pc)
    {
        if (j == pc) return ResultadoRodada.Empate;

        bool venceu = (j == Escolha.Pedra && pc == Escolha.Tesoura) ||
                      (j == Escolha.Papel && pc == Escolha.Pedra) ||
                      (j == Escolha.Tesoura && pc == Escolha.Papel);

        return venceu ? ResultadoRodada.Vitoria : ResultadoRodada.Derrota;
    }
}
