
namespace drawing
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
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.btnExe = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.tmrTick = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlDraw
            // 
            this.pnlDraw.Location = new System.Drawing.Point(26, 25);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(661, 265);
            this.pnlDraw.TabIndex = 0;
            this.pnlDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDraw_MouseMove);
            // 
            // btnExe
            // 
            this.btnExe.Location = new System.Drawing.Point(26, 321);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(131, 80);
            this.btnExe.TabIndex = 1;
            this.btnExe.Text = "Hide Drawing";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(163, 321);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(128, 80);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // tmrTick
            // 
            this.tmrTick.Enabled = true;
            this.tmrTick.Interval = 10;
            this.tmrTick.Tick += new System.EventHandler(this.tmrTick_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnExe);
            this.Controls.Add(this.pnlDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Button btnExe;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Timer tmrTick;
    }
}

