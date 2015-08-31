using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Spritimator_Tao
{
    public partial class CreateSprite : Form
    {
        string spriteName;

        public string SpriteName { get { return spriteName; } }

        public CreateSprite()
        {
            InitializeComponent();
        }

        private void CreateSprite_Load(object sender, EventArgs e)
        {
            tSpriteName.SelectAll();
        }

        private void bCreateSprite_Click(object sender, EventArgs e)
        {
            spriteName = tSpriteName.Text;
            DialogResult = DialogResult.OK;
        }

        private void bCancelSprite_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void tSpriteName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                spriteName = tSpriteName.Text;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
