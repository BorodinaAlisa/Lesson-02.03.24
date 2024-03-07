namespace Lesson_02._03._24
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Название");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Адрес");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Телефон");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Меню");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Количество столов");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ресторан", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Номер столика");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Вместимость");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Бронь");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Дата и время бронирования");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Список зарезервированных блюд");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Столик", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Имя");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Телефон");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Email");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Количество гостей");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Специальные требования");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Клиент", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Clients = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Загрузить = new System.Windows.Forms.Button();
            this.Закрыть = new System.Windows.Forms.Button();
            this.Показать = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clients)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.treeView2);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Clients);
            this.splitContainer2.Panel2.Controls.Add(this.Загрузить);
            this.splitContainer2.Panel2.Controls.Add(this.Закрыть);
            this.splitContainer2.Panel2.Controls.Add(this.Показать);
            this.splitContainer2.Size = new System.Drawing.Size(981, 613);
            this.splitContainer2.SplitterDistance = 327;
            this.splitContainer2.TabIndex = 1;
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView2.Location = new System.Drawing.Point(0, 223);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "Название";
            treeNode1.Text = "Название";
            treeNode2.Name = "Адрес";
            treeNode2.Text = "Адрес";
            treeNode3.Name = "Телефон";
            treeNode3.Text = "Телефон";
            treeNode4.Name = "Меню";
            treeNode4.Text = "Меню";
            treeNode5.Name = "Количество столов";
            treeNode5.Text = "Количество столов";
            treeNode6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            treeNode6.Name = "Ресторан";
            treeNode6.Text = "Ресторан";
            treeNode7.Name = "Номер столика";
            treeNode7.Text = "Номер столика";
            treeNode8.Name = "Вместимость";
            treeNode8.Text = "Вместимость";
            treeNode9.Name = "Бронь";
            treeNode9.Text = "Бронь";
            treeNode10.Name = "Дата и время бронирования";
            treeNode10.Text = "Дата и время бронирования";
            treeNode11.Name = "Список зарезервированных блюд";
            treeNode11.Text = "Список зарезервированных блюд";
            treeNode12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            treeNode12.Name = "Столик";
            treeNode12.Text = "Столик";
            treeNode13.Name = "Имя";
            treeNode13.Text = "Имя";
            treeNode14.Name = "Телефон";
            treeNode14.Text = "Телефон";
            treeNode15.Name = "Email";
            treeNode15.Text = "Email";
            treeNode16.Name = "Количество гостей";
            treeNode16.Text = "Количество гостей";
            treeNode17.Name = "Специальные требования";
            treeNode17.Text = "Специальные требования";
            treeNode18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            treeNode18.Name = "Клиент";
            treeNode18.Text = "Клиент";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode12,
            treeNode18});
            this.treeView2.Size = new System.Drawing.Size(249, 390);
            this.treeView2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(327, 223);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Clients
            // 
            this.Clients.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.Clients.Location = new System.Drawing.Point(25, 150);
            this.Clients.Name = "Clients";
            this.Clients.RowHeadersWidth = 51;
            this.Clients.RowTemplate.Height = 24;
            this.Clients.Size = new System.Drawing.Size(580, 187);
            this.Clients.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Загрузить
            // 
            this.Загрузить.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Загрузить.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Загрузить.Location = new System.Drawing.Point(2, 0);
            this.Загрузить.Name = "Загрузить";
            this.Загрузить.Size = new System.Drawing.Size(197, 91);
            this.Загрузить.TabIndex = 0;
            this.Загрузить.Text = "Загрузить";
            this.Загрузить.UseVisualStyleBackColor = false;
            this.Загрузить.Click += new System.EventHandler(this.Загрузить_Click);
            // 
            // Закрыть
            // 
            this.Закрыть.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Закрыть.Location = new System.Drawing.Point(408, 0);
            this.Закрыть.Name = "Закрыть";
            this.Закрыть.Size = new System.Drawing.Size(197, 91);
            this.Закрыть.TabIndex = 2;
            this.Закрыть.Text = "Закрыть\r\n";
            this.Закрыть.UseVisualStyleBackColor = false;
            this.Закрыть.Click += new System.EventHandler(this.Закрыть_Click);
            // 
            // Показать
            // 
            this.Показать.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Показать.Location = new System.Drawing.Point(205, 0);
            this.Показать.Name = "Показать";
            this.Показать.Size = new System.Drawing.Size(197, 91);
            this.Показать.TabIndex = 1;
            this.Показать.Text = "Показать";
            this.Показать.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(981, 613);
            this.Controls.Add(this.splitContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Бронирование столиков в ресторане";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button Загрузить;
        private System.Windows.Forms.Button Закрыть;
        private System.Windows.Forms.Button Показать;
        private System.Windows.Forms.DataGridView Clients;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

