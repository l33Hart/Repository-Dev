using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace LeeHart_CE02
{
    class DataCall
    {
        string connection = "userid=dbsAdmin;" +
                "password=password;" +
        "database=MobileDev;" +
        "port=8889;";


       MySqlConnection Conn = new MySqlConnection();
        MySqlCommand Command = new MySqlCommand();
        OpenFileDialog open = new OpenFileDialog();
        public DataCall()
        {
            MessageBox.Show("Select your TXT file with your IP");
            if (open.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader read = new StreamReader(open.FileName))
                {
                    connection = @"server=" + read.ReadLine().ToString() +";" + connection;
                }
            }
            try
            {
                MySqlConnection Conn = new MySqlConnection(connection);
                Command.Connection = Conn;
                Conn.Open();
                MessageBox.Show("Connected");
                
            }
            catch(Exception e)
            { MessageBox.Show(e.ToString()); }
            

        }
        public DataTable Data_Table(string query)
        {
            DataTable table = new DataTable();
            try
            {

                Command.CommandText = query;
                MySqlDataAdapter dataTable = new MySqlDataAdapter(Command);
                dataTable.Fill(table);
            }catch(Exception e) { MessageBox.Show(e.ToString()); }
            return table;
        }
        public void AddData(string query)
        {
           
            try
            {
                
                
                Command.CommandText = query;
                Command.ExecuteNonQuery();
                
            }catch(Exception e) { MessageBox.Show(e.ToString()); }
            
        }
    }
}
