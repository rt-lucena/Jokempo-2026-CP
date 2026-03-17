using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokempo.Core;

public class Jogador
{
    public string Nome { get; set; }
    public Estatisticas Estatisticas { get; set; }

    public Jogador(string nome)
    {
        Nome = nome;
        Estatisticas = new Estatisticas();
    }
}
