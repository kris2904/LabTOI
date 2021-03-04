namespace KristinaIlina17102
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_graf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox_Wavelet = new System.Windows.Forms.PictureBox();
            this.button_WAVE_Wavelet = new System.Windows.Forms.Button();
            this.button_function = new System.Windows.Forms.Button();
            this.button_Sombrero = new System.Windows.Forms.Button();
            this.button_Converting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_graf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Wavelet)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_graf
            // 
            this.chart_graf.BackColor = System.Drawing.Color.Transparent;
            this.chart_graf.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chart_graf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart_graf.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DashedDownwardDiagonal;
            this.chart_graf.BackImageTransparentColor = System.Drawing.Color.LightYellow;
            this.chart_graf.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart_graf.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart_graf.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_graf.Legends.Add(legend2);
            this.chart_graf.Location = new System.Drawing.Point(23, 12);
            this.chart_graf.Name = "chart_graf";
            this.chart_graf.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart_graf.Series.Add(series2);
            this.chart_graf.Size = new System.Drawing.Size(442, 371);
            this.chart_graf.TabIndex = 0;
            this.chart_graf.Text = "chart_graf";
            // 
            // pictureBox_Wavelet
            // 
            this.pictureBox_Wavelet.Location = new System.Drawing.Point(471, 76);
            this.pictureBox_Wavelet.Name = "pictureBox_Wavelet";
            this.pictureBox_Wavelet.Size = new System.Drawing.Size(178, 162);
            this.pictureBox_Wavelet.TabIndex = 1;
            this.pictureBox_Wavelet.TabStop = false;
            // 
            // button_WAVE_Wavelet
            // 
            this.button_WAVE_Wavelet.Location = new System.Drawing.Point(23, 399);
            this.button_WAVE_Wavelet.Name = "button_WAVE_Wavelet";
            this.button_WAVE_Wavelet.Size = new System.Drawing.Size(109, 50);
            this.button_WAVE_Wavelet.TabIndex = 2;
            this.button_WAVE_Wavelet.Text = "WAVE-вейвлета";
            this.button_WAVE_Wavelet.UseVisualStyleBackColor = true;
            this.button_WAVE_Wavelet.Click += new System.EventHandler(this.button_WAVE_Wavelet_Click);
            // 
            // button_function
            // 
            this.button_function.Location = new System.Drawing.Point(267, 399);
            this.button_function.Name = "button_function";
            this.button_function.Size = new System.Drawing.Size(105, 50);
            this.button_function.TabIndex = 3;
            this.button_function.Text = "Исходная функция";
            this.button_function.UseVisualStyleBackColor = true;
            this.button_function.Click += new System.EventHandler(this.button_function_Click);
            // 
            // button_Sombrero
            // 
            this.button_Sombrero.Location = new System.Drawing.Point(156, 399);
            this.button_Sombrero.Name = "button_Sombrero";
            this.button_Sombrero.Size = new System.Drawing.Size(95, 50);
            this.button_Sombrero.TabIndex = 4;
            this.button_Sombrero.Text = "Сомбреро";
            this.button_Sombrero.UseVisualStyleBackColor = true;
            this.button_Sombrero.Click += new System.EventHandler(this.button_Sombrero_Click);
            // 
            // button_Converting
            // 
            this.button_Converting.Location = new System.Drawing.Point(504, 279);
            this.button_Converting.Name = "button_Converting";
            this.button_Converting.Size = new System.Drawing.Size(128, 61);
            this.button_Converting.TabIndex = 5;
            this.button_Converting.Text = " Результат вейвлет-преобразования ";
            this.button_Converting.UseVisualStyleBackColor = true;
            this.button_Converting.Click += new System.EventHandler(this.button_Converting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 476);
            this.Controls.Add(this.button_Converting);
            this.Controls.Add(this.button_Sombrero);
            this.Controls.Add(this.button_function);
            this.Controls.Add(this.button_WAVE_Wavelet);
            this.Controls.Add(this.pictureBox_Wavelet);
            this.Controls.Add(this.chart_graf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_graf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Wavelet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_graf;
        private System.Windows.Forms.PictureBox pictureBox_Wavelet;
        private System.Windows.Forms.Button button_WAVE_Wavelet;
        private System.Windows.Forms.Button button_function;
        private System.Windows.Forms.Button button_Sombrero;
        private System.Windows.Forms.Button button_Converting;
    }
}

