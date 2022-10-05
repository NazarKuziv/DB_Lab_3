using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace DB_Lab_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            passwordTb.PasswordChar = '*';
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
        static public Form1 form1 = null;
        private void Log_in_button_Click(object sender, EventArgs e)
        {
            if ((userNameTb.Text != "") && (passwordTb.Text != ""))
            {
                try
                {
                    db.con.Open();
                    db.cmd.CommandText = "SELECT * FROM dbo.Users WHERE [user_name] = '" + userNameTb.Text + "' AND [password] = '" + passwordTb.Text + "' ;"; 
                    SqlDataReader reader = db.cmd.ExecuteReader();
                    
                    int level = 1;
                    int i = 0;
                    while (reader.Read())
                    {
                        i++;
                        level = reader.GetInt32(2);

                    }
                    reader.Close();
                    if(i == 1)
                    {
                        userNameTb.Text = "";
                        passwordTb.Text = "";

                        if (form1 == null)
                            form1 = new Form1(level);
                        form1.RefToForm2 = this;
                        this.Visible = false;
                        form1.Show();
                        form1.Activate();
                        
                    }
                    else
                    {
                        MessageBox.Show("Wrong username or password!");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString());
                }
                finally
                {
                    db.con.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter your username and password");
            }         

        }

        private void Log_up_button_Click(object sender, EventArgs e)
        {
            if ((userNameTb.Text != "") && (passwordTb.Text != ""))
            {
                try
                {
                    db.con.Open();
                    db.cmd.CommandText = "SELECT * FROM dbo.Users WHERE [user_name] = '" + userNameTb.Text + "' ;";
                    SqlDataReader reader = db.cmd.ExecuteReader();
                    string check_user_name = "";
                    int i = 0;
                    while (reader.Read())
                    {
                        i++;
                        check_user_name = reader.GetValue(0).ToString();
                    }
                    reader.Close();

                    if (i==0)
                    {
                        db.cmd.CommandText = "Insert into dbo.Users([user_name], [password],[level])" +
                        " Values('" + userNameTb.Text + "','" + passwordTb.Text + "',1);";
                        db.cmd.ExecuteNonQuery();
                        userNameTb.Text = "";
                        passwordTb.Text = "";
                        MessageBox.Show($"Registration was successful");
                    }
                    else
                    {
                        MessageBox.Show($"Username '{userNameTb.Text}' is already taken.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString());
                }
                finally
                {
                    db.con.Close();
                }
                

               
            }
            else
            {
                MessageBox.Show("Enter your username and password");
            }
;
           


        }
    }
}
