namespace Target
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
            tabControl = new TabControl();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(49, 107);
            button1.Name = "button1";
            button1.Size = new Size(90, 34);
            button1.TabIndex = 0;
            button1.Text = "Exercicio 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tabControl
            // 
            tabControl.Location = new Point(227, -2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(855, 453);
            tabControl.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(49, 175);
            button2.Name = "button2";
            button2.Size = new Size(90, 34);
            button2.TabIndex = 2;
            button2.Text = "Exercicio 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(49, 240);
            button3.Name = "button3";
            button3.Size = new Size(90, 34);
            button3.TabIndex = 3;
            button3.Text = "Exercicio 3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(tabControl);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private TabControl tabControl;
        private Button button2;
        private Button button3;
    }
}
