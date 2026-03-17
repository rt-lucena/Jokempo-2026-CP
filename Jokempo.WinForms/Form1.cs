using Jokempo.Core;

namespace Jokempo.WinForms;

public partial class Form1 : Form
{
    private readonly Jogo _jogo = new();
    private Jogador? _jogadorAtual;

    public Form1() => InitializeComponent();

    private void Form1_Load(object sender, EventArgs e)
    {
        // inicialização se necessário
    }

    private void btnEntrar_Click(object sender, EventArgs e)
    {
        string nome = txtNome.Text.Trim();
        if (string.IsNullOrWhiteSpace(nome)) return;

        _jogadorAtual = _jogo.ObterOuCriarJogador(nome);
        lblResultado.Text = $"Bem-vindo, {_jogadorAtual.Nome}!";
        AtualizarPlacar();
    }

    private void btnPedra_Click(object sender, EventArgs e) => Jogar(Escolha.Pedra);
    private void btnPapel_Click(object sender, EventArgs e) => Jogar(Escolha.Papel);
    private void btnTesoura_Click(object sender, EventArgs e) => Jogar(Escolha.Tesoura);

    private void Jogar(Escolha escolha)
    {
        if (_jogadorAtual == null)
        {
            lblResultado.Text = "⚠️ Digite seu nome primeiro!";
            return;
        }

        var rodada = _jogo.Jogar(_jogadorAtual, escolha);

        string resultado = rodada.Resultado switch
        {
            ResultadoRodada.Vitoria => "🏆 Você venceu!",
            ResultadoRodada.Empate => "👉 Empate!",
            ResultadoRodada.Derrota => "💻 PC venceu!",
            _ => ""
        };

        lblResultado.Text = $"{resultado}  |  PC escolheu: {rodada.EscolhaPC}";
        AtualizarPlacar();
    }

    private void AtualizarPlacar()
    {
        dgvPlacar.Rows.Clear();
        foreach (var j in _jogo.Jogadores)
        {
            var e = j.Estatisticas;
            dgvPlacar.Rows.Add(j.Nome, e.Vitorias, e.Empates, e.Derrotas);
        }
    }

    private void lblResultado_Click(object sender, EventArgs e)
    {

    }
}