namespace DesignPatterns
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSingleton = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSingleton
            // 
            this.btnSingleton.Location = new System.Drawing.Point(606, 79);
            this.btnSingleton.Name = "btnSingleton";
            this.btnSingleton.Size = new System.Drawing.Size(110, 42);
            this.btnSingleton.TabIndex = 0;
            this.btnSingleton.Text = "Singleton";
            this.btnSingleton.UseVisualStyleBackColor = true;
            this.btnSingleton.Click += new System.EventHandler(this.btnSingleton_Click);
            // 
            // btnMore
            // 
            this.btnMore.Location = new System.Drawing.Point(606, 164);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(110, 42);
            this.btnMore.TabIndex = 0;
            this.btnMore.Text = "abc";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.btnSingleton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSingleton;
        private Button btnMore;
    }
}