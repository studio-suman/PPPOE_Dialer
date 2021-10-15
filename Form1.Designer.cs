
namespace PPPOE_Dialer
{
    partial class ConnectDialer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectDialer));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.uName = new System.Windows.Forms.Label();
            this.passwd = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cnnect = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // uName
            // 
            this.uName.AutoSize = true;
            this.uName.Location = new System.Drawing.Point(206, 74);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(60, 13);
            this.uName.TabIndex = 2;
            this.uName.Text = "User Name";
            // 
            // passwd
            // 
            this.passwd.AutoSize = true;
            this.passwd.Location = new System.Drawing.Point(206, 116);
            this.passwd.Name = "passwd";
            this.passwd.Size = new System.Drawing.Size(53, 13);
            this.passwd.TabIndex = 3;
            this.passwd.Text = "Password";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 166);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Remember Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cnnect
            // 
            this.cnnect.Location = new System.Drawing.Point(209, 194);
            this.cnnect.Name = "cnnect";
            this.cnnect.Size = new System.Drawing.Size(75, 23);
            this.cnnect.TabIndex = 5;
            this.cnnect.Text = "Connect";
            this.cnnect.UseVisualStyleBackColor = true;
            this.cnnect.Click += new System.EventHandler(this.cnnect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(34, 202);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(73, 13);
            this.lb_status.TabIndex = 7;
            this.lb_status.Text = "Disconnected";
            // 
            // lb_message
            // 
            this.lb_message.AutoSize = true;
            this.lb_message.Location = new System.Drawing.Point(192, 27);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(35, 13);
            this.lb_message.TabIndex = 8;
            this.lb_message.Text = "label1";
            this.lb_message.Visible = false;
            // 
            // ConnectDialer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 231);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cnnect);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.uName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectDialer";
            this.Text = "Connect Dialer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label uName;
        private System.Windows.Forms.Label passwd;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button cnnect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label lb_message;
    }
}

