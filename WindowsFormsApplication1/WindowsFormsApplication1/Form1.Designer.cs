namespace WindowsFormsApplication1
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
            this.lbltickets = new System.Windows.Forms.Label();
            this.txttickets = new System.Windows.Forms.TextBox();
            this.lbltheater = new System.Windows.Forms.Label();
            this.txttheater = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.lblanswer = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltickets
            // 
            this.lbltickets.AutoSize = true;
            this.lbltickets.Location = new System.Drawing.Point(62, 42);
            this.lbltickets.Name = "lbltickets";
            this.lbltickets.Size = new System.Drawing.Size(88, 13);
            this.lbltickets.TabIndex = 0;
            this.lbltickets.Text = "number of tickets";
            // 
            // txttickets
            // 
            this.txttickets.Location = new System.Drawing.Point(156, 35);
            this.txttickets.Name = "txttickets";
            this.txttickets.Size = new System.Drawing.Size(100, 20);
            this.txttickets.TabIndex = 1;
            // 
            // lbltheater
            // 
            this.lbltheater.AutoSize = true;
            this.lbltheater.Location = new System.Drawing.Point(72, 106);
            this.lbltheater.Name = "lbltheater";
            this.lbltheater.Size = new System.Drawing.Size(78, 13);
            this.lbltheater.TabIndex = 2;
            this.lbltheater.Text = "theater number";
            // 
            // txttheater
            // 
            this.txttheater.Location = new System.Drawing.Point(156, 99);
            this.txttheater.Name = "txttheater";
            this.txttheater.Size = new System.Drawing.Size(100, 20);
            this.txttheater.TabIndex = 3;
            this.txttheater.TextChanged += new System.EventHandler(this.txttheater_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(156, 146);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "is student";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(167, 190);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(75, 23);
            this.btncalc.TabIndex = 6;
            this.btncalc.Text = "calculate";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // lblanswer
            // 
            this.lblanswer.AutoSize = true;
            this.lblanswer.Location = new System.Drawing.Point(184, 236);
            this.lblanswer.Name = "lblanswer";
            this.lblanswer.Size = new System.Drawing.Size(13, 13);
            this.lblanswer.TabIndex = 7;
            this.lblanswer.Text = "0";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(306, 271);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "exit";
            this.btnexit.UseVisualStyleBackColor = true;
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(91, 83);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(254, 13);
            this.lblinfo.TabIndex = 9;
            this.lblinfo.Text = "theater number must be either 2 \"classics\" or 3 \"3D\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 319);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lblanswer);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txttheater);
            this.Controls.Add(this.lbltheater);
            this.Controls.Add(this.txttickets);
            this.Controls.Add(this.lbltickets);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltickets;
        private System.Windows.Forms.TextBox txttickets;
        private System.Windows.Forms.Label lbltheater;
        private System.Windows.Forms.TextBox txttheater;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Label lblanswer;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblinfo;
    }
}

