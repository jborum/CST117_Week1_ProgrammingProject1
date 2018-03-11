namespace Exercise_3
{
    partial class frmConvert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConvert));
            this.lblEarthWeight = new System.Windows.Forms.Label();
            this.lblMarsWeight = new System.Windows.Forms.Label();
            this.txtEarthWeight = new System.Windows.Forms.TextBox();
            this.txtMarsWeight = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEarthWeight
            // 
            this.lblEarthWeight.AutoSize = true;
            this.lblEarthWeight.BackColor = System.Drawing.Color.Black;
            this.lblEarthWeight.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEarthWeight.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblEarthWeight.Location = new System.Drawing.Point(12, 9);
            this.lblEarthWeight.Name = "lblEarthWeight";
            this.lblEarthWeight.Size = new System.Drawing.Size(296, 17);
            this.lblEarthWeight.TabIndex = 0;
            this.lblEarthWeight.Text = "ENTER YOUR WEIGHT ON EARTH (LBS)";
            // 
            // lblMarsWeight
            // 
            this.lblMarsWeight.AutoSize = true;
            this.lblMarsWeight.BackColor = System.Drawing.Color.Black;
            this.lblMarsWeight.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarsWeight.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblMarsWeight.Location = new System.Drawing.Point(12, 62);
            this.lblMarsWeight.Name = "lblMarsWeight";
            this.lblMarsWeight.Size = new System.Drawing.Size(233, 17);
            this.lblMarsWeight.TabIndex = 1;
            this.lblMarsWeight.Text = "YOUR WEIGHT ON MARS (LBS)";
            // 
            // txtEarthWeight
            // 
            this.txtEarthWeight.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtEarthWeight.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEarthWeight.ForeColor = System.Drawing.Color.Black;
            this.txtEarthWeight.Location = new System.Drawing.Point(15, 29);
            this.txtEarthWeight.MaximumSize = new System.Drawing.Size(300, 20);
            this.txtEarthWeight.MinimumSize = new System.Drawing.Size(300, 20);
            this.txtEarthWeight.Name = "txtEarthWeight";
            this.txtEarthWeight.Size = new System.Drawing.Size(300, 20);
            this.txtEarthWeight.TabIndex = 0;
            // 
            // txtMarsWeight
            // 
            this.txtMarsWeight.BackColor = System.Drawing.Color.Black;
            this.txtMarsWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarsWeight.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMarsWeight.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarsWeight.ForeColor = System.Drawing.Color.LemonChiffon;
            this.txtMarsWeight.Location = new System.Drawing.Point(15, 82);
            this.txtMarsWeight.MaximumSize = new System.Drawing.Size(300, 20);
            this.txtMarsWeight.MinimumSize = new System.Drawing.Size(300, 20);
            this.txtMarsWeight.Name = "txtMarsWeight";
            this.txtMarsWeight.Size = new System.Drawing.Size(300, 20);
            this.txtMarsWeight.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.SandyBrown;
            this.btnConvert.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown;
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConvert.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.Black;
            this.btnConvert.Location = new System.Drawing.Point(15, 124);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(300, 25);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "CONVERT";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(12, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(300, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmConvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Programming_Project_1.Properties.Resources.marsBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 367);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtMarsWeight);
            this.Controls.Add(this.txtEarthWeight);
            this.Controls.Add(this.lblMarsWeight);
            this.Controls.Add(this.lblEarthWeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConvert";
            this.Text = "EARTH TO MARS CONVERSION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEarthWeight;
        private System.Windows.Forms.Label lblMarsWeight;
        private System.Windows.Forms.TextBox txtEarthWeight;
        private System.Windows.Forms.TextBox txtMarsWeight;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClose;
    }
}

