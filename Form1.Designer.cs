namespace YalymovPV_01_08
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemoveAt = new System.Windows.Forms.Button();
            this.listBoxSports = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTarget = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рост";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Возраст в годах";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вес тела(кг)";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(407, 26);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 26);
            this.textBoxHeight.TabIndex = 3;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(407, 80);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 26);
            this.textBoxYear.TabIndex = 4;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(407, 129);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 26);
            this.textBoxWeight.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxTarget);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonRemoveAt);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxWeight);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxYear);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxHeight);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 470);
            this.panel1.TabIndex = 6;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(117, 242);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(118, 48);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemoveAt
            // 
            this.buttonRemoveAt.Location = new System.Drawing.Point(352, 242);
            this.buttonRemoveAt.Name = "buttonRemoveAt";
            this.buttonRemoveAt.Size = new System.Drawing.Size(176, 48);
            this.buttonRemoveAt.TabIndex = 7;
            this.buttonRemoveAt.Text = "Удалить выбранное";
            this.buttonRemoveAt.UseVisualStyleBackColor = true;
            this.buttonRemoveAt.Click += new System.EventHandler(this.buttonRemoveAt_Click);
            // 
            // listBoxSports
            // 
            this.listBoxSports.FormattingEnabled = true;
            this.listBoxSports.ItemHeight = 20;
            this.listBoxSports.Location = new System.Drawing.Point(716, 12);
            this.listBoxSports.Name = "listBoxSports";
            this.listBoxSports.Size = new System.Drawing.Size(554, 484);
            this.listBoxSports.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Цель";
            // 
            // comboBoxTarget
            // 
            this.comboBoxTarget.FormattingEnabled = true;
            this.comboBoxTarget.Items.AddRange(new object[] {
            "fit",
            "fat"});
            this.comboBoxTarget.Location = new System.Drawing.Point(407, 181);
            this.comboBoxTarget.Name = "comboBoxTarget";
            this.comboBoxTarget.Size = new System.Drawing.Size(121, 28);
            this.comboBoxTarget.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 634);
            this.Controls.Add(this.listBoxSports);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRemoveAt;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxSports;
        private System.Windows.Forms.ComboBox comboBoxTarget;
        private System.Windows.Forms.Label label4;
    }
}

