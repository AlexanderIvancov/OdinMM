namespace Odin.CRM
{ 
    partial class frm_AddEventSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddEventSchedule));
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.cmb_RespPerson = new Odin.CMB_Components.Common.cmb_Common();
            this.txt_ExecDate = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny1 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.txt_EventDate = new Odin.CustomControls.NullableDateTimePicker();
            this.buttonSpecAny10 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Result = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny5 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.cmb_State = new Odin.CMB_Components.Common.cmb_Common();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Comments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny6 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.txt_Action = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.buttonSpecAny4 = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_OK = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.cmb_RespPerson);
            this.kryptonPanel1.Controls.Add(this.txt_ExecDate);
            this.kryptonPanel1.Controls.Add(this.txt_EventDate);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.txt_Result);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel10);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel8);
            this.kryptonPanel1.Controls.Add(this.cmb_State);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.txt_Comments);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.txt_Action);
            this.kryptonPanel1.Controls.Add(this.btn_Cancel);
            this.kryptonPanel1.Controls.Add(this.btn_OK);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonPanel1.Size = new System.Drawing.Size(594, 310);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // cmb_RespPerson
            // 
            this.cmb_RespPerson.IsEmptyColor = false;
            this.cmb_RespPerson.Location = new System.Drawing.Point(90, 147);
            this.cmb_RespPerson.Name = "cmb_RespPerson";
            this.cmb_RespPerson.OrderBy = "id";
            this.cmb_RespPerson.sCurrentValue = "";
            this.cmb_RespPerson.SelectedValue = 0;
            this.cmb_RespPerson.sID_Filled = "id";
            this.cmb_RespPerson.Size = new System.Drawing.Size(231, 20);
            this.cmb_RespPerson.sTable = "vw_CRMActionRespPerson";
            this.cmb_RespPerson.sText_Filled = "respperson";
            this.cmb_RespPerson.sTitle = "Responsible person";
            this.cmb_RespPerson.TabIndex = 300;
            // 
            // txt_ExecDate
            // 
            this.txt_ExecDate.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.txt_ExecDate.CalendarShowWeekNumbers = true;
            this.txt_ExecDate.CustomFormat = null;
            this.txt_ExecDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_ExecDate.Location = new System.Drawing.Point(297, 175);
            this.txt_ExecDate.Name = "txt_ExecDate";
            this.txt_ExecDate.NullValue = " ";
            this.txt_ExecDate.Size = new System.Drawing.Size(104, 21);
            this.txt_ExecDate.TabIndex = 35;
            this.txt_ExecDate.DropDown += new System.EventHandler<ComponentFactory.Krypton.Toolkit.DateTimePickerDropArgs>(this.txt_ExecDate_DropDown);
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny1.UniqueName = "FD382E911439407A54B59F3225689532";
            // 
            // txt_EventDate
            // 
            this.txt_EventDate.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny10});
            this.txt_EventDate.CalendarShowWeekNumbers = true;
            this.txt_EventDate.CustomFormat = null;
            this.txt_EventDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_EventDate.Location = new System.Drawing.Point(90, 174);
            this.txt_EventDate.Name = "txt_EventDate";
            this.txt_EventDate.NullValue = " ";
            this.txt_EventDate.Size = new System.Drawing.Size(104, 21);
            this.txt_EventDate.TabIndex = 25;
            // 
            // buttonSpecAny10
            // 
            this.buttonSpecAny10.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.buttonSpecAny10.UniqueName = "FD382E911439407A54B59F3225689532";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(200, 176);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(93, 20);
            this.kryptonLabel6.TabIndex = 299;
            this.kryptonLabel6.Values.Text = "Execution date:";
            // 
            // txt_Result
            // 
            this.txt_Result.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny5});
            this.txt_Result.Location = new System.Drawing.Point(90, 276);
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(495, 23);
            this.txt_Result.TabIndex = 45;
            // 
            // buttonSpecAny5
            // 
            this.buttonSpecAny5.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny5.UniqueName = "5522A47E28474C27AE8C1DF704791D4A";
            this.buttonSpecAny5.Click += new System.EventHandler(this.buttonSpecAny5_Click);
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(8, 276);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(46, 20);
            this.kryptonLabel10.TabIndex = 297;
            this.kryptonLabel10.Values.Text = "Result:";
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(375, 147);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(41, 20);
            this.kryptonLabel8.TabIndex = 293;
            this.kryptonLabel8.Values.Text = "State:";
            this.kryptonLabel8.Visible = false;
            // 
            // cmb_State
            // 
            this.cmb_State.IsEmptyColor = false;
            this.cmb_State.Location = new System.Drawing.Point(438, 147);
            this.cmb_State.Name = "cmb_State";
            this.cmb_State.OrderBy = "id";
            this.cmb_State.sCurrentValue = "";
            this.cmb_State.SelectedValue = 0;
            this.cmb_State.sID_Filled = "id";
            this.cmb_State.Size = new System.Drawing.Size(122, 20);
            this.cmb_State.sTable = "BAS_CRMEventState";
            this.cmb_State.sText_Filled = "evstate";
            this.cmb_State.sTitle = "Event state";
            this.cmb_State.TabIndex = 30;
            this.cmb_State.Visible = false;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(7, 147);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(83, 20);
            this.kryptonLabel5.TabIndex = 289;
            this.kryptonLabel5.Values.Text = "Resp. person:";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(7, 175);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(64, 20);
            this.kryptonLabel3.TabIndex = 32;
            this.kryptonLabel3.Values.Text = "Plan date:";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(7, 202);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(72, 20);
            this.kryptonLabel7.TabIndex = 28;
            this.kryptonLabel7.Values.Text = "Comments:";
            // 
            // txt_Comments
            // 
            this.txt_Comments.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny6});
            this.txt_Comments.Location = new System.Drawing.Point(90, 202);
            this.txt_Comments.Multiline = true;
            this.txt_Comments.Name = "txt_Comments";
            this.txt_Comments.Size = new System.Drawing.Size(495, 68);
            this.txt_Comments.TabIndex = 40;
            // 
            // buttonSpecAny6
            // 
            this.buttonSpecAny6.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny6.UniqueName = "5522A47E28474C27AE8C1DF704791D4A";
            this.buttonSpecAny6.Click += new System.EventHandler(this.buttonSpecAny6_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(7, 118);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(48, 20);
            this.kryptonLabel4.TabIndex = 21;
            this.kryptonLabel4.Values.Text = "Action:";
            // 
            // txt_Action
            // 
            this.txt_Action.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny4});
            this.txt_Action.Location = new System.Drawing.Point(90, 118);
            this.txt_Action.Name = "txt_Action";
            this.txt_Action.Size = new System.Drawing.Size(495, 23);
            this.txt_Action.TabIndex = 5;
            // 
            // buttonSpecAny4
            // 
            this.buttonSpecAny4.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Close;
            this.buttonSpecAny4.UniqueName = "5522A47E28474C27AE8C1DF704791D4A";
            this.buttonSpecAny4.Click += new System.EventHandler(this.buttonSpecAny4_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(495, 50);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 34);
            this.btn_Cancel.TabIndex = 10;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(495, 10);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(90, 34);
            this.btn_OK.TabIndex = 9;
            this.btn_OK.Values.Image = global::Odin.Global_Resourses.Ok;
            this.btn_OK.Values.Text = "OK";
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // frm_AddEventSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 310);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_AddEventSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add action";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_OK;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Action;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Comments;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private CMB_Components.Common.cmb_Common cmb_State;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Result;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny5;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private CustomControls.NullableDateTimePicker txt_ExecDate;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private CustomControls.NullableDateTimePicker txt_EventDate;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny buttonSpecAny10;
        private CMB_Components.Common.cmb_Common cmb_RespPerson;
    }
}