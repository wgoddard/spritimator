namespace Spritimator_Tao
{
    partial class NewSequence
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
            this.bAcceptSeqName = new System.Windows.Forms.Button();
            this.txtASequenceName = new System.Windows.Forms.TextBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAcceptSeqName
            // 
            this.bAcceptSeqName.Location = new System.Drawing.Point(52, 135);
            this.bAcceptSeqName.Name = "bAcceptSeqName";
            this.bAcceptSeqName.Size = new System.Drawing.Size(64, 25);
            this.bAcceptSeqName.TabIndex = 1;
            this.bAcceptSeqName.Text = "OK";
            this.bAcceptSeqName.UseVisualStyleBackColor = true;
            this.bAcceptSeqName.Click += new System.EventHandler(this.bAcceptSeqName_Click);
            // 
            // txtASequenceName
            // 
            this.txtASequenceName.Location = new System.Drawing.Point(52, 75);
            this.txtASequenceName.Name = "txtASequenceName";
            this.txtASequenceName.Size = new System.Drawing.Size(113, 20);
            this.txtASequenceName.TabIndex = 0;
            this.txtASequenceName.Text = "Sequence Name";
            this.txtASequenceName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtASequenceName_KeyPress);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(136, 135);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(66, 25);
            this.bCancel.TabIndex = 2;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 188);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.txtASequenceName);
            this.Controls.Add(this.bAcceptSeqName);
            this.Name = "Form2";
            this.Text = "Create New Sequence";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAcceptSeqName;
        private System.Windows.Forms.TextBox txtASequenceName;
        private System.Windows.Forms.Button bCancel;
    }
}