namespace Cryptographer
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Encrypt_Click = new System.Windows.Forms.Button();
            this.Decrypt_Click = new System.Windows.Forms.Button();
            this.Folder_Btn_Click = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Folder = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Зашифровать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // Encrypt_Click
            // 
            this.Encrypt_Click.Location = new System.Drawing.Point(168, 272);
            this.Encrypt_Click.Name = "Encrypt_Click";
            this.Encrypt_Click.Size = new System.Drawing.Size(136, 29);
            this.Encrypt_Click.TabIndex = 0;
            this.Encrypt_Click.Text = "Зашифровать";
            this.Encrypt_Click.UseVisualStyleBackColor = true;
            this.Encrypt_Click.Click += new System.EventHandler(this.Encrypt_Click_Click);
            // 
            // Decrypt_Click
            // 
            this.Decrypt_Click.Location = new System.Drawing.Point(410, 272);
            this.Decrypt_Click.Name = "Decrypt_Click";
            this.Decrypt_Click.Size = new System.Drawing.Size(132, 29);
            this.Decrypt_Click.TabIndex = 1;
            this.Decrypt_Click.Text = "Расшифровать";
            this.Decrypt_Click.UseVisualStyleBackColor = true;
            this.Decrypt_Click.Click += new System.EventHandler(this.Decrypt_Click_Click);
            // 
            // Folder_Btn_Click
            // 
            this.Folder_Btn_Click.Location = new System.Drawing.Point(545, 136);
            this.Folder_Btn_Click.Name = "Folder_Btn_Click";
            this.Folder_Btn_Click.Size = new System.Drawing.Size(137, 29);
            this.Folder_Btn_Click.TabIndex = 2;
            this.Folder_Btn_Click.Text = "Выбрать файл";
            this.Folder_Btn_Click.UseVisualStyleBackColor = true;
            this.Folder_Btn_Click.Click += new System.EventHandler(this.Folder_Btn_Click_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Путь к файлу";
            // 
            // Folder
            // 
            this.Folder.Location = new System.Drawing.Point(205, 136);
            this.Folder.Name = "Folder";
            this.Folder.Size = new System.Drawing.Size(309, 27);
            this.Folder.TabIndex = 4;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(711, 427);
            this.Controls.Add(this.Folder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Folder_Btn_Click);
            this.Controls.Add(this.Decrypt_Click);
            this.Controls.Add(this.Encrypt_Click);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Label label1;
        private Button Encrypt_Click;
        private Button Decrypt_Click;
        private Button Folder_Btn_Click;
        private Label label2;
        private TextBox Folder;
    }
}