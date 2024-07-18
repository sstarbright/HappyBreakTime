namespace HappyBreakTime
{
    partial class BreakOver
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartWorking = new System.Windows.Forms.Button();
            this.btnStopWorking = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::HappyBreakTime.Properties.Resources.Good;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 434);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 86);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nice Break!";
            // 
            // btnStartWorking
            // 
            this.btnStartWorking.Location = new System.Drawing.Point(42, 395);
            this.btnStartWorking.Name = "btnStartWorking";
            this.btnStartWorking.Size = new System.Drawing.Size(185, 58);
            this.btnStartWorking.TabIndex = 3;
            this.btnStartWorking.Text = "Start Timer";
            this.btnStartWorking.UseVisualStyleBackColor = true;
            this.btnStartWorking.Click += new System.EventHandler(this.btnStartWorking_Click);
            // 
            // btnStopWorking
            // 
            this.btnStopWorking.Location = new System.Drawing.Point(251, 395);
            this.btnStopWorking.Name = "btnStopWorking";
            this.btnStopWorking.Size = new System.Drawing.Size(185, 58);
            this.btnStopWorking.TabIndex = 4;
            this.btnStopWorking.Text = "Stop Timer";
            this.btnStopWorking.UseVisualStyleBackColor = true;
            this.btnStopWorking.Click += new System.EventHandler(this.btnStopWorking_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(48, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Don\'t forget to do some stretches!";
            // 
            // BreakOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 481);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStopWorking);
            this.Controls.Add(this.btnStartWorking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(496, 520);
            this.MinimumSize = new System.Drawing.Size(496, 520);
            this.Name = "BreakOver";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YAY!";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BreakOver_FormClosed);
            this.Load += new System.EventHandler(this.BreakOver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnStartWorking;
        private Button btnStopWorking;
        private Label label2;
    }
}