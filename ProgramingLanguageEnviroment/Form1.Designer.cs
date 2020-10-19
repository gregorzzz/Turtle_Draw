namespace ProgramingLanguageEnviroment
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.command_line = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(473, 31);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(368, 421);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(33, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(413, 421);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // command_line
            // 
            this.command_line.Location = new System.Drawing.Point(32, 482);
            this.command_line.Name = "command_line";
            this.command_line.Size = new System.Drawing.Size(808, 20);
            this.command_line.TabIndex = 2;
            this.command_line.KeyDown += new System.Windows.Forms.KeyEventHandler(this.command_line_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.command_line);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox canvas;

        private System.Windows.Forms.TextBox command_line;

        private System.Windows.Forms.RichTextBox richTextBox1;

        #endregion
    }
}