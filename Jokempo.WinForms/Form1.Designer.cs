namespace Jokempo.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            btnEntrar = new Button();
            btnPedra = new Button();
            btnPapel = new Button();
            btnTesoura = new Button();
            lblResultado = new Label();
            dgvPlacar = new DataGridView();
            colNome = new DataGridViewTextBoxColumn();
            colVitorias = new DataGridViewTextBoxColumn();
            colEmpates = new DataGridViewTextBoxColumn();
            colDerrotas = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPlacar).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(351, 240);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(363, 269);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 1;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnPedra
            // 
            btnPedra.Location = new Point(282, 197);
            btnPedra.Name = "btnPedra";
            btnPedra.Size = new Size(75, 23);
            btnPedra.TabIndex = 2;
            btnPedra.Text = "✊ Pedra";
            btnPedra.UseVisualStyleBackColor = true;
            btnPedra.Click += btnPedra_Click;
            // 
            // btnPapel
            // 
            btnPapel.Location = new Point(363, 197);
            btnPapel.Name = "btnPapel";
            btnPapel.Size = new Size(75, 23);
            btnPapel.TabIndex = 3;
            btnPapel.Text = "✋ Papel";
            btnPapel.UseVisualStyleBackColor = true;
            btnPapel.Click += btnPapel_Click;
            // 
            // btnTesoura
            // 
            btnTesoura.Location = new Point(444, 197);
            btnTesoura.Name = "btnTesoura";
            btnTesoura.Size = new Size(75, 23);
            btnTesoura.TabIndex = 4;
            btnTesoura.Text = "✌ Tesoura";
            btnTesoura.UseVisualStyleBackColor = true;
            btnTesoura.Click += btnTesoura_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(351, 376);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(16, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "...";
            lblResultado.Click += lblResultado_Click;
            // 
            // dgvPlacar
            // 
            dgvPlacar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlacar.Columns.AddRange(new DataGridViewColumn[] { colNome, colVitorias, colEmpates, colDerrotas });
            dgvPlacar.Location = new Point(184, 22);
            dgvPlacar.Name = "dgvPlacar";
            dgvPlacar.Size = new Size(443, 150);
            dgvPlacar.TabIndex = 6;
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            // 
            // colVitorias
            // 
            colVitorias.HeaderText = "V";
            colVitorias.Name = "colVitorias";
            // 
            // colEmpates
            // 
            colEmpates.HeaderText = "E";
            colEmpates.Name = "colEmpates";
            // 
            // colDerrotas
            // 
            colDerrotas.HeaderText = "D";
            colDerrotas.Name = "colDerrotas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvPlacar);
            Controls.Add(lblResultado);
            Controls.Add(btnTesoura);
            Controls.Add(btnPapel);
            Controls.Add(btnPedra);
            Controls.Add(btnEntrar);
            Controls.Add(txtNome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPlacar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Button btnEntrar;
        private Button btnPedra;
        private Button btnPapel;
        private Button btnTesoura;
        private Label lblResultado;
        private DataGridView dgvPlacar;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colVitorias;
        private DataGridViewTextBoxColumn colEmpates;
        private DataGridViewTextBoxColumn colDerrotas;
    }
}
