using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Spritimator_Tao
{
    public partial class Form2 : Form
    {
        public string SequenceName;

        public Form2()
        {
            InitializeComponent();
        }

        private void bAcceptSeqName_Click(object sender, EventArgs e)
        {
            Accept();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtASequenceName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                Accept();
            //MessageBox.Show(((int)e.KeyChar).ToString());
        }

        private void Accept()
        {
            SequenceName = txtASequenceName.Text;
            DialogResult = DialogResult.OK;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtASequenceName.SelectAll();
            txtASequenceName.Focus();
        }
    }
}
