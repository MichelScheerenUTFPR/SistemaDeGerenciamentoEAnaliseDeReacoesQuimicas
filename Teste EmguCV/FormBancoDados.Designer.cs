namespace Teste_EmguCV
{
    partial class FormBancoDados
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
            this.components = new System.ComponentModel.Container();
            this.pbWebCam = new System.Windows.Forms.PictureBox();
            this.pbObter = new System.Windows.Forms.PictureBox();
            this.btnObterDosArquivos = new System.Windows.Forms.Button();
            this.btnGravarBanco = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblResultadoGravacao = new System.Windows.Forms.Label();
            this.btnPegarBanco = new System.Windows.Forms.Button();
            this.btnCapturarImagem = new System.Windows.Forms.Button();
            this.pbCaptura = new System.Windows.Forms.PictureBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.btnCortar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWebCam
            // 
            this.pbWebCam.Location = new System.Drawing.Point(12, 12);
            this.pbWebCam.Name = "pbWebCam";
            this.pbWebCam.Size = new System.Drawing.Size(465, 288);
            this.pbWebCam.TabIndex = 0;
            this.pbWebCam.TabStop = false;
            this.pbWebCam.Paint += new System.Windows.Forms.PaintEventHandler(this.PbWebCam_Paint);
            this.pbWebCam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbWebCam_MouseDown);
            this.pbWebCam.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbWebCam_MouseMove);
            this.pbWebCam.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbWebCam_MouseUp);
            // 
            // pbObter
            // 
            this.pbObter.Location = new System.Drawing.Point(490, 12);
            this.pbObter.Name = "pbObter";
            this.pbObter.Size = new System.Drawing.Size(468, 288);
            this.pbObter.TabIndex = 1;
            this.pbObter.TabStop = false;
            // 
            // btnObterDosArquivos
            // 
            this.btnObterDosArquivos.Location = new System.Drawing.Point(490, 306);
            this.btnObterDosArquivos.Name = "btnObterDosArquivos";
            this.btnObterDosArquivos.Size = new System.Drawing.Size(155, 26);
            this.btnObterDosArquivos.TabIndex = 2;
            this.btnObterDosArquivos.Text = "Abrir Imagem";
            this.btnObterDosArquivos.UseVisualStyleBackColor = true;
            this.btnObterDosArquivos.Click += new System.EventHandler(this.BtnObterDosArquivos_Click);
            // 
            // btnGravarBanco
            // 
            this.btnGravarBanco.Location = new System.Drawing.Point(664, 306);
            this.btnGravarBanco.Name = "btnGravarBanco";
            this.btnGravarBanco.Size = new System.Drawing.Size(155, 26);
            this.btnGravarBanco.TabIndex = 3;
            this.btnGravarBanco.Text = "Gravar no Banco de Dados";
            this.btnGravarBanco.UseVisualStyleBackColor = true;
            this.btnGravarBanco.Click += new System.EventHandler(this.BtnGravarBanco_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.FileName = "openFileDialog1";
            // 
            // lblResultadoGravacao
            // 
            this.lblResultadoGravacao.AutoSize = true;
            this.lblResultadoGravacao.Location = new System.Drawing.Point(661, 331);
            this.lblResultadoGravacao.Name = "lblResultadoGravacao";
            this.lblResultadoGravacao.Size = new System.Drawing.Size(113, 13);
            this.lblResultadoGravacao.TabIndex = 4;
            this.lblResultadoGravacao.Text = "texto de carregamento";
            this.lblResultadoGravacao.Visible = false;
            // 
            // btnPegarBanco
            // 
            this.btnPegarBanco.Location = new System.Drawing.Point(844, 306);
            this.btnPegarBanco.Name = "btnPegarBanco";
            this.btnPegarBanco.Size = new System.Drawing.Size(114, 26);
            this.btnPegarBanco.TabIndex = 5;
            this.btnPegarBanco.Text = "Recuperar do Banco";
            this.btnPegarBanco.UseVisualStyleBackColor = true;
            this.btnPegarBanco.Click += new System.EventHandler(this.btnPegarBanco_Click);
            // 
            // btnCapturarImagem
            // 
            this.btnCapturarImagem.Location = new System.Drawing.Point(12, 306);
            this.btnCapturarImagem.Name = "btnCapturarImagem";
            this.btnCapturarImagem.Size = new System.Drawing.Size(100, 35);
            this.btnCapturarImagem.TabIndex = 6;
            this.btnCapturarImagem.Text = "Capturar Imagem";
            this.btnCapturarImagem.UseVisualStyleBackColor = true;
            this.btnCapturarImagem.Click += new System.EventHandler(this.BtnCapturarImagem_Click);
            // 
            // pbCaptura
            // 
            this.pbCaptura.Location = new System.Drawing.Point(12, 347);
            this.pbCaptura.Name = "pbCaptura";
            this.pbCaptura.Size = new System.Drawing.Size(465, 288);
            this.pbCaptura.TabIndex = 7;
            this.pbCaptura.TabStop = false;
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(490, 347);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(468, 288);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // btnCortar
            // 
            this.btnCortar.Location = new System.Drawing.Point(118, 306);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(144, 35);
            this.btnCortar.TabIndex = 8;
            this.btnCortar.Text = "Imagem Recortada";
            this.btnCortar.UseVisualStyleBackColor = true;
            this.btnCortar.Click += new System.EventHandler(this.BtnCortar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 651);
            this.Controls.Add(this.btnCortar);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.pbCaptura);
            this.Controls.Add(this.btnCapturarImagem);
            this.Controls.Add(this.btnPegarBanco);
            this.Controls.Add(this.lblResultadoGravacao);
            this.Controls.Add(this.btnGravarBanco);
            this.Controls.Add(this.btnObterDosArquivos);
            this.Controls.Add(this.pbObter);
            this.Controls.Add(this.pbWebCam);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWebCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWebCam;
        private System.Windows.Forms.PictureBox pbObter;
        private System.Windows.Forms.Button btnObterDosArquivos;
        private System.Windows.Forms.Button btnGravarBanco;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Label lblResultadoGravacao;
        private System.Windows.Forms.Button btnPegarBanco;
        private System.Windows.Forms.Button btnCapturarImagem;
        private System.Windows.Forms.PictureBox pbCaptura;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button btnCortar;
    }
}

