
namespace Paint
{
    partial class frm_paint
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
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_colors = new System.Windows.Forms.Panel();
            this.pbx_red = new System.Windows.Forms.PictureBox();
            this.pbx_yellow = new System.Windows.Forms.PictureBox();
            this.pbx_blue = new System.Windows.Forms.PictureBox();
            this.pbx_purple = new System.Windows.Forms.PictureBox();
            this.pnl_main.SuspendLayout();
            this.pnl_colors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_purple)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnl_main.Controls.Add(this.pnl_colors);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(714, 343);
            this.pnl_main.TabIndex = 0;
            this.pnl_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_main_MouseDown);
            this.pnl_main.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_main_MouseMove);
            this.pnl_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_main_MouseUp);
            // 
            // pnl_colors
            // 
            this.pnl_colors.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnl_colors.Controls.Add(this.pbx_purple);
            this.pnl_colors.Controls.Add(this.pbx_blue);
            this.pnl_colors.Controls.Add(this.pbx_yellow);
            this.pnl_colors.Controls.Add(this.pbx_red);
            this.pnl_colors.Location = new System.Drawing.Point(558, 7);
            this.pnl_colors.Name = "pnl_colors";
            this.pnl_colors.Size = new System.Drawing.Size(151, 29);
            this.pnl_colors.TabIndex = 0;
            // 
            // pbx_red
            // 
            this.pbx_red.BackColor = System.Drawing.Color.Red;
            this.pbx_red.Location = new System.Drawing.Point(17, 3);
            this.pbx_red.Name = "pbx_red";
            this.pbx_red.Size = new System.Drawing.Size(25, 24);
            this.pbx_red.TabIndex = 0;
            this.pbx_red.TabStop = false;
            this.pbx_red.Click += new System.EventHandler(this.pictureboxs_click);
            // 
            // pbx_yellow
            // 
            this.pbx_yellow.BackColor = System.Drawing.Color.Yellow;
            this.pbx_yellow.Location = new System.Drawing.Point(48, 3);
            this.pbx_yellow.Name = "pbx_yellow";
            this.pbx_yellow.Size = new System.Drawing.Size(25, 24);
            this.pbx_yellow.TabIndex = 0;
            this.pbx_yellow.TabStop = false;
            this.pbx_yellow.Click += new System.EventHandler(this.pictureboxs_click);
            // 
            // pbx_blue
            // 
            this.pbx_blue.BackColor = System.Drawing.Color.Blue;
            this.pbx_blue.Location = new System.Drawing.Point(79, 3);
            this.pbx_blue.Name = "pbx_blue";
            this.pbx_blue.Size = new System.Drawing.Size(25, 24);
            this.pbx_blue.TabIndex = 0;
            this.pbx_blue.TabStop = false;
            this.pbx_blue.Click += new System.EventHandler(this.pictureboxs_click);
            // 
            // pbx_purple
            // 
            this.pbx_purple.BackColor = System.Drawing.Color.Purple;
            this.pbx_purple.Location = new System.Drawing.Point(110, 3);
            this.pbx_purple.Name = "pbx_purple";
            this.pbx_purple.Size = new System.Drawing.Size(25, 24);
            this.pbx_purple.TabIndex = 0;
            this.pbx_purple.TabStop = false;
            this.pbx_purple.Click += new System.EventHandler(this.pictureboxs_click);
            // 
            // frm_paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 343);
            this.Controls.Add(this.pnl_main);
            this.Name = "frm_paint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_main.ResumeLayout(false);
            this.pnl_colors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_purple)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel pnl_colors;
        private System.Windows.Forms.PictureBox pbx_purple;
        private System.Windows.Forms.PictureBox pbx_blue;
        private System.Windows.Forms.PictureBox pbx_yellow;
        private System.Windows.Forms.PictureBox pbx_red;
    }
}

