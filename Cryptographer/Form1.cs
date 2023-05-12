using System;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace Cryptographer
{
    public partial class Form1 : Form
    {
        AES aes = new AES();
        public Form1()
        {
            InitializeComponent();
        }

        private void Folder_Btn_Click_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();
            OD.Filter = "All files(*.*) | *.*| Text files(*.txt)|*.txt| C#(*.cs)|*.cs| Picture(*.jpg)|*.jpg| Picture(*.png)|*.png";
            OD.FileName = "";
            if (OD.ShowDialog() == DialogResult.OK)
            {
                Folder.Text = OD.FileName;
            }
        }

        private void Encrypt_Click_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] x;
                x = aes.Encrypt(Folder.Text);
                MessageBox.Show("Файл зашифрован. Сохраните файл!");
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "All files(*.*) | *.*| Text files(*.txt)|*.txt| C#(*.cs)|*.cs| Picture(*.jpg)|*.jpg| Picture(*.png)|*.png";
                if (save.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = save.FileName;
                File.WriteAllBytes(filename, x);
                MessageBox.Show("Файл сохранен");
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Decrypt_Click_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] y;
                y = aes.Decrypt(Folder.Text);
                MessageBox.Show("Файл расшифрован. Сохраните файл!");
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "All files(*.*) | *.*| Text files(*.txt)|*.txt| C#(*.cs)|*.cs| Picture(*.jpg)|*.jpg| Picture(*.png)|*.png";
                if (save.ShowDialog() == DialogResult.Cancel)
                    return;
                string filename = save.FileName;
                File.WriteAllBytes(filename, y);
                MessageBox.Show("Файл сохранен");
                GC.Collect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}