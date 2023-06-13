using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using ComponentFactory.Krypton.Toolkit;

namespace Odin.Global_Classes
{
    public class class_Global
    {

        public static string sConnStr = Properties.Settings.Default.OdinDBConnectionString;

        public int NEN_Int(string Fld)
        {
            if (String.IsNullOrEmpty(Fld) || Fld == "(None)")
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(Fld);
            }
        }

        public long NEN_LongInt(string Fld)
        {
            if (String.IsNullOrEmpty(Fld) || Fld == "(None)")
            {
                return 0;
            }
            else
            {
                return Convert.ToInt64(Fld);
            }
        }

        public float NEN_Float(string Fld)
        {
            if (String.IsNullOrEmpty(Fld) || Fld == "(None)")
            {
                return 0;
            }
            else
            {
                return 1;//float.Parse(Convert.ToDouble(Fld));
            }
        }

        public double NEN_Double(string Fld)
        {
            if (String.IsNullOrEmpty(Fld) || Fld == "(None)")
            {
                return 0;
            }
            else
            {
                return Convert.ToDouble(Fld);
            }
        }

        public string NES(string Fld)
        {
            if (String.IsNullOrEmpty(Fld)
                || Fld == "  /  /"
                || Fld == "  .  ."
                || Fld == "(None)"
                || Fld == null)
            {
                return "";
            }
            else
            {
                return Fld;
            }
        }

        public bool NumToBool(string Fld)
        {
            if (Fld == "-1")
            { return true; }
            else
            { return false; }
        
        }

        public bool IntToBool(int Fld)
        {
            if (Fld == -1)
            { return true; }
            else
            { return false; }

        }
        /*public bool CheckToBool(string Fld)
        {
            if (Fld == "Checked")
            { return true; }
            else
            { return false; }
        }*/

        public int BoolToCheck(bool Fld)
        {
            if (Fld == true)
            { return -1; }
            else
            { return 0; }
        }

