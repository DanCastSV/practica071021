
namespace practica071021
{
    partial class fmtest
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
            this.frmTest = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // frmTest
            // 
            this.frmTest.Location = new System.Drawing.Point(319, 177);
            this.frmTest.Name = "frmTest";
            this.frmTest.Size = new System.Drawing.Size(113, 49);
            this.frmTest.TabIndex = 0;
            this.frmTest.Text = "test";
            this.frmTest.UseSelectable = true;
            this.frmTest.Click += new System.EventHandler(this.frmTest_Click);
            // 
            // fmtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frmTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmtest";
            this.Text = "fmtest";
            this.Load += new System.EventHandler(this.fmtest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton frmTest;
    }
}