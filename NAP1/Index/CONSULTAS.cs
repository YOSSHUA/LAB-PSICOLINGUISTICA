using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Index
{
    public partial class CONSULTAS : Form
    {
        AutoCompleteStringCollection ids = new AutoCompleteStringCollection();
       
        

        public CONSULTAS()
        {
            InitializeComponent();
            
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            NAP ind = new NAP();
            ind.Show();
            
        }

       
        int x =0;
        
        private void txtID_OnTextChanged(object sender, System.EventArgs e)
        {
            if(x <= 0){
                txtID.Text = "";
                x++;
            }
        }
        
        private void CONSULTAS_Load(object sender, EventArgs e)
        {
            CONEXIONES o = new CONEXIONES();
            try
            {
                txtID.DisplayMember = "idsujeto";
                txtID.ValueMember = "idsujeto";
                txtID.DataSource = o.ids();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error abra de nuevo el software");
            }

            
        }
        

        private void btnDatos_Click(object sender, EventArgs e)
        {

            if (txtID.Text != "")
            {
                CONEXIONES clase = new CONEXIONES();
                DataTable datatab = new DataTable();
                datatab = clase.ConsID(txtID.Text);
                if (datatab != null)
                {
                    dgvConsID.DataSource = datatab;
                }
                else
                {
                    MessageBox.Show("Hubo un error durante la consulta");
                }
                CONEXIONES c = new CONEXIONES();
                string cadena = c.cone();
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(cadena))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("select sexo, edad, esconlaridad from palabras.sujeto2 where idsujeto = '" + txtID.Text + "'", conn))
                        {
                            conn.Open();
                            cmd.CommandType = CommandType.Text;
                            MySqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read() == true)
                            {
                                txtEdad.Text = dr["edad"].ToString();
                                txtEsc.Text = dr["esconlaridad"].ToString();
                                if (dr["sexo"].ToString() == "1")
                                {
                                    txtSexo.Text = "Mujer";
                                }
                                else
                                {
                                    txtSexo.Text = "Hombre";
                                }

                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error durante la consulta");
                }

                double s = 0;
                for (int i = 0; i < dgvConsID.Rows.Count; i++)
                {
                    if (dgvConsID[1, i].Value != null)
                    {
                        if (dgvConsID[1, i].Value.ToString() != String.Empty)
                        {
                            s++;
                        }
                    }
                }
                txtValido.Text = ((s * 100) / (dgvConsID.Rows.Count - 1)).ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un ID");
            }
        }

        private void btnGral_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtEdad.Text = "";
            txtEsc.Text = "";
            txtSexo.Text = "";
            txtValido.Text = "";
            CONEXIONES c = new CONEXIONES();
            DataTable d = new DataTable();
            d = c.gral();
            if (d != null)
            {
                dgvConsID.DataSource = d;
            }
            else
            {
                MessageBox.Show("Error durante la consulta general");
            }
        }
        
    }
}
