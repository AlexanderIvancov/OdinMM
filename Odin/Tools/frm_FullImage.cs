using ComponentFactory.Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.Tools
{
    public partial class frm_FullImage : KryptonForm
    {
        public frm_FullImage()
        {
            InitializeComponent();
        }
        public string HeaderText
        {
            get { return this.Text; }
            set { this.Text = value; }
        }
        public void ShowImage(string Path)
        {
            try
            {

                pic_Image.ImageLocation = Path;
                pic_Image.Load();


            }
            catch
            {

                pic_Image.Image = null;
            }

        }
        private void btn_Print_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog diag = new PrintPreviewDialog();

            try
            {

                double aspectRatio = 0;
                double aspectRatioWidth = 0;
                double aspectRatioHeight = 0;


                double width = (double)pic_Image.Image.Width;
                double height = (double)pic_Image.Image.Height;

                aspectRatioWidth = 707 / width;
                aspectRatioHeight = 1000 / height;

                aspectRatio = width > height ? aspectRatioWidth : aspectRatioHeight;



                int wi = 0;
                wi = Convert.ToInt32(width * aspectRatio);
                int hi = 0;
                hi = Convert.ToInt32(height * aspectRatio);


                Bitmap New_Bitmap = new Bitmap(pic_Image.Image, wi, hi);
                pic_Image.Image = New_Bitmap;


                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169);
                printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);

                diag.Document = printDocument1;
                diag.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
        }
    }
}
