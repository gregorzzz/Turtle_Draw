using System.Drawing;

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
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.command_line = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(473, 55);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(368, 421);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // inputBox
            // 
            this.inputBox.BackColor = System.Drawing.Color.Black;
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputBox.ForeColor = System.Drawing.Color.White;
            this.inputBox.Location = new System.Drawing.Point(33, 55);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(413, 421);
            this.inputBox.TabIndex = 1;
            this.inputBox.Text = "";
            // 
            // command_line
            // 
            this.command_line.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.command_line.BackColor = System.Drawing.SystemColors.WindowText;
            this.command_line.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.command_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.command_line.ForeColor = System.Drawing.Color.White;
            this.command_line.Location = new System.Drawing.Point(33, 523);
            this.command_line.Name = "command_line";
            this.command_line.AutoSize = false;
            this.command_line.Size = new System.Drawing.Size(808, 97);
            this.command_line.TabIndex = 2;
            this.command_line.KeyDown += new System.Windows.Forms.KeyEventHandler(this.command_line_KeyDown);
            // 
            // labelInput
            // 
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelInput.ForeColor = System.Drawing.Color.White;
            this.labelInput.Location = new System.Drawing.Point(189, 9);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(102, 38);
            this.labelInput.TabIndex = 3;
            this.labelInput.Text = "Input";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(589, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(372, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Console";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(34, 622);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(87, 34);
            this.runButton.TabIndex = 6;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(900, 674);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.command_line);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button runButton;

        private System.Windows.Forms.RichTextBox inputBox;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label labelInput;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.PictureBox canvas;

        private System.Windows.Forms.TextBox command_line;

        #endregion
    }
}