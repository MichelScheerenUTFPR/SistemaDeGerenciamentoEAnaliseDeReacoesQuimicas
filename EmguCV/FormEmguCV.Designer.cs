namespace Teste_EmguCV
{
    partial class FormEmguCV
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pbCapturaWebCam = new System.Windows.Forms.PictureBox();
            this.btnObterDiferenciador = new System.Windows.Forms.Button();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.nudTempo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudCapturas = new System.Windows.Forms.NumericUpDown();
            this.btnIniciarCapturas = new System.Windows.Forms.Button();
            this.rtxtSinais = new System.Windows.Forms.RichTextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRetanguloManual = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.graficoResultados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlWebCam = new System.Windows.Forms.Panel();
            this.menuWebCam = new System.Windows.Forms.MenuStrip();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxCaminhoPlanilha = new System.Windows.Forms.TextBox();
            this.txtBoxNomePlanilha = new System.Windows.Forms.TextBox();
            this.folderBrowserPlanilha = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCaminhoPlanilha = new System.Windows.Forms.Button();
            this.btnGerarPlanilha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturaWebCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoResultados)).BeginInit();
            this.pnlWebCam.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbCapturaWebCam
            // 
            this.pbCapturaWebCam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCapturaWebCam.Location = new System.Drawing.Point(0, 24);
            this.pbCapturaWebCam.Name = "pbCapturaWebCam";
            this.pbCapturaWebCam.Size = new System.Drawing.Size(557, 425);
            this.pbCapturaWebCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCapturaWebCam.TabIndex = 0;
            this.pbCapturaWebCam.TabStop = false;
            this.pbCapturaWebCam.Paint += new System.Windows.Forms.PaintEventHandler(this.PbCapturaWebCam_Paint);
            this.pbCapturaWebCam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbCapturaWebCam_MouseDown);
            this.pbCapturaWebCam.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbCapturaWebCam_MouseMove);
            this.pbCapturaWebCam.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbCapturaWebCam_MouseUp);
            // 
            // btnObterDiferenciador
            // 
            this.btnObterDiferenciador.Location = new System.Drawing.Point(46, 590);
            this.btnObterDiferenciador.Name = "btnObterDiferenciador";
            this.btnObterDiferenciador.Size = new System.Drawing.Size(140, 33);
            this.btnObterDiferenciador.TabIndex = 1;
            this.btnObterDiferenciador.Text = "Obter Direrenciador";
            this.btnObterDiferenciador.UseVisualStyleBackColor = true;
            this.btnObterDiferenciador.Click += new System.EventHandler(this.BtnObterDiferenciador_Click);
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(89, 629);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.ReadOnly = true;
            this.txtBlue.Size = new System.Drawing.Size(97, 20);
            this.txtBlue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 636);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Blue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 688);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Red";
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(89, 681);
            this.txtRed.Name = "txtRed";
            this.txtRed.ReadOnly = true;
            this.txtRed.Size = new System.Drawing.Size(97, 20);
            this.txtRed.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 662);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Green";
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(89, 655);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.ReadOnly = true;
            this.txtGreen.Size = new System.Drawing.Size(97, 20);
            this.txtGreen.TabIndex = 6;
            // 
            // nudTempo
            // 
            this.nudTempo.Location = new System.Drawing.Point(327, 467);
            this.nudTempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTempo.Name = "nudTempo";
            this.nudTempo.Size = new System.Drawing.Size(67, 20);
            this.nudTempo.TabIndex = 8;
            this.nudTempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tempo (seg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 500);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Capturas/seg";
            // 
            // nudCapturas
            // 
            this.nudCapturas.Location = new System.Drawing.Point(327, 493);
            this.nudCapturas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapturas.Name = "nudCapturas";
            this.nudCapturas.Size = new System.Drawing.Size(67, 20);
            this.nudCapturas.TabIndex = 10;
            this.nudCapturas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnIniciarCapturas
            // 
            this.btnIniciarCapturas.Enabled = false;
            this.btnIniciarCapturas.Location = new System.Drawing.Point(400, 467);
            this.btnIniciarCapturas.Name = "btnIniciarCapturas";
            this.btnIniciarCapturas.Size = new System.Drawing.Size(141, 47);
            this.btnIniciarCapturas.TabIndex = 12;
            this.btnIniciarCapturas.Text = "Iniciar";
            this.btnIniciarCapturas.UseVisualStyleBackColor = true;
            this.btnIniciarCapturas.Click += new System.EventHandler(this.BtnIniciarCapturas_Click);
            // 
            // rtxtSinais
            // 
            this.rtxtSinais.Location = new System.Drawing.Point(258, 524);
            this.rtxtSinais.Name = "rtxtSinais";
            this.rtxtSinais.ReadOnly = true;
            this.rtxtSinais.Size = new System.Drawing.Size(283, 177);
            this.rtxtSinais.TabIndex = 13;
            this.rtxtSinais.Text = "";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(63, 485);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(43, 20);
            this.txtX1.TabIndex = 14;
            this.txtX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(63, 516);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(43, 20);
            this.txtX2.TabIndex = 15;
            this.txtX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(136, 516);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(43, 20);
            this.txtY2.TabIndex = 17;
            this.txtY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(136, 485);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(43, 20);
            this.txtY1.TabIndex = 16;
            this.txtY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 492);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "x1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "y2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "y1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "x2";
            // 
            // btnRetanguloManual
            // 
            this.btnRetanguloManual.Location = new System.Drawing.Point(46, 542);
            this.btnRetanguloManual.Name = "btnRetanguloManual";
            this.btnRetanguloManual.Size = new System.Drawing.Size(140, 33);
            this.btnRetanguloManual.TabIndex = 22;
            this.btnRetanguloManual.Text = "Atualizar Manual";
            this.btnRetanguloManual.UseVisualStyleBackColor = true;
            this.btnRetanguloManual.Click += new System.EventHandler(this.BtnRetanguloManual_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 469);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Coordenadas da Área Selecionada:";
            // 
            // graficoResultados
            // 
            chartArea2.AxisX.Crossing = 0D;
            chartArea2.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisX.Title = "Capturas";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.Crossing = 0D;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.Title = "Sinal";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.Name = "ChartArea1";
            this.graficoResultados.ChartAreas.Add(chartArea2);
            this.graficoResultados.Location = new System.Drawing.Point(595, 12);
            this.graficoResultados.Name = "graficoResultados";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.CustomProperties = "LabelStyle=TopLeft";
            series2.IsVisibleInLegend = false;
            series2.MarkerSize = 3;
            series2.Name = "Series1";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.graficoResultados.Series.Add(series2);
            this.graficoResultados.Size = new System.Drawing.Size(602, 415);
            this.graficoResultados.TabIndex = 25;
            this.graficoResultados.Text = "chart1";
            // 
            // pnlWebCam
            // 
            this.pnlWebCam.Controls.Add(this.pbCapturaWebCam);
            this.pnlWebCam.Controls.Add(this.menuWebCam);
            this.pnlWebCam.Location = new System.Drawing.Point(12, 12);
            this.pnlWebCam.Name = "pnlWebCam";
            this.pnlWebCam.Size = new System.Drawing.Size(557, 449);
            this.pnlWebCam.TabIndex = 26;
            // 
            // menuWebCam
            // 
            this.menuWebCam.Location = new System.Drawing.Point(0, 0);
            this.menuWebCam.Name = "menuWebCam";
            this.menuWebCam.Size = new System.Drawing.Size(557, 24);
            this.menuWebCam.TabIndex = 1;
            this.menuWebCam.Text = "menuStrip1";
            this.menuWebCam.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuWebCam_ItemClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(604, 473);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Caminho do Diretório";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(607, 500);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Nome do Arquivo";
            // 
            // txtBoxCaminhoPlanilha
            // 
            this.txtBoxCaminhoPlanilha.Location = new System.Drawing.Point(716, 470);
            this.txtBoxCaminhoPlanilha.Name = "txtBoxCaminhoPlanilha";
            this.txtBoxCaminhoPlanilha.Size = new System.Drawing.Size(128, 20);
            this.txtBoxCaminhoPlanilha.TabIndex = 29;
            // 
            // txtBoxNomePlanilha
            // 
            this.txtBoxNomePlanilha.Location = new System.Drawing.Point(716, 497);
            this.txtBoxNomePlanilha.Name = "txtBoxNomePlanilha";
            this.txtBoxNomePlanilha.Size = new System.Drawing.Size(128, 20);
            this.txtBoxNomePlanilha.TabIndex = 30;
            // 
            // btnCaminhoPlanilha
            // 
            this.btnCaminhoPlanilha.Location = new System.Drawing.Point(850, 477);
            this.btnCaminhoPlanilha.Name = "btnCaminhoPlanilha";
            this.btnCaminhoPlanilha.Size = new System.Drawing.Size(120, 35);
            this.btnCaminhoPlanilha.TabIndex = 31;
            this.btnCaminhoPlanilha.Text = "Buscar Diretório";
            this.btnCaminhoPlanilha.UseVisualStyleBackColor = true;
            this.btnCaminhoPlanilha.Click += new System.EventHandler(this.BtnCaminhoPlanilha_Click);
            // 
            // btnGerarPlanilha
            // 
            this.btnGerarPlanilha.Location = new System.Drawing.Point(1013, 462);
            this.btnGerarPlanilha.Name = "btnGerarPlanilha";
            this.btnGerarPlanilha.Size = new System.Drawing.Size(162, 57);
            this.btnGerarPlanilha.TabIndex = 32;
            this.btnGerarPlanilha.Text = "Gerar Planilha";
            this.btnGerarPlanilha.UseVisualStyleBackColor = true;
            this.btnGerarPlanilha.Click += new System.EventHandler(this.BtnGerarPlanilha_Click);
            // 
            // FormEmguCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 749);
            this.Controls.Add(this.btnGerarPlanilha);
            this.Controls.Add(this.btnCaminhoPlanilha);
            this.Controls.Add(this.txtBoxNomePlanilha);
            this.Controls.Add(this.txtBoxCaminhoPlanilha);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pnlWebCam);
            this.Controls.Add(this.graficoResultados);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRetanguloManual);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.rtxtSinais);
            this.Controls.Add(this.btnIniciarCapturas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudCapturas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGreen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBlue);
            this.Controls.Add(this.btnObterDiferenciador);
            this.Name = "FormEmguCV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmguCV_FormClosing);
            this.Load += new System.EventHandler(this.FormEmguCV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturaWebCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoResultados)).EndInit();
            this.pnlWebCam.ResumeLayout(false);
            this.pnlWebCam.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCapturaWebCam;
        private System.Windows.Forms.Button btnObterDiferenciador;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.NumericUpDown nudTempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudCapturas;
        private System.Windows.Forms.Button btnIniciarCapturas;
        private System.Windows.Forms.RichTextBox rtxtSinais;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRetanguloManual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoResultados;
        private System.Windows.Forms.Panel pnlWebCam;
        private System.Windows.Forms.MenuStrip menuWebCam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBoxCaminhoPlanilha;
        private System.Windows.Forms.TextBox txtBoxNomePlanilha;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserPlanilha;
        private System.Windows.Forms.Button btnCaminhoPlanilha;
        private System.Windows.Forms.Button btnGerarPlanilha;
    }
}

