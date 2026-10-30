namespace Odin.DataCollection
{
    partial class frm_RepairCardFin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.layoutCards = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBottom = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.lbl_OperPrompt = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_Refresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_Oper = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lbl_PageInfo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.btn_NextPage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_PrevPage = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonHeaderGroupTop = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.btn_DeleteCard = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Print = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_CloseCard = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Deny = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Approve = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_VisualControl = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_Worker = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_ChangeWorker = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Repair = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Actions = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_AddCard = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Close = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Create = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroupTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroupTop.Panel)).BeginInit();
            this.kryptonHeaderGroupTop.Panel.SuspendLayout();
            this.kryptonHeaderGroupTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutCards
            // 
            this.layoutCards.BackColor = System.Drawing.Color.Gray;
            this.layoutCards.ColumnCount = 2;
            this.layoutCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutCards.Location = new System.Drawing.Point(0, 126);
            this.layoutCards.Name = "layoutCards";
            this.layoutCards.RowCount = 2;
            this.layoutCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutCards.Size = new System.Drawing.Size(1710, 765);
            this.layoutCards.TabIndex = 2;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lbl_OperPrompt);
            this.pnlBottom.Controls.Add(this.btn_Refresh);
            this.pnlBottom.Controls.Add(this.txt_Oper);
            this.pnlBottom.Controls.Add(this.lbl_PageInfo);
            this.pnlBottom.Controls.Add(this.btn_NextPage);
            this.pnlBottom.Controls.Add(this.btn_PrevPage);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 891);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBottom.Size = new System.Drawing.Size(1710, 70);
            this.pnlBottom.TabIndex = 1;
            // 
            // lbl_OperPrompt
            // 
            this.lbl_OperPrompt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_OperPrompt.Location = new System.Drawing.Point(1276, 10);
            this.lbl_OperPrompt.Name = "lbl_OperPrompt";
            this.lbl_OperPrompt.Size = new System.Drawing.Size(154, 50);
            this.lbl_OperPrompt.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_OperPrompt.TabIndex = 6;
            this.lbl_OperPrompt.Values.Text = "SCAN RESULT";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Refresh.Location = new System.Drawing.Point(610, 10);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(140, 50);
            this.btn_Refresh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Values.Image = global::Odin.Global_Resourses.reload_4545;
            this.btn_Refresh.Values.Text = "Refresh";
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // txt_Oper
            // 
            this.txt_Oper.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_Oper.Location = new System.Drawing.Point(1430, 10);
            this.txt_Oper.Multiline = true;
            this.txt_Oper.Name = "txt_Oper";
            this.txt_Oper.Size = new System.Drawing.Size(270, 50);
            this.txt_Oper.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.txt_Oper.TabIndex = 3;
            this.txt_Oper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Oper_KeyPress);
            // 
            // lbl_PageInfo
            // 
            this.lbl_PageInfo.AutoSize = false;
            this.lbl_PageInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_PageInfo.Location = new System.Drawing.Point(370, 10);
            this.lbl_PageInfo.Name = "lbl_PageInfo";
            this.lbl_PageInfo.Size = new System.Drawing.Size(240, 50);
            this.lbl_PageInfo.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_PageInfo.StateCommon.ShortText.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lbl_PageInfo.TabIndex = 1;
            this.lbl_PageInfo.Values.Text = "Page. 1 из 1";
            // 
            // btn_NextPage
            // 
            this.btn_NextPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_NextPage.Location = new System.Drawing.Point(190, 10);
            this.btn_NextPage.Name = "btn_NextPage";
            this.btn_NextPage.Size = new System.Drawing.Size(180, 50);
            this.btn_NextPage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btn_NextPage.TabIndex = 2;
            this.btn_NextPage.Values.Text = "NEXT ►";
            this.btn_NextPage.Click += new System.EventHandler(this.btn_NextPage_Click);
            // 
            // btn_PrevPage
            // 
            this.btn_PrevPage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_PrevPage.Location = new System.Drawing.Point(10, 10);
            this.btn_PrevPage.Name = "btn_PrevPage";
            this.btn_PrevPage.Size = new System.Drawing.Size(180, 50);
            this.btn_PrevPage.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btn_PrevPage.TabIndex = 0;
            this.btn_PrevPage.Values.Text = "◄ PREVIOUS";
            this.btn_PrevPage.Click += new System.EventHandler(this.btn_PrevPage_Click);
            // 
            // kryptonHeaderGroupTop
            // 
            this.kryptonHeaderGroupTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeaderGroupTop.Location = new System.Drawing.Point(0, 0);
            this.kryptonHeaderGroupTop.Name = "kryptonHeaderGroupTop";
            // 
            // kryptonHeaderGroupTop.Panel
            // 
            this.kryptonHeaderGroupTop.Panel.Controls.Add(this.btn_DeleteCard);
            this.kryptonHeaderGroupTop.Panel.Controls.Add(this.btn_Print);
            this.kryptonHeaderGroupTop.Panel.Controls.Add(this.btn_CloseCard);
            this.kryptonHeaderGroupTop.Panel.Controls.Add(this.btn_Deny);
            this.kryptonHeaderGroupTop.Panel.Controls.Add(this.btn_Approve);
            this.kryptonHeaderGroupTop.Panel.Controls.Add(this.btn_VisualControl);
            this.kryptonHeaderGroupTop.Panel.Controls.Add(this.txt_Worker);
            this.kryptonHeaderGroupTop.Panel.Controls.Add(this.btn_ChangeWorker);
            this.kryptonHeaderGroupTop.Panel.Controls.Add(this.btn_Repair);
            this.kryptonHeaderGroupTop.Panel.Controls.Add(this.btn_Actions);
            this.kryptonHeaderGroupTop.Panel.Controls.Add(this.btn_AddCard);
            this.kryptonHeaderGroupTop.Panel.Controls.Add(this.btn_Close);
            this.kryptonHeaderGroupTop.Panel.Controls.Add(this.btn_Create);
            this.kryptonHeaderGroupTop.Panel.Padding = new System.Windows.Forms.Padding(6);
            this.kryptonHeaderGroupTop.Size = new System.Drawing.Size(1710, 126);
            this.kryptonHeaderGroupTop.TabIndex = 0;
            this.kryptonHeaderGroupTop.ValuesPrimary.Heading = "Repair cards";
            this.kryptonHeaderGroupTop.ValuesPrimary.Image = global::Odin.Global_Resourses.Repair32x32;
            this.kryptonHeaderGroupTop.ValuesSecondary.Heading = "Select a card below to perform actions";
            // 
            // btn_DeleteCard
            // 
            this.btn_DeleteCard.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_DeleteCard.Location = new System.Drawing.Point(1196, 6);
            this.btn_DeleteCard.Name = "btn_DeleteCard";
            this.btn_DeleteCard.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_DeleteCard.Size = new System.Drawing.Size(120, 56);
            this.btn_DeleteCard.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_DeleteCard.TabIndex = 288;
            this.btn_DeleteCard.Values.Image = global::Odin.Global_Resourses.delete2__2_;
            this.btn_DeleteCard.Values.Text = "Delete";
            this.btn_DeleteCard.Click += new System.EventHandler(this.btn_DeleteCard_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Print.Location = new System.Drawing.Point(1076, 6);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Print.Size = new System.Drawing.Size(120, 56);
            this.btn_Print.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Print.TabIndex = 8;
            this.btn_Print.Values.Image = global::Odin.Global_Resourses.Print2;
            this.btn_Print.Values.Text = "Print";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_CloseCard
            // 
            this.btn_CloseCard.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_CloseCard.Location = new System.Drawing.Point(946, 6);
            this.btn_CloseCard.Name = "btn_CloseCard";
            this.btn_CloseCard.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_CloseCard.Size = new System.Drawing.Size(130, 56);
            this.btn_CloseCard.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_CloseCard.TabIndex = 7;
            this.btn_CloseCard.Values.Image = global::Odin.Global_Resourses.Finish_big;
            this.btn_CloseCard.Values.Text = "Close";
            this.btn_CloseCard.Click += new System.EventHandler(this.btn_CloseCard_Click);
            // 
            // btn_Deny
            // 
            this.btn_Deny.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Deny.Location = new System.Drawing.Point(826, 6);
            this.btn_Deny.Name = "btn_Deny";
            this.btn_Deny.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Deny.Size = new System.Drawing.Size(120, 56);
            this.btn_Deny.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Deny.TabIndex = 6;
            this.btn_Deny.Values.Image = global::Odin.Global_Resourses.Decline_32;
            this.btn_Deny.Values.Text = "Decline\r\nrepair";
            this.btn_Deny.Click += new System.EventHandler(this.btn_Deny_Click);
            // 
            // btn_Approve
            // 
            this.btn_Approve.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Approve.Location = new System.Drawing.Point(701, 6);
            this.btn_Approve.Name = "btn_Approve";
            this.btn_Approve.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Approve.Size = new System.Drawing.Size(125, 56);
            this.btn_Approve.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Approve.TabIndex = 5;
            this.btn_Approve.Values.Image = global::Odin.Global_Resourses.Approve_32;
            this.btn_Approve.Values.Text = "Approve\r\nrepair";
            this.btn_Approve.Click += new System.EventHandler(this.btn_Approve_Click);
            // 
            // btn_VisualControl
            // 
            this.btn_VisualControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_VisualControl.Location = new System.Drawing.Point(568, 6);
            this.btn_VisualControl.Name = "btn_VisualControl";
            this.btn_VisualControl.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_VisualControl.Size = new System.Drawing.Size(133, 56);
            this.btn_VisualControl.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_VisualControl.TabIndex = 287;
            this.btn_VisualControl.Values.Image = global::Odin.Global_Resourses.watchman;
            this.btn_VisualControl.Values.Text = "Visual\r\ncontrol";
            this.btn_VisualControl.Click += new System.EventHandler(this.btn_VisualControl_Click);
            // 
            // txt_Worker
            // 
            this.txt_Worker.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_Worker.Enabled = false;
            this.txt_Worker.Location = new System.Drawing.Point(1252, 6);
            this.txt_Worker.Multiline = true;
            this.txt_Worker.Name = "txt_Worker";
            this.txt_Worker.ReadOnly = true;
            this.txt_Worker.Size = new System.Drawing.Size(220, 56);
            this.txt_Worker.StateDisabled.Back.Color1 = System.Drawing.Color.Yellow;
            this.txt_Worker.StateDisabled.Content.Color1 = System.Drawing.Color.Black;
            this.txt_Worker.StateDisabled.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txt_Worker.TabIndex = 9;
            this.txt_Worker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ChangeWorker
            // 
            this.btn_ChangeWorker.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_ChangeWorker.Location = new System.Drawing.Point(1472, 6);
            this.btn_ChangeWorker.Name = "btn_ChangeWorker";
            this.btn_ChangeWorker.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_ChangeWorker.Size = new System.Drawing.Size(65, 56);
            this.btn_ChangeWorker.TabIndex = 10;
            this.btn_ChangeWorker.Values.Image = global::Odin.Global_Resourses.workers_refresh;
            this.btn_ChangeWorker.Values.Text = "";
            this.btn_ChangeWorker.Click += new System.EventHandler(this.btn_ChangeWorker_Click);
            // 
            // btn_Repair
            // 
            this.btn_Repair.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Repair.Location = new System.Drawing.Point(433, 6);
            this.btn_Repair.Name = "btn_Repair";
            this.btn_Repair.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Repair.Size = new System.Drawing.Size(135, 56);
            this.btn_Repair.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Repair.TabIndex = 4;
            this.btn_Repair.Values.Image = global::Odin.Global_Resourses.Repair48x48;
            this.btn_Repair.Values.Text = "Repair";
            this.btn_Repair.Click += new System.EventHandler(this.btn_Repair_Click);
            // 
            // btn_Actions
            // 
            this.btn_Actions.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Actions.Location = new System.Drawing.Point(273, 6);
            this.btn_Actions.Name = "btn_Actions";
            this.btn_Actions.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Actions.Size = new System.Drawing.Size(160, 56);
            this.btn_Actions.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Actions.TabIndex = 3;
            this.btn_Actions.Values.Image = global::Odin.Global_Resourses.Deficite48x48;
            this.btn_Actions.Values.Text = "Actions";
            this.btn_Actions.Click += new System.EventHandler(this.btn_Actions_Click);
            // 
            // btn_AddCard
            // 
            this.btn_AddCard.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_AddCard.Location = new System.Drawing.Point(136, 6);
            this.btn_AddCard.Name = "btn_AddCard";
            this.btn_AddCard.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_AddCard.Size = new System.Drawing.Size(137, 56);
            this.btn_AddCard.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_AddCard.TabIndex = 2;
            this.btn_AddCard.Values.Image = global::Odin.Global_Resourses.Search1;
            this.btn_AddCard.Values.Text = "Identify";
            this.btn_AddCard.Click += new System.EventHandler(this.btn_AddCard_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.Location = new System.Drawing.Point(1537, 6);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Close.Size = new System.Drawing.Size(165, 56);
            this.btn_Close.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Values.Image = global::Odin.Global_Resourses.exit;
            this.btn_Close.Values.Text = "Exit";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Create.Location = new System.Drawing.Point(6, 6);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btn_Create.Size = new System.Drawing.Size(130, 56);
            this.btn_Create.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Create.TabIndex = 1;
            this.btn_Create.Values.Image = global::Odin.Global_Resourses.AddForm;
            this.btn_Create.Values.Text = "Create";
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // frm_RepairCardFin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 961);
            this.Controls.Add(this.layoutCards);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.kryptonHeaderGroupTop);
            this.KeyPreview = true;
            this.Name = "frm_RepairCardFin";
            this.TabText = "Repair card";
            this.Text = "Repair card";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_RepairCardFin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroupTop.Panel)).EndInit();
            this.kryptonHeaderGroupTop.Panel.ResumeLayout(false);
            this.kryptonHeaderGroupTop.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroupTop)).EndInit();
            this.kryptonHeaderGroupTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroupTop;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Create;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_AddCard;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Actions;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Repair;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Approve;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Deny;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_CloseCard;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Print;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Worker;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_ChangeWorker;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Close;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel pnlBottom;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_PrevPage;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_PageInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_NextPage;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Refresh;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Oper;
        private System.Windows.Forms.TableLayoutPanel layoutCards;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lbl_OperPrompt;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_VisualControl;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_DeleteCard;
    }
}