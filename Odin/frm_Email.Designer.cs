namespace Odin
{
    partial class frm_Email
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_From = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gradientPanel26 = new Owf.Controls.GradientPanel2();
            this.gradientPanel21 = new Owf.Controls.GradientPanel2();
            this.txt_Message = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Attachments = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Attach = new Panels.RibbonMenuButton();
            this.btn_Print = new Owf.Controls.GlassButton();
            this.btn_Cancel = new Owf.Controls.GlassButton();
            this.gradientPanel1 = new Owf.Controls.GradientPanel();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_From
            // 
            this.txt_From.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_From.Location = new System.Drawing.Point(87, 6);
            this.txt_From.Name = "txt_From";
            this.txt_From.ReadOnly = true;
            this.txt_From.Size = new System.Drawing.Size(466, 20);
            this.txt_From.TabIndex = 214;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 215;
            this.label1.Text = "From:";
            // 
            // txt_To
            // 
            this.txt_To.Location = new System.Drawing.Point(87, 32);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(466, 20);
            this.txt_To.TabIndex = 216;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 217;
            this.label2.Text = "To:";
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(87, 58);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(466, 20);
            this.txt_Subject.TabIndex = 218;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 219;
            this.label3.Text = "Subject:";
            // 
            // gradientPanel26
            // 
            this.gradientPanel26.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel26.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel26.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel26.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(155)))), ((int)(((byte)(221)))));
            this.gradientPanel26.Location = new System.Drawing.Point(15, 85);
            this.gradientPanel26.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gradientPanel26.Name = "gradientPanel26";
            this.gradientPanel26.Padding = new System.Windows.Forms.Padding(1);
            this.gradientPanel26.ShowBottomBorder = true;
            this.gradientPanel26.ShowLeftBorder = true;
            this.gradientPanel26.ShowRightBorder = true;
            this.gradientPanel26.ShowTopBorder = true;
            this.gradientPanel26.Size = new System.Drawing.Size(540, 2);
            this.gradientPanel26.StartColor = System.Drawing.Color.White;
            this.gradientPanel26.TabIndex = 220;
            // 
            // gradientPanel21
            // 
            this.gradientPanel21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel21.BackgroundGradientMode = Owf.Controls.GradientPanel2.PanelGradientMode.BackwardDiagonal;
            this.gradientPanel21.borderColor = System.Drawing.Color.Transparent;
            this.gradientPanel21.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(155)))), ((int)(((byte)(221)))));
            this.gradientPanel21.Location = new System.Drawing.Point(15, 254);
            this.gradientPanel21.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gradientPanel21.Name = "gradientPanel21";
            this.gradientPanel21.Padding = new System.Windows.Forms.Padding(1);
            this.gradientPanel21.ShowBottomBorder = true;
            this.gradientPanel21.ShowLeftBorder = true;
            this.gradientPanel21.ShowRightBorder = true;
            this.gradientPanel21.ShowTopBorder = true;
            this.gradientPanel21.Size = new System.Drawing.Size(540, 2);
            this.gradientPanel21.StartColor = System.Drawing.Color.White;
            this.gradientPanel21.TabIndex = 221;
            // 
            // txt_Message
            // 
            this.txt_Message.Location = new System.Drawing.Point(87, 94);
            this.txt_Message.Multiline = true;
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Message.Size = new System.Drawing.Size(466, 153);
            this.txt_Message.TabIndex = 222;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 223;
            this.label4.Text = "Message:";
            // 
            // txt_Attachments
            // 
            this.txt_Attachments.Location = new System.Drawing.Point(87, 263);
            this.txt_Attachments.Multiline = true;
            this.txt_Attachments.Name = "txt_Attachments";
            this.txt_Attachments.Size = new System.Drawing.Size(438, 43);
            this.txt_Attachments.TabIndex = 224;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 225;
            this.label5.Text = "Attachments:";
            // 
            // btn_Attach
            // 
            this.btn_Attach.Arrow = Panels.RibbonMenuButton.e_arrow.None;
            this.btn_Attach.BackColor = System.Drawing.Color.Transparent;
            this.btn_Attach.ColorBase = System.Drawing.Color.Transparent;
            this.btn_Attach.ColorBaseStroke = System.Drawing.Color.Transparent;
            this.btn_Attach.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(172)))), ((int)(((byte)(227)))));
            this.btn_Attach.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(187)))), ((int)(((byte)(243)))));
            this.btn_Attach.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(100)))), ((int)(((byte)(187)))));
            this.btn_Attach.ColorPressStroke = System.Drawing.Color.Transparent;
            this.btn_Attach.FadingSpeed = 35;
            this.btn_Attach.FlatAppearance.BorderSize = 0;
            this.btn_Attach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Attach.GroupPos = Panels.RibbonMenuButton.e_groupPos.None;
            this.btn_Attach.ImageLocation = Panels.RibbonMenuButton.e_imagelocation.Top;
            this.btn_Attach.ImageOffset = 0;
            this.btn_Attach.IsPressed = false;
            this.btn_Attach.KeepPress = false;
            this.btn_Attach.Location = new System.Drawing.Point(530, 273);
            this.btn_Attach.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btn_Attach.MenuPos = new System.Drawing.Point(0, 0);
            this.btn_Attach.Name = "btn_Attach";
            this.btn_Attach.Radius = 6;
            this.btn_Attach.ShowBase = Panels.RibbonMenuButton.e_showbase.Yes;
            this.btn_Attach.Size = new System.Drawing.Size(24, 24);
            this.btn_Attach.SplitButton = Panels.RibbonMenuButton.e_splitbutton.No;
            this.btn_Attach.SplitDistance = 0;
            this.btn_Attach.TabIndex = 226;
            this.btn_Attach.Title = "";
            this.btn_Attach.UseVisualStyleBackColor = true;
            this.btn_Attach.Click += new System.EventHandler(this.btn_Attach_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(100)))), ((int)(((byte)(187)))));
            this.btn_Print.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Print.ForeColor = System.Drawing.Color.Black;
            this.btn_Print.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Print.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_Print.Location = new System.Drawing.Point(400, 9);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_Print.Size = new System.Drawing.Size(72, 34);
            this.btn_Print.TabIndex = 25;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(100)))), ((int)(((byte)(187)))));
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Cancel.InnerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_Cancel.Location = new System.Drawing.Point(478, 9);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.OuterBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btn_Cancel.Size = new System.Drawing.Size(75, 34);
            this.btn_Cancel.TabIndex = 26;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gradientPanel1.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.gradientPanel1.Controls.Add(this.btn_Cancel);
            this.gradientPanel1.Controls.Add(this.btn_Print);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(192)))), ((int)(((byte)(234)))));
            this.gradientPanel1.Location = new System.Drawing.Point(0, 323);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.gradientPanel1.ShowBottomBorder = true;
            this.gradientPanel1.ShowLeftBorder = true;
            this.gradientPanel1.ShowRightBorder = true;
            this.gradientPanel1.ShowTopBorder = true;
            this.gradientPanel1.Size = new System.Drawing.Size(567, 51);
            this.gradientPanel1.TabIndex = 213;
            // 
            // frm_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 374);
            this.Controls.Add(this.btn_Attach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Attachments);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.gradientPanel21);
            this.Controls.Add(this.gradientPanel26);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Subject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_From);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "frm_Email";
            this.Text = "frm_Email";
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txt_From;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.Label label3;
        private Owf.Controls.GradientPanel2 gradientPanel26;
        private Owf.Controls.GradientPanel2 gradientPanel21;
        private System.Windows.Forms.TextBox txt_Message;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Attachments;
        private System.Windows.Forms.Label label5;
        private Panels.RibbonMenuButton btn_Attach;
        private Owf.Controls.GlassButton btn_Print;
        private Owf.Controls.GlassButton btn_Cancel;
        private Owf.Controls.GradientPanel gradientPanel1;
    }
}