namespace autoShooterr
{
    partial class Form1
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
			
            this.components = new System.ComponentModel.Container();
			this.SuspendLayout();

			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1140, 15);
			this.BackColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "";
            this.TopMost = true;
			
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);

			this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

    }
}

