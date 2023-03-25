using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kadrs
{
    public partial class fUsers : Form
    {
        private List<UserData> userItems = new List<UserData>();
        private int CountPerPage = 6, NBegin = 0;
        private UserItem SelectedUser;

        public fUsers()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("C:\\ZkeeeRusSoftware"))
            {
                Directory.CreateDirectory("C:\\ZkeeeRusSoftware");
            }
            try
            {
                if (!File.Exists("C:\\ZkeeeRusSoftware\\Kadrs.mdf"))
                {
                    var data = Properties.Resources.Kadrs;
                    using (var stream = new FileStream("C:\\ZkeeeRusSoftware\\Kadrs.mdf", FileMode.Create))
                    {
                        stream.Write(data, 0, data.Count());
                        stream.Flush();
                    }
                }
                if (!File.Exists("C:\\ZkeeeRusSoftware\\Kadrs_log.mdf"))
                {
                    var data = Properties.Resources.Kadrs_log;
                    using (var stream = new FileStream("C:\\ZkeeeRusSoftware\\Kadrs_log.mdf", FileMode.Create))
                    {
                        stream.Write(data, 0, data.Count());
                        stream.Flush();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при запуске!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
                return;
            }

            cbSearchBy.SelectedIndex = 0;
            cbFilter.SelectedIndex = 0;
            cbSort.SelectedIndex = 0;

            FillList();
            FillTable();
        }

        private void FillList()
        {
            NBegin = 0;

            userItems.Clear();


            string filter = "";

            switch (cbFilter.SelectedIndex)
            {
                case 1: // Стажёр
                    filter += " and p.Name = 'Стажёр' ";
                    break;

                case 2: // Уборщик
                    filter += " and p.Name = 'Уборщик' ";
                    break;

                case 3: // Программист
                    filter += " and p.Name = 'Программист' ";
                    break;

                case 4: // Менеджер
                    filter += " and p.Name = 'Менеджер' ";
                    break;

                case 5: // Консультант
                    filter += " and p.Name = 'Консультант' ";
                    break;
            }

            switch (cbSearchBy.SelectedIndex)
            {
                case 1: // Name
                    filter += $" and u.Name like '{tbSearch.Text}%' ";
                    break;

                case 2: // Surname
                    filter += $" and u.Surname like '{tbSearch.Text}%' ";
                    break;

                case 3: // LastName
                    filter += $" and u.LastName like '{tbSearch.Text}%' ";
                    break;
            }

            if (cbSort.SelectedIndex == 1)
            {
                filter += "\n Order by Surname DESC ";
            }
            else if (cbSort.SelectedIndex == 2)
            {
                filter += "\n Order by Name ASC ";
            }


            string query = $"Select u.IdUser as Id, u.Name as Name, u.Surname as Surname, u.LastName as LastName, u.Birthday as Birthday, u.Phone as Phone, u.Email as Email, p.Name as Post, p.IdPost as IdPost \n" +
                           $"From Users u, Posts p \n" +
                           $"Where u.IdPost = p.IdPost {filter}";

            rtbQuery.Text = query;

            SqlDataReader data = SqlQuery.ExecuteReader(query);
            if (data == null)
                return;

            while (data.Read())
            {

                UserData user = new UserData();

                user.IdUser = Convert.ToInt32(data["Id"]);
                user.IdPost = Convert.ToInt32(data["IdPost"]);

                user.Name = data["Name"].ToString();
                user.Surname = data["Surname"].ToString();
                user.LastName = data["LastName"].ToString();
                user.Phone = data["Phone"].ToString();
                user.Email = data["Email"].ToString();
                user.Birthday = Convert.ToDateTime(data["Birthday"]);
                user.Post = data["Post"].ToString();

                user.Photo = Properties.Resources.User;


                userItems.Add(user);
                //flpUsers.Controls.Add(item);

            }

            data.Close();
        }
        private void FillTable()
        {
            flpUsers.Controls.Clear();

          

            for (int i = NBegin; i <= NBegin + CountPerPage - 1; i++)
            {
                // если вышли за пределы списка
                if (i > userItems.Count - 1)
                    break;
                //
                UserItem item = new UserItem(userItems[i]);

                item.Click += Panel_Click;
                item.lFIO.Click += PanelItem_Click;
                item.lPhone.Click += PanelItem_Click;
                item.lEmail.Click += PanelItem_Click;
                item.lPost.Click += PanelItem_Click;
                item.lBirthday.Click += PanelItem_Click;
                item.pbPhoto.Click += PanelItem_Click;

                flpUsers.Controls.Add(item);

            }
            if (flpUsers.Controls.Count > 0)
            {
                SelectedUser = flpUsers.Controls[0] as UserItem;
                SelectedUser.BackColor = Color.LightGreen;
            }

            if (CountPerPage == 0)
                CountPerPage = 1;
            int Cnt = userItems.Count / CountPerPage;
            // кол-во страниц
            // если есть неполная последняя страница
            if (userItems.Count % CountPerPage != 0)
                Cnt++;


            pPages.Controls.Clear();
            lBack.Dock = DockStyle.Left;
            lNext.Dock = DockStyle.Left;
            pPages.Controls.Add(lNext);
            for (int i = Cnt; i >= 1; i--)
            {
                Label l = new Label();
                l.Text = i.ToString();
                l.Dock = DockStyle.Left;
                l.AutoSize = true;
                // если отображается номер текущей страницы
                if ((NBegin + CountPerPage) / CountPerPage == i)
                {
                    l.BackColor = Color.LightGray;
                    l.Font = new Font(l.Font, FontStyle.Bold);
                }
                l.Click += L_Click;
                pPages.Controls.Add(l);
            }

            pPages.Controls.Add(lBack);

            //TslInfo.Text = $"Всего записей: {userItems.Count}, отображается {DgvClients.RowCount}";
        }

        private void PanelItem_Click(object sender, EventArgs e)
        {
            Panel parent = ((sender as Control).Parent as Panel);

            Panel_Click(parent, e);
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            SelectedUser.BackColor = Color.White;

            SelectedUser = sender as UserItem;

            SelectedUser.BackColor = Color.LightGreen;
        }

        private void L_Click(object sender, EventArgs e)
        {
            //номер страницы на метке, на которой выполнили щелчок
            int n = int.Parse((sender as Label).Text);
            NBegin = (n - 1) * CountPerPage;
            FillTable();
        }
        private void LBack_Click(object sender, EventArgs e)
        {
            //если страница не первая
            if (NBegin > 0)
            {
                NBegin -= CountPerPage;
                FillTable();
            }
        }
        //нужно
        private void LNext_Click(object sender, EventArgs e)
        {
            //если страница не последняя
            if (NBegin + CountPerPage < userItems.Count)
            {
                NBegin += CountPerPage;
                FillTable();
            }
        }

        private void bNewUser_Click(object sender, EventArgs e)
        {
            fNewUser newUser = new fNewUser();
            if (newUser.ShowDialog() == DialogResult.OK)
            {
                FillList();
                FillTable();
            }
        }

        private void bRemoveUser_Click(object sender, EventArgs e)
        {
            if (SelectedUser == null)
            {
                MessageBox.Show("Ни один пользователь не выделен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"Вы действительно хотите удалить {SelectedUser.Data.Surname}?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = $"Delete Users " +
                               $"Where IdUser = {SelectedUser.Data.IdUser}";
                SqlQuery.Execute(query);

                FillList();
                FillTable();

                MessageBox.Show("Кадр удалён из базы!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FilterChanged(object sender, EventArgs e)
        {
            FillList();
            FillTable();
        }
    }
}
