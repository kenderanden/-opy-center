namespace копировальный_центр
{
    partial class Клиенты
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
            this.components = new System.ComponentModel.Container();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxпочта = new System.Windows.Forms.TextBox();
            this.textBoxтелефон = new System.Windows.Forms.TextBox();
            this.textBoxимя = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonПоиск = new System.Windows.Forms.Button();
            this.textBoxПоиск = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 129);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(12, 158);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 23);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(12, 187);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(100, 23);
            this.buttonDel.TabIndex = 2;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxпочта
            // 
            this.textBoxпочта.Location = new System.Drawing.Point(12, 103);
            this.textBoxпочта.Name = "textBoxпочта";
            this.textBoxпочта.Size = new System.Drawing.Size(100, 20);
            this.textBoxпочта.TabIndex = 3;
            // 
            // textBoxтелефон
            // 
            this.textBoxтелефон.Location = new System.Drawing.Point(12, 64);
            this.textBoxтелефон.Name = "textBoxтелефон";
            this.textBoxтелефон.Size = new System.Drawing.Size(100, 20);
            this.textBoxтелефон.TabIndex = 4;
            // 
            // textBoxимя
            // 
            this.textBoxимя.Location = new System.Drawing.Point(12, 25);
            this.textBoxимя.Name = "textBoxимя";
            this.textBoxимя.Size = new System.Drawing.Size(100, 20);
            this.textBoxимя.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Почта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Имя";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(118, 12);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(670, 426);
            this.listView.TabIndex = 9;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "id";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Имя";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Телефон";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mail";
            // 
            // buttonПоиск
            // 
            this.buttonПоиск.Location = new System.Drawing.Point(12, 299);
            this.buttonПоиск.Name = "buttonПоиск";
            this.buttonПоиск.Size = new System.Drawing.Size(100, 23);
            this.buttonПоиск.TabIndex = 10;
            this.buttonПоиск.Text = "Поиск";
            this.toolTip1.SetToolTip(this.buttonПоиск, "Поиск по номеру телефона");
            this.buttonПоиск.UseVisualStyleBackColor = true;
            this.buttonПоиск.Click += new System.EventHandler(this.buttonПоиск_Click);
            // 
            // textBoxПоиск
            // 
            this.textBoxПоиск.Location = new System.Drawing.Point(12, 273);
            this.textBoxПоиск.Name = "textBoxПоиск";
            this.textBoxПоиск.Size = new System.Drawing.Size(100, 20);
            this.textBoxПоиск.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textBoxПоиск, "Поиск по номеру телефона");
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // Клиенты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxПоиск);
            this.Controls.Add(this.buttonПоиск);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxимя);
            this.Controls.Add(this.textBoxтелефон);
            this.Controls.Add(this.textBoxпочта);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Клиенты";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxпочта;
        private System.Windows.Forms.TextBox textBoxтелефон;
        private System.Windows.Forms.TextBox textBoxимя;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button buttonПоиск;
        private System.Windows.Forms.TextBox textBoxПоиск;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}