namespace Azzi_Pixel_Ruler
{
    partial class AzziPixelRuler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AzziPixelRuler));
            this.MouseMovementListener = new System.Windows.Forms.Timer(this.components);
            this.HorizontalBackground = new System.Windows.Forms.PictureBox();
            this.VerticalBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // MouseMovementListener
            // 
            this.MouseMovementListener.Enabled = true;
            this.MouseMovementListener.Interval = 50;
            this.MouseMovementListener.Tick += new System.EventHandler(this.MouseMovementListener_Tick);
            // 
            // HorizontalBackground
            // 
            this.HorizontalBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HorizontalBackground.BackgroundImage")));
            this.HorizontalBackground.InitialImage = null;
            this.HorizontalBackground.Location = new System.Drawing.Point(15, 30);
            this.HorizontalBackground.Name = "HorizontalBackground";
            this.HorizontalBackground.Size = new System.Drawing.Size(265, 32);
            this.HorizontalBackground.TabIndex = 0;
            this.HorizontalBackground.TabStop = false;
            this.HorizontalBackground.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AzziPixelRuler_MouseClick);
            this.HorizontalBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Offset_MouseDown);
            // 
            // VerticalBackground
            // 
            this.VerticalBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VerticalBackground.BackgroundImage")));
            this.VerticalBackground.InitialImage = null;
            this.VerticalBackground.Location = new System.Drawing.Point(30, 16);
            this.VerticalBackground.Name = "VerticalBackground";
            this.VerticalBackground.Size = new System.Drawing.Size(33, 213);
            this.VerticalBackground.TabIndex = 1;
            this.VerticalBackground.TabStop = false;
            this.VerticalBackground.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AzziPixelRuler_MouseClick);
            this.VerticalBackground.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Offset_MouseDown);
            // 
            // AzziPixelRuler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(60, 60);
            this.Controls.Add(this.VerticalBackground);
            this.Controls.Add(this.HorizontalBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AzziPixelRuler";
            this.Text = "AzziPixelRule";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AzziPixelRuler_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AzziPixelRuler_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer MouseMovementListener;
        private System.Windows.Forms.PictureBox HorizontalBackground;
        private System.Windows.Forms.PictureBox VerticalBackground;
    }
}

