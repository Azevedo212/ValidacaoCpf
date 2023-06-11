namespace validacaoCpf
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
            label1 = new Label();
            label2 = new Label();
            lb_nome = new Label();
            lb_cpf = new Label();
            lb_idade = new Label();
            lb_peso = new Label();
            lb_altura = new Label();
            lb_sexo = new Label();
            tx_nome = new TextBox();
            tx_cpf = new MaskedTextBox();
            tx_idade = new TextBox();
            tx_altura = new TextBox();
            tx_peso = new TextBox();
            tx_sexo = new ComboBox();
            bt_calcular = new Button();
            bt_cancelar = new Button();
            lb_invalido = new Label();
            lb_resultado = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(71, 9);
            label1.Name = "label1";
            label1.Size = new Size(268, 36);
            label1.TabIndex = 0;
            label1.Text = "CALCULAR IMC";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 45);
            label2.Name = "label2";
            label2.Size = new Size(392, 13);
            label2.TabIndex = 1;
            label2.Text = "_____________________________________________________________________________";
            // 
            // lb_nome
            // 
            lb_nome.AutoSize = true;
            lb_nome.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_nome.Location = new Point(48, 88);
            lb_nome.Name = "lb_nome";
            lb_nome.Size = new Size(50, 19);
            lb_nome.TabIndex = 2;
            lb_nome.Text = "Nome:";
            // 
            // lb_cpf
            // 
            lb_cpf.AutoSize = true;
            lb_cpf.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_cpf.Location = new Point(48, 149);
            lb_cpf.Name = "lb_cpf";
            lb_cpf.Size = new Size(35, 19);
            lb_cpf.TabIndex = 3;
            lb_cpf.Text = "Cpf:";
            // 
            // lb_idade
            // 
            lb_idade.AutoSize = true;
            lb_idade.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_idade.Location = new Point(269, 88);
            lb_idade.Name = "lb_idade";
            lb_idade.Size = new Size(44, 19);
            lb_idade.TabIndex = 4;
            lb_idade.Text = "Idade";
            // 
            // lb_peso
            // 
            lb_peso.AutoSize = true;
            lb_peso.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_peso.Location = new Point(229, 214);
            lb_peso.Name = "lb_peso";
            lb_peso.Size = new Size(42, 19);
            lb_peso.TabIndex = 5;
            lb_peso.Text = "Peso:";
            // 
            // lb_altura
            // 
            lb_altura.AutoSize = true;
            lb_altura.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_altura.Location = new Point(48, 213);
            lb_altura.Name = "lb_altura";
            lb_altura.Size = new Size(49, 19);
            lb_altura.TabIndex = 6;
            lb_altura.Text = "Altura:";
            // 
            // lb_sexo
            // 
            lb_sexo.AutoSize = true;
            lb_sexo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_sexo.Location = new Point(229, 149);
            lb_sexo.Name = "lb_sexo";
            lb_sexo.Size = new Size(43, 19);
            lb_sexo.TabIndex = 7;
            lb_sexo.Text = "Sexo:";
            // 
            // tx_nome
            // 
            tx_nome.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tx_nome.Location = new Point(48, 110);
            tx_nome.Name = "tx_nome";
            tx_nome.Size = new Size(188, 21);
            tx_nome.TabIndex = 8;
            tx_nome.TextChanged += tx_nome_TextChanged;
            // 
            // tx_cpf
            // 
            tx_cpf.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tx_cpf.Location = new Point(48, 171);
            tx_cpf.Mask = "000,000,000-00";
            tx_cpf.Name = "tx_cpf";
            tx_cpf.Size = new Size(119, 21);
            tx_cpf.TabIndex = 9;
            tx_cpf.MaskInputRejected += tx_cpf_MaskInputRejected;
            // 
            // tx_idade
            // 
            tx_idade.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tx_idade.Location = new Point(269, 110);
            tx_idade.Name = "tx_idade";
            tx_idade.Size = new Size(100, 21);
            tx_idade.TabIndex = 10;
            tx_idade.TextChanged += tx_idade_TextChanged;
            // 
            // tx_altura
            // 
            tx_altura.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tx_altura.Location = new Point(48, 236);
            tx_altura.Multiline = true;
            tx_altura.Name = "tx_altura";
            tx_altura.Size = new Size(102, 21);
            tx_altura.TabIndex = 11;
            tx_altura.TextChanged += tx_altura_TextChanged;
            // 
            // tx_peso
            // 
            tx_peso.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tx_peso.Location = new Point(229, 236);
            tx_peso.Name = "tx_peso";
            tx_peso.Size = new Size(100, 21);
            tx_peso.TabIndex = 12;
            tx_peso.TextChanged += tx_peso_TextChanged;
            // 
            // tx_sexo
            // 
            tx_sexo.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tx_sexo.FormattingEnabled = true;
            tx_sexo.Items.AddRange(new object[] { "Masculino", "Feminino" });
            tx_sexo.Location = new Point(229, 171);
            tx_sexo.Name = "tx_sexo";
            tx_sexo.Size = new Size(101, 23);
            tx_sexo.TabIndex = 13;
            tx_sexo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // bt_calcular
            // 
            bt_calcular.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bt_calcular.Location = new Point(13, 313);
            bt_calcular.Name = "bt_calcular";
            bt_calcular.Size = new Size(119, 37);
            bt_calcular.TabIndex = 14;
            bt_calcular.Text = "Calcular";
            bt_calcular.UseVisualStyleBackColor = true;
            bt_calcular.Click += bt_calcular_Click;
            // 
            // bt_cancelar
            // 
            bt_cancelar.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bt_cancelar.Location = new Point(288, 313);
            bt_cancelar.Name = "bt_cancelar";
            bt_cancelar.Size = new Size(117, 37);
            bt_cancelar.TabIndex = 15;
            bt_cancelar.Text = "Cancelar";
            bt_cancelar.UseVisualStyleBackColor = true;
            bt_cancelar.Click += bt_cancelar_Click;
            // 
            // lb_invalido
            // 
            lb_invalido.AutoSize = true;
            lb_invalido.Location = new Point(129, 269);
            lb_invalido.Name = "lb_invalido";
            lb_invalido.Size = new Size(38, 15);
            lb_invalido.TabIndex = 16;
            lb_invalido.Text = "label3";
            // 
            // lb_resultado
            // 
            lb_resultado.AutoSize = true;
            lb_resultado.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_resultado.Location = new Point(150, 284);
            lb_resultado.Name = "lb_resultado";
            lb_resultado.Size = new Size(41, 15);
            lb_resultado.TabIndex = 17;
            lb_resultado.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(430, 374);
            Controls.Add(lb_resultado);
            Controls.Add(lb_invalido);
            Controls.Add(bt_cancelar);
            Controls.Add(bt_calcular);
            Controls.Add(tx_sexo);
            Controls.Add(tx_peso);
            Controls.Add(tx_altura);
            Controls.Add(tx_idade);
            Controls.Add(tx_cpf);
            Controls.Add(tx_nome);
            Controls.Add(lb_sexo);
            Controls.Add(lb_altura);
            Controls.Add(lb_peso);
            Controls.Add(lb_idade);
            Controls.Add(lb_cpf);
            Controls.Add(lb_nome);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lb_nome;
        private Label lb_cpf;
        private Label lb_idade;
        private Label lb_peso;
        private Label lb_altura;
        private Label lb_sexo;
        private TextBox tx_nome;
        private MaskedTextBox tx_cpf;
        private TextBox tx_idade;
        private TextBox tx_altura;
        private TextBox tx_peso;
        private ComboBox tx_sexo;
        private Button bt_calcular;
        private Button bt_cancelar;
        private Label lb_invalido;
        private Label lb_resultado;
    }
}