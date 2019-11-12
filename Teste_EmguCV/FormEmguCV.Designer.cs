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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.graficoAnalise = new ZedGraph.ZedGraphControl();
            this.graficoResultados = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturaWebCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCapturaWebCam
            // 
            this.pbCapturaWebCam.Location = new System.Drawing.Point(12, 12);
            this.pbCapturaWebCam.Name = "pbCapturaWebCam";
            this.pbCapturaWebCam.Size = new System.Drawing.Size(550, 415);
            this.pbCapturaWebCam.TabIndex = 0;
            this.pbCapturaWebCam.TabStop = false;
            this.pbCapturaWebCam.Paint += new System.Windows.Forms.PaintEventHandler(this.PbCapturaWebCam_Paint);
            this.pbCapturaWebCam.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbCapturaWebCam_MouseDown);
            this.pbCapturaWebCam.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbCapturaWebCam_MouseMove);
            this.pbCapturaWebCam.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbCapturaWebCam_MouseUp);
            // 
            // btnObterDiferenciador
            // 
            this.btnObterDiferenciador.Location = new System.Drawing.Point(46, 564);
            this.btnObterDiferenciador.Name = "btnObterDiferenciador";
            this.btnObterDiferenciador.Size = new System.Drawing.Size(140, 33);
            this.btnObterDiferenciador.TabIndex = 1;
            this.btnObterDiferenciador.Text = "Obter Direrenciador";
            this.btnObterDiferenciador.UseVisualStyleBackColor = true;
            this.btnObterDiferenciador.Click += new System.EventHandler(this.BtnObterDiferenciador_Click);
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(89, 603);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.ReadOnly = true;
            this.txtBlue.Size = new System.Drawing.Size(97, 20);
            this.txtBlue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Blue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 662);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Red";
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(89, 655);
            this.txtRed.Name = "txtRed";
            this.txtRed.ReadOnly = true;
            this.txtRed.Size = new System.Drawing.Size(97, 20);
            this.txtRed.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 636);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Green";
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(89, 629);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.ReadOnly = true;
            this.txtGreen.Size = new System.Drawing.Size(97, 20);
            this.txtGreen.TabIndex = 6;
            // 
            // nudTempo
            // 
            this.nudTempo.Location = new System.Drawing.Point(327, 441);
            this.nudTempo.Name = "nudTempo";
            this.nudTempo.Size = new System.Drawing.Size(67, 20);
            this.nudTempo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tempo (seg)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Capturas/seg";
            // 
            // nudCapturas
            // 
            this.nudCapturas.Location = new System.Drawing.Point(327, 467);
            this.nudCapturas.Name = "nudCapturas";
            this.nudCapturas.Size = new System.Drawing.Size(67, 20);
            this.nudCapturas.TabIndex = 10;
            // 
            // btnIniciarCapturas
            // 
            this.btnIniciarCapturas.Location = new System.Drawing.Point(400, 441);
            this.btnIniciarCapturas.Name = "btnIniciarCapturas";
            this.btnIniciarCapturas.Size = new System.Drawing.Size(141, 47);
            this.btnIniciarCapturas.TabIndex = 12;
            this.btnIniciarCapturas.Text = "Iniciar";
            this.btnIniciarCapturas.UseVisualStyleBackColor = true;
            this.btnIniciarCapturas.Click += new System.EventHandler(this.BtnIniciarCapturas_Click);
            // 
            // rtxtSinais
            // 
            this.rtxtSinais.Location = new System.Drawing.Point(258, 498);
            this.rtxtSinais.Name = "rtxtSinais";
            this.rtxtSinais.ReadOnly = true;
            this.rtxtSinais.Size = new System.Drawing.Size(283, 177);
            this.rtxtSinais.TabIndex = 13;
            this.rtxtSinais.Text = "";
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(63, 459);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(43, 20);
            this.txtX1.TabIndex = 14;
            this.txtX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(63, 490);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(43, 20);
            this.txtX2.TabIndex = 15;
            this.txtX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(136, 490);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(43, 20);
            this.txtY2.TabIndex = 17;
            this.txtY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(136, 459);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(43, 20);
            this.txtY1.TabIndex = 16;
            this.txtY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "x1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "y2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 465);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "y1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "x2";
            // 
            // btnRetanguloManual
            // 
            this.btnRetanguloManual.Location = new System.Drawing.Point(46, 516);
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
            this.label10.Location = new System.Drawing.Point(43, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Coordenadas da Área Selecionada:";
            // 
            // graficoAnalise
            // 
            this.graficoAnalise.Location = new System.Drawing.Point(616, 12);
            this.graficoAnalise.Name = "graficoAnalise";
            this.graficoAnalise.ScrollGrace = 0D;
            this.graficoAnalise.ScrollMaxX = 0D;
            this.graficoAnalise.ScrollMaxY = 0D;
            this.graficoAnalise.ScrollMaxY2 = 0D;
            this.graficoAnalise.ScrollMinX = 0D;
            this.graficoAnalise.ScrollMinY = 0D;
            this.graficoAnalise.ScrollMinY2 = 0D;
            this.graficoAnalise.Size = new System.Drawing.Size(476, 362);
            this.graficoAnalise.TabIndex = 24;
            this.graficoAnalise.UseExtendedPrintDialog = true;
            // 
            // graficoResultados
            // 
            chartArea1.AxisX.Crossing = 0D;
            chartArea1.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.Title = "Capturas";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.Crossing = 0D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY.Title = "Sinal";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.graficoResultados.ChartAreas.Add(chartArea1);
            this.graficoResultados.Location = new System.Drawing.Point(602, 402);
            this.graficoResultados.Name = "graficoResultados";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.CustomProperties = "LabelStyle=TopLeft";
            series1.IsVisibleInLegend = false;
            series1.MarkerSize = 3;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.graficoResultados.Series.Add(series1);
            this.graficoResultados.Size = new System.Drawing.Size(557, 300);
            this.graficoResultados.TabIndex = 25;
            this.graficoResultados.Text = "chart1";
            // 
            // FormEmguCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 749);
            this.Controls.Add(this.graficoResultados);
            this.Controls.Add(this.graficoAnalise);
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
            this.Controls.Add(this.pbCapturaWebCam);
            this.Name = "FormEmguCV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmguCV_FormClosing);
            this.Load += new System.EventHandler(this.FormEmguCV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCapturaWebCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoResultados)).EndInit();
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
        private ZedGraph.ZedGraphControl graficoAnalise;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoResultados;
    }
}

