namespace Traveling_Salesman_Problem
{
    partial class StatCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatCalc));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_edgeInput = new System.Windows.Forms.TextBox();
            this.lbl_instructions = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_mean = new System.Windows.Forms.Label();
            this.lbl_sdsample = new System.Windows.Forms.Label();
            this.lbl_Sdpop = new System.Windows.Forms.Label();
            this.lbl_stats = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Qrange = new System.Windows.Forms.Label();
            this.lbl_outlyer = new System.Windows.Forms.Label();
            this.lbl_max = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(156, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 102);
            this.label1.TabIndex = 0;
            this.label1.Text = "Standard Deviation \r\nCalculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_edgeInput
            // 
            this.txt_edgeInput.BackColor = System.Drawing.SystemColors.Window;
            this.txt_edgeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edgeInput.Location = new System.Drawing.Point(78, 241);
            this.txt_edgeInput.Multiline = true;
            this.txt_edgeInput.Name = "txt_edgeInput";
            this.txt_edgeInput.Size = new System.Drawing.Size(546, 187);
            this.txt_edgeInput.TabIndex = 1;
            // 
            // lbl_instructions
            // 
            this.lbl_instructions.AutoSize = true;
            this.lbl_instructions.BackColor = System.Drawing.Color.Transparent;
            this.lbl_instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_instructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbl_instructions.Location = new System.Drawing.Point(72, 153);
            this.lbl_instructions.Name = "lbl_instructions";
            this.lbl_instructions.Size = new System.Drawing.Size(566, 64);
            this.lbl_instructions.TabIndex = 2;
            this.lbl_instructions.Text = "Enter Data seperated by a space or comma.\r\nFor example: \"56 67 87 87 87 98\".";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(78, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 10);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.Color.Transparent;
            this.btn_calculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_calculate.BackgroundImage")));
            this.btn_calculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_calculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_calculate.FlatAppearance.BorderSize = 0;
            this.btn_calculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_calculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_calculate.Location = new System.Drawing.Point(595, 561);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(205, 86);
            this.btn_calculate.TabIndex = 9;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_mean
            // 
            this.lbl_mean.AutoSize = true;
            this.lbl_mean.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mean.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mean.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_mean.Location = new System.Drawing.Point(72, 534);
            this.lbl_mean.Name = "lbl_mean";
            this.lbl_mean.Size = new System.Drawing.Size(0, 32);
            this.lbl_mean.TabIndex = 10;
            // 
            // lbl_sdsample
            // 
            this.lbl_sdsample.AutoSize = true;
            this.lbl_sdsample.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sdsample.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sdsample.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_sdsample.Location = new System.Drawing.Point(72, 601);
            this.lbl_sdsample.Name = "lbl_sdsample";
            this.lbl_sdsample.Size = new System.Drawing.Size(0, 32);
            this.lbl_sdsample.TabIndex = 11;
            // 
            // lbl_Sdpop
            // 
            this.lbl_Sdpop.AutoSize = true;
            this.lbl_Sdpop.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Sdpop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sdpop.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_Sdpop.Location = new System.Drawing.Point(72, 671);
            this.lbl_Sdpop.Name = "lbl_Sdpop";
            this.lbl_Sdpop.Size = new System.Drawing.Size(0, 32);
            this.lbl_Sdpop.TabIndex = 12;
            // 
            // lbl_stats
            // 
            this.lbl_stats.AutoSize = true;
            this.lbl_stats.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_stats.Location = new System.Drawing.Point(72, 743);
            this.lbl_stats.Name = "lbl_stats";
            this.lbl_stats.Size = new System.Drawing.Size(0, 32);
            this.lbl_stats.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(400, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 14;
            // 
            // lbl_Qrange
            // 
            this.lbl_Qrange.AutoSize = true;
            this.lbl_Qrange.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Qrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qrange.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_Qrange.Location = new System.Drawing.Point(72, 810);
            this.lbl_Qrange.Name = "lbl_Qrange";
            this.lbl_Qrange.Size = new System.Drawing.Size(0, 32);
            this.lbl_Qrange.TabIndex = 15;
            // 
            // lbl_outlyer
            // 
            this.lbl_outlyer.AutoSize = true;
            this.lbl_outlyer.BackColor = System.Drawing.Color.Transparent;
            this.lbl_outlyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outlyer.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_outlyer.Location = new System.Drawing.Point(678, 241);
            this.lbl_outlyer.Name = "lbl_outlyer";
            this.lbl_outlyer.Size = new System.Drawing.Size(0, 32);
            this.lbl_outlyer.TabIndex = 16;
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.BackColor = System.Drawing.Color.Transparent;
            this.lbl_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_max.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_max.Location = new System.Drawing.Point(72, 459);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(0, 32);
            this.lbl_max.TabIndex = 17;
            // 
            // TravelingSalesman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(812, 880);
            this.Controls.Add(this.lbl_max);
            this.Controls.Add(this.lbl_outlyer);
            this.Controls.Add(this.lbl_Qrange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_stats);
            this.Controls.Add(this.lbl_Sdpop);
            this.Controls.Add(this.lbl_sdsample);
            this.Controls.Add(this.lbl_mean);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_instructions);
            this.Controls.Add(this.txt_edgeInput);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TravelingSalesman";
            this.Text = "Standard Deviation Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_edgeInput;
        private System.Windows.Forms.Label lbl_instructions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_mean;
        private System.Windows.Forms.Label lbl_sdsample;
        private System.Windows.Forms.Label lbl_Sdpop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_stats;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Qrange;
        private System.Windows.Forms.Label lbl_outlyer;
        private System.Windows.Forms.Label lbl_max;
    }
}

