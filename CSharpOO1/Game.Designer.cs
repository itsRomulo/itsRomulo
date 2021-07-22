namespace CSharpOO1
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSorte = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnCloseGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVidas = new System.Windows.Forms.Label();
            this.Certo = new System.Windows.Forms.Label();
            this.lstHist = new System.Windows.Forms.ListBox();
            this.btnAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite um Número:";
            // 
            // txtSorte
            // 
            this.txtSorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSorte.Location = new System.Drawing.Point(303, 172);
            this.txtSorte.Multiline = true;
            this.txtSorte.Name = "txtSorte";
            this.txtSorte.Size = new System.Drawing.Size(98, 31);
            this.txtSorte.TabIndex = 1;
            this.txtSorte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(45, 225);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(148, 39);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Verificar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnCloseGame
            // 
            this.btnCloseGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseGame.Location = new System.Drawing.Point(216, 380);
            this.btnCloseGame.Name = "btnCloseGame";
            this.btnCloseGame.Size = new System.Drawing.Size(148, 39);
            this.btnCloseGame.TabIndex = 4;
            this.btnCloseGame.Text = "Sair";
            this.btnCloseGame.UseVisualStyleBackColor = true;
            this.btnCloseGame.Click += new System.EventHandler(this.btnCloseGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(453, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tentativas Restantes:";
            // 
            // lblVidas
            // 
            this.lblVidas.AutoSize = true;
            this.lblVidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVidas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblVidas.Location = new System.Drawing.Point(695, 131);
            this.lblVidas.Name = "lblVidas";
            this.lblVidas.Size = new System.Drawing.Size(44, 31);
            this.lblVidas.TabIndex = 6;
            this.lblVidas.Text = "10";
            // 
            // Certo
            // 
            this.Certo.AutoSize = true;
            this.Certo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Certo.ForeColor = System.Drawing.Color.Red;
            this.Certo.Location = new System.Drawing.Point(49, 324);
            this.Certo.Name = "Certo";
            this.Certo.Size = new System.Drawing.Size(0, 31);
            this.Certo.TabIndex = 7;
            // 
            // lstHist
            // 
            this.lstHist.FormattingEnabled = true;
            this.lstHist.Location = new System.Drawing.Point(458, 172);
            this.lstHist.Name = "lstHist";
            this.lstHist.Size = new System.Drawing.Size(292, 238);
            this.lstHist.TabIndex = 8;
            // 
            // btnAgain
            // 
            this.btnAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgain.Location = new System.Drawing.Point(62, 380);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(148, 39);
            this.btnAgain.TabIndex = 9;
            this.btnAgain.Text = "Jogar Novamente";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.lstHist);
            this.Controls.Add(this.Certo);
            this.Controls.Add(this.lblVidas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCloseGame);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtSorte);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSorte;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnCloseGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVidas;
        private System.Windows.Forms.Label Certo;
        private System.Windows.Forms.ListBox lstHist;
        private System.Windows.Forms.Button btnAgain;
    }
}