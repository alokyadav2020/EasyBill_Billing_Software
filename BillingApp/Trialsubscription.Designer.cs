namespace BillingSystem
{
    partial class Trialsubscription
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.vslbl = new System.Windows.Forms.Label();
            this.d1lbl = new System.Windows.Forms.Label();
            this.d2lbl = new System.Windows.Forms.Label();
            this.d3lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(612, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Activate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(67, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 76);
            this.label1.TabIndex = 1;
            this.label1.Text = "One Month Free Trial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "EasyBill";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Standard Version";
            // 
            // vslbl
            // 
            this.vslbl.AutoSize = true;
            this.vslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vslbl.ForeColor = System.Drawing.Color.Green;
            this.vslbl.Location = new System.Drawing.Point(98, 217);
            this.vslbl.Name = "vslbl";
            this.vslbl.Size = new System.Drawing.Size(24, 20);
            this.vslbl.TabIndex = 4;
            this.vslbl.Text = "vs";
            // 
            // d1lbl
            // 
            this.d1lbl.AutoSize = true;
            this.d1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d1lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.d1lbl.Location = new System.Drawing.Point(100, 250);
            this.d1lbl.Name = "d1lbl";
            this.d1lbl.Size = new System.Drawing.Size(24, 17);
            this.d1lbl.TabIndex = 5;
            this.d1lbl.Text = "d1";
            // 
            // d2lbl
            // 
            this.d2lbl.AutoSize = true;
            this.d2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d2lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.d2lbl.Location = new System.Drawing.Point(100, 276);
            this.d2lbl.Name = "d2lbl";
            this.d2lbl.Size = new System.Drawing.Size(24, 17);
            this.d2lbl.TabIndex = 5;
            this.d2lbl.Text = "d2";
            // 
            // d3lbl
            // 
            this.d3lbl.AutoSize = true;
            this.d3lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d3lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.d3lbl.Location = new System.Drawing.Point(99, 301);
            this.d3lbl.Name = "d3lbl";
            this.d3lbl.Size = new System.Drawing.Size(24, 17);
            this.d3lbl.TabIndex = 5;
            this.d3lbl.Text = "d3";
            // 
            // Trialsubscription
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(780, 370);
            this.Controls.Add(this.d3lbl);
            this.Controls.Add(this.d2lbl);
            this.Controls.Add(this.d1lbl);
            this.Controls.Add(this.vslbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Trialsubscription";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trialsubscription";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Trialsubscription_FormClosed);
            this.Load += new System.EventHandler(this.Trialsubscription_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Trialsubscription_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label vslbl;
        private System.Windows.Forms.Label d1lbl;
        private System.Windows.Forms.Label d2lbl;
        private System.Windows.Forms.Label d3lbl;
    }
}