namespace NewsABGN.UI.User_Controls
{
    partial class UserKeywordControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUserKeyword = new System.Windows.Forms.Label();
            this.lblRemoveKeyword = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserKeyword
            // 
            this.lblUserKeyword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUserKeyword.Font = new System.Drawing.Font("가는안상수체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUserKeyword.Location = new System.Drawing.Point(0, 7);
            this.lblUserKeyword.Name = "lblUserKeyword";
            this.lblUserKeyword.Size = new System.Drawing.Size(168, 25);
            this.lblUserKeyword.TabIndex = 0;
            this.lblUserKeyword.Text = "user Keyword 1";
            this.lblUserKeyword.Click += new System.EventHandler(this.LblUserKeyword_Click);
            // 
            // lblRemoveKeyword
            // 
            this.lblRemoveKeyword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRemoveKeyword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRemoveKeyword.Font = new System.Drawing.Font("굵은안상수체", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRemoveKeyword.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRemoveKeyword.Location = new System.Drawing.Point(211, 0);
            this.lblRemoveKeyword.Margin = new System.Windows.Forms.Padding(0);
            this.lblRemoveKeyword.Name = "lblRemoveKeyword";
            this.lblRemoveKeyword.Size = new System.Drawing.Size(38, 37);
            this.lblRemoveKeyword.TabIndex = 1;
            this.lblRemoveKeyword.Text = "X";
            this.lblRemoveKeyword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRemoveKeyword.Click += new System.EventHandler(this.LblRemoveKeyword_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::NewsABGN.UI.Properties.Resources.keyword;
            this.pictureBox1.Location = new System.Drawing.Point(171, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.LblWordFrequency_Click);
            // 
            // UserKeywordControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRemoveKeyword);
            this.Controls.Add(this.lblUserKeyword);
            this.MinimumSize = new System.Drawing.Size(190, 0);
            this.Name = "UserKeywordControl";
            this.Size = new System.Drawing.Size(252, 39);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserKeyword;
        private System.Windows.Forms.Label lblRemoveKeyword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
