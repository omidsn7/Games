
namespace ThreadingGamee
{
    partial class Form
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
            this.btn_red = new System.Windows.Forms.Button();
            this.btn_blue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_red
            // 
            this.btn_red.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_red.Location = new System.Drawing.Point(16, 12);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(115, 31);
            this.btn_red.TabIndex = 0;
            this.btn_red.Text = "Red";
            this.btn_red.UseVisualStyleBackColor = true;
            this.btn_red.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // btn_blue
            // 
            this.btn_blue.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_blue.Location = new System.Drawing.Point(154, 12);
            this.btn_blue.Name = "btn_blue";
            this.btn_blue.Size = new System.Drawing.Size(115, 31);
            this.btn_blue.TabIndex = 1;
            this.btn_blue.Text = "Blue";
            this.btn_blue.UseVisualStyleBackColor = true;
            this.btn_blue.Click += new System.EventHandler(this.btn_blue_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 95);
            this.Controls.Add(this.btn_blue);
            this.Controls.Add(this.btn_red);
            this.Name = "Form";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_red;
        private System.Windows.Forms.Button btn_blue;
    }
}

