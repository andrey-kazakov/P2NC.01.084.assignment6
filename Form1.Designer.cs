namespace assignment6_AndreiKazakov
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
            this.RockButton = new System.Windows.Forms.Button();
            this.ScissorsButton = new System.Windows.Forms.Button();
            this.PaperButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RockButton
            // 
            this.RockButton.Location = new System.Drawing.Point(13, 13);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(75, 60);
            this.RockButton.TabIndex = 0;
            this.RockButton.Text = "Rock";
            this.RockButton.UseVisualStyleBackColor = true;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // ScissorsButton
            // 
            this.ScissorsButton.Location = new System.Drawing.Point(176, 13);
            this.ScissorsButton.Name = "ScissorsButton";
            this.ScissorsButton.Size = new System.Drawing.Size(75, 60);
            this.ScissorsButton.TabIndex = 1;
            this.ScissorsButton.Text = "Scissors";
            this.ScissorsButton.UseVisualStyleBackColor = true;
            this.ScissorsButton.Click += new System.EventHandler(this.ScissorsButton_Click);
            // 
            // PaperButton
            // 
            this.PaperButton.Location = new System.Drawing.Point(94, 12);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(75, 60);
            this.PaperButton.TabIndex = 2;
            this.PaperButton.Text = "Paper";
            this.PaperButton.UseVisualStyleBackColor = true;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 84);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.ScissorsButton);
            this.Controls.Add(this.RockButton);
            this.Name = "Form1";
            this.Text = "assignment6_AndreiKazakov";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.Button ScissorsButton;
        private System.Windows.Forms.Button PaperButton;
    }
}

