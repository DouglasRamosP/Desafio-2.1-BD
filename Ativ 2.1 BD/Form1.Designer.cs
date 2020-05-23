namespace Ativ_2._1_BD
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbServidor = new System.Windows.Forms.Label();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbBanco = new System.Windows.Forms.Label();
            this.lbSql = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.txtSql = new System.Windows.Forms.TextBox();
            this.btmExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbServidor
            // 
            this.lbServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbServidor.Location = new System.Drawing.Point(25, 43);
            this.lbServidor.MinimumSize = new System.Drawing.Size(20, 20);
            this.lbServidor.Name = "lbServidor";
            this.lbServidor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbServidor.Size = new System.Drawing.Size(119, 38);
            this.lbServidor.TabIndex = 0;
            this.lbServidor.Text = "Servidor";
            // 
            // lbUsuario
            // 
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(25, 116);
            this.lbUsuario.MinimumSize = new System.Drawing.Size(20, 20);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbUsuario.Size = new System.Drawing.Size(119, 38);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuário";
            this.lbUsuario.Click += new System.EventHandler(this.LUsuario_Click);
            // 
            // lbSenha
            // 
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(25, 196);
            this.lbSenha.MinimumSize = new System.Drawing.Size(20, 20);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbSenha.Size = new System.Drawing.Size(119, 38);
            this.lbSenha.TabIndex = 0;
            this.lbSenha.Text = "Senha";
            // 
            // lbBanco
            // 
            this.lbBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBanco.Location = new System.Drawing.Point(25, 272);
            this.lbBanco.MinimumSize = new System.Drawing.Size(20, 20);
            this.lbBanco.Name = "lbBanco";
            this.lbBanco.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbBanco.Size = new System.Drawing.Size(119, 38);
            this.lbBanco.TabIndex = 0;
            this.lbBanco.Text = "Banco";
            // 
            // lbSql
            // 
            this.lbSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSql.Location = new System.Drawing.Point(25, 348);
            this.lbSql.MinimumSize = new System.Drawing.Size(20, 20);
            this.lbSql.Name = "lbSql";
            this.lbSql.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbSql.Size = new System.Drawing.Size(119, 38);
            this.lbSql.TabIndex = 0;
            this.lbSql.Text = "SQL";
            this.lbSql.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(138, 34);
            this.txtServidor.Multiline = true;
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(289, 46);
            this.txtServidor.TabIndex = 1;
            this.txtServidor.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(138, 108);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(289, 46);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(138, 188);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(289, 46);
            this.txtSenha.TabIndex = 1;
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(138, 264);
            this.txtBanco.Multiline = true;
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(289, 46);
            this.txtBanco.TabIndex = 1;
            // 
            // txtSql
            // 
            this.txtSql.Location = new System.Drawing.Point(138, 340);
            this.txtSql.Multiline = true;
            this.txtSql.Name = "txtSql";
            this.txtSql.Size = new System.Drawing.Size(633, 98);
            this.txtSql.TabIndex = 1;
            // 
            // btmExecutar
            // 
            this.btmExecutar.Location = new System.Drawing.Point(498, 34);
            this.btmExecutar.Name = "btmExecutar";
            this.btmExecutar.Size = new System.Drawing.Size(273, 73);
            this.btmExecutar.TabIndex = 2;
            this.btmExecutar.Text = "EXECUTAR!";
            this.btmExecutar.UseVisualStyleBackColor = true;
            this.btmExecutar.Click += new System.EventHandler(this.btmExecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmExecutar);
            this.Controls.Add(this.txtSql);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lbSql);
            this.Controls.Add(this.lbBanco);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.lbServidor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbUsuario;
        internal System.Windows.Forms.Label lbSenha;
        internal System.Windows.Forms.Label lbBanco;
        internal System.Windows.Forms.Label lbSql;
        internal System.Windows.Forms.Label lbServidor;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.TextBox txtSql;
        private System.Windows.Forms.Button btmExecutar;
    }
}

