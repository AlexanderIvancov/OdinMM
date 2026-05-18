using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Odin.Global_Classes;

namespace Odin.CustomControls
{
    public delegate void DisplayKeyboardSymbolEventHandler16(string symbol, bool symremove);
    public delegate void SendClosingEventHandler16(object sender);

    public partial class frm_ScreenNumKeyboard16 : Template_CMB
    {
        public event DisplayKeyboardSymbolEventHandler16 DisplayKeyboardSymbol;
        public event SendClosingEventHandler16 SendClosing;

        PopupWindowHelper PopupHelper = null;

        Font boldFont;

        bool _showingModal = false;
       
      
        public bool ShowingModal
        {
            get { return _showingModal; }
            set { _showingModal = value; }
        }
       
        public string CellText
        {
            get;
            set;
        }

        public frm_ScreenNumKeyboard16()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();

        }

        

        private void frm_ScreenNumKeyboard_Load(object sender, EventArgs e)
        {   
                int buttonwidth = (Int32)this.Width / 5;
                int buttonheigh = (Int32)this.Height / 4;

                drawButton(0, 0, "1", buttonwidth, buttonheigh);
                drawButton(0, 1, "2", buttonwidth, buttonheigh);
                drawButton(0, 2, "3", buttonwidth, buttonheigh);
                drawButton(0, 3, "4", buttonwidth, buttonheigh);
                drawButton(0, 4, "-", buttonwidth, buttonheigh);
                drawButton(1, 0, "5", buttonwidth, buttonheigh);
                drawButton(1, 1, "6", buttonwidth, buttonheigh);
                drawButton(1, 2, "7", buttonwidth, buttonheigh);
                drawButton(1, 3, "8", buttonwidth, buttonheigh);
                drawButton(1, 4, "Back", buttonwidth, buttonheigh);
                drawButton(2, 0, "9", buttonwidth, buttonheigh);
                drawButton(2, 1, "0", buttonwidth, buttonheigh);
                drawButton(2, 2, "A", buttonwidth, buttonheigh);
                drawButton(2, 3, "B", buttonwidth, buttonheigh);
                drawButton(2, 4, "Clear", buttonwidth, buttonheigh);
                drawButton(3, 0, "C", buttonwidth, buttonheigh);
                drawButton(3, 1, "D", buttonwidth, buttonheigh);
                drawButton(3, 2, "E", buttonwidth, buttonheigh);
                drawButton(3, 3, "F", buttonwidth, buttonheigh);
                drawButton(3, 4, "OK", buttonwidth, buttonheigh);
            
        }

        private void drawButton(int i, int j, string count, int w, int h)
        {
            List<Button> digitButtons = new List<Button>();
            Button newbutton = new Button();
            newbutton.Name = "Button" + count;
            newbutton.Width = w;
            newbutton.Height = h;
            newbutton.Text = count;
            boldFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
           
            newbutton.Font = boldFont;
            newbutton.Left = count == "," ? newbutton.Width * (j * 2) : newbutton.Width * j;
            //newbutton.Top = newbutton.Height == 100 ? (newbutton.Height / 2) * i : newbutton.Height * i;
            newbutton.Top = newbutton.Height == (Int32)this.Height / 4 * 2 ? (newbutton.Height / 2) * i : newbutton.Height * i;

            newbutton.Click += new EventHandler(newbutton_Click);

            digitButtons.Add(new Button());
            this.Controls.Add(newbutton);
        }

        private void newbutton_Click(object sender, EventArgs e)
        {
            string cellVal = "";
            string tempString = "";

            if (DisplayKeyboardSymbol != null)
            {
                try
                {
                    Button button = sender as Button;
                    if ((string)button.Text == "Back")
                    {
                        cellVal = CellText;
                        DisplayKeyboardSymbol(cellVal.Remove(cellVal.Length - 1), true);
                    }
                    else if ((string)button.Text == "Clear")
                    {
                        cellVal = CellText;
                        DisplayKeyboardSymbol("", true);
                    }
                    else
                    {
                        switch ((string)button.Text)
                        {
                            case "-":
                                tempString = CellText != null ? CellText : string.Empty;

                                if (tempString.Contains("-"))
                                {
                                    return;
                                }

                                else
                                {
                                     DisplayKeyboardSymbol("-", false);//
                                }

                                break;

                            case "OK":
                               // SendClosing(this);
                                this.Close();
                                break;

                            default:
                                DisplayKeyboardSymbol(button.Text, false);//

                                break;
                        }
                    }


                }
                catch
                {
                    return;
                }
            }

        }
    }
}
