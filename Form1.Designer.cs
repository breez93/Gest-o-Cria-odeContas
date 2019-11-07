namespace GestãodeContas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BCriarCOrdem = new System.Windows.Forms.Button();
            this.BDepositarOrdem = new System.Windows.Forms.Button();
            this.BLevantarOrdem = new System.Windows.Forms.Button();
            this.BRequisitarCheques = new System.Windows.Forms.Button();
            this.BMostrarJuroPoupança = new System.Windows.Forms.Button();
            this.BLevantarPoupança = new System.Windows.Forms.Button();
            this.BDepositarPoupança = new System.Windows.Forms.Button();
            this.BCriarContaPoupança = new System.Windows.Forms.Button();
            this.BSaldoInicial = new System.Windows.Forms.Button();
            this.BNome = new System.Windows.Forms.Button();
            this.TbDepositarOrdem = new System.Windows.Forms.TextBox();
            this.TbLevantarOrdem = new System.Windows.Forms.TextBox();
            this.TbLevantarPoupança = new System.Windows.Forms.TextBox();
            this.TbDepositarPoupança = new System.Windows.Forms.TextBox();
            this.RTBCaracteristicas = new System.Windows.Forms.RichTextBox();
            this.TbSaldoInicial = new System.Windows.Forms.TextBox();
            this.TbNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BVerSaldoOrdem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contas à Ordem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(770, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contas Poupança";
            // 
            // BCriarCOrdem
            // 
            this.BCriarCOrdem.Location = new System.Drawing.Point(115, 45);
            this.BCriarCOrdem.Name = "BCriarCOrdem";
            this.BCriarCOrdem.Size = new System.Drawing.Size(116, 20);
            this.BCriarCOrdem.TabIndex = 2;
            this.BCriarCOrdem.Text = "CriarConta";
            this.BCriarCOrdem.UseVisualStyleBackColor = true;
            this.BCriarCOrdem.Click += new System.EventHandler(this.BCriarCOrdem_Click);
            // 
            // BDepositarOrdem
            // 
            this.BDepositarOrdem.Location = new System.Drawing.Point(115, 129);
            this.BDepositarOrdem.Name = "BDepositarOrdem";
            this.BDepositarOrdem.Size = new System.Drawing.Size(116, 20);
            this.BDepositarOrdem.TabIndex = 3;
            this.BDepositarOrdem.Text = "Depositar";
            this.BDepositarOrdem.UseVisualStyleBackColor = true;
            this.BDepositarOrdem.Click += new System.EventHandler(this.BDepositarOrdem_Click);
            // 
            // BLevantarOrdem
            // 
            this.BLevantarOrdem.Location = new System.Drawing.Point(115, 174);
            this.BLevantarOrdem.Name = "BLevantarOrdem";
            this.BLevantarOrdem.Size = new System.Drawing.Size(116, 20);
            this.BLevantarOrdem.TabIndex = 4;
            this.BLevantarOrdem.Text = "Levantar";
            this.BLevantarOrdem.UseVisualStyleBackColor = true;
            this.BLevantarOrdem.Click += new System.EventHandler(this.BLevantarOrdem_Click);
            // 
            // BRequisitarCheques
            // 
            this.BRequisitarCheques.Location = new System.Drawing.Point(115, 213);
            this.BRequisitarCheques.Name = "BRequisitarCheques";
            this.BRequisitarCheques.Size = new System.Drawing.Size(116, 20);
            this.BRequisitarCheques.TabIndex = 5;
            this.BRequisitarCheques.Text = "Requisitar Cheques";
            this.BRequisitarCheques.UseVisualStyleBackColor = true;
            // 
            // BMostrarJuroPoupança
            // 
            this.BMostrarJuroPoupança.Location = new System.Drawing.Point(683, 210);
            this.BMostrarJuroPoupança.Name = "BMostrarJuroPoupança";
            this.BMostrarJuroPoupança.Size = new System.Drawing.Size(116, 23);
            this.BMostrarJuroPoupança.TabIndex = 9;
            this.BMostrarJuroPoupança.Text = "Mostrar taxa de juro";
            this.BMostrarJuroPoupança.UseVisualStyleBackColor = true;
            // 
            // BLevantarPoupança
            // 
            this.BLevantarPoupança.Location = new System.Drawing.Point(683, 171);
            this.BLevantarPoupança.Name = "BLevantarPoupança";
            this.BLevantarPoupança.Size = new System.Drawing.Size(116, 23);
            this.BLevantarPoupança.TabIndex = 8;
            this.BLevantarPoupança.Text = "Levantar";
            this.BLevantarPoupança.UseVisualStyleBackColor = true;
            // 
            // BDepositarPoupança
            // 
            this.BDepositarPoupança.Location = new System.Drawing.Point(683, 130);
            this.BDepositarPoupança.Name = "BDepositarPoupança";
            this.BDepositarPoupança.Size = new System.Drawing.Size(116, 23);
            this.BDepositarPoupança.TabIndex = 7;
            this.BDepositarPoupança.Text = "Depositar";
            this.BDepositarPoupança.UseVisualStyleBackColor = true;
            // 
            // BCriarContaPoupança
            // 
            this.BCriarContaPoupança.Location = new System.Drawing.Point(683, 42);
            this.BCriarContaPoupança.Name = "BCriarContaPoupança";
            this.BCriarContaPoupança.Size = new System.Drawing.Size(116, 23);
            this.BCriarContaPoupança.TabIndex = 6;
            this.BCriarContaPoupança.Text = "Criar Conta";
            this.BCriarContaPoupança.UseVisualStyleBackColor = true;
            this.BCriarContaPoupança.Click += new System.EventHandler(this.BCriarContaPoupança_Click);
            // 
            // BSaldoInicial
            // 
            this.BSaldoInicial.Location = new System.Drawing.Point(541, 288);
            this.BSaldoInicial.Name = "BSaldoInicial";
            this.BSaldoInicial.Size = new System.Drawing.Size(75, 23);
            this.BSaldoInicial.TabIndex = 10;
            this.BSaldoInicial.Text = "Saldo Inicial";
            this.BSaldoInicial.UseVisualStyleBackColor = true;
            // 
            // BNome
            // 
            this.BNome.Location = new System.Drawing.Point(249, 288);
            this.BNome.Name = "BNome";
            this.BNome.Size = new System.Drawing.Size(75, 23);
            this.BNome.TabIndex = 11;
            this.BNome.Text = "Nome";
            this.BNome.UseVisualStyleBackColor = true;
            // 
            // TbDepositarOrdem
            // 
            this.TbDepositarOrdem.Location = new System.Drawing.Point(249, 129);
            this.TbDepositarOrdem.Name = "TbDepositarOrdem";
            this.TbDepositarOrdem.Size = new System.Drawing.Size(100, 20);
            this.TbDepositarOrdem.TabIndex = 12;
            // 
            // TbLevantarOrdem
            // 
            this.TbLevantarOrdem.Location = new System.Drawing.Point(249, 175);
            this.TbLevantarOrdem.Name = "TbLevantarOrdem";
            this.TbLevantarOrdem.Size = new System.Drawing.Size(100, 20);
            this.TbLevantarOrdem.TabIndex = 13;
            // 
            // TbLevantarPoupança
            // 
            this.TbLevantarPoupança.Location = new System.Drawing.Point(821, 171);
            this.TbLevantarPoupança.Name = "TbLevantarPoupança";
            this.TbLevantarPoupança.Size = new System.Drawing.Size(100, 20);
            this.TbLevantarPoupança.TabIndex = 14;
            // 
            // TbDepositarPoupança
            // 
            this.TbDepositarPoupança.Location = new System.Drawing.Point(821, 131);
            this.TbDepositarPoupança.Name = "TbDepositarPoupança";
            this.TbDepositarPoupança.Size = new System.Drawing.Size(100, 20);
            this.TbDepositarPoupança.TabIndex = 15;
            // 
            // RTBCaracteristicas
            // 
            this.RTBCaracteristicas.Location = new System.Drawing.Point(364, 34);
            this.RTBCaracteristicas.Name = "RTBCaracteristicas";
            this.RTBCaracteristicas.Size = new System.Drawing.Size(303, 229);
            this.RTBCaracteristicas.TabIndex = 16;
            this.RTBCaracteristicas.Text = "";
            // 
            // TbSaldoInicial
            // 
            this.TbSaldoInicial.Location = new System.Drawing.Point(622, 291);
            this.TbSaldoInicial.Name = "TbSaldoInicial";
            this.TbSaldoInicial.Size = new System.Drawing.Size(192, 20);
            this.TbSaldoInicial.TabIndex = 17;
            // 
            // TbNome
            // 
            this.TbNome.Location = new System.Drawing.Point(330, 290);
            this.TbNome.Name = "TbNome";
            this.TbNome.Size = new System.Drawing.Size(188, 20);
            this.TbNome.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Caracteristicas";
            // 
            // BVerSaldoOrdem
            // 
            this.BVerSaldoOrdem.Location = new System.Drawing.Point(115, 89);
            this.BVerSaldoOrdem.Name = "BVerSaldoOrdem";
            this.BVerSaldoOrdem.Size = new System.Drawing.Size(116, 23);
            this.BVerSaldoOrdem.TabIndex = 20;
            this.BVerSaldoOrdem.Text = "Ver Saldo";
            this.BVerSaldoOrdem.UseVisualStyleBackColor = true;
            this.BVerSaldoOrdem.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(683, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Ver Saldo";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BVerSaldoOrdem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbNome);
            this.Controls.Add(this.TbSaldoInicial);
            this.Controls.Add(this.RTBCaracteristicas);
            this.Controls.Add(this.TbDepositarPoupança);
            this.Controls.Add(this.TbLevantarPoupança);
            this.Controls.Add(this.TbLevantarOrdem);
            this.Controls.Add(this.TbDepositarOrdem);
            this.Controls.Add(this.BNome);
            this.Controls.Add(this.BSaldoInicial);
            this.Controls.Add(this.BMostrarJuroPoupança);
            this.Controls.Add(this.BLevantarPoupança);
            this.Controls.Add(this.BDepositarPoupança);
            this.Controls.Add(this.BCriarContaPoupança);
            this.Controls.Add(this.BRequisitarCheques);
            this.Controls.Add(this.BLevantarOrdem);
            this.Controls.Add(this.BDepositarOrdem);
            this.Controls.Add(this.BCriarCOrdem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BCriarCOrdem;
        private System.Windows.Forms.Button BDepositarOrdem;
        private System.Windows.Forms.Button BLevantarOrdem;
        private System.Windows.Forms.Button BRequisitarCheques;
        private System.Windows.Forms.Button BMostrarJuroPoupança;
        private System.Windows.Forms.Button BLevantarPoupança;
        private System.Windows.Forms.Button BDepositarPoupança;
        private System.Windows.Forms.Button BCriarContaPoupança;
        private System.Windows.Forms.Button BSaldoInicial;
        private System.Windows.Forms.Button BNome;
        private System.Windows.Forms.TextBox TbDepositarOrdem;
        private System.Windows.Forms.TextBox TbLevantarOrdem;
        private System.Windows.Forms.TextBox TbLevantarPoupança;
        private System.Windows.Forms.TextBox TbDepositarPoupança;
        private System.Windows.Forms.RichTextBox RTBCaracteristicas;
        private System.Windows.Forms.TextBox TbSaldoInicial;
        private System.Windows.Forms.TextBox TbNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BVerSaldoOrdem;
        private System.Windows.Forms.Button button2;
    }
}

