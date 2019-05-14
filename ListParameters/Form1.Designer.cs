namespace ListParameters
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
            this.buttonGet1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonRestSharp1 = new System.Windows.Forms.Button();
            this.textBoxVapix = new System.Windows.Forms.TextBox();
            this.textBoxVapix2 = new System.Windows.Forms.TextBox();
            this.buttonRestSharp2 = new System.Windows.Forms.Button();
            this.buttonGet2 = new System.Windows.Forms.Button();
            this.textBoxVapix3 = new System.Windows.Forms.TextBox();
            this.buttonRestSharp3 = new System.Windows.Forms.Button();
            this.buttonGet3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGet1
            // 
            this.buttonGet1.Location = new System.Drawing.Point(529, 8);
            this.buttonGet1.Name = "buttonGet1";
            this.buttonGet1.Size = new System.Drawing.Size(75, 23);
            this.buttonGet1.TabIndex = 0;
            this.buttonGet1.Text = "Get Param";
            this.buttonGet1.UseVisualStyleBackColor = true;
            this.buttonGet1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(23, 108);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(984, 358);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // buttonRestSharp1
            // 
            this.buttonRestSharp1.Location = new System.Drawing.Point(628, 9);
            this.buttonRestSharp1.Name = "buttonRestSharp1";
            this.buttonRestSharp1.Size = new System.Drawing.Size(153, 23);
            this.buttonRestSharp1.TabIndex = 2;
            this.buttonRestSharp1.Text = "Get Param using RestSharp";
            this.buttonRestSharp1.UseVisualStyleBackColor = true;
            this.buttonRestSharp1.Click += new System.EventHandler(this.Button1_Rest_Click);
            // 
            // textBoxVapix
            // 
            this.textBoxVapix.Location = new System.Drawing.Point(12, 9);
            this.textBoxVapix.Name = "textBoxVapix";
            this.textBoxVapix.Size = new System.Drawing.Size(511, 20);
            this.textBoxVapix.TabIndex = 3;
            this.textBoxVapix.Text = "http://myserver/axis-cgi/param.cgi?action=list&responseformat=rfc";
            // 
            // textBoxVapix2
            // 
            this.textBoxVapix2.Location = new System.Drawing.Point(12, 35);
            this.textBoxVapix2.Name = "textBoxVapix2";
            this.textBoxVapix2.Size = new System.Drawing.Size(511, 20);
            this.textBoxVapix2.TabIndex = 6;
            this.textBoxVapix2.Text = "http://192.168.0.90/axis-cgi/playclip.cgi?location=HiBabu8k.wav&repeat=0&volume=1" +
    "23";
            // 
            // buttonRestSharp2
            // 
            this.buttonRestSharp2.Location = new System.Drawing.Point(628, 35);
            this.buttonRestSharp2.Name = "buttonRestSharp2";
            this.buttonRestSharp2.Size = new System.Drawing.Size(153, 23);
            this.buttonRestSharp2.TabIndex = 5;
            this.buttonRestSharp2.Text = "Get Param using RestSharp";
            this.buttonRestSharp2.UseVisualStyleBackColor = true;
            this.buttonRestSharp2.Click += new System.EventHandler(this.Button2_Rest_Click);
            // 
            // buttonGet2
            // 
            this.buttonGet2.Location = new System.Drawing.Point(529, 34);
            this.buttonGet2.Name = "buttonGet2";
            this.buttonGet2.Size = new System.Drawing.Size(75, 23);
            this.buttonGet2.TabIndex = 4;
            this.buttonGet2.Text = "Get Param";
            this.buttonGet2.UseVisualStyleBackColor = true;
            this.buttonGet2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxVapix3
            // 
            this.textBoxVapix3.Location = new System.Drawing.Point(12, 61);
            this.textBoxVapix3.Name = "textBoxVapix3";
            this.textBoxVapix3.Size = new System.Drawing.Size(511, 20);
            this.textBoxVapix3.TabIndex = 9;
            this.textBoxVapix3.Text = "http://myserver/axis-cgi/param.cgi?action=list&responseformat=rfc";
            // 
            // buttonRestSharp3
            // 
            this.buttonRestSharp3.Location = new System.Drawing.Point(628, 61);
            this.buttonRestSharp3.Name = "buttonRestSharp3";
            this.buttonRestSharp3.Size = new System.Drawing.Size(153, 23);
            this.buttonRestSharp3.TabIndex = 8;
            this.buttonRestSharp3.Text = "Get Param using RestSharp";
            this.buttonRestSharp3.UseVisualStyleBackColor = true;
            this.buttonRestSharp3.Click += new System.EventHandler(this.Button3_Rest_Click);
            // 
            // buttonGet3
            // 
            this.buttonGet3.Location = new System.Drawing.Point(529, 60);
            this.buttonGet3.Name = "buttonGet3";
            this.buttonGet3.Size = new System.Drawing.Size(75, 23);
            this.buttonGet3.TabIndex = 7;
            this.buttonGet3.Text = "Get Param";
            this.buttonGet3.UseVisualStyleBackColor = true;
            this.buttonGet3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(814, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(814, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(878, 11);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(118, 20);
            this.textBoxUserName.TabIndex = 12;
            this.textBoxUserName.Text = "root";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(878, 34);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(118, 20);
            this.textBoxPassword.TabIndex = 13;
            this.textBoxPassword.Text = "pass";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(817, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 459);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxVapix3);
            this.Controls.Add(this.buttonRestSharp3);
            this.Controls.Add(this.buttonGet3);
            this.Controls.Add(this.textBoxVapix2);
            this.Controls.Add(this.buttonRestSharp2);
            this.Controls.Add(this.buttonGet2);
            this.Controls.Add(this.textBoxVapix);
            this.Controls.Add(this.buttonRestSharp1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonGet1);
            this.Name = "Form1";
            this.Text = "Parameter List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGet1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonRestSharp1;
        private System.Windows.Forms.TextBox textBoxVapix;
        private System.Windows.Forms.TextBox textBoxVapix2;
        private System.Windows.Forms.Button buttonRestSharp2;
        private System.Windows.Forms.Button buttonGet2;
        private System.Windows.Forms.TextBox textBoxVapix3;
        private System.Windows.Forms.Button buttonRestSharp3;
        private System.Windows.Forms.Button buttonGet3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button button1;
    }
}

