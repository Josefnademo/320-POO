namespace Drones
{
    partial class AirSpace
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ticker = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ticker
            // 
            ticker.Enabled = true;
            ticker.Interval = 10;
            ticker.Tick += NewFrame;
            // 
            // AirSpace
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1904, 1041);
            Name = "AirSpace";
            Text = "AirSpace";
            Load += AirSpace_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer ticker;
    }
}