        public int BitToInt(int Fld)
        {
            if (Fld == 1)
            { return -1; }
            else
            { return 0; }
        }
        public bool ConfirmDeliveries()
        {
            string message = "Are you sure you want to confirm selected deliveries?";//global::BookIntes.Global_Resourses.Move_Confirm.ToString();
            string caption = "Confirming ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        }
        
        /// <summary>
        /// Displays delete confirm message box
        /// </summary>
        public bool DeleteConfirm()
        {
            DialogResult result = KryptonTaskDialog.Show("Deleting warning!",
                                "",
                               global::Odin.Global_Resourses.Delete_Confirm.ToString(),
                               MessageBoxIcon.Warning,
                               TaskDialogButtons.Yes | TaskDialogButtons.No);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;


            //return MessageConfirm(global::Odin.Global_Resourses.Delete_Caption.ToString(),
            //    global::Odin.Global_Resourses.Delete_Confirm.ToString());
        }

        public bool ClearConfirm()
        {
            DialogResult result = KryptonTaskDialog.Show("Clear warning!",
                                "",
                               "Are you sure you want to clear list?",
                               MessageBoxIcon.Warning,
                               TaskDialogButtons.Yes | TaskDialogButtons.No);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
            
        }

        public bool ConfirmMessage(string Title, string Instruction, string MainContent)
        {
            DialogResult result = KryptonTaskDialog.Show(Title,
                                Instruction,
                               MainContent,
                               MessageBoxIcon.Warning,
                               TaskDialogButtons.Yes | TaskDialogButtons.No);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;

        }

        public void ShowMessage(string Title, string Instruction, string MainContent)
        {
            DialogResult result = KryptonTaskDialog.Show(Title,
                                Instruction,
                               MainContent,
                               MessageBoxIcon.Warning,
                               TaskDialogButtons.OK);
        }
        public bool CloseConfirm()
        {
            DialogResult result = KryptonTaskDialog.Show("Closing warning!",
                                "Closing will delete reservation for batch!",
                               "Are you sure you want to close batch?",
                               MessageBoxIcon.Warning,
                               TaskDialogButtons.Yes | TaskDialogButtons.No);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        public bool CancelConfirm()
        {
            DialogResult result = KryptonTaskDialog.Show("Cancelling warning!",
                                "Cancelling will delete reservation for all lines!",
                               "Are you sure you want to cancel?",
                               MessageBoxIcon.Warning,
                               TaskDialogButtons.Yes | TaskDialogButtons.No);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        public bool CloseConfirmProject()
        {
            DialogResult result = KryptonTaskDialog.Show("Closing warning!",
                                "Closing will delete reservation for project!",
                               "Are you sure you want to close project?",
                               MessageBoxIcon.Warning,
                               TaskDialogButtons.Yes | TaskDialogButtons.No);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        public bool CloseConfirmInvoice()
        {
            DialogResult result = KryptonTaskDialog.Show("Closing warning!",
                                "Closing will make line inactive!",
                               "Are you sure you want to make inactive line?",
                               MessageBoxIcon.Warning,
                               TaskDialogButtons.Yes | TaskDialogButtons.No);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        public bool CloseProjectConfirm()
        {
            DialogResult result = KryptonTaskDialog.Show("Closing warning!",
                                "",
                               "Are you sure you want to close whole project?",
                               MessageBoxIcon.Warning,
                               TaskDialogButtons.Yes | TaskDialogButtons.No);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        public bool RemoveReservationConfirm()
        {
            DialogResult result = KryptonTaskDialog.Show("Deletion of reservation warning!",
                                "Operation will remove reservation of label for batch!",
                               "Are you sure you want to remove label reservation for batch?",
                               MessageBoxIcon.Warning,
                               TaskDialogButtons.Yes | TaskDialogButtons.No);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }

        public bool OpenConfirm()
        {
            DialogResult result = KryptonTaskDialog.Show("Closing warning!",
                                "",
                               "Are you sure you want to re-open batch?",
                               MessageBoxIcon.Warning,
                               TaskDialogButtons.Yes | TaskDialogButtons.No);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Displays confirm message box
        /// </summary>
        /// <param name="caption">MessageBox Caption</param>
        /// <param name="message">MessageBox text</param>
        /// <returns>Boolean vale</returns>
        public bool MessageConfirm(string caption, string message)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        public bool CloseLine()
        {
            string message = "Are you sure you want to close line?";//global::BookIntes.Global_Resourses.Move_Confirm.ToString();
            string caption = "Closing ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        }
        public bool SaveConfirm()
        {
            string message = global::Odin.Global_Resourses.Save_Confirm.ToString();
            string caption = global::Odin.Global_Resourses.Save_Caption.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        }

        public bool MoveConfirm(string MsgFrom, string MsgDest)
        {
            string message = "Are you sure you want to move " + MsgFrom + "to" + MsgDest + "?";//global::BookIntes.Global_Resourses.Move_Confirm.ToString();
            string caption = global::Odin.Global_Resourses.Move_Caption.ToString();
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        }
        public bool DeleteApproveConfirm(int ReqId)
        {
            string message = "Request NO: " + ReqId.ToString() + " already have approving. Are you sure you want to remove approving?";//global::BookIntes.Global_Resourses.Move_Confirm.ToString();
            string caption = "Approve removal";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        }
        public bool DeleteApproveInvoice(string Invoice)
        {
            string message = "Are you sure you want to open invoice NO: " + Invoice + "?";//global::BookIntes.Global_Resourses.Move_Confirm.ToString();
            string caption = "Approve opening";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        }
        public bool ApprovePOMOQ()
        {
            string message = "MOQ or MPQ is more than you indicated, do you want to recalculate qty?";//global::BookIntes.Global_Resourses.Move_Confirm.ToString();
            string caption = "Approve qty to MOQ ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        }
        public bool ApproveBlockClientOrder()
        {
            string message = "Are you sure you want to block ALL order?";//global::BookIntes.Global_Resourses.Move_Confirm.ToString();
            string caption = "Block ALL order? ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        }

        public bool CopyConfirm()
        {
            string message = "Are you sure you want to copy selected line?";//global::BookIntes.Global_Resourses.Move_Confirm.ToString();
            string caption = "Copy line?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        }

        public bool CopyConfirmRatio()
        {
            string message = "Are you sure you want to copy ratio?";//global::BookIntes.Global_Resourses.Move_Confirm.ToString();
            string caption = "Copy ratio?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        }

        public bool CopyConfirmSetup()
        {
            string message = "Are you sure you want to copy ratio?";//global::BookIntes.Global_Resourses.Move_Confirm.ToString();
            string caption = "Copy ratio?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        }

        public bool ApprovePOtoCOcreation()
        {
            string message = "Are you sure you want to create customer order based on purchase order?";//global::BookIntes.Global_Resourses.Move_Confirm.ToString();
            string caption = "CO creation ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        }
        public bool ConfirmReqClose(string str)
        {
            string message = "Are you sure you want to close request line for" + str + "?";//global::BookIntes.Global_Resourses.Move_Confirm.ToString();
            string caption = "Request closing ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        }
        public bool ConfirmUpdateForAllLines(string str)
        {
            string message = "Are you sure you want to copy/paste value from " + str + " for all lines?";//global::BookIntes.Global_Resourses.Move_Confirm.ToString();
            string caption = "Confirm changes ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        }

        public bool ConfirmUpdateRespPersonTech(string oldresppers, string newresppers)
        {
            string message = "Do you want to update responsible person for article from " + oldresppers + " to " + newresppers + "?";//global::BookIntes.Global_Resourses.Move_Confirm.ToString();
            string caption = "Confirm updating of responsible person ";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons, icon);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
                return false;
        }

        public bool StartLaunchConfirm()
        {
            DialogResult result = KryptonTaskDialog.Show("Are you sure to start selected launch?",
                                "",
                              "Are you sure to start selected launch?",
                               MessageBoxIcon.Question,
                               TaskDialogButtons.Yes | TaskDialogButtons.No);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;


            //return MessageConfirm(global::Odin.Global_Resourses.Delete_Caption.ToString(),
            //    global::Odin.Global_Resourses.Delete_Confirm.ToString());
        }

        public bool ReserveLaunchConfirm()
        {
            DialogResult result = KryptonTaskDialog.Show("Are you sure to reserve RM for selected launch?",
                                "",
                              "Are you sure to reserve RM for selected launch?",
                               MessageBoxIcon.Question,
                               TaskDialogButtons.Yes | TaskDialogButtons.No);
            if (result == DialogResult.Yes)
                return true;
            else
                return false;


            //return MessageConfirm(global::Odin.Global_Resourses.Delete_Caption.ToString(),
            //    global::Odin.Global_Resourses.Delete_Confirm.ToString());
        }

        public double TryCatchDouble(string Value)
        {
            double DoubleVal;

            bool result = Double.TryParse(Value, out DoubleVal);
            if (result == false || DoubleVal < 0)
            { return 0; }
            else
            {
                return DoubleVal;
            }
        }
        public int TryCatchInt(string Value)
        {
            int Int32Val;

            bool result = int.TryParse(Value, out Int32Val);
            if (result == false || Int32Val < 0)
            { return 0; }
            else
            {
                return Int32Val;
            }
        }
        public string IsDateTime(string Value)
        {
            DateTime IsDT;
            try
            {
                bool result = DateTime.TryParse(Value, out IsDT);
                if (result == false)
                { return ""; }
                else
                { return IsDT.ToShortDateString(); ; }
            }
            catch (FormatException)
            {
                return "";
            }
        }
       
        public static DataTable GlobalDT(string sQueryString)
        {
            //string sConnStr = Properties.Settings.Default.DBAxonConnectionString;
            using (SqlConnection connection = new SqlConnection(sConnStr))
            {

                SqlDataAdapter sda = new SqlDataAdapter(sQueryString, connection);

                DataSet ds = new DataSet();

                sda.Fill(ds);
                                
                return ds.Tables[0];

            }

        }

        public string BeforeChar(string Fld, string chr)
        {
            int k = Fld.IndexOf(chr);
            if (k == -1)
                return Fld;
            else
                return Fld.Substring(0, k);
        }
        public string ReplaceChar(string Fld, string Pattern, string Replacement)
        {
            //Regex rgx = new Regex(Pattern);
            //return rgx.Replace(Fld, Replacement);
            return Fld.Replace(Pattern, Replacement);
        }

        public bool IsFormAlreadyOpen(string sFormName)
        {
            var isFound = false;

            foreach (Form f in Application.OpenForms)
            {
                //f.BringToFront();
                if (f.Name == sFormName)
                {
                    f.BringToFront();
                    f.WindowState = FormWindowState.Normal;
                    isFound = true;
                }
            }

            return isFound;
        }

        public void DeleteAlreadyOpenForm(string sFormName)
        {
            foreach (Form f in Application.OpenForms)
            {
                //f.BringToFront();
                if (f.Name == sFormName)
                {
                    f.Close();
                    break;
                }
            }
        }

        public static bool IsFoundControl(Control container, Type type)
        {
            foreach (Control c in container.Controls)
            {
                if (c.GetType() == type)
                {
                    return true;
                }

                if (c.Controls.Count > 0)
                {
                    return IsFoundControl(c, type);
                }
            }

            return false;
        }

        
        public double RoundUp(double Num, int Dec)
        {
            switch (Dec)
            {
                case 0:
                    return Math.Round((Num + 0.499), 0);
                case 1:
                    return Math.Round((Num + 0.0499), 1);
                case 2:
                    return Math.Round((Num + 0.00499), 2);
                case 3:
                    return Math.Round((Num + 0.000499), 3);
                case 4:
                    return Math.Round((Num + 0.0000499), 4);
                case 5:
                    return Math.Round((Num + 0.00000499), 5);
                default: return Math.Round(Num, Dec);
            }
        }
        public string[] Array36 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F", "G", "H",
                                     "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

        public int Convert_36to10(string _value)
        {
            int _res = 0;
            int _lenght = _value.Length;

            while (_lenght > 0)
            {

                _res = _res + Array.IndexOf(Array36, _value.Substring(_value.Length - _lenght, 1)) * (Convert.ToInt32(Math.Pow(36, _lenght - 1)));
                _lenght--;
            }

            return _res;
        }

        public string Convert_10to36(int _value)
        {
            string _res = "";
            int _remainder;
            while (_value > 0)
            {
                _remainder = _value % 36;
                _value = _value / 36;

                _res = Array36[_remainder] + _res;
            }

            return _res;
        }
        public static float ToSingle(double value)
        {
            return (float)value;
        }
    }
}
