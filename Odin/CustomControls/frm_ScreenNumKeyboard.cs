using Odin.Global_Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Odin.CustomControls
{
    public delegate void DisplayKeyboardSymbolEventHandler(string symbol, bool symremove);


    public partial class frm_ScreenNumKeyboard : Template_CMB
    {
        public event DisplayKeyboardSymbolEventHandler DisplayKeyboardSymbol;

        PopupWindowHelper PopupHelper = null;

        Font boldFont;

        bool _showingModal = false;

        string _decSeparator = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0].ToString();
        public string DecSeparator
        {
            get { return _decSeparator; }
        }

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

        public frm_ScreenNumKeyboard()
        {
            InitializeComponent();
            PopupHelper = new PopupWindowHelper();

        }



        private void frm_ScreenNumKeyboard_Load(object sender, EventArgs e)
        {
            int count = 1;

            #region old
            //for (int row = 0; row < 4; row++)
            //{

            //    for (int button_in_row = 0; button_in_row < 4; button_in_row++)
            //    {
            //        if (row < 3 && button_in_row < 3)
            //        {
            //            drawButton(row, button_in_row, count.ToString(), 50, 50);
            //            count++;
            //        }
            //        else if (row == 3 && button_in_row == 0)
            //        {
            //            drawButton(row, button_in_row, "0", 100, 50);
            //        }
            //        else if (row == 3 && button_in_row == 1)
            //        {
            //            drawButton(row, button_in_row, ",", 50, 50);
            //            break;
            //        }

            //        if (row == 2 && button_in_row == 3)
            //        {
            //            drawButton(row, button_in_row, "OK", 50, 100);
            //        }

            //        if (row == 0 && button_in_row == 3)
            //        {
            //            drawButton(row, button_in_row, "-", 50, 50);
            //        }
            //        if (row == 1 && button_in_row == 3)
            //        {
            //            drawButton(row, button_in_row, "Back", 50, 50);
            //        }

            //    }

            //}

            #endregion

            for (int row = 0; row < 4; row++)
            {
                int buttonwidth = (Int32)this.Width / 4;
                int buttonheigh = (Int32)this.Height / 4;

                for (int button_in_row = 0; button_in_row < 4; button_in_row++)
                {
                    if (row < 3 && button_in_row < 3)
                    {
                        drawButton(row, button_in_row, count.ToString(), buttonwidth, buttonheigh);
                        count++;
                    }
                    else if (row == 3 && button_in_row == 0)
                    {
                        drawButton(row, button_in_row, "0", buttonwidth * 2, buttonheigh);
                    }
                    else if (row == 3 && button_in_row == 1)
                    {
                        drawButton(row, button_in_row, ",", buttonwidth, buttonheigh);
                        break;
                    }

                    if (row == 2 && button_in_row == 3)
                    {
                        drawButton(row, button_in_row, "OK", buttonwidth, buttonheigh * 2);
                    }

                    if (row == 0 && button_in_row == 3)
                    {
                        drawButton(row, button_in_row, "-", buttonwidth, buttonheigh);
                    }
                    if (row == 1 && button_in_row == 3)
                    {
                        drawButton(row, button_in_row, "Back", buttonwidth, buttonheigh);
                    }

                }

            }
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
                    if ((string)button.Text != "Back")
                    {
                        switch ((string)button.Text)
                        {
                            case ",":
                                tempString = CellText;

                                if (tempString.Contains(DecSeparator))
                                {
                                    return;
                                }
                                else
                                {
                                    DisplayKeyboardSymbol(DecSeparator, false);//
                                }

                                break;

                            case "-":
                                tempString = CellText != null ? CellText : string.Empty;

                                if (tempString.Contains("-"))
                                {
                                    return;
                                }

                                else if (string.IsNullOrEmpty(tempString))
                                {
                                    DisplayKeyboardSymbol("-", false);//
                                }

                                break;

                            case "OK":
                                this.Close();
                                break;

                            default:
                                DisplayKeyboardSymbol(button.Text, false);//

                                break;
                        }
                    }
                    else
                    {
                        cellVal = CellText;

                        DisplayKeyboardSymbol(cellVal.Remove(cellVal.Length - 1), true);
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
