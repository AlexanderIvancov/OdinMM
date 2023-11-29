using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Odin.Workshop
{
    public partial class ctl_ProductivityChart : UserControl
    {
        public ctl_ProductivityChart()
        {
            InitializeComponent();
        }

        public void FillData(DataTable dt)
        {
            // bind the data table to chart
            this.chart1.Series.Clear();

            var series = this.chart1.Series.Add("Productivity (%)");
            series.XValueMember = "Id";
            series.YValueMembers = "Percentage";
            series.ChartType = SeriesChartType.Column;

            this.chart1.DataSource = dt;
            this.chart1.DataBind();
            // custom labels 
            //foreach (var g in dt.AsEnumerable().GroupBy(x => x.Field<string>("Week")))
            //{
            //    string week = g.Key;
            //    var stages = g.Select(r => new { Id = r.Field<int>("Id"), Stage = r.Field<string>("Stage") });
            //    // find min-max
            //    int min = stages.Min(y => y.Id);
            //    int max = stages.Max(y => y.Id);
            //    // stage labels
            //    foreach (var stage in stages)
            //    {
            //        var label = new CustomLabel(stage.Id - 1, stage.Id + 1, stage.Stage, 0, LabelMarkStyle.None);
            //        this.chart1.ChartAreas[0].AxisX.CustomLabels.Add(label);
            //    }
            //    // stage weeks
            //    var weeklabel = new CustomLabel(min, max, week, 1, LabelMarkStyle.LineSideMark);
            //    this.chart1.ChartAreas[0].AxisX.CustomLabels.Add(weeklabel);
            //}
            foreach (var g in dt.AsEnumerable().GroupBy(x => x.Field<string>("Stage")))
            {
                string stage = g.Key;

                var weeks = g.Select(r => new { Id = r.Field<int>("Id"), Week = r.Field<string>("Week"), legend = r.Field<string>("legend"), percentage = r.Field<int>("Percentage") });
                // find min-max
                int min = weeks.Min(y => y.Id);
                int max = weeks.Max(y => y.Id);
                // stage labels
                foreach (var week in weeks)
                {
                    var label = new CustomLabel(week.Id - 1, week.Id + 1, week.Week.Substring(0, 3), 0, LabelMarkStyle.None);
                    this.chart1.ChartAreas[0].AxisX.CustomLabels.Add(label);

                }
                // stage weeks.

                var stagelabel = new CustomLabel(min == max ? min - 1 : min, min == max ? max + 1 : max, stage, 2, min == max ? LabelMarkStyle.None : LabelMarkStyle.LineSideMark);
                this.chart1.ChartAreas[0].AxisX.CustomLabels.Add(stagelabel);

                //chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 270;

            }
            series.IsValueShownAsLabel = false;
            for (var idx = 0; idx < series.Points.Count; idx++)
            {
                var node = dt.AsEnumerable().
                    Where(r => r.Field<int>("Id") == Convert.ToInt32(series.Points[idx].XValue)).FirstOrDefault();

                series.Points[idx].Label = node["legend"].ToString();
                //int _addy = series.Points[idx].AddY(35);

            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Save image as ...";
                sfd.Filter = "*.bmp|*.bmp;|*.png|*.png;|*.jpg|*.jpg";
                sfd.AddExtension = true;
                sfd.FileName = "graphicImage";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    switch (sfd.FilterIndex)
                    {
                        case 1: chart1.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Bmp); break;
                        case 2: chart1.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png); break;
                        case 3: chart1.SaveImage(sfd.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg); break;
                    }
                }
            }
        }
    }
}
