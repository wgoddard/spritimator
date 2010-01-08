namespace Spritimator_Tao
{
    partial class CreateSprite
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
            this.tSpriteName = new System.Windows.Forms.TextBox();
            this.bCreateSprite = new System.Windows.Forms.Button();
            this.bCancelSprite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tSpriteName
            // 
            this.tSpriteName.Location = new System.Drawing.Point(35, 61);
            this.tSpriteName.Name = "tSpriteName";
            this.tSpriteName.Size = new System.Drawing.Size(114, 20);
            this.tSpriteName.TabIndex = 0;
            this.tSpriteName.Text = "Sprite Name";
            this.tSpriteName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tSpriteName_KeyPress);
            // 
            // bCreateSprite
            // 
            this.bCreateSprite.Location = new System.Drawing.Point(35, 103);
            this.bCreateSprite.Name = "bCreateSprite";
            this.bCreateSprite.Size = new System.Drawing.Size(73, 23);
            this.bCreateSprite.TabIndex = 1;
            this.bCreateSprite.Text = "Create";
            this.bCreateSprite.UseVisualStyleBackColor = true;
            this.bCreateSprite.Click += new System.EventHandler(this.bCreateSprite_Click);
            // 
            // bCancelSprite
            // 
            this.bCancelSprite.Location = new System.Drawing.Point(118, 103);
            this.bCancelSprite.Name = "bCancelSprite";
            this.bCancelSprite.Size = new System.Drawing.Size(64, 23);
            this.bCancelSprite.TabIndex = 2;
            this.bCancelSprite.Text = "Cancel";
            this.bCancelSprite.UseVisualStyleBackColor = true;
            this.bCancelSprite.Click += new System.EventHandler(this.bCancelSprite_Click);
            // 
            // CreateSprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bCancelSprite);
            this.Controls.Add(this.bCreateSprite);
            this.Controls.Add(this.tSpriteName);
            this.Name = "CreateSprite";
            this.Text = "Create Sprite";
            this.Load += new System.EventHandler(this.CreateSprite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tSpriteName;
        private System.Windows.Forms.Button bCreateSprite;
        private System.Windows.Forms.Button bCancelSprite;
    }
}