namespace GuideWire
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
            this.ballPosition = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer1.Interval = 1000;
            this.SuspendLayout();
            // 
            // ballPosition
            // 
            this.ballPosition.BackColor = System.Drawing.Color.Red;
            this.ballPosition.Location = new System.Drawing.Point(12, 12);
            this.ballPosition.Name = "ballPosition";
            this.ballPosition.Size = new System.Drawing.Size(72, 76);
            this.ballPosition.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ballPosition);
            this.Name = "Form1";
            this.Text = "Guidewire application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ballPosition;
        private System.Windows.Forms.Timer timer1;
    }
}

