
namespace ProjektZaliczeniowy
{
    partial class ZakupyZrealizowaneForm
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
            this.TimerOk = new System.Windows.Forms.Timer(this.components);
            this.TimerBad = new System.Windows.Forms.Timer(this.components);
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimerOk
            // 
            this.TimerOk.Interval = 20;
            this.TimerOk.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TimerBad
            // 
            this.TimerBad.Enabled = true;
            this.TimerBad.Interval = 20;
            this.TimerBad.Tick += new System.EventHandler(this.TimerBad_Tick);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InfoLabel.ForeColor = System.Drawing.Color.Red;
            this.InfoLabel.Location = new System.Drawing.Point(12, 320);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(51, 16);
            this.InfoLabel.TabIndex = 0;
            this.InfoLabel.Text = "label1";
            this.InfoLabel.Visible = false;
            // 
            // ZakupyZrealizowaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 388);
            this.Controls.Add(this.InfoLabel);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(406, 427);
            this.MinimumSize = new System.Drawing.Size(406, 427);
            this.Name = "ZakupyZrealizowaneForm";
            this.Text = "ZakupyZrealizowane";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Timer TimerBad;
        public System.Windows.Forms.Timer TimerOk;
        public System.Windows.Forms.Label InfoLabel;
    }
}