﻿namespace NewsABGN.UI.User_Controls
{
    partial class WordCloudControl
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
            this.flpWordCloudList = new System.Windows.Forms.FlowLayoutPanel();
            this.lblKeywordTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpWordCloudList
            // 
            this.flpWordCloudList.AutoScroll = true;
            this.flpWordCloudList.BackColor = System.Drawing.Color.Transparent;
            this.flpWordCloudList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpWordCloudList.Font = new System.Drawing.Font("중간안상수체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.flpWordCloudList.Location = new System.Drawing.Point(11, 41);
            this.flpWordCloudList.Name = "flpWordCloudList";
            this.flpWordCloudList.Size = new System.Drawing.Size(268, 272);
            this.flpWordCloudList.TabIndex = 1;
            this.flpWordCloudList.WrapContents = false;
            // 
            // lblKeywordTitle
            // 
            this.lblKeywordTitle.AutoSize = true;
            this.lblKeywordTitle.BackColor = System.Drawing.Color.White;
            this.lblKeywordTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKeywordTitle.Font = new System.Drawing.Font("굵은안상수체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblKeywordTitle.Location = new System.Drawing.Point(0, 0);
            this.lblKeywordTitle.Name = "lblKeywordTitle";
            this.lblKeywordTitle.Padding = new System.Windows.Forms.Padding(6);
            this.lblKeywordTitle.Size = new System.Drawing.Size(183, 36);
            this.lblKeywordTitle.TabIndex = 3;
            this.lblKeywordTitle.Text = "실시간 연관키워드 빈도수";
            // 
            // WordCloudControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblKeywordTitle);
            this.Controls.Add(this.flpWordCloudList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "WordCloudControl";
            this.Size = new System.Drawing.Size(253, 316);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpWordCloudList;
        private System.Windows.Forms.Label lblKeywordTitle;
    }
}
