using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Clear(Control ctrl)
        {
            foreach (Control item in ctrl.Controls)
            {
                if (item is TextBox txt)
                {
                    txt.Clear();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connection = "Server=localhost;Database=PhoneBook;Trusted_Connection=True;";
            using SqlConnection con = new SqlConnection(connection); // using block to dispose the connection
            using SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            /* cmd.CommandText = "insert into People (FirstName, LastName, Mail, Phone) VALUES('Hasan', 'Abbasov', 'hasanva@code.edu.az', '+994558286555')";*/
            cmd.CommandText = "insert into People (FirstName, LastName, Mail, Phone) VALUES(@firstName, @lastName, @mail, @phone)";
            cmd.Parameters.AddWithValue("@firstName",txtAdi.Text);
            cmd.Parameters.AddWithValue("@lastName",txtSoyadi.Text);
            cmd.Parameters.AddWithValue("@mail",txtMail.Text);
            cmd.Parameters.AddWithValue("@phone",txtTelefon.Text);
                cmd.CommandType = System.Data.CommandType.Text;

            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            
            bool result = cmd.ExecuteNonQuery() > 0;

            MessageBox.Show(result ? "Kayit eklendi" : "Islem hatasi" , "Kayi Ekleme Bildirimi",
                MessageBoxButtons.OK, result ? MessageBoxIcon.Asterisk : MessageBoxIcon.Error);
            Clear(grbSavePerson);
        }
    }
}
