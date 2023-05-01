namespace Connect_Four
{
    partial class HowToPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HowToPlay));
            this.pnlHow = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHow = new System.Windows.Forms.Label();
            this.lblIStructions = new System.Windows.Forms.Label();
            this.pnlHow.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHow
            // 
            this.pnlHow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(120)))));
            this.pnlHow.Controls.Add(this.btnExit);
            this.pnlHow.Controls.Add(this.lblHow);
            this.pnlHow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHow.Location = new System.Drawing.Point(0, 0);
            this.pnlHow.Name = "pnlHow";
            this.pnlHow.Size = new System.Drawing.Size(500, 66);
            this.pnlHow.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(457, 1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "⨉";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHow
            // 
            this.lblHow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(255)))), ((int)(((byte)(120)))));
            this.lblHow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHow.Font = new System.Drawing.Font("Gadugi", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHow.ForeColor = System.Drawing.Color.Black;
            this.lblHow.Location = new System.Drawing.Point(0, 0);
            this.lblHow.Name = "lblHow";
            this.lblHow.Size = new System.Drawing.Size(500, 66);
            this.lblHow.TabIndex = 0;
            this.lblHow.Text = "How To Play :";
            this.lblHow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIStructions
            // 
            this.lblIStructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIStructions.Font = new System.Drawing.Font("Gadugi", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIStructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblIStructions.Location = new System.Drawing.Point(0, 66);
            this.lblIStructions.Name = "lblIStructions";
            this.lblIStructions.Size = new System.Drawing.Size(500, 234);
            this.lblIStructions.TabIndex = 1;
            this.lblIStructions.Text = resources.GetString("lblIStructions.Text");
            this.lblIStructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.lblIStructions);
            this.Controls.Add(this.pnlHow);
            this.Font = new System.Drawing.Font("Gadugi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HowToPlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HowToPlay";
            this.pnlHow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHow;
        private System.Windows.Forms.Label lblHow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblIStructions;
    }
}