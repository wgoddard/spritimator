using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Spritimator_Tao
{
    partial class EditSequence : Form
    {
        private AnimSequence sequence = null;

        public EditSequence(AnimSequence seq)
        {
            if (seq == null) { DialogResult = DialogResult.Abort; }
            sequence = seq;
            InitializeComponent();
        }

        private void EditSequence_Load(object sender, EventArgs e)
        {
            tName.Text = sequence.Name;
            tReturnLoopFrame.Text = sequence.ReturnLoopFrame.ToString();
            cLoops.Checked = sequence.Loops;

            //sequence.
        }

        public AnimSequence Sequence
        {
            get { return sequence; }
            set { sequence = value; }
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            sequence.Name = tName.Text;
            int frameLoop = int.Parse(tReturnLoopFrame.Text);
            if (frameLoop < sequence.FrameCount)
                sequence.ReturnLoopFrame = frameLoop;
            sequence.Loops = cLoops.Checked;

            if (cApplyTime.Checked == true)
            {
                double time = double.Parse(tTime.Text);
                foreach (Frame frame in sequence.Frames)
                {
                    frame.Time = time;
                }
            }

            DialogResult = DialogResult.OK;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to purge the sequence?", "Confirm Erasure",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes)
            {
                sequence.Frames.Clear();
                DialogResult = DialogResult.OK;
            }
        }

    }
}
