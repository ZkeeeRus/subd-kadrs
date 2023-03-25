using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Kadrs
{
    public class Parametres
    {
        //public static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\Базы данных\Kadrs.mdf"";Integrated Security=True;Connect Timeout=30";
        public static string ConnectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\ZkeeeRusSoftware\Kadrs.mdf"";Integrated Security=True;Connect Timeout=30";
    }

    public class SqlQuery
    {
        public static SqlDataReader ExecuteReader(string query)
        {
            if (query == null)
                throw new ArgumentNullException("query");

            SqlConnection connection = new SqlConnection(Parametres.ConnectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                return command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка подключения", MessageBoxButtons.OK);

                if (connection.State == ConnectionState.Open)
                    connection.Close();
                return null;
            }

        }
        public static void Execute(string query)
        {
            if (query == null)
                throw new ArgumentNullException("query");

            SqlConnection connection = new SqlConnection(Parametres.ConnectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка подключения", MessageBoxButtons.OK);

                if (connection.State == ConnectionState.Open)
                    connection.Close();
                return;
            }

        }
        public static void Execute(string query, string paramName, object param)
        {
            if (query == null)
                throw new ArgumentNullException("query");

            SqlConnection connection = new SqlConnection(Parametres.ConnectionString);
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue(paramName, param);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка подключения", MessageBoxButtons.OK);

                if (connection.State == ConnectionState.Open)
                    connection.Close();
                return;
            }

        }
    }



    public class UserData
    {
        public int IdUser;
        public int IdPost;

        public string Name;
        public string Surname;
        public string LastName;
        public DateTime Birthday;
        public string Phone;
        public string Email;
        public string Post;

        public Image Photo;
    }
    public class PostData
    {
        public int IdPost;
        public string Name;
    }

    public class UserItem : Panel
    {
        public UserData Data;

       public PictureBox pbPhoto;
       public Label lPost;
       public Label lEmail;
       public Label lPhone;
       public Label lBirthday;
       public Label lFIO;

        public UserItem(UserData data)
        {
            Data = data;


            this.lFIO = new Label();
            this.pbPhoto = new PictureBox();
            this.lBirthday = new Label();
            this.lPhone = new Label();
            this.lEmail = new Label();
            this.lPost = new Label();
          
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.DoubleBuffered = true;
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.lPost);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lPhone);
            this.Controls.Add(this.lBirthday);
            this.Controls.Add(this.lFIO);
            this.Size = new Size(650, 115);
            // 
            // lFIO
            // 
            this.lFIO.AutoSize = true;
            this.lFIO.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.lFIO.Location = new Point(129, 7);
            this.lFIO.Name = "lFIO";
            this.lFIO.Size = new Size(205, 23);
            this.lFIO.TabIndex = 0;
            this.lFIO.Text = $"{Data.Surname} {Data.Name} {Data.LastName}";
            // 
            // pbPhoto
            // 
            pbPhoto.Location = new Point(3, 6);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new Size(120, 100);
            this.pbPhoto.TabIndex = 1;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            this.pbPhoto.BorderStyle = BorderStyle.FixedSingle;
            this.pbPhoto.Image = Data.Photo;
            // 
            // lBirthday
            // 
            this.lBirthday.AutoSize = true;
            this.lBirthday.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.lBirthday.Location = new Point(129, 30);
            this.lBirthday.Name = "lBirthday";
            this.lBirthday.Size = new Size(202, 19);
            this.lBirthday.TabIndex = 0;
            this.lBirthday.Text = $"Дата рождения: {Data.Birthday.ToString("d")}";
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.lPhone.Location = new Point(129, 49);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new Size(236, 19);
            this.lPhone.TabIndex = 0;
            this.lPhone.Text = $"Номер телефона: {Data.Phone}";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.lEmail.Location = new Point(129, 68);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new Size(292, 19);
            this.lEmail.TabIndex = 0;
            this.lEmail.Text = $"Электронная почта: {Data.Email}";
            // 
            // lPost
            // 
            this.lPost.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            this.lPost.Location = new Point(244, 94);
            this.lPost.Name = "lPost";
            this.lPost.Size = new Size(401, 19);
            this.lPost.TabIndex = 0;
            this.lPost.Text = $"Должность: {Data.Post}";
            this.lPost.TextAlign = ContentAlignment.MiddleRight;
        }
    }
}
