namespace копировальный_центр
{
    partial class Меню
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
            this.buttonКлиенты = new System.Windows.Forms.Button();
            this.buttonЗаказы = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonКлиенты
            // 
            this.buttonКлиенты.Location = new System.Drawing.Point(12, 12);
            this.buttonКлиенты.Name = "buttonКлиенты";
            this.buttonКлиенты.Size = new System.Drawing.Size(198, 37);
            this.buttonКлиенты.TabIndex = 0;
            this.buttonКлиенты.Text = "Клиенты";
            this.buttonКлиенты.UseVisualStyleBackColor = true;
            this.buttonКлиенты.Click += new System.EventHandler(this.buttonКлиенты_Click);
            // 
            // buttonЗаказы
            // 
            this.buttonЗаказы.Location = new System.Drawing.Point(12, 55);
            this.buttonЗаказы.Name = "buttonЗаказы";
            this.buttonЗаказы.Size = new System.Drawing.Size(198, 37);
            this.buttonЗаказы.TabIndex = 1;
            this.buttonЗаказы.Text = "Заказы";
            this.buttonЗаказы.UseVisualStyleBackColor = true;
            this.buttonЗаказы.Click += new System.EventHandler(this.buttonЗаказы_Click);
            // 
            // Меню
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 218);
            this.Controls.Add(this.buttonЗаказы);
            this.Controls.Add(this.buttonКлиенты);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Меню";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Меню_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonКлиенты;
        private System.Windows.Forms.Button buttonЗаказы;
    }
}