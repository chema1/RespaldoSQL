using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace respaldoSQL
{
    public partial class Form1 : Form
    {
        private SqlCommand command;
        private SqlConnection conn;
        private SqlDataReader leer;
        string sql = "";
        string conectarString = "";

        private DataSet ds;
        private OleDbConnection conexion;
        private OleDbDataAdapter adaptador;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                conectarString="Data Source ="+txtDataSourse.Text+"; User Id="+txtUserID.Text+"; Password="+txtPassword.Text+"";
                conn = new SqlConnection(conectarString);
                conn.Open();
                //sql = "EXEC sp_databases";
                sql = "SELECT * FROM sys.databases d WHERE d.database_id>4";
                command = new SqlCommand(sql,conn);
                leer = command.ExecuteReader();
                comboBD.Items.Clear();
                while (leer.Read()) {
                    comboBD.Items.Add(leer[0].ToString());
                }
                txtDataSourse.Enabled = false;
                txtPassword.Enabled = false;
                txtUserID.Enabled = false;
                button1.Enabled = false;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                comboBD.Enabled = true;
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtDataSourse.Enabled = true;
            txtUserID.Enabled = true;
            txtPassword.Enabled = true;
            comboBD.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button5.Enabled = false;
            comboBD.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try { 
                if(comboBD.Text.CompareTo("")==0){//si no hay nada seleccionado 
                    MessageBox.Show("selecciona una base de datos");
                    return;
                }
                conn = new SqlConnection(conectarString);
                conn.Open();
                sql = "BACKUP DATABASE " + comboBD.Text + " TO DISK='" + txtLocalizacion.Text + "\\" + comboBD.Text + "." + DateTime.Now.Ticks.ToString() + ".bak'";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                MessageBox.Show("EL RESPALDO SE REALIZO CORRECTAMENTE");
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dig = new FolderBrowserDialog();
            if(dig.ShowDialog()==DialogResult.OK){
                txtLocalizacion.Text = dig.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            dig.Filter = "Backup Files(*.bak)|*.bak|All Files(*.*)|*.*";
            dig.FilterIndex = 0;
            if (dig.ShowDialog() == DialogResult.OK)
            {
                txtRespaldo.Text = dig.SafeFileName;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try { 
                if(comboBD.Text.CompareTo("")==0){
                    MessageBox.Show("Selecciona una base de datos");
                    return;
                }
                conn = new SqlConnection(conectarString);
                conn.Open();
                sql = "Alter Database " + comboBD.Text + " Set SINGLE_USER WHIT ROLLBACK IMMEDIATE;";
                sql += "Restore Database " + comboBD.Text + " FROM DISK='" + txtRespaldo.Text + "' WHIT REPLACE;";
                command = new SqlCommand(sql,conn);
                command.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("restauracion d la BD correctamete");
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            conexion = new OleDbConnection(@"PROVIDER=Microsoft.ACE.OLEDB.12.0; Data Source=Prueba.xls; Extended Properties=Excel 12.0 Xml");
            adaptador = new OleDbDataAdapter("SELECT * FROM [Hoja1$]", conexion);
            adaptador.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

            //conectar a sql server //para este ejercicios debemos tener una base Excel y una tabla TablaExcel(ID,NOMBRE,GRUPO)
            SqlConnection conexiondestino = new SqlConnection("Data Source=servidor; Initial Catalog=Excel;User ID=sa; Password=234");
            conexiondestino.Open();
            SqlBulkCopy importar = new SqlBulkCopy(conexiondestino);
            importar.DestinationTableName = "TablaExcel";
            importar.WriteToServer(ds.Tables[0]);
            conexiondestino.Close();
        }
    }
}
