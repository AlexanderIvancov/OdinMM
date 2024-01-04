namespace Odin
{
    partial class frm_EmailNew
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_EmailNew));
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.kryptonRibbon1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.btn_Send = new ComponentFactory.Krypton.Ribbon.ButtonSpecAppMenu();
            this.btn_Close = new ComponentFactory.Krypton.Ribbon.ButtonSpecAppMenu();
            this.kryptonRibbonTab1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.btn_SendMail = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.btn_Attach = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.txt_Attachments = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTextBox();
            this.panelFill = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_Message = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.txt_Subject = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.txt_To = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.txt_From = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.clipboard1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.clipboardPaste = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFill)).BeginInit();
            this.panelFill.SuspendLayout();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Office2010Silver;
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonRibbon1.RibbonAppButton.AppButtonImage = global::Odin.Global_Resourses.Valknut;
            this.kryptonRibbon1.RibbonAppButton.AppButtonSpecs.AddRange(new ComponentFactory.Krypton.Ribbon.ButtonSpecAppMenu[] {
            this.btn_Send,
            this.btn_Close});
            this.kryptonRibbon1.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.kryptonRibbonTab1});
            this.kryptonRibbon1.SelectedContext = null;
            this.kryptonRibbon1.SelectedTab = this.kryptonRibbonTab1;
            this.kryptonRibbon1.Size = new System.Drawing.Size(642, 143);
            this.kryptonRibbon1.TabIndex = 0;
            // 
            // btn_Send
            // 
            this.btn_Send.Image = global::Odin.Global_Resourses.SendMail;
            this.btn_Send.UniqueName = "7914FB548A1343CD92A9A2A24C2B387A";
            // 
            // btn_Close
            // 
            this.btn_Close.Image = global::Odin.Global_Resourses.delete2__2_;
            this.btn_Close.UniqueName = "CEE6FC565A464E783CB03069DDD25B7E";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // kryptonRibbonTab1
            // 
            this.kryptonRibbonTab1.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1});
            this.kryptonRibbonTab1.Text = "Message";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1});
            this.kryptonRibbonGroup1.TextLine1 = "Message";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.btn_SendMail,
            this.btn_Attach,
            this.txt_Attachments});
            // 
            // btn_SendMail
            // 
            this.btn_SendMail.ImageLarge = global::Odin.Global_Resourses.mail_send;
            this.btn_SendMail.ImageSmall = global::Odin.Global_Resourses.mail_send;
            this.btn_SendMail.TextLine1 = "Send";
            this.btn_SendMail.Click += new System.EventHandler(this.btn_SendMail_Click);
            // 
            // btn_Attach
            // 
            this.btn_Attach.ImageLarge = global::Odin.Global_Resourses.IncludeAttachFile;
            this.btn_Attach.ImageSmall = global::Odin.Global_Resourses.IncludeAttachFile;
            this.btn_Attach.TextLine1 = "Attach";
            this.btn_Attach.Click += new System.EventHandler(this.btn_Attach_Click);
            // 
            // txt_Attachments
            // 
            this.txt_Attachments.MaximumSize = new System.Drawing.Size(250, 0);
            this.txt_Attachments.MinimumSize = new System.Drawing.Size(250, 0);
            this.txt_Attachments.Multiline = true;
            this.txt_Attachments.Text = "";
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.tableLayout);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 143);
            this.panelFill.Name = "panelFill";
            this.panelFill.Padding = new System.Windows.Forms.Padding(7);
            this.panelFill.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.panelFill.Size = new System.Drawing.Size(642, 290);
            this.panelFill.TabIndex = 1;
            // 
            // tableLayout
            // 
            this.tableLayout.AutoSize = true;
            this.tableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayout.BackColor = System.Drawing.Color.Transparent;
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout.Controls.Add(this.kryptonLabel1, 0, 2);
            this.tableLayout.Controls.Add(this.kryptonButton2, 0, 1);
            this.tableLayout.Controls.Add(this.txt_Message, 0, 3);
            this.tableLayout.Controls.Add(this.txt_Subject, 1, 2);
            this.tableLayout.Controls.Add(this.txt_To, 1, 1);
            this.tableLayout.Controls.Add(this.txt_From, 1, 0);
            this.tableLayout.Controls.Add(this.kryptonButton1, 0, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayout.Location = new System.Drawing.Point(7, 7);
            this.tableLayout.Margin = new System.Windows.Forms.Padding(1);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 4;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayout.Size = new System.Drawing.Size(628, 276);
            this.tableLayout.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 65);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonLabel1.Size = new System.Drawing.Size(53, 21);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Subject:";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(3, 34);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonButton2.Size = new System.Drawing.Size(50, 25);
            this.kryptonButton2.TabIndex = 1;
            this.kryptonButton2.Values.Text = "To...";
            // 
            // txt_Message
            // 
            this.txt_Message.AcceptsTab = true;
            this.txt_Message.AutoSize = true;
            this.tableLayout.SetColumnSpan(this.txt_Message, 2);
            this.txt_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Message.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Message.Location = new System.Drawing.Point(3, 92);
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txt_Message.Size = new System.Drawing.Size(622, 194);
            this.txt_Message.TabIndex = 6;
            this.txt_Message.Text = "";
            // 
            // txt_Subject
            // 
            this.txt_Subject.AutoSize = true;
            this.txt_Subject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Subject.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subject.Location = new System.Drawing.Point(62, 65);
            this.txt_Subject.Multiline = false;
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txt_Subject.Size = new System.Drawing.Size(563, 21);
            this.txt_Subject.TabIndex = 5;
            this.txt_Subject.Text = "";
            // 
            // txt_To
            // 
            this.txt_To.AutoSize = true;
            this.txt_To.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_To.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_To.Location = new System.Drawing.Point(62, 34);
            this.txt_To.Multiline = false;
            this.txt_To.Name = "txt_To";
            this.txt_To.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txt_To.Size = new System.Drawing.Size(563, 25);
            this.txt_To.TabIndex = 4;
            this.txt_To.Text = "";
            // 
            // txt_From
            // 
            this.txt_From.AutoSize = true;
            this.txt_From.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_From.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_From.Location = new System.Drawing.Point(62, 3);
            this.txt_From.Multiline = false;
            this.txt_From.Name = "txt_From";
            this.txt_From.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.txt_From.Size = new System.Drawing.Size(563, 25);
            this.txt_From.TabIndex = 3;
            this.txt_From.Text = "";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(3, 3);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.kryptonButton1.Size = new System.Drawing.Size(50, 25);
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.Text = "From...";
            // 
            // clipboard1
            // 
            this.clipboard1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.clipboardPaste});
            this.clipboard1.MinimumSize = ComponentFactory.Krypton.Ribbon.GroupItemSize.Large;
            // 
            // clipboardPaste
            // 
            this.clipboardPaste.ButtonType = ComponentFactory.Krypton.Ribbon.GroupButtonType.Split;
            this.clipboardPaste.ImageSmall = ((System.Drawing.Image)(resources.GetObject("clipboardPaste.ImageSmall")));
            this.clipboardPaste.KeyTip = "V";
            this.clipboardPaste.TextLine1 = "Paste";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frm_EmailNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 433);
            this.Controls.Add(this.panelFill);
            this.Controls.Add(this.kryptonRibbon1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_EmailNew";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New email ";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelFill)).EndInit();
            this.panelFill.ResumeLayout(false);
            this.panelFill.PerformLayout();
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());
            this.PerformLayout(); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelFill;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txt_Subject;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txt_To;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txt_From;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btn_SendMail;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton btn_Attach;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple clipboard1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton clipboardPaste;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTextBox txt_Attachments;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ComponentFactory.Krypton.Ribbon.ButtonSpecAppMenu btn_Send;
        private ComponentFactory.Krypton.Ribbon.ButtonSpecAppMenu btn_Close;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txt_Message;
    }
}