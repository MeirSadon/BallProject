namespace BallProject__10._07___WinForm____UIThread
{
    partial class Form1
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
            this.CreateBallBtn = new System.Windows.Forms.Button();
            this.RemoveBallsBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateBallBtn
            // 
            this.CreateBallBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CreateBallBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateBallBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CreateBallBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.CreateBallBtn.Location = new System.Drawing.Point(0, 0);
            this.CreateBallBtn.Name = "CreateBallBtn";
            this.CreateBallBtn.Size = new System.Drawing.Size(403, 43);
            this.CreateBallBtn.TabIndex = 0;
            this.CreateBallBtn.Text = "Create Ball";
            this.CreateBallBtn.UseVisualStyleBackColor = false;
            this.CreateBallBtn.Click += new System.EventHandler(this.AddBallBtn_Click);
            // 
            // RemoveBallsBtn
            // 
            this.RemoveBallsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveBallsBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RemoveBallsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveBallsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.RemoveBallsBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RemoveBallsBtn.Location = new System.Drawing.Point(398, 0);
            this.RemoveBallsBtn.Name = "RemoveBallsBtn";
            this.RemoveBallsBtn.Size = new System.Drawing.Size(402, 43);
            this.RemoveBallsBtn.TabIndex = 2;
            this.RemoveBallsBtn.Text = "Remove Ball";
            this.RemoveBallsBtn.UseVisualStyleBackColor = false;
            this.RemoveBallsBtn.Click += new System.EventHandler(this.RemoveBallsImg_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StartBtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.StartBtn.Location = new System.Drawing.Point(0, 0);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(0);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(800, 451);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start !";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.RemoveBallsBtn);
            this.Controls.Add(this.CreateBallBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateBallBtn;
        private System.Windows.Forms.Button RemoveBallsBtn;
        private System.Windows.Forms.Button StartBtn;
    }
}

