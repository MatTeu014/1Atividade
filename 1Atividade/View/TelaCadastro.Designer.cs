namespace _1Atividade.View
{
    partial class TelaCadastro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tbx_nome = new TextBox();
            tbx_cpf = new TextBox();
            tbx_email = new TextBox();
            tbx_telefone = new TextBox();
            btn_cadastrar = new Button();
            cbx_estado = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 41);
            label1.Name = "label1";
            label1.Size = new Size(176, 50);
            label1.TabIndex = 0;
            label1.Text = "Cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label2.Location = new Point(243, 134);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label3.Location = new Point(263, 181);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label4.Location = new Point(243, 228);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 3;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label5.Location = new Point(223, 272);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 4;
            label5.Text = "Telefone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            label6.Location = new Point(239, 321);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 5;
            label6.Text = "Estado:";
            // 
            // tbx_nome
            // 
            tbx_nome.Location = new Point(316, 135);
            tbx_nome.Name = "tbx_nome";
            tbx_nome.Size = new Size(164, 27);
            tbx_nome.TabIndex = 6;
            // 
            // tbx_cpf
            // 
            tbx_cpf.Location = new Point(316, 182);
            tbx_cpf.Name = "tbx_cpf";
            tbx_cpf.Size = new Size(164, 27);
            tbx_cpf.TabIndex = 7;
            // 
            // tbx_email
            // 
            tbx_email.Location = new Point(316, 229);
            tbx_email.Name = "tbx_email";
            tbx_email.Size = new Size(164, 27);
            tbx_email.TabIndex = 8;
            // 
            // tbx_telefone
            // 
            tbx_telefone.Location = new Point(316, 273);
            tbx_telefone.Name = "tbx_telefone";
            tbx_telefone.Size = new Size(164, 27);
            tbx_telefone.TabIndex = 9;
            // 
            // btn_cadastrar
            // 
            btn_cadastrar.Location = new Point(577, 386);
            btn_cadastrar.Name = "btn_cadastrar";
            btn_cadastrar.Size = new Size(129, 37);
            btn_cadastrar.TabIndex = 11;
            btn_cadastrar.Text = "Cadastrar";
            btn_cadastrar.UseVisualStyleBackColor = true;
            btn_cadastrar.Click += btn_cadastrar_Click;
            // 
            // cbx_estado
            // 
            cbx_estado.FormattingEnabled = true;
            cbx_estado.Items.AddRange(new object[] { "SP", "MG", "RJ", "MT", "GO", "MS", "BA", "AC", "RS", "ES", "CE", "PR", "SC", "PI", "MA", "RR", "AP", "AM", "RO", "SE", "AL", "RN", "PB", "PA", "TO", "PE" });
            cbx_estado.Location = new Point(316, 318);
            cbx_estado.Name = "cbx_estado";
            cbx_estado.Size = new Size(164, 28);
            cbx_estado.TabIndex = 12;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbx_estado);
            Controls.Add(btn_cadastrar);
            Controls.Add(tbx_telefone);
            Controls.Add(tbx_email);
            Controls.Add(tbx_cpf);
            Controls.Add(tbx_nome);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaCadastro";
            Text = "TelaCadastro";
            Load += TelaCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tbx_nome;
        private TextBox tbx_cpf;
        private TextBox tbx_email;
        private TextBox tbx_telefone;
        private Button btn_cadastrar;
        private ComboBox cbx_estado;
    }
}