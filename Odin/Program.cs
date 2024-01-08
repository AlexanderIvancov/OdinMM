using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace Odin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //if (System.DateTime.Now < Convert.ToDateTime("06/07/2019"))
            Application.Run(new Main());
        }
    }
    public static class ObjectExtension
    {
        public static void GetKryptonFormFields(this object form, Type type)
        {
            //using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.OdinDBConnectionString))
            //{
            //    connection.Open();
            //    PropertyInfo property1 = null;
            //    PropertyInfo secproperty1 = null;
            //    PropertyInfo sizeproperty = null;
            //    PropertyInfo widthproperty = null;
            //    Dictionary<string, string> fields = SetKryptonFormFields(type.Name, connection);
            //    var test2 = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            //    type.GetProperty("Text").SetValue(form, fields.ContainsKey("Text") ? fields["Text"] : "");
            //    foreach (var property in type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            //        switch (property.FieldType.Name)
            //        {
            //            //case "KryptonRibbonGroupButton":
            //            //    property1 = property.FieldType.GetProperty("TextLine1", BindingFlags.Public | BindingFlags.Instance);
            //            //    property1.SetValue(property.GetValue(form), fields.ContainsKey(property.Name + "." + property1.Name) ? fields[property.Name + "." + property1.Name] : "");
            //            //    property1 = property.FieldType.GetProperty("TextLine2", BindingFlags.Public | BindingFlags.Instance);
            //            //    property1.SetValue(property.GetValue(form), fields.ContainsKey(property.Name + "." + property1.Name) ? fields[property.Name + "." + property1.Name] : "");
            //            //    break;
            //            //case "KryptonRibbonTab":
            //            //    //property1 = property.FieldType.GetProperty("Text", BindingFlags.Public | BindingFlags.Instance);
            //            //    //property1.SetValue(property.GetValue(form), fields.ContainsKey(property.Name + "." + property1.Name) ? fields[property.Name + "." + property1.Name] : "");
            //            //    break;
            //            //case "KryptonRibbonGroup":
            //            //    property1 = property.FieldType.GetProperty("TextLine1", BindingFlags.Public | BindingFlags.Instance);
            //            //    property1.SetValue(property.GetValue(form), fields.ContainsKey(property.Name + "." + property1.Name) ? fields[property.Name + "." + property1.Name] : "");
            //            //    break;
            //            //case "KryptonGroupBox":
            //            //    property1 = property.FieldType.GetProperty("Values", BindingFlags.Public | BindingFlags.Instance);
            //            //    secproperty1 = property1.PropertyType.GetProperty("Heading", BindingFlags.Public | BindingFlags.Instance);
            //            //    secproperty1.SetValue(property1.GetValue(property.GetValue(form)), fields.ContainsKey(property.Name + "." + property1.Name + "." + secproperty1.Name) ? fields[property.Name + "." + property1.Name + "." + secproperty1.Name] : "");
            //            //    break;
            //            //case "KryptonRadioButton":
            //            //    property1 = property.FieldType.GetProperty("Values", BindingFlags.Public | BindingFlags.Instance);
            //            //    secproperty1 = property1.PropertyType.GetProperty("Text", BindingFlags.Public | BindingFlags.Instance);
            //            //    secproperty1.SetValue(property1.GetValue(property.GetValue(form)), fields.ContainsKey(property.Name + "." + property1.Name + "." + secproperty1.Name) ? fields[property.Name + "." + property1.Name + "." + secproperty1.Name] : "");
            //            //    break;
            //            //case "KryptonDataGridViewCheckBoxColumn":
            //            //    property1 = property.FieldType.GetProperty("HeaderText", BindingFlags.Public | BindingFlags.Instance);
            //            //    property1.SetValue(property.GetValue(form), fields.ContainsKey(property.Name + "." + property1.Name) ? fields[property.Name + "." + property1.Name] : "");
            //            //    break;
            //            //case "DataGridViewLinkColumn":
            //            //    property1 = property.FieldType.GetProperty("HeaderText", BindingFlags.Public | BindingFlags.Instance);
            //            //    property1.SetValue(property.GetValue(form), fields.ContainsKey(property.Name + "." + property1.Name) ? fields[property.Name + "." + property1.Name] : "");
            //            //    break;
            //            //case "KryptonDataGridViewTextBoxColumn":
            //            //    property1 = property.FieldType.GetProperty("HeaderText", BindingFlags.Public | BindingFlags.Instance);
            //            //    property1.SetValue(property.GetValue(form), fields.ContainsKey(property.Name + "." + property1.Name) ? fields[property.Name + "." + property1.Name] : "");
            //            //    break;
            //            //case "KryptonContextMenuItem":
            //            //    property1 = property.FieldType.GetProperty("Text", BindingFlags.Public | BindingFlags.Instance);
            //            //    property1.SetValue(property.GetValue(form), fields.ContainsKey(property.Name + "." + property1.Name) ? fields[property.Name + "." + property1.Name] : "");
            //            //    break;
            //            //case "BindingNavigator":
            //            //    property1 = property.FieldType.GetProperty("Text", BindingFlags.Public | BindingFlags.Instance);
            //            //    property1.SetValue(property.GetValue(form), fields.ContainsKey(property.Name + "." + property1.Name) ? fields[property.Name + "." + property1.Name] : "");
            //            //    break;
            //            //case "DataGridViewTextBoxColumn":
            //            //    property1 = property.FieldType.GetProperty("HeaderText", BindingFlags.Public | BindingFlags.Instance);
            //            //    property1.SetValue(property.GetValue(form), fields.ContainsKey(property.Name + "." + property1.Name) ? fields[property.Name + "." + property1.Name] : "");
            //            //    break;
            //            //case "DataGridViewCheckBoxColumn":
            //            //    property1 = property.FieldType.GetProperty("HeaderText", BindingFlags.Public | BindingFlags.Instance);
            //            //    property1.SetValue(property.GetValue(form), fields.ContainsKey(property.Name + "." + property1.Name) ? fields[property.Name + "." + property1.Name] : "");
            //            //    break;
            //            //case "KryptonButton":
            //            //    property1 = property.FieldType.GetProperty("Values", BindingFlags.Public | BindingFlags.Instance);
            //            //    sizeproperty = property.FieldType.GetProperty("AutoSize", BindingFlags.Public | BindingFlags.Instance);
            //            //    sizeproperty.SetValue(property.GetValue(form), true );
            //            //    //widthproperty = sizeproperty.PropertyType.GetProperty("Width");
            //            //    secproperty1 = property1.PropertyType.GetProperty("Text");
            //            //    //widthproperty.SetValue(sizeproperty.GetValue(property.GetValue(form)), 
            //            //    //    fields.ContainsKey(property.Name + "." + property1.Name + "." + secproperty1.Name) ? 
            //            //    //    Int32.Parse(widthproperty.GetValue(sizeproperty.GetValue(property.GetValue(form))).ToString()) + 
            //            //    //        (fields[property.Name + "." + property1.Name + "." + secproperty1.Name].Length - secproperty1.GetValue(property1.GetValue(property.GetValue(form))).ToString().Length)*6 : 
            //            //    //    Int32.Parse(widthproperty.GetValue(sizeproperty.GetValue(property.GetValue(form))).ToString()));
            //            //    secproperty1.SetValue(property1.GetValue(property.GetValue(form)), fields.ContainsKey(property.Name + "." + property1.Name + "." + secproperty1.Name) ? fields[property.Name + "." + property1.Name + "." + secproperty1.Name] : "");
            //            //    break;
            //            //case "KryptonCheckBox":
            //            //    property1 = property.FieldType.GetProperty("Values", BindingFlags.Public | BindingFlags.Instance);
            //            //    secproperty1 = property1.PropertyType.GetProperty("Text", BindingFlags.Public | BindingFlags.Instance);
            //            //    secproperty1.SetValue(property1.GetValue(property.GetValue(form)), fields.ContainsKey(property.Name + "." + property1.Name + "." + secproperty1.Name) ? fields[property.Name + "." + property1.Name + "." + secproperty1.Name] : "");
            //            //    break;
            //            //case "KryptonHeaderGroup":
            //            //    property1 = property.FieldType.GetProperty("ValuesPrimary", BindingFlags.Public | BindingFlags.Instance);
            //            //    secproperty1 = property1.PropertyType.GetProperty("Heading", BindingFlags.Public | BindingFlags.Instance);
            //            //    secproperty1.SetValue(property1.GetValue(property.GetValue(form)), fields.ContainsKey(property.Name + "." + property1.Name + "." + secproperty1.Name) ? fields[property.Name + "." + property1.Name + "." + secproperty1.Name] : "");
            //            //    property1 = property.FieldType.GetProperty("ValuesSecondary", BindingFlags.Public | BindingFlags.Instance);
            //            //    secproperty1 = property1.PropertyType.GetProperty("Heading", BindingFlags.Public | BindingFlags.Instance);
            //            //    secproperty1.SetValue(property1.GetValue(property.GetValue(form)), fields.ContainsKey(property.Name + "." + property1.Name + "." + secproperty1.Name) ? fields[property.Name + "." + property1.Name + "." + secproperty1.Name] : "");
            //            //    break;
            //            //case "KryptonLabel":
            //            //    property1 = property.FieldType.GetProperty("Values", BindingFlags.Public | BindingFlags.Instance);
            //            //    secproperty1 = property1.PropertyType.GetProperty("Text", BindingFlags.Public | BindingFlags.Instance);
            //            //    secproperty1.SetValue(property1.GetValue(property.GetValue(form)), fields.ContainsKey(property.Name + "." + property1.Name + "." + secproperty1.Name) ? fields[property.Name + "." + property1.Name + "." + secproperty1.Name] : "");
            //            //    break;
            //            //case "KryptonHeader":
            //            //    property1 = property.FieldType.GetProperty("Values", BindingFlags.Public | BindingFlags.Instance);
            //            //    secproperty1 = property1.PropertyType.GetProperty("Heading", BindingFlags.Public | BindingFlags.Instance);
            //            //    secproperty1.SetValue(property1.GetValue(property.GetValue(form)), fields.ContainsKey(property.Name + "." + property1.Name + "." + secproperty1.Name) ? fields[property.Name + "." + property1.Name + "." + secproperty1.Name] : "");
            //            //    break;
            //            //case "KryptonRichTextBox":
            //            //    property1 = property.FieldType.GetProperty("Text", BindingFlags.Public | BindingFlags.Instance);
            //            //    property1.SetValue(property.GetValue(form), fields.ContainsKey(property.Name + "." + property1.Name) ? fields[property.Name + "." + property1.Name] : "");
            //            //    break;
            //            //case "ToolStripLabel":
            //            //    property1 = property.FieldType.GetProperty("Text", BindingFlags.Public | BindingFlags.Instance);
            //            //    property1.SetValue(property.GetValue(form), fields.ContainsKey(property.Name + "." + property1.Name) ? fields[property.Name + "." + property1.Name] : "");
            //            //    property1 = property.FieldType.GetProperty("ToolTipText", BindingFlags.Public | BindingFlags.Instance);
            //            //    property1.SetValue(property.GetValue(form), fields.ContainsKey(property.Name + "." + property1.Name) ? fields[property.Name + "." + property1.Name] : "");
            //            //    break;
            //            //case "ToolStripButton":
            //            //    property1 = property.FieldType.GetProperty("Text", BindingFlags.Public | BindingFlags.Instance);
            //            //    property1.SetValue(property.GetValue(form), fields.ContainsKey(property.Name + "." + property1.Name) ? fields[property.Name + "." + property1.Name] : "");
            //            //    break;
            //            //case "ToolStripTextBox":
            //            //    property1 = property.FieldType.GetProperty("Text", BindingFlags.Public | BindingFlags.Instance);
            //            //    property1.SetValue(property.GetValue(form), fields.ContainsKey(property.Name + "." + property1.Name) ? fields[property.Name + "." + property1.Name] : "");
            //            //    property1 = property.FieldType.GetProperty("ToolTipText", BindingFlags.Public | BindingFlags.Instance);
            //            //    property1.SetValue(property.GetValue(form), fields.ContainsKey(property.Name + "." + property1.Name) ? fields[property.Name + "." + property1.Name] : "");
            //            //    break;
            //            //case "ToolStripMenuItem":
            //            //    property1 = property.FieldType.GetProperty("Text", BindingFlags.Public | BindingFlags.Instance);
            //            //    property1.SetValue(property.GetValue(form), fields.ContainsKey(property.Name + "." + property1.Name) ? fields[property.Name + "." + property1.Name] : "");
            //            //    break;
            //            default:
            //                break;
            //        }
            //    connection.Close();
            }
        }
        //public static Dictionary<string, string> SetKryptonFormFields(string form, SqlConnection connection)
        //{
        //    Dictionary<string, string> fields = new Dictionary<string, string>();
        //    string sql = $@"SELECT field, string FROM BAS_FormFields WHERE form = '{form}' and lang = 'RUS'";
        //    using (SqlDataReader reader = new SqlCommand(sql, connection).ExecuteReader())
        //    {
        //        while (reader.Read())
        //            fields.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString() ?? "");
        //        return fields;
        //    }
        //}
        public static void GetKryptonFormFields(this object form)
        {
            //using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.OdinDBConnectionString))
            //{
            //    connection.Open();
            //    //string sql = $@"IF not EXISTS (SELECT * FROM BAS_FormFields WHERE form = '{new System.Diagnostics.StackTrace(false).GetFrame(1).GetMethod().Name}' and field = 'Text')
            //    //            insert INTO BAS_FormFields (form, field, string, lang) 
            //    //            VALUES ('{new System.Diagnostics.StackTrace(false).GetFrame(1).GetMethod().Name}', 'Text', '{form.GetType().GetProperty("Text").GetValue(form).ToString().Replace("'", "''")}', 'ENG')";
            //    //SqlCommand command = new SqlCommand(sql, connection);
            //    //command.ExecuteNonQuery();
            //    var field = SetKryptonFormFields(new System.Diagnostics.StackTrace(false).GetFrame(1).GetMethod().Name, connection);
            //    form.GetType().GetProperty("Text", BindingFlags.Public | BindingFlags.Instance).SetValue(form, field.ContainsKey("Text") ? field["Text"] : "");
            //    connection.Close();
            //}
        }
    }
}