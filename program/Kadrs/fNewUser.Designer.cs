
namespace Kadrs
{
    partial class fNewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNewUser));
            this.lTitle = new System.Windows.Forms.Label();
            this.pTitle = new System.Windows.Forms.Panel();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.lSurname = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.lPhone = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lBirthday = new System.Windows.Forms.Label();
            this.cbPosts = new System.Windows.Forms.ComboBox();
            this.lPost = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.pTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTitle.Location = new System.Drawing.Point(115, 30);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(154, 33);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "Новый кадр";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pTitle.Controls.Add(this.lTitle);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(390, 100);
            this.pTitle.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(182, 139);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 27);
            this.tbName.TabIndex = 2;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(182, 106);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(180, 27);
            this.tbSurname.TabIndex = 1;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(182, 172);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(180, 27);
            this.tbLastName.TabIndex = 3;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(182, 205);
            this.tbPhone.Mask = "+7(999) 000-0000";
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(180, 27);
            this.tbPhone.TabIndex = 4;
            this.tbPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(182, 238);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(180, 27);
            this.tbEmail.TabIndex = 5;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(127, 142);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(43, 19);
            this.lName.TabIndex = 6;
            this.lName.Text = "Имя:";
            // 
            // lSurname
            // 
            this.lSurname.AutoSize = true;
            this.lSurname.Location = new System.Drawing.Point(95, 109);
            this.lSurname.Name = "lSurname";
            this.lSurname.Size = new System.Drawing.Size(75, 19);
            this.lSurname.TabIndex = 6;
            this.lSurname.Text = "Фамилия:";
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(95, 175);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(78, 19);
            this.lLastName.TabIndex = 6;
            this.lLastName.Text = "Отчество:";
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(43, 208);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(130, 19);
            this.lPhone.TabIndex = 6;
            this.lPhone.Text = "Номер телефона:";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(27, 241);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(146, 19);
            this.lEmail.TabIndex = 6;
            this.lEmail.Text = "Электронная почта:";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(182, 271);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(180, 27);
            this.dtpBirthday.TabIndex = 6;
            // 
            // lBirthday
            // 
            this.lBirthday.AutoSize = true;
            this.lBirthday.Location = new System.Drawing.Point(51, 277);
            this.lBirthday.Name = "lBirthday";
            this.lBirthday.Size = new System.Drawing.Size(119, 19);
            this.lBirthday.TabIndex = 6;
            this.lBirthday.Text = "Дата рождения:";
            // 
            // cbPosts
            // 
            this.cbPosts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosts.FormattingEnabled = true;
            this.cbPosts.Location = new System.Drawing.Point(182, 304);
            this.cbPosts.Name = "cbPosts";
            this.cbPosts.Size = new System.Drawing.Size(180, 27);
            this.cbPosts.TabIndex = 7;
            // 
            // lPost
            // 
            this.lPost.AutoSize = true;
            this.lPost.Location = new System.Drawing.Point(81, 307);
            this.lPost.Name = "lPost";
            this.lPost.Size = new System.Drawing.Size(89, 19);
            this.lPost.TabIndex = 6;
            this.lPost.Text = "Должность:";
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(12, 391);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(366, 30);
            this.bCancel.TabIndex = 9;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(12, 355);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(366, 30);
            this.bAdd.TabIndex = 8;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // fNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 433);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.cbPosts);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.lPost);
            this.Controls.Add(this.lBirthday);
            this.Controls.Add(this.lEmail);
            this.Controls.Add(this.lPhone);
            this.Controls.Add(this.lLastName);
            this.Controls.Add(this.lSurname);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.pTitle);
            this.Font = new System.Drawing.Font("Candara", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление нового кадра";
            this.Load += new System.EventHandler(this.fNewUser_Load);
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.MaskedTextBox tbPhone;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lSurname;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lBirthday;
        private System.Windows.Forms.ComboBox cbPosts;
        private System.Windows.Forms.Label lPost;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdd;
    }
}