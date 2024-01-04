namespace Odin.Workshop
{
    partial class ctl_ProductivityChart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.productivityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productivity = new Odin.Workshop.Productivity();
            this.bs_List = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productivityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Area3DStyle.Inclination = 45;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.PointDepth = 50;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.productivityBindingSource;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Week";
            series1.XValueMember = "Week";
            series1.YValueMembers = "0";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1900, 516);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Productivity indicator";
            // 
            // productivityBindingSource
            // 
            this.productivityBindingSource.DataMember = "ProductivityDataTable";
            this.productivityBindingSource.DataSource = this.productivity;
            // 
            // productivity
            // 
            this.productivity.DataSetName = "Productivity";
            this.productivity.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(1764, 48);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(90, 42);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Values.Image = global::Odin.Global_Resourses.Save_24x24;
            this.btn_Save.Values.Text = "";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // ctl_ProductivityChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.chart1);
            this.Name = "ctl_ProductivityChart";
            this.Size = new System.Drawing.Size(1900, 516);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productivityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_List)).EndInit();
            this.ResumeLayout(false); this.GetKryptonFormFields(this.GetType());

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource bs_List;
        private System.Windows.Forms.BindingSource productivityBindingSource;
        private Productivity productivity;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Save;
    }
}
