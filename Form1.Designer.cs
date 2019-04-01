namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ball = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.slider = new System.Windows.Forms.PictureBox();
            this.vert = new System.Windows.Forms.Timer(this.components);
            this.horz = new System.Windows.Forms.Timer(this.components);
            this.key_watch = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_sum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.Enabled = false;
            this.ball.Image = ((System.Drawing.Image)(resources.GetObject("ball.Image")));
            this.ball.Location = new System.Drawing.Point(38, 9);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(50, 50);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(848, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.Color.Orange;
            this.slider.Location = new System.Drawing.Point(270, 486);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(127, 13);
            this.slider.TabIndex = 2;
            this.slider.TabStop = false;
            // 
            // vert
            // 
            this.vert.Enabled = true;
            this.vert.Tick += new System.EventHandler(this.vert_Tick_1);
            // 
            // horz
            // 
            this.horz.Enabled = true;
            this.horz.Tick += new System.EventHandler(this.horz_Tick);
            // 
            // key_watch
            // 
            this.key_watch.Enabled = true;
            this.key_watch.Tick += new System.EventHandler(this.key_watch_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.label_sum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(53, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 301);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(196, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "GAME PAUSE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_score.Location = new System.Drawing.Point(393, 9);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(63, 17);
            this.label_score.TabIndex = 4;
            this.label_score.Text = "score : 0";
            // 
            // label_sum
            // 
            this.label_sum.AutoSize = true;
            this.label_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label_sum.Location = new System.Drawing.Point(314, 208);
            this.label_sum.Name = "label_sum";
            this.label_sum.Size = new System.Drawing.Size(99, 24);
            this.label_sum.TabIndex = 1;
            this.label_sum.Text = "SCORE : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(884, 500);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.slider);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ball);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox slider;
        private System.Windows.Forms.Timer vert;
        private System.Windows.Forms.Timer horz;
        private System.Windows.Forms.Timer key_watch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_sum;
    }
}

