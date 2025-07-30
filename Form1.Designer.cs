namespace selenium66
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
            button1 = new Button();
            textBox1 = new TextBox();
            label = new Label();
            label1 = new Label();
            textBoxNoiDungComment = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(506, 283);
            button1.Name = "button1";
            button1.Size = new Size(243, 109);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(251, 53);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(434, 79);
            textBox1.TabIndex = 1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(70, 56);
            label.Name = "label";
            label.Size = new Size(175, 15);
            label.TabIndex = 2;
            label.Text = "Nhập link post fb cần comment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 167);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 3;
            label1.Text = "Nội dung comment";
            // 
            // textBoxNoiDungComment
            // 
            textBoxNoiDungComment.Location = new Point(257, 168);
            textBoxNoiDungComment.Multiline = true;
            textBoxNoiDungComment.Name = "textBoxNoiDungComment";
            textBoxNoiDungComment.Size = new Size(428, 108);
            textBoxNoiDungComment.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 138);
            label2.Name = "label2";
            label2.Size = new Size(399, 15);
            label2.TabIndex = 5;
            label2.Text = "link dạng: https://www.facebook.com/photo.php?fbid=1235704111902406";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBoxNoiDungComment);
            Controls.Add(label1);
            Controls.Add(label);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label;
        private Label label1;
        private TextBox textBoxNoiDungComment;
        private Label label2;
    }
}
