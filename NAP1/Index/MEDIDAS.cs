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
    public partial class MEDIDAS : Form
    {
        private Microsoft.Office.Interop.Excel.Application app = null;
        private Microsoft.Office.Interop.Excel.Workbook workbook = null;
        private Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
        private Microsoft.Office.Interop.Excel.Range workSheet_range = null;
        public string m1, m2, m3, m4, m5, m6, m7, m8;
        int opc;
        public MEDIDAS()
        {
            InitializeComponent();
            
        }
        private void limpiar()
        {
            txtPalEs1.Text = "";           
            lblN.Text = "";
            lblNH.Text = "";
            lblNM.Text = "";
            txtEdad1.Text = "";
            txtEdad2.Text = "";
            txtEsc1.Text = "";
            txtEsc2.Text = "";
            txtPalEs.Text = "";
            FAP.Text = "";
            FAS.Text = "";
            SUM.Text = "";
            DIST.Text = "";
            NUMA.Text = "";
            INVALIDO.Text = "";
            RESPIDI.Text = "";
            CUEVAL.Text = "";
            txtPA.Text = "";
            FAPH.Text = "";
            FASH.Text = "";
            SUMH.Text = "";
            DISTH.Text = "";
            NUMAH.Text = "";
            INVALIDOH.Text = "";
            RESPIDIH.Text = "";
            CUEVALH.Text = "";
            txtPAH.Text = "";
            FAPM.Text = "";
            FASM.Text = "";
            SUMM.Text = "";
            DISTM.Text = "";
            NUMAM.Text = "";
            INVALIDOM.Text = "";
            RESPIDIM.Text = "";
            CUEVALM.Text = "";
            txtPAM.Text = "";
            dgv.DataSource = null;
            dgvH.DataSource = null;
            dgvM.DataSource = null;
            dgvClasGral.DataSource = null;
            dgvClasH.DataSource = null;
            dgvClasM.DataSource = null;
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            verlistas();
            limpiar();
            pnlBuscador.Visible = true;
            
            pnlGral.Visible = true;
            pnlHyM.Visible = false ;
            pnlEscolaridad.Visible = false;
            pnlEdad.Visible = false;
            opc = 1;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            verlistas();
            limpiar();
            pnlBuscador.Visible = true;
            pnlHyM.Visible = true;
            pnlGral.Visible = false;
            pnlEscolaridad.Visible = false;
            pnlEdad.Visible = false;
            opc = 2;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            verlistas();
            limpiar();
            pnlBuscador.Visible = true;
            pnlHyM.Visible = false;
            pnlGral.Visible = true;
            pnlEscolaridad.Visible = false;
            pnlEdad.Visible = true;
            opc = 3;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            verlistas();
            limpiar();
            pnlBuscador.Visible = true;
            
            pnlHyM.Visible = false;
            pnlGral.Visible = true;
            pnlEscolaridad.Visible = true;
            pnlEdad.Visible = false;
            opc = 4;
        }



        private void Index_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            lblProgre.Visible = false;
            m1 = "Fuerza asociativa del primer asociado";
            m2 = "Fuerza asociativo del segundo asociado";
            m3 = "Suma de la fuerza asociativa de los dos primeros asociados";
            m4 = "Diferencia en la fuerza asociativa entre el primer y segundo asociado";
            m5 = "Número de asociados diferentes válidos";
            m6 = "Porcentaje de respuestas en blanco o no válidas en cada palabra";
            m7 = "Porcentaje de respuestas idiosincrásicas";
            m8 = "Cue Validity";
            label12.Text = m1;
            label13.Text = m2;
            label14.Text = m3;
            label15.Text = m4;
            label16.Text = m5;
            label17.Text = m6;
            label18.Text = m7;
            label19.Text = m8;
            label20.Text = m1;
            label21.Text = m2;
            label22.Text = m3;
            label23.Text = m4;
            label24.Text = m5;
            label25.Text = m6;
            label26.Text = m7;
            label27.Text = m8;
            CONEXIONES c = new CONEXIONES();
            DataTable dt = new DataTable();
            dt = c.combo();
            int i = 0;
            foreach(DataRow r in dt.Rows){
                if (i < 117){
                    txtPalEs.Items.Add(r[0].ToString());
                }else{
                    txtPalEs1.Items.Add(r[0].ToString());
                }
                i++;
            }
           

            
                
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            NAP ind = new NAP();
            ind.Show();

        }

       

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtPalEs.Text == "" && txtPalEs1.Text == "")
            {
                MessageBox.Show("Ingrese una palabra estímulo");
                return;
            }
            if (opc == 1 || opc == 3 || opc == 4 || opc == 7)
            {
                
                    if(opc == 3 || opc ==7 ){
                    if (txtEdad1.Text == "" || txtEdad2.Text == "")
                    {
                        MessageBox.Show("Ingrese un rango de edades");
                        return;
                    }   
                }
                if(opc == 4 || opc ==7 ){
                    if (txtEsc1.Text == "" || txtEsc1.Text == "")
                    {
                        MessageBox.Show("Ingrese un rango de años escolaridad");
                        return;
                    }   
                }
                llenar1();
                int n = 0;
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    n += Convert.ToInt32(dgv.Rows[i].Cells[1].Value);
                }
                lblN.Text = "Número de personas: " + Convert.ToString(n);
            }
            else
            {
                if(opc == 5 || opc ==8 ){
                    if (txtEdad1.Text == "" || txtEdad2.Text == "")
                    {
                        MessageBox.Show("Ingrese un rango de edades");
                        return;
                    }   
                }
                if (opc == 6 || opc == 8)
                {
                    if (txtEsc1.Text == "" || txtEsc1.Text == "")
                    {
                        MessageBox.Show("Ingrese un rango de años escolaridad");
                        return;
                    }
                }
                
                llenar2();
                if (dgvH.Rows.Count - 1 >= 2)
                {
                    textHombres();
                }
                if(dgvM.Rows.Count -1 >= 2){
                    textMujeres();
                }
                int n = 0;
                for (int i = 0; i < dgvH.Rows.Count; i++)
                {
                    n += Convert.ToInt32(dgvH.Rows[i].Cells[1].Value);
                }
                lblNH.Text = "Número de personas: " + Convert.ToString(n);
                int n2 = 0;
                for (int i = 0; i < dgvM.Rows.Count; i++)
                {
                    n2 += Convert.ToInt32(dgvM.Rows[i].Cells[1].Value);
                }
                lblNM.Text = "Número de personas: " + Convert.ToString(n2);
            }

        }

        private void llenar1()
        {
            CONEXIONES c = new CONEXIONES();
            DataTable dat = new DataTable();
            DataTable dat1 = new DataTable();
            try
            {
                if (opc == 1)
                {
                    if (txtPalEs.Text != "")
                    {
                        dat = c.frecuencias(txtPalEs.Text.ToString());
                        dat1 = c.frecuencias1(txtPalEs.Text.ToString()); 
                    }
                    else
                    {
                        dat = c.frecuencias(txtPalEs1.Text.ToString());
                        dat1 = c.frecuencias1(txtPalEs1.Text.ToString());
                    }
                }
                if (opc == 3)
                {
                    if (txtPalEs.Text != "")
                    {
                        dat = c.Eda(txtPalEs.Text.ToString(), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                        dat1 = c.Eda1(txtPalEs.Text.ToString(), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                    }
                    else
                    {
                        dat = c.Eda(txtPalEs1.Text.ToString(), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                        dat1 = c.Eda1(txtPalEs1.Text.ToString(), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                    }
                }
                if (opc == 4)
                {
                    if (txtPalEs.Text != "")
                    {
                        dat = c.Esc(txtPalEs.Text.ToString(), Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text));
                        dat1 = c.Esc1(txtPalEs.Text.ToString(), Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text));
                    }
                    else
                    {
                        dat = c.Esc(txtPalEs1.Text.ToString(), Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text));
                        dat1 = c.Esc1(txtPalEs1.Text.ToString(), Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text));
                    }
                }
                if (opc == 7)
                {
                    if (txtPalEs.Text != "")
                    {
                        dat = c.EscoEdad(txtPalEs.Text, Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                        dat1 = c.EscoEdad1(txtPalEs.Text, Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                    }
                    else
                    {
                        dat = c.EscoEdad(txtPalEs1.Text, Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                        dat1 = c.EscoEdad1(txtPalEs1.Text, Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                    }
                }
                if (dat != null)
                {
                    dgv.DataSource = dat;
                    texts();
                }
                else
                {
                    MessageBox.Show("Hubo un error durante la conexion a la base de datos");
                }
                if (dat1 != null)
                {
                    dgvClasGral.DataSource = dat1;
                }
                else
                {
                    MessageBox.Show("Hubo un error durante la conexion a la base de datos");
                }
                
                    
                
            }catch(Exception ex){
                MessageBox.Show("Hubo un error, intente de nuevo");
            }
        }
        private void llenar2()
        {
            CONEXIONES c = new CONEXIONES();
            DataTable datH = new DataTable();
            DataTable datM = new DataTable();
            DataTable datH1 = new DataTable();
            DataTable datM1 = new DataTable();
            if (opc == 2)
            {
                if (txtPalEs.Text != "")
                {
                    datH = c.sexoH(txtPalEs.Text);
                    datM = c.sexoM(txtPalEs.Text);
                    datH1 = c.sexoH1(txtPalEs.Text);
                    datM1 = c.sexoM1(txtPalEs.Text);
                }
                else
                {
                    datH = c.sexoH(txtPalEs1.Text);
                    datM = c.sexoM(txtPalEs1.Text);
                    datH1 = c.sexoH1(txtPalEs1.Text);
                    datM1 = c.sexoM1(txtPalEs1.Text);
                }
            }
            if (opc == 5)
            {
                if (txtPalEs.Text != "")
                {
                    datH = c.SexoEdaH(txtPalEs.Text.ToString(), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                    datM = c.SexoEdaM(txtPalEs.Text.ToString(), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                    datH1 = c.SexoEdaH1(txtPalEs.Text.ToString(), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                    datM1 = c.SexoEdaM1(txtPalEs.Text.ToString(), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                }
                else
                {
                    datH = c.SexoEdaH(txtPalEs1.Text.ToString(), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                    datM = c.SexoEdaM(txtPalEs1.Text.ToString(), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                    datH1 = c.SexoEdaH1(txtPalEs1.Text.ToString(), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                    datM1 = c.SexoEdaM1(txtPalEs1.Text.ToString(), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                }
            }
            if (opc == 6)
            {
                if (txtPalEs.Text != "")
                {
                    datH = c.SexoEscoH(txtPalEs.Text.ToString(), Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text));
                    datM = c.SexoEscoM(txtPalEs.Text.ToString(), Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text));
                    datH1 = c.SexoEscoH1(txtPalEs.Text.ToString(), Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text));
                    datM1 = c.SexoEscoM1(txtPalEs.Text.ToString(), Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text));
                }
                else
                {
                    datH = c.SexoEscoH(txtPalEs1.Text.ToString(), Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text));
                    datM = c.SexoEscoM(txtPalEs1.Text.ToString(), Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text));
                    datH1 = c.SexoEscoH1(txtPalEs1.Text.ToString(), Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text));
                    datM1 = c.SexoEscoM1(txtPalEs1.Text.ToString(), Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text));
                }
            }
            if (opc == 8)
            {
                if (txtPalEs.Text != "")
                {
                    datH = c.SexoEdaEscoH(txtPalEs.Text, Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                    datM = c.SexoEdaEscoM(txtPalEs.Text, Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                    datH1 = c.SexoEdaEscoH1(txtPalEs.Text, Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                    datM1 = c.SexoEdaEscoM1(txtPalEs.Text, Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                }
                else
                {
                    datH = c.SexoEdaEscoH(txtPalEs1.Text, Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                    datM = c.SexoEdaEscoM(txtPalEs1.Text, Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                    datH1 = c.SexoEdaEscoH1(txtPalEs1.Text, Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                    datM1 = c.SexoEdaEscoM1(txtPalEs1.Text, Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                }
            }
            if (datH != null && datM != null)
            {
                dgvH.DataSource = datH;
                dgvM.DataSource = datM;
            }
            else
            {
                MessageBox.Show("Hubo un error durante la conexion a la base de datos");
            }

            if (datH1 != null && datM1 != null)
            {
                dgvClasH.DataSource = datH1;
                dgvClasM.DataSource = datM1;
            }else{
                MessageBox.Show("Hubo un error durante la conexion a la base de datos");
            }
        }
        

        private void sexoEdadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verlistas();
            limpiar();
            pnlBuscador.Visible = true;
            
            pnlGral.Visible = false;
            pnlHyM.Visible = true;
            pnlEscolaridad.Visible = false;
            pnlEdad.Visible = true;
            opc = 5;
        }

        private void sexoEscolaridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verlistas();
            limpiar();
            pnlBuscador.Visible = true;
            
            pnlGral.Visible = false;
            pnlHyM.Visible = true;
            pnlEscolaridad.Visible = true;
            pnlEdad.Visible = false;
            opc = 6;
        }

        private void sexoEdadEscolaridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            verlistas();
            limpiar();
            pnlBuscador.Visible = true;
            
            pnlGral.Visible = true;
            pnlHyM.Visible = false;
            pnlEscolaridad.Visible = true;
            pnlEdad.Visible = true;
            opc = 7;
        }

        private void sexoEdadEscolaridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            verlistas();
            limpiar();
            pnlBuscador.Visible = true;
            pnlGral.Visible = false;
            pnlHyM.Visible = true;
            pnlEscolaridad.Visible = true;
            pnlEdad.Visible = true;
            opc = 8;
        }

        private void textHombres()
        {
            txtPAH.Text =dgvH.Rows[0].Cells[0].Value.ToString();
            FAPH.Text = Math.Round(Convert.ToDouble(dgvH.Rows[0].Cells[2].Value.ToString()),2).ToString();
            FASH.Text = Math.Round(Convert.ToDouble(dgvH.Rows[1].Cells[2].Value.ToString()),2).ToString();
            SUMH.Text = Math.Round(Convert.ToDouble(Convert.ToString(Convert.ToDouble(dgvH.Rows[0].Cells[2].Value) + Convert.ToDouble(dgvH.Rows[1].Cells[2].Value))),2).ToString();
            DISTH.Text = Math.Round(Convert.ToDouble(Convert.ToString(Convert.ToDouble(dgvH.Rows[0].Cells[2].Value) - Convert.ToDouble(dgvH.Rows[1].Cells[2].Value))),2).ToString();
            double invalido = 0, j = 0;
            for (int i = 0; i < dgvH.Rows.Count; i++)
            {
                
                    if (dgvH.Rows[i].Cells[0].Value != null){
                        if ( dgvH.Rows[i].Cells[0].Value.ToString() == string.Empty)
                        {
                        
                            invalido = Convert.ToDouble(dgvH.Rows[i].Cells[1].Value.ToString());
                        }
                    }
                
            }
            double suma = 0;
            for (int i = 0; i < dgvH.Rows.Count; i++)
            {
                suma += Convert.ToInt32(dgvH.Rows[i].Cells[1].Value);
            }
            if (invalido != 0)
            {
                INVALIDOH.Text = Math.Round(Convert.ToDouble( Convert.ToString((invalido * 100) / suma)),2).ToString();
                NUMAH.Text = Convert.ToString(dgvH.Rows.Count - 2 );
            }
            else
            {
                INVALIDOH.Text = "0";
                NUMAH.Text = Convert.ToString(dgvH.Rows.Count-1);
            }

            double idi = 0, porc = 0;
            for (int i = 0; i < dgvH.Rows.Count; i++)
            {
                if (dgvH.Rows[i].Cells[1].Value != null)
                {
                    if (dgvH.Rows[i].Cells[1].Value.ToString() == "1" && dgvH.Rows[i].Cells[0].Value.ToString() != string.Empty)
                    {
                        idi += Convert.ToDouble(dgvH.Rows[i].Cells[2].Value);
                    }
                }
            }
            RESPIDIH.Text = Math.Round(idi, 2).ToString();
        }
        private void textMujeres()
        {
            txtPAM.Text =dgvM.Rows[0].Cells[0].Value.ToString();
            FAPM.Text = Math.Round(Convert.ToDouble(dgvM.Rows[0].Cells[2].Value.ToString()),2).ToString();
            FASM.Text = Math.Round(Convert.ToDouble(dgvM.Rows[1].Cells[2].Value.ToString()),2).ToString();
            SUMM.Text = Math.Round(Convert.ToDouble( Convert.ToString(Convert.ToDouble(dgvM.Rows[0].Cells[2].Value) + Convert.ToDouble(dgvM.Rows[1].Cells[2].Value))),2).ToString();
            DISTM.Text = Math.Round(Convert.ToDouble(Convert.ToString(Convert.ToDouble(dgvM.Rows[0].Cells[2].Value) - Convert.ToDouble(dgvM.Rows[1].Cells[2].Value))),2).ToString();
            double invalido = 0, j = 0;
            for (int i = 0; i < dgvM.Rows.Count; i++)
            {
                if (dgvM.Rows[i].Cells[0].Value != null)
                {
                    if (dgvM.Rows[i].Cells[0].Value.ToString() == string.Empty)
                    {
                        
                        invalido = Convert.ToDouble(dgvM.Rows[i].Cells[1].Value.ToString());
                    }
                }
            }
            double suma = 0;
            for (int i = 0; i < dgvM.Rows.Count; i++)
            {
                suma += Convert.ToInt32(dgvM.Rows[i].Cells[1].Value);
            }
            if (invalido != 0)
            {
                INVALIDOM.Text =Math.Round(Convert.ToDouble( Convert.ToString((invalido * 100) / suma)),2).ToString();
                NUMAM.Text = Convert.ToString(dgvM.Rows.Count - 2);
            }
            else
            {
                INVALIDOM.Text = "0";
                NUMAM.Text = Convert.ToString(dgvM.Rows.Count-1);
            }

            double idi = 0, porc = 0;
            for (int i = 0; i < dgvM.Rows.Count; i++)
            {
                if (dgvM.Rows[i].Cells[1].Value != null)
                {
                    if (dgvM.Rows[i].Cells[1].Value.ToString() == "1" && dgvM.Rows[i].Cells[0].Value.ToString() != string.Empty)
                    {
                        idi += Convert.ToDouble(dgvM.Rows[i].Cells[2].Value);
                    }
                }
            }

            RESPIDIM.Text = Math.Round(idi, 2).ToString();

        }
        private void texts()
        {
            txtPA.Text = dgv.Rows[0].Cells[0].Value.ToString();
            FAP.Text = Math.Round(Convert.ToDouble(dgv.Rows[0].Cells[2].Value.ToString()),2).ToString();
            FAS.Text = Math.Round(Convert.ToDouble(dgv.Rows[1].Cells[2].Value.ToString()),2).ToString();
            SUM.Text = Math.Round(Convert.ToDouble(Convert.ToString(Convert.ToDouble(dgv.Rows[0].Cells[2].Value) + Convert.ToDouble(dgv.Rows[1].Cells[2].Value))),2).ToString();
            DIST.Text =Math.Round(Convert.ToDouble( Convert.ToString(Convert.ToDouble(dgv.Rows[0].Cells[2].Value) - Convert.ToDouble(dgv.Rows[1].Cells[2].Value))),2).ToString();
            double invalido = 0, j = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Cells[0].Value != null)
                {
                    if (dgv.Rows[i].Cells[0].Value.ToString() == string.Empty)
                    {
                        
                        invalido = Convert.ToDouble(dgv.Rows[i].Cells[1].Value.ToString());
                    }
                }
                
            }
            double suma = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                suma += Convert.ToInt32(dgv.Rows[i].Cells[1].Value);
            }
            if (invalido != 0)
            {
                INVALIDO.Text =  Math.Round(Convert.ToDouble(Convert.ToString((invalido * 100) / suma)),2).ToString();
                NUMA.Text = Convert.ToString(dgv.Rows.Count - 2);
            }
            else
            {
                INVALIDO.Text = "0";
                NUMA.Text = Convert.ToString(dgv.Rows.Count-1);
            }

            double idi = 0;
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Cells[1].Value != null)
                {
                    if (dgv.Rows[i].Cells[1].Value.ToString() == "1" && dgv.Rows[i].Cells[0].Value.ToString() != string.Empty)
                    {
                        idi += Convert.ToDouble(dgv.Rows[i].Cells[2].Value);
                    }
                }
            }

            RESPIDI.Text = Math.Round(idi, 2).ToString();
           
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            lblProgre.Visible = true;
            try
            {
                //if (opc != 1)
                //{
                    if (validar())
                    {
                        CreateExcelDoc excell = new CreateExcelDoc();
                        MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                        builder.Server = "localhost";
                        builder.UserID = "root";
                        builder.Password = "root";
                        builder.Database = "palabras";
                        builder.SslMode = MySql.Data.MySqlClient.MySqlSslMode.None;

                        using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                        {
                            using (MySqlCommand cmd = new MySqlCommand("select distinct(palabraBase) from palabras.respuestas2 order by palabraBase ASC", conn))
                            {
                                conn.Open();
                                cmd.CommandType = System.Data.CommandType.Text;
                                //Se crea la variable de retorno
                                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                                DataTable dt = new DataTable();
                                da.Fill(dt);
                                // Cerramos conexión
                                conn.Close();

                                if (dt.Rows.Count != 0)
                                {
                                    
                                    int i = 2;
                                    excell.createHeaders(1, 1, "Palabra base ", "A1", "A1", 2, "YELLOW", true, 10, "n");
                                    excell.createHeaders(1, 2, m1, "B1", "B1", 2, "YELLOW", true, 10, "n");
                                    excell.createHeaders(1, 3, m2, "C1", "C1", 2, "YELLOW", true, 10, "n");
                                    excell.createHeaders(1, 4, m3, "D1", "D1", 2, "YELLOW", true, 10, "n");
                                    excell.createHeaders(1, 5, m4, "E1", "E1", 2, "YELLOW", true, 10, "n");
                                    excell.createHeaders(1, 6, m5, "F1", "F1", 2, "YELLOW", true, 10, "n");
                                    excell.createHeaders(1, 7, m6, "G1", "G1", 2, "YELLOW", true, 10, "n");
                                    excell.createHeaders(1, 8, m7, "H1", "H1", 2, "YELLOW", true, 10, "n");
                                    excell.createHeaders(1, 9, m8, "I1", "I1", 2, "YELLOW", true, 10, "n");
                                    excell.createHeaders(1, 10, "Primer asociado", "J1", "J1", 2, "YELLOW", true, 10, "n");
                                    Dictionary<string, double> mapa = new Dictionary<string, double>();
                                    Dictionary<int, string> pos = new Dictionary<int, string>();
                                    foreach (DataRow row in dt.Rows)
                                    {
                                        llenar1(row[0].ToString());

                                        excell.addData(i, 1, row[0].ToString(), "A" + Convert.ToString(i), "A" + Convert.ToString(i), "");
                                        excell.addData(i, 2, FAP.Text, "B" + Convert.ToString(i), "B" + Convert.ToString(i), "");
                                        excell.addData(i, 3, FAS.Text, "C" + Convert.ToString(i), "C" + Convert.ToString(i), "");
                                        excell.addData(i, 4, SUM.Text, "D" + Convert.ToString(i), "D" + Convert.ToString(i), "");
                                        excell.addData(i, 5, DIST.Text, "E" + Convert.ToString(i), "E" + Convert.ToString(i), "");
                                        excell.addData(i, 6, NUMA.Text, "F" + Convert.ToString(i), "F" + Convert.ToString(i), "");
                                        excell.addData(i, 7, INVALIDO.Text, "G" + Convert.ToString(i), "G" + Convert.ToString(i), "");
                                        excell.addData(i, 8, RESPIDI.Text, "H" + Convert.ToString(i), "H" + Convert.ToString(i), "");
                                        excell.addData(i, 10, dgv.Rows[0].Cells[0].Value.ToString(), "J" + Convert.ToString(i), "J" + Convert.ToString(i), "");
                                        /*double w = 0;
                                        for(int y  = ; y < dgv.Rows.Count; y++){
                                            if(dgv.Rows[i].Cells[3].Value != null){
                                                w+= Convert.ToDouble(dgv.Rows[i].Cells[3].Value.ToString());
                                            }
                                        }
                                        excell.addData(i, 11, );*/
                                        if (mapa.ContainsKey(dgv.Rows[0].Cells[0].Value.ToString()))
                                        {

                                            mapa[dgv.Rows[0].Cells[0].Value.ToString()]++;
                                        }
                                        else
                                        {
                                            mapa.Add(dgv.Rows[0].Cells[0].Value.ToString(), 1);
                                        }
                                        pos.Add(i, dgv.Rows[0].Cells[0].Value.ToString());
                                        i++;

                                        int por =  (100 * (i-2))/ dt.Rows.Count ;
                                        progressBar1.Value = por;
                                    }
                                    for (int j = i - 1; j >= 2; j--)
                                    {
                                        excell.addData(j, 9, Convert.ToString(Convert.ToDouble(1.0 / mapa[pos[j]])), "I" + Convert.ToString(j), "I" + Convert.ToString(j), "");
                                    }

                                }
                            }
                        }
                    }
                //}
                //else
                //{
                //    MessageBox.Show("El archivo general se puede descargar en la página principal");

                //}
                    progressBar1.Visible = false;
                    lblProgre.Visible = false;
                    MessageBox.Show("Se genero el excel correctamente");
            }catch(Exception ex){
                MessageBox.Show("Ocurrio un problema al generar las medidas en excel, intente de nuevo");
                progressBar1.Visible = false;
                lblProgre.Visible = false;
                dgv.DataSource = null;
                
            }
        }
        private void llenar1(string pal)
        {
            CONEXIONES c = new CONEXIONES();
            DataTable dat = new DataTable();
            try
            {

                if (opc == 1)
                {
                    dat = c.frecuencias(pal);
                }
                if (opc == 3)
                {
                    dat = c.Eda(pal, Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                }
                if (opc == 4)
                {
                    dat = c.Esc(pal, Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text));
                }
                if (opc == 7)
                {
                    dat = c.EscoEdad(pal, Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                }
                if (dat != null)
                {
                    dgv.DataSource = dat;
                }
                else
                {
                    MessageBox.Show("Hubo un error durante la conexion a la base de datos");
                }
                texts();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error, intente de nuevo");
            }
        }

        private void btnMujeres_Click(object sender, EventArgs e)
        {
            lblProgre.Visible = true;
            progressBar1.Visible = true;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            try
            {
                if (validar())
                {
                    CreateExcelDoc excell = new CreateExcelDoc();
                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                    builder.Server = "localhost";
                    builder.UserID = "root";
                    builder.Password = "root";
                    builder.Database = "palabras";
                    builder.SslMode = MySql.Data.MySqlClient.MySqlSslMode.None;

                    using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                    {
                        //using (MySqlCommand cmd = new MySqlCommand("select distinct(palabraBase) from palabras.respuestas2 ", conn))
                        using (MySqlCommand cmd = new MySqlCommand("select distinct(palabraBase) from palabras.respuestas2 limit 117", conn))
                        {
                            conn.Open();
                            cmd.CommandType = System.Data.CommandType.Text;
                            //Se crea la variable de retorno
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            // Cerramos conexión
                            conn.Close();

                            if (dt.Rows.Count != 0)
                            {
                                int i = 2;
                                
                                excell.createHeaders(1, 1, "Palabra base ", "A1", "A1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 2, m1, "B1", "B1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 3, m2, "C1", "C1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 4, m3, "D1", "D1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 5, m4, "E1", "E1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 6, m5, "F1", "F1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 7, m6, "G1", "G1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 8, m7, "H1", "H1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 9, m8, "I1", "I1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 10, "Primer asociado", "J1", "J1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 11, "Tiempo de respuesta del primer asociado", "K1", "K1", 2, "YELLOW", true, 10, "n");
                                Dictionary<string, double> mapa = new Dictionary<string, double>();
                                Dictionary<int, string> pos = new Dictionary<int, string>();
                                foreach (DataRow row in dt.Rows)
                                {
                                    
                                        llenarmujeres(row[0].ToString());


                                        excell.addData(i, 1, row[0].ToString(), "A" + Convert.ToString(i), "A" + Convert.ToString(i), "");
                                        excell.addData(i, 2, FAPM.Text, "B" + Convert.ToString(i), "B" + Convert.ToString(i), "");
                                        excell.addData(i, 3, FASM.Text, "C" + Convert.ToString(i), "C" + Convert.ToString(i), "");
                                        excell.addData(i, 4, SUMM.Text, "D" + Convert.ToString(i), "D" + Convert.ToString(i), "");
                                        excell.addData(i, 5, DISTM.Text, "E" + Convert.ToString(i), "E" + Convert.ToString(i), "");
                                        excell.addData(i, 6, NUMAM.Text, "F" + Convert.ToString(i), "F" + Convert.ToString(i), "");
                                        excell.addData(i, 7, INVALIDOM.Text, "G" + Convert.ToString(i), "G" + Convert.ToString(i), "");
                                        excell.addData(i, 8, RESPIDIM.Text, "H" + Convert.ToString(i), "H" + Convert.ToString(i), "");
                                        excell.addData(i, 10, dgvM.Rows[0].Cells[0].Value.ToString(), "J" + Convert.ToString(i), "J" + Convert.ToString(i), "");
                                        excell.addData(i, 11, dgvM.Rows[0].Cells[3].Value.ToString(), "K" + Convert.ToString(i), "K" + Convert.ToString(i), "");
                                        if (mapa.ContainsKey(dgvM.Rows[0].Cells[0].Value.ToString()))
                                        {

                                            mapa[dgvM.Rows[0].Cells[0].Value.ToString()]++;
                                        }
                                        else
                                        {
                                            mapa.Add(dgvM.Rows[0].Cells[0].Value.ToString(), 1);
                                        }
                                        pos.Add(i, dgvM.Rows[0].Cells[0].Value.ToString());
                                        i++;
                                        int por = (100 * (i - 2)) / dt.Rows.Count;
                                        progressBar1.Value = por;
                                    
                                    
                                }
                                for (int j = i - 1; j >= 2; j--)
                                {
                                    excell.addData(j, 9, Convert.ToString(Convert.ToDouble(1.0 / mapa[pos[j]])), "I" + Convert.ToString(j), "I" + Convert.ToString(j), "");
                                }

                            }
                        }
                    }
                }
                progressBar1.Visible = false;
                lblProgre.Visible = false;
                MessageBox.Show("Se genero el excel correctamente");
            }catch(Exception ex){
                MessageBox.Show("Ocurrio un problema al generar las medidas en excel, intente de nuevo");
                progressBar1.Visible = false;
                lblProgre.Visible = false;
                dgvM.DataSource = null;

            }
        }

        private void btnHombres_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            try
            {
                if (validar())
                {
                    CreateExcelDoc excell = new CreateExcelDoc();
                    MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
                    builder.Server = "localhost";
                    builder.UserID = "root";
                    builder.Password = "root";
                    builder.Database = "palabras";
                    builder.SslMode = MySql.Data.MySqlClient.MySqlSslMode.None;

                    using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("select distinct(palabraBase) from palabras.respuestas2 order by palabraBase ASC", conn))
                        {
                            conn.Open();
                            cmd.CommandType = System.Data.CommandType.Text;
                            //Se crea la variable de retorno
                            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            // Cerramos conexión
                            conn.Close();

                            if (dt.Rows.Count != 0)
                            {
                                int i = 2;
                                excell.createHeaders(1, 1, "Palabra base ", "A1", "A1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 2, m1, "B1", "B1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 3, m2, "C1", "C1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 4, m3, "D1", "D1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 5, m4, "E1", "E1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 6, m5, "F1", "F1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 7, m6, "G1", "G1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 8, m7, "H1", "H1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 9, m8, "I1", "I1", 2, "YELLOW", true, 10, "n");
                                excell.createHeaders(1, 10, "Primer asociado", "J1", "J1", 2, "YELLOW", true, 10, "n");
                                Dictionary<string, double> mapa = new Dictionary<string, double>();
                                Dictionary<int, string> pos = new Dictionary<int, string>();
                                foreach (DataRow row in dt.Rows)
                                {
                                    
                                    llenarhombres(row[0].ToString());

                                    excell.addData(i, 1, row[0].ToString(), "A" + Convert.ToString(i), "A" + Convert.ToString(i), "");
                                    excell.addData(i, 2, FAPH.Text, "B" + Convert.ToString(i), "B" + Convert.ToString(i), "");
                                    excell.addData(i, 3, FASH.Text, "C" + Convert.ToString(i), "C" + Convert.ToString(i), "");
                                    excell.addData(i, 4, SUMH.Text, "D" + Convert.ToString(i), "D" + Convert.ToString(i), "");
                                    excell.addData(i, 5, DISTH.Text, "E" + Convert.ToString(i), "E" + Convert.ToString(i), "");
                                    excell.addData(i, 6, NUMAH.Text, "F" + Convert.ToString(i), "F" + Convert.ToString(i), "");
                                    excell.addData(i, 7, INVALIDOH.Text, "G" + Convert.ToString(i), "G" + Convert.ToString(i), "");
                                    excell.addData(i, 8, RESPIDIH.Text, "H" + Convert.ToString(i), "H" + Convert.ToString(i), "");
                                    excell.addData(i, 10, dgvH.Rows[0].Cells[0].Value.ToString(), "J" + Convert.ToString(i), "J" + Convert.ToString(i), "");
                                    if (mapa.ContainsKey(dgvH.Rows[0].Cells[0].Value.ToString()))
                                    {

                                        mapa[dgvH.Rows[0].Cells[0].Value.ToString()]++;
                                    }
                                    else
                                    {
                                        mapa.Add(dgvH.Rows[0].Cells[0].Value.ToString(), 1);
                                    }
                                    pos.Add(i, dgvH.Rows[0].Cells[0].Value.ToString());
                                    i++;
                                    int por = (100 * (i - 2)) / dt.Rows.Count;
                                    progressBar1.Value = por;
                                }
                                for (int j = i - 1; j >= 2; j--)
                                {
                                    excell.addData(j, 9, Convert.ToString(Convert.ToDouble(1.0 / mapa[pos[j]])), "I" + Convert.ToString(j), "I" + Convert.ToString(j), "");
                                }

                            }
                        }
                    }
                }
                progressBar1.Visible = false;
                lblProgre.Visible = false;
                MessageBox.Show("Se genero el excel correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un problema al generar las medidas en excel, intente de nuevo");
                progressBar1.Visible = false;
                lblProgre.Visible = false;
                dgvH.DataSource = null;
            }
        }
        private void llenarhombres(string pal)
        {
            CONEXIONES c = new CONEXIONES();
            DataTable datH = new DataTable();
            try
            {
                if (opc == 2)
                {
                    datH = c.sexoH(pal);

                }
                if (opc == 5)
                {
                    datH = c.SexoEdaH(pal, Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));

                }
                if (opc == 6)
                {
                    datH = c.SexoEscoH(pal, Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text));

                }
                if (opc == 8)
                {
                    datH = c.SexoEdaEscoH(pal, Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));

                }
                if (datH != null)
                {
                    dgvH.DataSource = datH;
                    if (dgvH.Rows.Count - 1 >= 2)
                    {
                        textHombres();
                    }

                }
                else
                {
                    MessageBox.Show("Hubo un error durante la conexion a la base de datos");
                }
                
                
            }catch(Exception ex){
                MessageBox.Show("Hubo un erro al generar el excel de medidas de hombres");
            }
        }
        private void llenarmujeres(string pal)
        {
            try
            {
                CONEXIONES c = new CONEXIONES();
                DataTable datM = new DataTable();
                datM = c.frecuencias(pal);
                /*if (opc == 2)
                {

                    datM = c.sexoM(pal);
                }
                if (opc == 5)
                {

                    datM = c.SexoEdaM(pal, Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                }
                if (opc == 6)
                {

                    datM = c.SexoEscoM(pal, Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text));
                }
                if (opc == 8)
                {

                    datM = c.SexoEdaEscoM(pal, Convert.ToInt32(txtEsc1.Text), Convert.ToInt32(txtEsc2.Text), Convert.ToInt32(txtEdad1.Text), Convert.ToInt32(txtEdad2.Text));
                } */
                 
                if (datM != null)
                {

                    dgvM.DataSource = datM;
                    textMujeres();
                }
                else
                {
                    MessageBox.Show("Hubo un error durante la conexion a la base de datos");
                }
                
                    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al general el excel de medidas de mujeres");
            }
        }
        public bool validar()
        {
            if (opc == 1 || opc == 3 || opc == 4 || opc == 7)
            {

                if (opc == 3 || opc == 7)
                {
                    if (txtEdad1.Text == "" || txtEdad2.Text == "")
                    {
                        MessageBox.Show("Ingrese un rango de edades");
                        return false;
                    }
                }
                if (opc == 4 || opc == 7)
                {
                    if (txtEsc1.Text == "" || txtEsc1.Text == "")
                    {
                        MessageBox.Show("Ingrese un rango de años escolaridad");
                        return false;
                    }
                }
            }
            else
            {
                if (opc == 5 || opc == 8)
                {
                    if (txtEdad1.Text == "" || txtEdad2.Text == "")
                    {
                        MessageBox.Show("Ingrese un rango de edades");
                        return false;
                    }
                }
                if (opc == 6 || opc == 8)
                {
                    if (txtEsc1.Text == "" || txtEsc1.Text == "")
                    {
                        MessageBox.Show("Ingrese un rango de años escolaridad");
                        return false;
                    }
                }
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            INFO i = new INFO();
            i.Show();
            

        }

        private void btnLista1_Click(object sender, EventArgs e)
        {
            verlista1();
            pnlEdad.Visible = false;
            pnlEscolaridad.Visible = false;
            pnlGral.Visible = false;
            pnlHyM.Visible = false;

        }

        private void btnLista2_Click(object sender, EventArgs e)
        {
            verlista2();
            pnlEdad.Visible = false;
            pnlEscolaridad.Visible = false;
            pnlGral.Visible = false;
            pnlHyM.Visible = false;
        }
        public void verlista1()
        {
            pnlBuscador.Visible = true;
            btnBuscar.Visible = false;
            lblPEs.Visible = false;
            txtPalEs1.Visible = false;
            lblL2.Visible = false;
            lblL1.Visible = true;
            txtPalEs.Visible = true;
            
        }
        public void verlista2()
        {
            pnlBuscador.Visible = true;
            btnBuscar.Visible = false;
            lblPEs.Visible = false;
            txtPalEs1.Visible = true;
            lblL2.Visible = true;
            lblL1.Visible = false;
            txtPalEs.Visible = false;
        }
        public void verlistas()
        {
            btnBuscar.Visible = true;
            lblPEs.Visible = true;
            txtPalEs1.Visible = true;
            lblL2.Visible = true;
            lblL1.Visible = true;
            txtPalEs.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CLASIFICACION c = new CLASIFICACION();
            c.Show();
        }
        
    }

}
