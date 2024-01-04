namespace Odin.Planning.Passport
{
    partial class frm_AddLaunchPassportComment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddLaunchPassportComment));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_TechComments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.grp_State = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.rb_Cancelled = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_Closed = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.rb_New = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Comments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny3 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.chk_SendEmail = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_State)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grp_State.Panel)).BeginInit();
            this.grp_State.Panel.SuspendLayout();
            this.grp_State.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.chk_SendEmail);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.txt_TechComments);
            this.kryptonPanel1.Controls.Add(this.grp_State);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.txt_Comments);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(470, 290);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(10, 196);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(70, 36);
            this.kryptonLabel1.TabIndex = 304;
            this.kryptonLabel1.Values.Text = "Tech dept. \r\ncomments:";
            // 
            // txt_TechComments
            // 
            this.txt_TechComments.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_TechComments.Location = new System.Drawing.Point(89, 196);
            this.txt_TechComments.Multiline = true;
            this.txt_TechComments.Name = "txt_TechComments";
            this.txt_TechComments.Size = new System.Drawing.Size(369, 80);
            this.txt_TechComments.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txt_TechComments.TabIndex = 303;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny1.UniqueName = "D5B6C03750554195328E4B264796E65F";
            this.buttonSpecAny1.Click += new System.EventHandler(this.buttonSpecAny1_Click);
            // 
            // grp_State
            // 
            this.grp_State.Location = new System.Drawing.Point(89, 45);
            this.grp_State.Name = "grp_State";
            // 
            // grp_State.Panel
            // 
            this.grp_State.Panel.Controls.Add(this.rb_Cancelled);
            this.grp_State.Panel.Controls.Add(this.rb_Closed);
            this.grp_State.Panel.Controls.Add(this.rb_New);
            this.grp_State.Size = new System.Drawing.Size(265, 59);
            this.grp_State.TabIndex = 302;
            this.grp_State.Values.Heading = "State";
            // 
            // rb_Cancelled
            // 
            this.rb_Cancelled.Location = new System.Drawing.Point(156, 3);
            this.rb_Cancelled.Name = "rb_Cancelled";
            this.rb_Cancelled.Size = new System.Drawing.Size(75, 20);
            this.rb_Cancelled.TabIndex = 2;
            this.rb_Cancelled.Values.Text = "Cancelled";
            // 
            // rb_Closed
            // 
            this.rb_Closed.Location = new System.Drawing.Point(79, 3);
            this.rb_Closed.Name = "rb_Closed";
            this.rb_Closed.Size = new System.Drawing.Size(59, 20);
            this.rb_Closed.TabIndex = 1;
            this.rb_Closed.Values.Text = "Closed";
            // 
            // rb_New
            // 
            this.rb_New.Checked = true;
            this.rb_New.Location = new System.Drawing.Point(7, 3);
            this.rb_New.Name = "rb_New";
            this.rb_New.Size = new System.Drawing.Size(47, 20);
            this.rb_New.TabIndex = 0;
            this.rb_New.Values.Text = "New";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(10, 109);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel7.TabIndex = 300;
            this.kryptonLabel7.Values.Text = "Comments:";
            // 
            // txt_Comments
            // 
            this.txt_Comments.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny3});
            this.txt_Comments.Location = new System.Drawing.Point(89, 110);
            this.txt_Comments.Multiline = true;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(369, 80);
            this.txt_Comments.StateActive.Back.Color1 = System.Drawing.Color.White;
            this.txt_Comments.TabIndex = 299;
            this.txt_Comments.TextChanged += new System.EventHandler(this.txt_Comments_TextChanged);
            // 
            // buttonSpecAny3
            // 
            this.buttonSpecAny3.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny3.UniqueName = "D5B6C03750554195328E4B264796E65F";
            this.buttonSpecAny3.Click += new System.EventHandler(this.buttonSpecAny3_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Enabled = false;
            this.btn_OK.Location = new System.Drawing.Point(368, 15);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(90, 34);
            this.btn_OK.TabIndex = 27;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Ok;
            this.btn_OK.Values.Text = "OK";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(368, 55);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 34);
            this.btn_Cancel.TabIndex = 26;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            // 
            // chk_SendEmail
            // 
            this.chk_SendEmail.Location = new System.Drawing.Point(89, 15);
            this.chk_SendEmail.Name = "chk_SendEmail";
            this.chk_SendEmail.Size = new System.Drawing.Size(84, 20);
            this.chk_SendEmail.TabIndex = 305;
            this.chk_SendEmail.Values.Text = "Send email";
            // 
            // frm_AddLaunchPassportComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 290);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddLaunchPassportComment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add launch passport comment";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_State.Panel)).EndInit();
            this.grp_State.Panel.ResumeLayout(false);
            this.grp_State.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grp_State)).EndInit();
            this.grp_State.ResumeLayout(false);
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Comments;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox grp_State;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Cancelled;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_Closed;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton rb_New;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_TechComments;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox chk_SendEmail;
    }
}