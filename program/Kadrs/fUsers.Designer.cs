
namespace Kadrs
{
    partial class fUsers
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUsers));
            this.flpUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.pTitle = new System.Windows.Forms.Panel();
            this.lTitle = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lSearchBy = new System.Windows.Forms.Label();
            this.cbSearchBy = new System.Windows.Forms.ComboBox();
            this.lFilter = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.cbSort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pPages = new System.Windows.Forms.Panel();
            this.lNext = new System.Windows.Forms.Label();
            this.lBack = new System.Windows.Forms.Label();
            this.bNewUser = new System.Windows.Forms.Button();
            this.bRemoveUser = new System.Windows.Forms.Button();
            this.rtbQuery = new System.Windows.Forms.RichTextBox();
            this.pTitle.SuspendLayout();
            this.pPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpUsers
            // 
            this.flpUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpUsers.AutoScroll = true;
            this.flpUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpUsers.Location = new System.Drawing.Point(-1, 139);
            this.flpUsers.Name = "flpUsers";
            this.flpUsers.Size = new System.Drawing.Size(744, 294);
            this.flpUsers.TabIndex = 0;
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pTitle.Controls.Add(this.rtbQuery);
            this.pTitle.Controls.Add(this.lTitle);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(744, 100);
            this.pTitle.TabIndex = 1;
            // 
            // lTitle
            // 
            this.lTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTitle.Location = new System.Drawing.Point(281, 29);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(178, 33);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "Отдел кадров";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSearch
            // 
            this.tbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbSearch.Font = new System.Drawing.Font("Candara", 12F);
            this.tbSearch.Location = new System.Drawing.Point(69, 106);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(149, 27);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.FilterChanged);
            // 
            // lSearchBy
            // 
            this.lSearchBy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lSearchBy.AutoSize = true;
            this.lSearchBy.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lSearchBy.Location = new System.Drawing.Point(224, 109);
            this.lSearchBy.Name = "lSearchBy";
            this.lSearchBy.Size = new System.Drawing.Size(32, 19);
            this.lSearchBy.TabIndex = 3;
            this.lSearchBy.Text = "По:";
            // 
            // cbSearchBy
            // 
            this.cbSearchBy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchBy.Font = new System.Drawing.Font("Candara", 12F);
            this.cbSearchBy.FormattingEnabled = true;
            this.cbSearchBy.Items.AddRange(new object[] {
            "Отсутствует",
            "Имени",
            "Фамилии",
            "Отчеству"});
            this.cbSearchBy.Location = new System.Drawing.Point(262, 106);
            this.cbSearchBy.Name = "cbSearchBy";
            this.cbSearchBy.Size = new System.Drawing.Size(118, 27);
            this.cbSearchBy.TabIndex = 2;
            this.cbSearchBy.SelectedIndexChanged += new System.EventHandler(this.FilterChanged);
            // 
            // lFilter
            // 
            this.lFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lFilter.AutoSize = true;
            this.lFilter.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFilter.Location = new System.Drawing.Point(386, 109);
            this.lFilter.Name = "lFilter";
            this.lFilter.Size = new System.Drawing.Size(63, 19);
            this.lFilter.TabIndex = 3;
            this.lFilter.Text = "Фильтр:";
            // 
            // cbFilter
            // 
            this.cbFilter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.Font = new System.Drawing.Font("Candara", 12F);
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Без фильтрации",
            "Стажёр",
            "Уборщик",
            "Программист",
            "Менеджер",
            "Консультант"});
            this.cbFilter.Location = new System.Drawing.Point(455, 106);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(145, 27);
            this.cbFilter.TabIndex = 3;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.FilterChanged);
            // 
            // cbSort
            // 
            this.cbSort.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSort.Font = new System.Drawing.Font("Candara", 12F);
            this.cbSort.FormattingEnabled = true;
            this.cbSort.Items.AddRange(new object[] {
            "Без сортировки",
            "По убыванию",
            "По возрастанию"});
            this.cbSort.Location = new System.Drawing.Point(606, 106);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(126, 27);
            this.cbSort.TabIndex = 4;
            this.cbSort.SelectedIndexChanged += new System.EventHandler(this.FilterChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Поиск:";
            // 
            // pPages
            // 
            this.pPages.Controls.Add(this.lNext);
            this.pPages.Controls.Add(this.lBack);
            this.pPages.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pPages.Font = new System.Drawing.Font("Candara", 12F);
            this.pPages.Location = new System.Drawing.Point(0, 472);
            this.pPages.Name = "pPages";
            this.pPages.Size = new System.Drawing.Size(744, 45);
            this.pPages.TabIndex = 5;
            // 
            // lNext
            // 
            this.lNext.AutoSize = true;
            this.lNext.Location = new System.Drawing.Point(206, 17);
            this.lNext.Name = "lNext";
            this.lNext.Size = new System.Drawing.Size(17, 19);
            this.lNext.TabIndex = 0;
            this.lNext.Text = ">";
            this.lNext.Click += new System.EventHandler(this.LNext_Click);
            // 
            // lBack
            // 
            this.lBack.AutoSize = true;
            this.lBack.Location = new System.Drawing.Point(139, 16);
            this.lBack.Name = "lBack";
            this.lBack.Size = new System.Drawing.Size(17, 19);
            this.lBack.TabIndex = 0;
            this.lBack.Text = "<";
            this.lBack.Click += new System.EventHandler(this.LBack_Click);
            // 
            // bNewUser
            // 
            this.bNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bNewUser.Font = new System.Drawing.Font("Candara", 12F);
            this.bNewUser.Location = new System.Drawing.Point(587, 439);
            this.bNewUser.Name = "bNewUser";
            this.bNewUser.Size = new System.Drawing.Size(145, 27);
            this.bNewUser.TabIndex = 6;
            this.bNewUser.Text = "Добавить нового";
            this.bNewUser.UseVisualStyleBackColor = true;
            this.bNewUser.Click += new System.EventHandler(this.bNewUser_Click);
            // 
            // bRemoveUser
            // 
            this.bRemoveUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bRemoveUser.Font = new System.Drawing.Font("Candara", 12F);
            this.bRemoveUser.Location = new System.Drawing.Point(407, 439);
            this.bRemoveUser.Name = "bRemoveUser";
            this.bRemoveUser.Size = new System.Drawing.Size(174, 27);
            this.bRemoveUser.TabIndex = 6;
            this.bRemoveUser.Text = "Удалить выделенного";
            this.bRemoveUser.UseVisualStyleBackColor = true;
            this.bRemoveUser.Click += new System.EventHandler(this.bRemoveUser_Click);
            // 
            // rtbQuery
            // 
            this.rtbQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rtbQuery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbQuery.Font = new System.Drawing.Font("Candara", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbQuery.Location = new System.Drawing.Point(455, 3);
            this.rtbQuery.Name = "rtbQuery";
            this.rtbQuery.ReadOnly = true;
            this.rtbQuery.Size = new System.Drawing.Size(286, 94);
            this.rtbQuery.TabIndex = 2;
            this.rtbQuery.Text = "";
            // 
            // fUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 517);
            this.Controls.Add(this.bRemoveUser);
            this.Controls.Add(this.bNewUser);
            this.Controls.Add(this.pPages);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.cbSearchBy);
            this.Controls.Add(this.lFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lSearchBy);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pTitle);
            this.Controls.Add(this.flpUsers);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(760, 555);
            this.Name = "fUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "СУБД \"Кадры\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.pPages.ResumeLayout(false);
            this.pPages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpUsers;
        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lSearchBy;
        private System.Windows.Forms.ComboBox cbSearchBy;
        private System.Windows.Forms.Label lFilter;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.ComboBox cbSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pPages;
        private System.Windows.Forms.Label lNext;
        private System.Windows.Forms.Label lBack;
        private System.Windows.Forms.Button bNewUser;
        private System.Windows.Forms.Button bRemoveUser;
        private System.Windows.Forms.RichTextBox rtbQuery;
    }
}

