namespace HappyBreakTime
{
    partial class LockWarning
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
            this.components = new System.ComponentModel.Container();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnStartBreak = new System.Windows.Forms.Button();
            this.lblLockDisplay = new System.Windows.Forms.Label();
            this.tmrStartBreak = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(12, 90);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(776, 264);
            this.txtNotes.TabIndex = 0;
            // 
            // btnStartBreak
            // 
            this.btnStartBreak.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStartBreak.Location = new System.Drawing.Point(328, 360);
            this.btnStartBreak.Name = "btnStartBreak";
            this.btnStartBreak.Size = new System.Drawing.Size(135, 53);
            this.btnStartBreak.TabIndex = 1;
            this.btnStartBreak.Text = "Start Break";
            this.btnStartBreak.UseVisualStyleBackColor = true;
            this.btnStartBreak.Click += new System.EventHandler(this.btnStartBreak_Click);
            // 
            // lblLockDisplay
            // 
            this.lblLockDisplay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLockDisplay.AutoSize = true;
            this.lblLockDisplay.BackColor = System.Drawing.Color.White;
            this.lblLockDisplay.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLockDisplay.Location = new System.Drawing.Point(268, 24);
            this.lblLockDisplay.MaximumSize = new System.Drawing.Size(242, 46);
            this.lblLockDisplay.MinimumSize = new System.Drawing.Size(242, 46);
            this.lblLockDisplay.Name = "lblLockDisplay";
            this.lblLockDisplay.Size = new System.Drawing.Size(242, 46);
            this.lblLockDisplay.TabIndex = 2;
            this.lblLockDisplay.Text = "Locking in 5:00";
            // 
            // tmrStartBreak
            // 
            this.tmrStartBreak.Enabled = true;
            this.tmrStartBreak.Interval = 1000;
            this.tmrStartBreak.Tick += new System.EventHandler(this.tmrStartBreak_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notes";
            // 
            // LockWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLockDisplay);
            this.Controls.Add(this.btnStartBreak);
            this.Controls.Add(this.txtNotes);
            this.MinimumSize = new System.Drawing.Size(816, 464);
            this.Name = "LockWarning";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Warning!";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LockWarning_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtNotes;
        private Button btnStartBreak;
        private Label lblLockDisplay;
        private System.Windows.Forms.Timer tmrStartBreak;
        private Label label1;
    }
}