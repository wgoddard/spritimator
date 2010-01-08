namespace Spritimator_Tao
{
    partial class EditSequence
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
            this.lName = new System.Windows.Forms.Label();
            this.bApply = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.tName = new System.Windows.Forms.TextBox();
            this.lTime = new System.Windows.Forms.Label();
            this.tTime = new System.Windows.Forms.TextBox();
            this.cApplyTime = new System.Windows.Forms.CheckBox();
            this.bClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tReturnLoopFrame = new System.Windows.Forms.TextBox();
            this.cLoops = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(29, 22);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(38, 13);
            this.lName.TabIndex = 0;
            this.lName.Text = "Name:";
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(19, 210);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(80, 24);
            this.bApply.TabIndex = 1;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(116, 210);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(80, 24);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(86, 20);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(99, 20);
            this.tName.TabIndex = 3;
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Location = new System.Drawing.Point(16, 79);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(96, 13);
            this.lTime.TabIndex = 4;
            this.lTime.Text = "Batch Frame Time:";
            // 
            // tTime
            // 
            this.tTime.Location = new System.Drawing.Point(186, 76);
            this.tTime.Name = "tTime";
            this.tTime.Size = new System.Drawing.Size(68, 20);
            this.tTime.TabIndex = 6;
            // 
            // cApplyTime
            // 
            this.cApplyTime.AutoSize = true;
            this.cApplyTime.Location = new System.Drawing.Point(281, 79);
            this.cApplyTime.Name = "cApplyTime";
            this.cApplyTime.Size = new System.Drawing.Size(52, 17);
            this.cApplyTime.TabIndex = 7;
            this.cApplyTime.Text = "Apply";
            this.cApplyTime.UseVisualStyleBackColor = true;
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(215, 210);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(77, 24);
            this.bClear.TabIndex = 8;
            this.bClear.Text = "Clear All";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Returning Loop Start Frame: ";
            // 
            // tReturnLoopFrame
            // 
            this.tReturnLoopFrame.Location = new System.Drawing.Point(186, 114);
            this.tReturnLoopFrame.Name = "tReturnLoopFrame";
            this.tReturnLoopFrame.Size = new System.Drawing.Size(68, 20);
            this.tReturnLoopFrame.TabIndex = 10;
            // 
            // cLoops
            // 
            this.cLoops.AutoSize = true;
            this.cLoops.Location = new System.Drawing.Point(19, 172);
            this.cLoops.Name = "cLoops";
            this.cLoops.Size = new System.Drawing.Size(55, 17);
            this.cLoops.TabIndex = 11;
            this.cLoops.Text = "Loops";
            this.cLoops.UseVisualStyleBackColor = true;
            // 
            // EditSequence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 262);
            this.Controls.Add(this.cLoops);
            this.Controls.Add(this.tReturnLoopFrame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.cApplyTime);
            this.Controls.Add(this.tTime);
            this.Controls.Add(this.lTime);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.lName);
            this.Name = "EditSequence";
            this.Text = "Edit Sequence";
            this.Load += new System.EventHandler(this.EditSequence_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.TextBox tTime;
        private System.Windows.Forms.CheckBox cApplyTime;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tReturnLoopFrame;
        private System.Windows.Forms.CheckBox cLoops;
    }
}