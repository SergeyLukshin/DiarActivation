using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiarActivation
{
    public partial class ActivationForm : Form
    {
        public ActivationForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            byte[] key = ASCIIEncoding.ASCII.GetBytes("DIAR");
            RC4 encoder = new RC4(key);
            byte[] testBytes = ASCIIEncoding.ASCII.GetBytes(teSerialNumber.Text);
            byte[] result2 = encoder.Encode(testBytes, testBytes.Length);
            string encryptedString = encoder.GetByteString(result2);

            teActivationCode.Text = encryptedString;
        }
    }
}
