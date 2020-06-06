namespace копировальный_центр
{
    partial class Заказы
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxЦена = new System.Windows.Forms.TextBox();
            this.textBoxАдрес = new System.Windows.Forms.TextBox();
            this.textBoxЗаказы = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxКлиенты = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxПоиск = new System.Windows.Forms.TextBox();
            this.buttonПоиск = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адресс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Заказ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // textBoxЦена
            // 
            this.textBoxЦена.Location = new System.Drawing.Point(545, 25);
            this.textBoxЦена.Name = "textBoxЦена";
            this.textBoxЦена.Size = new System.Drawing.Size(121, 20);
            this.textBoxЦена.TabIndex = 5;
            // 
            // textBoxАдрес
            // 
            this.textBoxАдрес.Location = new System.Drawing.Point(418, 25);
            this.textBoxАдрес.Name = "textBoxАдрес";
            this.textBoxАдрес.Size = new System.Drawing.Size(121, 20);
            this.textBoxАдрес.TabIndex = 6;
            // 
            // textBoxЗаказы
            // 
            this.textBoxЗаказы.Location = new System.Drawing.Point(291, 25);
            this.textBoxЗаказы.Name = "textBoxЗаказы";
            this.textBoxЗаказы.Size = new System.Drawing.Size(121, 20);
            this.textBoxЗаказы.TabIndex = 7;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 52);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(993, 417);
            this.listView.TabIndex = 8;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "id клиекнта";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Заказ";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Статус";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Адрес";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Телефон";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Цена";
            // 
            // comboBoxКлиенты
            // 
            this.comboBoxКлиенты.FormattingEnabled = true;
            this.comboBoxКлиенты.Location = new System.Drawing.Point(12, 25);
            this.comboBoxКлиенты.Name = "comboBoxКлиенты";
            this.comboBoxКлиенты.Size = new System.Drawing.Size(273, 21);
            this.comboBoxКлиенты.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Клиенты";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(672, 25);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(753, 25);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(834, 25);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 13;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxПоиск
            // 
            this.textBoxПоиск.Location = new System.Drawing.Point(69, 2);
            this.textBoxПоиск.Name = "textBoxПоиск";
            this.textBoxПоиск.Size = new System.Drawing.Size(100, 20);
            this.textBoxПоиск.TabIndex = 14;
            this.toolTip1.SetToolTip(this.textBoxПоиск, "Поиск по номеру телефона");
            // 
            // buttonПоиск
            // 
            this.buttonПоиск.Location = new System.Drawing.Point(175, 0);
            this.buttonПоиск.Name = "buttonПоиск";
            this.buttonПоиск.Size = new System.Drawing.Size(75, 23);
            this.buttonПоиск.TabIndex = 15;
            this.buttonПоиск.Text = "Поиск";
            this.toolTip1.SetToolTip(this.buttonПоиск, "Поиск по номеру телефона");
            this.buttonПоиск.UseVisualStyleBackColor = true;
            this.buttonПоиск.Click += new System.EventHandler(this.buttonПоиск_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // Заказы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 481);
            this.Controls.Add(this.buttonПоиск);
            this.Controls.Add(this.textBoxПоиск);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxКлиенты);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.textBoxЗаказы);
            this.Controls.Add(this.textBoxАдрес);
            this.Controls.Add(this.textBoxЦена);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Заказы";
            this.Text = "Заказы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxЦена;
        private System.Windows.Forms.TextBox textBoxАдрес;
        private System.Windows.Forms.TextBox textBoxЗаказы;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox comboBoxКлиенты;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxПоиск;
        private System.Windows.Forms.Button buttonПоиск;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}