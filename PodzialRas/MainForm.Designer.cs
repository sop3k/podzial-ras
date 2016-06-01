namespace PodzialRas
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.folderPath = new System.Windows.Forms.TextBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Przeglądaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(12, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(557, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "SORTUJ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // folderPath
            // 
            this.folderPath.Location = new System.Drawing.Point(12, 31);
            this.folderPath.Name = "folderPath";
            this.folderPath.Size = new System.Drawing.Size(463, 20);
            this.folderPath.TabIndex = 2;
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(12, 146);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(557, 23);
            this.progress.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 181);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.folderPath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "PodziałRas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox folderPath;
        private System.Windows.Forms.ProgressBar progress;
    }
}

