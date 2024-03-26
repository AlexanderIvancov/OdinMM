using NPOI.HPSF;
using NPOI.HSSF.UserModel;
using NPOI.HSSF.Util;
using NPOI.SS.UserModel;
using Odin.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Odin.Global_Classes
{
    public class ExportData
    {
        private frm_Wait fmWait = null;
        private HSSFWorkbook hssfworkbook;

        public string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public DataGridView dgv
        {
            get;
            set;
        }

        public string fileName
        {
            get;
            set;
        }

        public string formname
        {
            get;
            set;
        }

        public bool showHiddenColumns
        {
            get;
            set;
        }

        public string Query
        {
            get;
            set;
        }

        public List<SqlParameter> SqlParams
        {
            get;
            set;
        }

        public ExportData(DataGridView Dgv, string Filename, string Formname)
        {
            dgv = Dgv;
            fileName = Filename;
            formname = Formname;
        }

        /// <summary> 
        /// Exports DateGridView rows to Excel file
        /// </summary> 
        public void DgvIntoExcel()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //MessageBox.Show(path);
            SaveFileDialog savefiledialog1 = new SaveFileDialog();
            savefiledialog1.InitialDirectory = path;

            savefiledialog1.FileName = fileName;
            savefiledialog1.DefaultExt = "xls";
            savefiledialog1.Filter = "Excel Files (*.xls)|*.xls|All files (*.*)|*.*";
            savefiledialog1.FilterIndex = 1;
            savefiledialog1.RestoreDirectory = true;


            if (savefiledialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = savefiledialog1.FileName;
                if (!string.IsNullOrEmpty(fileName))
                {
                    frm_ChooseColumns frmColumns = new frm_ChooseColumns();
                    frmColumns.AddCheckBoxes(dgv, formname);
                    var dialogResult = frmColumns.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        dgv.Enabled = false;
                        BackgroundWorker bw = new BackgroundWorker();
                        bw.DoWork += ImportData;

                        bw.RunWorkerCompleted += ImportCompleted;

                        fmWait = new frm_Wait();

                        bw.RunWorkerAsync(frmColumns.ColumnsList);
                        fmWait.Start();
                        fmWait.Show();
                    }
                }
            }
        }

        /// Exports DateGridView rows to Excel file
        /// </summary> 
        public void QueryIntoExcel()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //MessageBox.Show(path);
            SaveFileDialog savefiledialog1 = new SaveFileDialog();
            savefiledialog1.InitialDirectory = path;

            savefiledialog1.FileName = fileName;
            savefiledialog1.DefaultExt = "xls";
            savefiledialog1.Filter = "Excel Files (*.xls)|*.xls|All files (*.*)|*.*";
            savefiledialog1.FilterIndex = 1;
            savefiledialog1.RestoreDirectory = true;


            if (savefiledialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = savefiledialog1.FileName;
                if (!string.IsNullOrEmpty(fileName))
                {
                        dgv.Enabled = false;
                        BackgroundWorker bw = new BackgroundWorker();
                        bw.DoWork += ImportQueryData;

                        bw.RunWorkerCompleted += ImportCompleted;

                        fmWait = new frm_Wait();

                        bw.RunWorkerAsync();
                        fmWait.Start();
                        fmWait.Show();
                    
                }
            }
        }

        private void SetHeaderValue(ISheet sheet1, DataGridViewColumn column, IRow headerRow, int j)
        {
            ICell cell1 = HSSFCellUtil.CreateCell(headerRow, /*column.DisplayIndex*/j, column.HeaderText);

            IFont font1 = hssfworkbook.CreateFont();
            font1.Boldweight = (short)FontBoldWeight.Bold;

            ICellStyle style2 = hssfworkbook.CreateCellStyle();
            style2.SetFont(font1);

            cell1.CellStyle = style2;
            sheet1.AutoSizeColumn(/*column.DisplayIndex*/j);
        }

        private void SetHeaderQueryValue(ISheet sheet1, DataColumn column, IRow headerRow, int j)
        {
            ICell cell1 = HSSFCellUtil.CreateCell(headerRow, j, column.ColumnName);

            IFont font1 = hssfworkbook.CreateFont();
            font1.Boldweight = (short)FontBoldWeight.Bold;

            ICellStyle style2 = hssfworkbook.CreateCellStyle();
            style2.SetFont(font1);

            cell1.CellStyle = style2;
            sheet1.AutoSizeColumn(j);
        }


        private void InitializeWorkbook()
        {
            hssfworkbook = new HSSFWorkbook();

            ////create a entry of DocumentSummaryInformation
            DocumentSummaryInformation dsi = PropertySetFactory.CreateDocumentSummaryInformation();
            hssfworkbook.DocumentSummaryInformation = dsi;

            ////create a entry of SummaryInformation
            SummaryInformation si = PropertySetFactory.CreateSummaryInformation();
            si.Subject = "Exported";
            hssfworkbook.SummaryInformation = si;
        }

        private void ImportData(object sender, DoWorkEventArgs e)
        {
            InitializeWorkbook();

            ISheet sheet1 = hssfworkbook.CreateSheet("Sheet1");
            var param = e.Argument as List<DataGridViewColumn>;

            //MessageBox.Show(dgv.Rows.Count.ToString());
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                DataGridViewRow row = dgv.Rows[i]; // rows
                IRow rowExcel = sheet1.CreateRow(i + 1);

                fmWait.progressBar1.BeginInvoke(
                  (MethodInvoker)delegate
                  {
                      fmWait.progressBar1.Value = Convert.ToInt32(i * 10 * (100.0 / dgv.Rows.Count));
                  }
                );

                // Rows adding
                for (int k = 0; k < dgv.Columns.Count; k++)
                    if (param != null)
                    {
                        var col = param.Where(p => p.Name == dgv.Columns[k].Name).SingleOrDefault();
                        if (col != null)
                            try
                            {
                                var cell = rowExcel.CreateCell(k);
                                //ICellStyle Style = cell.CellStyle;
                                cell.CellStyle.FillPattern = FillPattern.SolidForeground;
                                cell.CellStyle.FillForegroundColor = typeMap[row.Cells[dgv.Columns[k].Index].Style.BackColor];
                                //cell.CellStyle = Style;
                                cell.SetCellValue(row.Cells[dgv.Columns[k].Index/*DisplayIndex*/].Value.ToString());
                            }
                            catch { rowExcel.CreateCell(k).SetCellValue(""); }
                    }
            }

            // Column headers
            var headerRow = sheet1.CreateRow(0);
            int j = 0;
            foreach (DataGridViewColumn column in dgv.Columns)
                if (param != null)
                {
                    var col = param.Where(p => p.Name == column.Name).SingleOrDefault();
                    if (col != null)
                    {
                        SetHeaderValue(sheet1, column, headerRow, j);
                        j++;
                    }
                }

            //Write the stream data of workbook to the root directory
            FileStream file = new FileStream(fileName, FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();
        }

        public static Dictionary<Color, short> typeMap = new Dictionary<Color, short>
        {
            [Color.White] = 9 ,
            [Color.LightGray] = 22,
            [Color.Magenta] = 14,
            [Color.WhiteSmoke] = 22,
            [Color.Yellow] = 13,
            [Color.Black] = 8 ,
            [Color.Blue] = 12,
            [Color.Red] = 10,
            [Color.Lime] = 34,
            [Color.Transparent] = 9 ,
            [Color.MediumSeaGreen] = 57,
            [Color.CornflowerBlue] = 48,
            [Color.SkyBlue] = 40,
            [Color.RoyalBlue] = 30,
            [Color.LightSkyBlue] = 35,
            [Color.DimGray] = 23,
            [Color.LightSteelBlue] = 27,
            [Color.Empty] = 9 ,
            [Color.LawnGreen] = 11,
            [Color.Green] = 17,
            [Color.Lavender] = 31,
            [Color.MediumBlue] = 39,
            [Color.AliceBlue] = 41,
            [Color.Gainsboro] = 22,
            [Color.Gold] = 51,
            [Color.Maroon] = 37,
            [Color.LightPink] = 45,
            [Color.Plum] = 61,
            [Color.Fuchsia] = 33,
            [Color.DarkOrange] = 53,
            [Color.DarkSlateGray] = 58,
            [Color.PapayaWhip] = 47,
            [Color.OliveDrab] = 50,
            [Color.Gray] = 63,
            [Color.Silver] = 55,
            [Color.Tomato] = 60,
            [Color.GreenYellow] = 42,
            [Color.LightCoral] = 29,
            [Color.Bisque] = 47,
            [Color.Azure] = 48,
            [Color.SandyBrown] = 43,
            [Color.Khaki] = 19,
            [Color.LightSalmon] = 29,
            [Color.NavajoWhite] = 26,
            [Color.Peru] = 52,
            [Color.IndianRed] = 29,
            [Color.Linen] = 26,
            [Color.Firebrick] = 37,
            [Color.Pink] = 45,
            [Color.DarkRed] = 37,
            [Color.Snow] = 9 ,
            [Color.DarkGray] = 63,
            [Color.DarkSlateBlue] = 32,
            [Color.DimGray] = 22,
            [Color.DarkBlue] = 12,
            [Color.LightYellow] = 43,
            [Color.CornflowerBlue] = 30,
            [Color.PowderBlue] = 24,
            [Color.SlateBlue] = 54,
            [Color.LightBlue] = 35,
            [SystemColors.WindowText] = 8 ,
            [SystemColors.Highlight] = 40,
            [SystemColors.HighlightText] = 9 ,
            [SystemColors.Window] = 9 ,
            [Color.PaleTurquoise] = 15,
            [Color.LightCyan] = 15,
            [SystemColors.ControlText] = 8,
            [SystemColors.AppWorkspace] = 9
        };

        private void ImportQueryData(object sender, DoWorkEventArgs e)
        {
            
            InitializeWorkbook();

            ISheet sheet1 = hssfworkbook.CreateSheet("Sheet1");
           

            var data = Helper.QuerySP(Query, SqlParams.ToArray());
            
            int columnNumber = 0;
            //MessageBox.Show(dgv.Rows.Count.ToString());
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DataRow row = data.Rows[i]; // rows
                IRow rowExcel = sheet1.CreateRow(i + 1);

                columnNumber = 0;

                fmWait.progressBar1.BeginInvoke(
                  (MethodInvoker)delegate
                  {
                      fmWait.progressBar1.Value = Convert.ToInt32(i * 10 * (100.0 / data.Rows.Count));
                  }
                );


                // Rows adding
                foreach (DataColumn column in data.Columns)// columns
                {
                    try
                    {
                        rowExcel.CreateCell(columnNumber).SetCellValue(row[column].ToString());
                    }
                    catch { rowExcel.CreateCell(columnNumber).SetCellValue(""); }
                    columnNumber++;
                }

            }

            // Column headers
            var headerRow = sheet1.CreateRow(0);
            int j = 0;
            foreach (DataColumn column in data.Columns)
            {
               SetHeaderQueryValue(sheet1, column, headerRow, j);
               j++;
            }


            //Write the stream data of workbook to the root directory
            FileStream file = new FileStream(fileName, FileMode.Create);
            hssfworkbook.Write(file);
            file.Close();


        }

        private void ImportCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (fmWait != null)
            {
                fmWait.Close();
                fmWait = null;
                dgv.Enabled = true;
            }

            if (e.Error != null)
            {
                return;
            }

            // Check to see if the background process was cancelled.
            if (e.Cancelled)
            {
                return;
            }
        }
    }
}
