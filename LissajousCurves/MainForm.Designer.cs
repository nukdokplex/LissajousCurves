namespace LissajousCurves
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deltaBetaInput = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.deltaAlphaInput = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.deltaDeltaInput = new System.Windows.Forms.NumericUpDown();
            this.deltaInput = new System.Windows.Forms.NumericUpDown();
            this.deltaTInput = new System.Windows.Forms.NumericUpDown();
            this.betaInput = new System.Windows.Forms.NumericUpDown();
            this.alphaInput = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.glControl = new OpenTK.GLControl();
            this.glTimer = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.viewPortSizeLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deltaBetaInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaAlphaInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaDeltaInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaTInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaInput)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.viewPortSizeLabel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.deltaBetaInput);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.deltaAlphaInput);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.deltaDeltaInput);
            this.panel1.Controls.Add(this.deltaInput);
            this.panel1.Controls.Add(this.deltaTInput);
            this.panel1.Controls.Add(this.betaInput);
            this.panel1.Controls.Add(this.alphaInput);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 360);
            this.panel1.TabIndex = 0;
            // 
            // deltaBetaInput
            // 
            this.deltaBetaInput.DecimalPlaces = 5;
            this.deltaBetaInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.deltaBetaInput.Location = new System.Drawing.Point(42, 90);
            this.deltaBetaInput.Name = "deltaBetaInput";
            this.deltaBetaInput.Size = new System.Drawing.Size(140, 20);
            this.deltaBetaInput.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Δβ:";
            // 
            // deltaAlphaInput
            // 
            this.deltaAlphaInput.DecimalPlaces = 5;
            this.deltaAlphaInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.deltaAlphaInput.Location = new System.Drawing.Point(42, 38);
            this.deltaAlphaInput.Name = "deltaAlphaInput";
            this.deltaAlphaInput.Size = new System.Drawing.Size(140, 20);
            this.deltaAlphaInput.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Δα:";
            // 
            // deltaDeltaInput
            // 
            this.deltaDeltaInput.DecimalPlaces = 5;
            this.deltaDeltaInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.deltaDeltaInput.Location = new System.Drawing.Point(42, 168);
            this.deltaDeltaInput.Name = "deltaDeltaInput";
            this.deltaDeltaInput.Size = new System.Drawing.Size(140, 20);
            this.deltaDeltaInput.TabIndex = 14;
            // 
            // deltaInput
            // 
            this.deltaInput.DecimalPlaces = 5;
            this.deltaInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.deltaInput.Location = new System.Drawing.Point(42, 142);
            this.deltaInput.Name = "deltaInput";
            this.deltaInput.Size = new System.Drawing.Size(140, 20);
            this.deltaInput.TabIndex = 13;
            // 
            // deltaTInput
            // 
            this.deltaTInput.DecimalPlaces = 2;
            this.deltaTInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.deltaTInput.Location = new System.Drawing.Point(42, 116);
            this.deltaTInput.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.deltaTInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.deltaTInput.Name = "deltaTInput";
            this.deltaTInput.Size = new System.Drawing.Size(140, 20);
            this.deltaTInput.TabIndex = 12;
            this.deltaTInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // betaInput
            // 
            this.betaInput.DecimalPlaces = 5;
            this.betaInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.betaInput.Location = new System.Drawing.Point(42, 64);
            this.betaInput.Name = "betaInput";
            this.betaInput.Size = new System.Drawing.Size(140, 20);
            this.betaInput.TabIndex = 11;
            this.betaInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // alphaInput
            // 
            this.alphaInput.DecimalPlaces = 5;
            this.alphaInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.alphaInput.Location = new System.Drawing.Point(42, 12);
            this.alphaInput.Name = "alphaInput";
            this.alphaInput.Size = new System.Drawing.Size(140, 20);
            this.alphaInput.TabIndex = 10;
            this.alphaInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Δδ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "δ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Δt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "β:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "α:";
            // 
            // glControl
            // 
            this.glControl.BackColor = System.Drawing.Color.Black;
            this.glControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.glControl.Location = new System.Drawing.Point(188, 0);
            this.glControl.Name = "glControl";
            this.glControl.Size = new System.Drawing.Size(394, 360);
            this.glControl.TabIndex = 1;
            this.glControl.VSync = true;
            this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_Paint);
            this.glControl.Resize += new System.EventHandler(this.glControl_Resize);
            // 
            // glTimer
            // 
            this.glTimer.Enabled = true;
            this.glTimer.Interval = 16;
            this.glTimer.Tick += new System.EventHandler(this.glTimer_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Viewport: ";
            // 
            // viewPortSizeLabel
            // 
            this.viewPortSizeLabel.AutoSize = true;
            this.viewPortSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewPortSizeLabel.Location = new System.Drawing.Point(71, 191);
            this.viewPortSizeLabel.Name = "viewPortSizeLabel";
            this.viewPortSizeLabel.Size = new System.Drawing.Size(0, 20);
            this.viewPortSizeLabel.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 360);
            this.Controls.Add(this.glControl);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Lissajous Curves";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deltaBetaInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaAlphaInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaDeltaInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaTInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private OpenTK.GLControl glControl;
        private System.Windows.Forms.Timer glTimer;
        private System.Windows.Forms.NumericUpDown deltaDeltaInput;
        private System.Windows.Forms.NumericUpDown deltaInput;
        private System.Windows.Forms.NumericUpDown deltaTInput;
        private System.Windows.Forms.NumericUpDown betaInput;
        private System.Windows.Forms.NumericUpDown alphaInput;
        private System.Windows.Forms.NumericUpDown deltaBetaInput;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown deltaAlphaInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label viewPortSizeLabel;
        private System.Windows.Forms.Label label8;
    }
}

