
namespace SnakeGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPuan = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timerYilanHareket = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pnl
            // 
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl.Location = new System.Drawing.Point(12, 71);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(400, 260);
            this.pnl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Puan :";
            // 
            // lblPuan
            // 
            this.lblPuan.AutoSize = true;
            this.lblPuan.ForeColor = System.Drawing.Color.White;
            this.lblPuan.Location = new System.Drawing.Point(69, 30);
            this.lblPuan.Name = "lblPuan";
            this.lblPuan.Size = new System.Drawing.Size(14, 15);
            this.lblPuan.TabIndex = 3;
            this.lblPuan.Text = "0";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.ForeColor = System.Drawing.Color.White;
            this.lblSure.Location = new System.Drawing.Point(378, 30);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(14, 15);
            this.lblSure.TabIndex = 5;
            this.lblSure.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(335, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sure :";
            // 
            // timerYilanHareket
            // 
            this.timerYilanHareket.Tick += new System.EventHandler(this.timerYilanHareket_Tick);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(434, 353);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPuan;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerYilanHareket;
        private System.Windows.Forms.Timer timer;
    }
}

