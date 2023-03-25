using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Kadrs
{
    public partial class fNewUser : Form
    {
        public fNewUser()
        {
            InitializeComponent();
        }

        List<PostData> lstPosts = new List<PostData>();

        private void fNewUser_Load(object sender, EventArgs e)
        {
            dtpBirthday.MaxDate = DateTime.Now;

            string query = "Select IdPost, Name From Posts";
            SqlDataReader data = SqlQuery.ExecuteReader(query);
            if (data == null)
                return;

            while (data.Read())
            {
                PostData post = new PostData();
                post.IdPost = Convert.ToInt32(data["IdPost"]);
                post.Name = data["Name"].ToString();

                lstPosts.Add(post);
                cbPosts.Items.Add(post.Name);
            }

            data.Close();

            cbPosts.SelectedIndex = 0;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            if (tbSurname.Text.Trim() != "" || tbName.Text.Trim() != "" || tbLastName.Text.Trim() != "" || tbEmail.Text.Trim() != "" || !tbPhone.Text.Contains("_"))
            {
                string phone = "+7" + tbPhone.Text;
                int IdPost = lstPosts[cbPosts.SelectedIndex].IdPost;
                DateTime birthday = dtpBirthday.Value;

                try
                {
                    MailAddress adress = new MailAddress(tbEmail.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Электронная почта написано неверно!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbEmail.Text = "";

                    return;
                }


                string query = $"Insert into Users (Surname, Name, LastName, Phone, Email, Birthday, IdPost) " +
                               $"Values ('{tbSurname.Text.Trim()}', '{tbName.Text.Trim()}', '{tbLastName.Text.Trim()}', '{phone}', '{tbEmail.Text.Trim()}', '{birthday.ToString("yyyy-MM-dd")}', {IdPost})";
                SqlQuery.Execute(query);


                MessageBox.Show("Кадр успешно добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Заполнены не все поля!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
