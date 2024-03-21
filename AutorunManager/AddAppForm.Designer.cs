namespace AutorunManager
{
    partial class AddAppForm
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.Location = new Point(40, 40);
            label1.Name = "label1";
            label1.Size = new Size(131, 32);
            label1.TabIndex = 0;
            label1.Text = "App name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(40, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 39);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.MistyRose;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.ForeColor = Color.DarkRed;
            button1.Location = new Point(86, 120);
            button1.Name = "button1";
            button1.Size = new Size(159, 43);
            button1.TabIndex = 2;
            button1.Text = "Add file path";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button2.Location = new Point(40, 210);
            button2.Name = "button2";
            button2.Size = new Size(250, 57);
            button2.TabIndex = 3;
            button2.Text = "Add app to autorun";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // AddAppForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(332, 303);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AddAppForm";
            Text = "AddAppForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}