namespace Odin.Workshop
{
    partial class frm_Workplaces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Workplaces));
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ctl_Workplaces1 = new Odin.Workshop.ctl_Workplaces();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.btn_Cancel);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 596);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.HeaderPrimary;
            this.kryptonPanel2.Size = new System.Drawing.Size(978, 49);
            this.kryptonPanel2.TabIndex = 34;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Cancel.Location = new System.Drawing.Point(883, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(90, 39);
            this.btn_Cancel.TabIndex = 228;
            this.btn_Cancel.Values.Image = global::Odin.Global_Resourses.Cancel;
            this.btn_Cancel.Values.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // ctl_Workplaces1
            // 
            this.ctl_Workplaces1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctl_Workplaces1.Location = new System.Drawing.Point(0, 0);
            this.ctl_Workplaces1.Name = "ctl_Workplaces1";
            this.ctl_Workplaces1.ProdPlaceId = 0;
            this.ctl_Workplaces1.Size = new System.Drawing.Size(978, 596);
            this.ctl_Workplaces1.TabIndex = 35;
            // 
            // frm_Workplaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 645);
            this.Controls.Add(this.ctl_Workplaces1);
            this.Controls.Add(this.kryptonPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Workplaces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "Workplaces assignment";
            this.Text = "Workplaces assignment";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public Main _Main;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
        public ctl_Workplaces ctl_Workplaces1;
    }
}