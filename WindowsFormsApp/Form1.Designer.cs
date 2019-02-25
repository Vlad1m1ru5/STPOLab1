namespace WindowsFormsApp
{
    partial class formMain
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
            this.labelProjName = new System.Windows.Forms.Label();
            this.labelFail = new System.Windows.Forms.Label();
            this.textBoxFail = new System.Windows.Forms.TextBox();
            this.groupBoxFail = new System.Windows.Forms.GroupBox();
            this.buttonFile = new System.Windows.Forms.Button();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.checkBoxSortQSort = new System.Windows.Forms.CheckBox();
            this.checkBoxSortShell = new System.Windows.Forms.CheckBox();
            this.labelSort = new System.Windows.Forms.Label();
            this.groupBoxArg = new System.Windows.Forms.GroupBox();
            this.textBoxArg = new System.Windows.Forms.TextBox();
            this.labelArg = new System.Windows.Forms.Label();
            this.buttonExe = new System.Windows.Forms.Button();
            this.openFileDialogFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxFail.SuspendLayout();
            this.groupBoxSort.SuspendLayout();
            this.groupBoxArg.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelProjName
            // 
            this.labelProjName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelProjName.AutoSize = true;
            this.labelProjName.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProjName.Location = new System.Drawing.Point(12, 9);
            this.labelProjName.Name = "labelProjName";
            this.labelProjName.Size = new System.Drawing.Size(612, 35);
            this.labelProjName.TabIndex = 0;
            this.labelProjName.Text = "Программа поиска трёхзначного числа в файле";
            // 
            // labelFail
            // 
            this.labelFail.AutoSize = true;
            this.labelFail.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFail.Location = new System.Drawing.Point(6, 16);
            this.labelFail.Name = "labelFail";
            this.labelFail.Size = new System.Drawing.Size(172, 22);
            this.labelFail.TabIndex = 1;
            this.labelFail.Text = "Укажите путь к файлу";
            // 
            // textBoxFail
            // 
            this.textBoxFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFail.Location = new System.Drawing.Point(184, 19);
            this.textBoxFail.Name = "textBoxFail";
            this.textBoxFail.Size = new System.Drawing.Size(229, 20);
            this.textBoxFail.TabIndex = 2;
            this.textBoxFail.Text = "<путь к файлу>";
            // 
            // groupBoxFail
            // 
            this.groupBoxFail.Controls.Add(this.buttonFile);
            this.groupBoxFail.Controls.Add(this.labelFail);
            this.groupBoxFail.Controls.Add(this.textBoxFail);
            this.groupBoxFail.Location = new System.Drawing.Point(12, 74);
            this.groupBoxFail.Name = "groupBoxFail";
            this.groupBoxFail.Size = new System.Drawing.Size(455, 51);
            this.groupBoxFail.TabIndex = 3;
            this.groupBoxFail.TabStop = false;
            this.groupBoxFail.Text = "Файл";
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(419, 18);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(30, 20);
            this.buttonFile.TabIndex = 3;
            this.buttonFile.Text = "...";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.Controls.Add(this.checkBoxSortQSort);
            this.groupBoxSort.Controls.Add(this.checkBoxSortShell);
            this.groupBoxSort.Controls.Add(this.labelSort);
            this.groupBoxSort.Location = new System.Drawing.Point(12, 236);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(455, 51);
            this.groupBoxSort.TabIndex = 4;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Сортировка";
            // 
            // checkBoxSortQSort
            // 
            this.checkBoxSortQSort.AutoSize = true;
            this.checkBoxSortQSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBoxSortQSort.Location = new System.Drawing.Point(317, 21);
            this.checkBoxSortQSort.Name = "checkBoxSortQSort";
            this.checkBoxSortQSort.Size = new System.Drawing.Size(132, 17);
            this.checkBoxSortQSort.TabIndex = 2;
            this.checkBoxSortQSort.Text = "Быстрая сортировка";
            this.checkBoxSortQSort.UseVisualStyleBackColor = true;
            // 
            // checkBoxSortShell
            // 
            this.checkBoxSortShell.AutoSize = true;
            this.checkBoxSortShell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.checkBoxSortShell.Location = new System.Drawing.Point(247, 21);
            this.checkBoxSortShell.Name = "checkBoxSortShell";
            this.checkBoxSortShell.Size = new System.Drawing.Size(53, 17);
            this.checkBoxSortShell.TabIndex = 1;
            this.checkBoxSortShell.Text = "Шелл";
            this.checkBoxSortShell.UseVisualStyleBackColor = true;
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.labelSort.Location = new System.Drawing.Point(6, 16);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(212, 22);
            this.labelSort.TabIndex = 0;
            this.labelSort.Text = "Укажите метод сортировки";
            // 
            // groupBoxArg
            // 
            this.groupBoxArg.Controls.Add(this.textBoxArg);
            this.groupBoxArg.Controls.Add(this.labelArg);
            this.groupBoxArg.Location = new System.Drawing.Point(12, 155);
            this.groupBoxArg.Name = "groupBoxArg";
            this.groupBoxArg.Size = new System.Drawing.Size(455, 51);
            this.groupBoxArg.TabIndex = 5;
            this.groupBoxArg.TabStop = false;
            this.groupBoxArg.Text = "Значение";
            // 
            // textBoxArg
            // 
            this.textBoxArg.Location = new System.Drawing.Point(306, 19);
            this.textBoxArg.Name = "textBoxArg";
            this.textBoxArg.Size = new System.Drawing.Size(143, 20);
            this.textBoxArg.TabIndex = 1;
            this.textBoxArg.Text = "0";
            this.textBoxArg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelArg
            // 
            this.labelArg.AutoSize = true;
            this.labelArg.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.labelArg.Location = new System.Drawing.Point(6, 16);
            this.labelArg.Name = "labelArg";
            this.labelArg.Size = new System.Drawing.Size(294, 22);
            this.labelArg.TabIndex = 0;
            this.labelArg.Text = "Укажите искомое трёхзначеное число";
            // 
            // buttonExe
            // 
            this.buttonExe.Location = new System.Drawing.Point(12, 317);
            this.buttonExe.Name = "buttonExe";
            this.buttonExe.Size = new System.Drawing.Size(90, 30);
            this.buttonExe.TabIndex = 6;
            this.buttonExe.Text = "Выполнить";
            this.buttonExe.UseVisualStyleBackColor = false;
            this.buttonExe.Click += new System.EventHandler(this.buttonExe_Click);
            // 
            // openFileDialogFile
            // 
            this.openFileDialogFile.FileName = "openFileDialog1";
            this.openFileDialogFile.Title = "Файл для сортировки";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 359);
            this.Controls.Add(this.buttonExe);
            this.Controls.Add(this.groupBoxArg);
            this.Controls.Add(this.groupBoxSort);
            this.Controls.Add(this.groupBoxFail);
            this.Controls.Add(this.labelProjName);
            this.MaximumSize = new System.Drawing.Size(662, 397);
            this.MinimumSize = new System.Drawing.Size(662, 397);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxFail.ResumeLayout(false);
            this.groupBoxFail.PerformLayout();
            this.groupBoxSort.ResumeLayout(false);
            this.groupBoxSort.PerformLayout();
            this.groupBoxArg.ResumeLayout(false);
            this.groupBoxArg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProjName;
        private System.Windows.Forms.Label labelFail;
        private System.Windows.Forms.TextBox textBoxFail;
        private System.Windows.Forms.GroupBox groupBoxFail;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.GroupBox groupBoxArg;
        private System.Windows.Forms.Label labelArg;
        private System.Windows.Forms.TextBox textBoxArg;
        private System.Windows.Forms.CheckBox checkBoxSortShell;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.CheckBox checkBoxSortQSort;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonExe;
        private System.Windows.Forms.OpenFileDialog openFileDialogFile;
    }
}

