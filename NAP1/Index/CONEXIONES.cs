using System;
using MySql.Data.Types;
using MySql.Data.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Index
{
    class CONEXIONES
    {
        public string cone()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "root";
            builder.Database = "palabras";           
            builder.SslMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            return builder.ToString();
        }
        public DataTable gral() {
            try
            {
                using(MySqlConnection cn = new MySqlConnection(cone())){
                    MySqlCommand cmd = new MySqlCommand("select idsujeto 'ID SUJETO', palabraBase 'PALABRA ESTIMULO' , respuesta ' PALABRA RESPUESTA', tiempo 'PROMEDIO DE TIEMPO DE RESPUESTA', gramatica 'TIPO DE RESPUESTA' from palabras.respuestas2", cn);
                    MySqlDataAdapter da= new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }catch(Exception ex){
                DataTable dt = new DataTable();
                return dt;
            }
        }
        
        public DataTable frecuencias(string pal)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("base1", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable frecuencias1(string pal)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("clasgral", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        
        
        public DataTable ConsID(string id)
        {
            try
            {
                string r = "";
                string builder = cone(); 
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select palabraBase 'PALABRA ESTIMULO' , respuesta ' PALABRA RESPUESTA', tiempo 'PROMEDIO DE TIEMPO DE RESPUESTA', gramatica 'TIPO DE RESPUESTA' from palabras.respuestas2 where idsujeto = '" + id + "'", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        
        public DataTable sexoM(string pal)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("mujeres", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable sexoM1(string pal)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("clasmujeres", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable sexoH(string pal)
        {
            try
            {
                
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("hombres", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable sexoH1(string pal)
        {
            try
            {

                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("clashombres", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable Eda(string pal, int edIni, int edFin)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("spEdad", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        cmd.Parameters.AddWithValue("@edini", edIni);
                        cmd.Parameters.AddWithValue("@edadfin", edFin);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable Eda1(string pal, int edIni, int edFin)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("classpEdad", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        cmd.Parameters.AddWithValue("@edini", edIni);
                        cmd.Parameters.AddWithValue("@edadfin", edFin);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable Esc(string pal, int escIni, int escFin)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("spEsc", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        cmd.Parameters.AddWithValue("@escIni", escIni);
                        cmd.Parameters.AddWithValue("@escFin", escFin);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable Esc1(string pal, int escIni, int escFin)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("classpEsc", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        cmd.Parameters.AddWithValue("@escIni", escIni);
                        cmd.Parameters.AddWithValue("@escFin", escFin);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable SexoEdaM(string pal, int edadI, int edadF)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("mujeresedad", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        cmd.Parameters.AddWithValue("@edad1", edadI);
                        cmd.Parameters.AddWithValue("@edad2", edadF);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable SexoEdaM1(string pal, int edadI, int edadF)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("clasmujeresedad", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        cmd.Parameters.AddWithValue("@edad1", edadI);
                        cmd.Parameters.AddWithValue("@edad2", edadF);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable SexoEdaH(string pal, int edadI, int edadF)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("hombresedad", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        cmd.Parameters.AddWithValue("@edad1", edadI);
                        cmd.Parameters.AddWithValue("@edad2", edadF);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable SexoEdaH1(string pal, int edadI, int edadF)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("clashombresedad", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        cmd.Parameters.AddWithValue("@edad1", edadI);
                        cmd.Parameters.AddWithValue("@edad2", edadF);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable SexoEscoM(string pal, int escI , int escF )
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("spEscM", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        cmd.Parameters.AddWithValue("@escIni", escI);
                        cmd.Parameters.AddWithValue("@escFin", escF);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable SexoEscoM1(string pal, int escI, int escF)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("classpEscM", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        cmd.Parameters.AddWithValue("@escIni", escI);
                        cmd.Parameters.AddWithValue("@escFin", escF);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable SexoEscoH(string pal, int escI , int escF)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("spEscH", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        cmd.Parameters.AddWithValue("@escIni", escI);
                        cmd.Parameters.AddWithValue("@escFin", escF);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable SexoEscoH1(string pal, int escI, int escF)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("classpEscH", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        cmd.Parameters.AddWithValue("@escIni", escI);
                        cmd.Parameters.AddWithValue("@escFin", escF);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable EscoEdad(string pal, int escI, int escF, int edadI, int edadF)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("spEscEdad", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        cmd.Parameters.AddWithValue("@escIni", escI);
                        cmd.Parameters.AddWithValue("@escFin", escF);
                        cmd.Parameters.AddWithValue("@edadIni", edadI);
                        cmd.Parameters.AddWithValue("@edadFin", edadF);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable EscoEdad1(string pal, int escI, int escF, int edadI, int edadF)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("classpEscEdad", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        cmd.Parameters.AddWithValue("@escIni", escI);
                        cmd.Parameters.AddWithValue("@escFin", escF);
                        cmd.Parameters.AddWithValue("@edadIni", edadI);
                        cmd.Parameters.AddWithValue("@edadFin", edadF);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable SexoEdaEscoM(string pal, int escI, int escF, int edadI, int edadF)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("spEscEdadMujeres", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        cmd.Parameters.AddWithValue("@escIni", escI);
                        cmd.Parameters.AddWithValue("@escFin", escF);
                        cmd.Parameters.AddWithValue("@edadIni", edadI);
                        cmd.Parameters.AddWithValue("@edadFin", edadF);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable SexoEdaEscoM1(string pal, int escI, int escF, int edadI, int edadF)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("classpEscEdadMujeres", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        cmd.Parameters.AddWithValue("@escIni", escI);
                        cmd.Parameters.AddWithValue("@escFin", escF);
                        cmd.Parameters.AddWithValue("@edadIni", edadI);
                        cmd.Parameters.AddWithValue("@edadFin", edadF);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable SexoEdaEscoH(string pal, int escI, int escF, int edadI, int edadF)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("spEscEdadHombre", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        cmd.Parameters.AddWithValue("@escIni", escI);
                        cmd.Parameters.AddWithValue("@escFin", escF);
                        cmd.Parameters.AddWithValue("@edadIni", edadI);
                        cmd.Parameters.AddWithValue("@edadFin", edadF);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable SexoEdaEscoH1(string pal, int escI, int escF, int edadI, int edadF)
        {
            try
            {
                string r = "";
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("classpEscEdadHombre", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p", pal);
                        cmd.Parameters.AddWithValue("@escIni", escI);
                        cmd.Parameters.AddWithValue("@escFin", escF);
                        cmd.Parameters.AddWithValue("@edadIni", edadI);
                        cmd.Parameters.AddWithValue("@edadFin", edadF);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable x = new DataTable();
                return x;
            }
        }
        public DataTable combo()
        {
            try
            {
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select distinct(palabraBase) from palabras.respuestas2", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
            }
        }
        public DataTable ids()
        {
            try
            {
                string builder = cone();
                using (MySqlConnection conn = new MySqlConnection(builder.ToString()))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select distinct(idsujeto) from palabras.sujeto2", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                DataTable dt = new DataTable();
                return dt;
            }
        }
        
        
        
    }
}
