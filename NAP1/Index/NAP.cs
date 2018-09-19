using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Diagnostics;


namespace Index
{
    public partial class NAP : Form
    {
        
         private void btnMed_Click(object sender, EventArgs e)
        {
            this.Hide();
            MEDIDAS med = new MEDIDAS();
            med.Show();
        }

        private void btnCons_Click(object sender, EventArgs e)
        {
            this.Hide();
            CONSULTAS cons = new CONSULTAS();
            cons.Show();
        }

        public NAP()
        {
            InitializeComponent();

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                var saveFileDialog = new SaveFileDialog();
                saveFileDialog.DefaultExt = "xlsx";
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx |All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    const string MyFileName = "C:\\Users\\YoSSHua\\Desktop\\NAP1\\Index\\Docs\\FINALBUENO.xlsx";
                    string execPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                    var filePath = Path.Combine(execPath, MyFileName);
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel.Workbook book = app.Workbooks.Open(filePath);
                    book.SaveAs(saveFileDialog.FileName); //Save
                    book.Close();
                    MessageBox.Show("Se descargo correctamente");
                }
                
            }catch(Exception ex){
                MessageBox.Show("Hubo un error");
            }
        }
        
        
        private void INDEX_Load(object sender, EventArgs e)
        {
            try
            {
                CONEXIONES c = new CONEXIONES();
                string co = c.cone();
                MySql.Data.MySqlClient.MySqlConnection cn = new MySql.Data.MySqlClient.MySqlConnection(co);
                cn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("use palabras", cn);
                cmd.ExecuteNonQuery();
                cn.Close();

            }catch(Exception ex){
                MessageBox.Show("Hubo un error al cargar la base de datos, contacte al administrador en turno");
                this.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }        


       
        
    }
}
