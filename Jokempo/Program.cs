using System;
using System.Collections.Generic;

var jogadores = new Dictionary<string, (int v, int e, int d)>();
string[] opcoes = { "Pedra ✊", "Papel ✋", "Tesoura ✌" };

Console.WriteLine("😀 Jokempo! 1-Sim / 0-Não");
if (Console.ReadKey().KeyChar == '0') return;

while (true)
{
    Console.WriteLine("\nQual seu nome?");
    string nome = Console.ReadLine() ?? "Jogador";
    if (!jogadores.ContainsKey(nome)) jogadores[nome] = (0, 0, 0);

    do {
        Console.WriteLine("\n0-Pedra, 1-Papel, 2-Tesoura");
        int player = int.Parse(Console.ReadKey().KeyChar.ToString());
        int pc = new Random().Next(3);

        Console.WriteLine($"\nVocê: {opcoes[player]} vs PC: {opcoes[pc]}");

        var stats = jogadores[nome];
        if (player == pc) {
            Console.WriteLine("Empate!");
            jogadores[nome] = (stats.v, stats.e + 1, stats.d);
        } else if ((player == 0 && pc == 2) || (player == 1 && pc == 0) || (player == 2 && pc == 1)) {
            Console.WriteLine("Você venceu!");
            jogadores[nome] = (stats.v + 1, stats.e, stats.d);
        } else {
            Console.WriteLine("PC venceu!");
            jogadores[nome] = (stats.v, stats.e, stats.d + 1);
        }

        Console.WriteLine("Jogar de novo? (1-Sim/Outro-Não)");
    } while (Console.ReadKey().KeyChar == '1');

    Console.WriteLine("\n--- Placar Geral ---");
    foreach (var j in jogadores) 
        Console.WriteLine($"{j.Key}: V:{j.Value.v} E:{j.Value.e} D:{j.Value.d}");

    Console.WriteLine("\n1-Trocar Jogador, 0-Sair");
    if (Console.ReadKey().KeyChar == '0') break;
}
