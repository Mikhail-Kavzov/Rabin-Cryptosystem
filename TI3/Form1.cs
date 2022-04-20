using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.IO;
using System.Threading;
namespace TI3
{
    public partial class FormRabin : Form
    {
        public FormRabin()
        {
            InitializeComponent();
            Directory.SetCurrentDirectory(@"../../../"); //по умолчанию текущая директория совпадает с расположением исполняемого файла

        }
       
        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox[] TBox = { resultTextBox, SourceTextBox, NTextBox};
                foreach (var Tb in TBox)
                    Tb.Text = "";

                openFileDlg.Filter = "All files(*.*)|*.*";
                if (openFileDlg.ShowDialog() == DialogResult.OK)
                {
                   
                    Rabin.Encrypt(PTextBox.Text, QTextBox.Text, BTextBox.Text, openFileDlg.FileName, TBox);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox[] TBox = { resultTextBox, SourceTextBox, NTextBox };
                foreach (var Tb in TBox)
                    Tb.Text = "";
                openFileDlg.Filter = "Rabin files(*.rbn)|*.rbn";
                if (openFileDlg.ShowDialog() == DialogResult.OK)
                {
                    Rabin.Decrypt(PTextBox.Text, QTextBox.Text, BTextBox.Text, openFileDlg.FileName, TBox);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
