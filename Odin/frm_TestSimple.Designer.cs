namespace Odin
{
    partial class frm_TestSimple
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
            this.txt_From = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_To = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Message = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.chk_UseSSL = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_UserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Password = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SMTP = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Port = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chk_UseDefault = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_From
            // 
            this.txt_From.Location = new System.Drawing.Point(136, 55);
            this.txt_From.Name = "txt_From";
            this.txt_From.Size = new System.Drawing.Size(194, 20);
            this.txt_From.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // txt_To
            // 
            this.txt_To.Location = new System.Drawing.Point(136, 81);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(194, 20);
            this.txt_To.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Message";
            // 
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(136, 107);
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(194, 20);
            this.txt_Message.TabIndex = 5;
            // 
            // chk_UseSSL
            // 
            this.chk_UseSSL.AutoSize = true;
            this.chk_UseSSL.Location = new System.Drawing.Point(136, 133);
            this.chk_UseSSL.Name = "chk_UseSSL";
            this.chk_UseSSL.Size = new System.Drawing.Size(68, 17);
            this.chk_UseSSL.TabIndex = 7;
            this.chk_UseSSL.Text = "Use SSL";
            this.chk_UseSSL.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "User name";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(136, 201);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(194, 20);
            this.txt_UserName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(136, 227);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(194, 20);
            this.txt_Password.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "SMTP server";
            // 
            // txt_SMTP
            // 
            this.txt_SMTP.Location = new System.Drawing.Point(136, 152);
            this.txt_SMTP.Name = "txt_SMTP";
            this.txt_SMTP.Size = new System.Drawing.Size(124, 20);
            this.txt_SMTP.TabIndex = 12;
            this.txt_SMTP.Text = "mail.micromount.by";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 57);
            this.button2.TabIndex = 14;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(298, 152);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(45, 20);
            this.txt_Port.TabIndex = 15;
            this.txt_Port.Text = "465";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(266, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Port";
            // 
            // chk_UseDefault
            // 
            this.chk_UseDefault.AutoSize = true;
            this.chk_UseDefault.Location = new System.Drawing.Point(136, 178);
            this.chk_UseDefault.Name = "chk_UseDefault";
            this.chk_UseDefault.Size = new System.Drawing.Size(134, 17);
            this.chk_UseDefault.TabIndex = 17;
            this.chk_UseDefault.Text = "Use default credentials";
            this.chk_UseDefault.UseVisualStyleBackColor = true;
            // 
            // frm_TestSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 326);
            this.Controls.Add(this.chk_UseDefault);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_SMTP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.chk_UseSSL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_From);
            this.Name = "frm_TestSimple";
            this.Text = "frm_TestSimple";
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());
            this.PerformLayout(); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_From;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_To;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Message;
        private System.Windows.Forms.CheckBox chk_UseSSL;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_UserName;
        private System.Windows.Forms.Label label5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Password;
        private System.Windows.Forms.Label label6;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_SMTP;
        private System.Windows.Forms.Button button2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Port;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chk_UseDefault;
    }
}