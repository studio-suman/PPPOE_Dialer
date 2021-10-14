
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.uName = new System.Windows.Forms.Label();
            this.passwd = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cnnect = new System.Windows.Forms.Button();
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
            // 
            // uName
            // 
            this.uName.AutoSize = true;
            this.uName.Location = new System.Drawing.Point(224, 73);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(60, 13);
            this.uName.TabIndex = 2;
            this.uName.Text = "User Name";
            // 
            // passwd
            // 
            this.passwd.AutoSize = true;
            this.passwd.Location = new System.Drawing.Point(224, 116);
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
            // 
            // ConnectDialer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 231);
            this.Controls.Add(this.cnnect);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.passwd);
            this.Controls.Add(this.uName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "ConnectDialer";
            this.Text = "Connect Dialer";
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
    }
}

