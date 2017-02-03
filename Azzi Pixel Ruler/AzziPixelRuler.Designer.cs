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
            this.ContextoLabelMarcador = new System.Windows.Forms.PictureBox();
            this.LinhaMarcador = new System.Windows.Forms.Panel();
            this.LabelMarcador = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContextoLabelMarcador)).BeginInit();
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
            // ContextoLabelMarcador
            // 
            this.ContextoLabelMarcador.BackColor = System.Drawing.Color.Transparent;
            this.ContextoLabelMarcador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ContextoLabelMarcador.BackgroundImage")));
            this.ContextoLabelMarcador.Location = new System.Drawing.Point(13, 49);
            this.ContextoLabelMarcador.Name = "ContextoLabelMarcador";
            this.ContextoLabelMarcador.Size = new System.Drawing.Size(21, 14);
            this.ContextoLabelMarcador.TabIndex = 4;
            this.ContextoLabelMarcador.TabStop = false;
            this.ContextoLabelMarcador.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AzziPixelRuler_MouseClick);
            this.ContextoLabelMarcador.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Offset_MouseDown);
            // 
            // LinhaMarcador
            // 
            this.LinhaMarcador.BackColor = System.Drawing.Color.White;
            this.LinhaMarcador.Location = new System.Drawing.Point(0, 56);
            this.LinhaMarcador.Name = "LinhaMarcador";
            this.LinhaMarcador.Size = new System.Drawing.Size(60, 1);
            this.LinhaMarcador.TabIndex = 5;
            this.LinhaMarcador.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AzziPixelRuler_MouseClick);
            this.LinhaMarcador.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Offset_MouseDown);
            // 
            // LabelMarcador
            // 
            this.LabelMarcador.AutoSize = true;
            this.LabelMarcador.BackColor = System.Drawing.Color.White;
            this.LabelMarcador.Font = new System.Drawing.Font("Arial", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMarcador.Location = new System.Drawing.Point(15, 53);
            this.LabelMarcador.Name = "LabelMarcador";
            this.LabelMarcador.Size = new System.Drawing.Size(16, 7);
            this.LabelMarcador.TabIndex = 6;
            this.LabelMarcador.Text = "100";
            this.LabelMarcador.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AzziPixelRuler_MouseClick);
            this.LabelMarcador.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Offset_MouseDown);
            // 
            // AzziPixelRuler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(156, 152);
            this.Controls.Add(this.LabelMarcador);
            this.Controls.Add(this.ContextoLabelMarcador);
            this.Controls.Add(this.LinhaMarcador);
            this.Controls.Add(this.VerticalBackground);
            this.Controls.Add(this.HorizontalBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AzziPixelRuler";
            this.Text = "AzziPixelRule";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AzziPixelRuler_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AzziPixelRuler_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.HorizontalBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VerticalBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContextoLabelMarcador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MouseMovementListener;
        private System.Windows.Forms.PictureBox HorizontalBackground;
        private System.Windows.Forms.PictureBox VerticalBackground;
        private System.Windows.Forms.PictureBox ContextoLabelMarcador;
        private System.Windows.Forms.Panel LinhaMarcador;
        private System.Windows.Forms.Label LabelMarcador;
    }
}

