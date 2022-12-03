namespace ClinicClientData
{
    partial class MainForm
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonCheckLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewClientAnimal = new System.Windows.Forms.DataGridView();
            this.dataGridViewClinicClient = new System.Windows.Forms.DataGridView();
            this.textBoxSearchNameClinic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMainInformation = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxSearchTimeBefore = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSearchTimeSince = new System.Windows.Forms.MaskedTextBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClinicClient)).BeginInit();
            this.panelMainInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(1189, 589);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(1282, 710);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonCheckLog
            // 
            this.buttonCheckLog.Location = new System.Drawing.Point(1223, 12);
            this.buttonCheckLog.Name = "buttonCheckLog";
            this.buttonCheckLog.Size = new System.Drawing.Size(134, 76);
            this.buttonCheckLog.TabIndex = 5;
            this.buttonCheckLog.Text = "Показать логи";
            this.buttonCheckLog.UseVisualStyleBackColor = true;
            this.buttonCheckLog.Click += new System.EventHandler(this.buttonCheckLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1106, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Животные человека";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Таблица с посещениями";
            // 
            // dataGridViewClientAnimal
            // 
            this.dataGridViewClientAnimal.AllowUserToAddRows = false;
            this.dataGridViewClientAnimal.AllowUserToDeleteRows = false;
            this.dataGridViewClientAnimal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientAnimal.Location = new System.Drawing.Point(902, 30);
            this.dataGridViewClientAnimal.Name = "dataGridViewClientAnimal";
            this.dataGridViewClientAnimal.ReadOnly = true;
            this.dataGridViewClientAnimal.Size = new System.Drawing.Size(443, 407);
            this.dataGridViewClientAnimal.TabIndex = 6;
            // 
            // dataGridViewClinicClient
            // 
            this.dataGridViewClinicClient.AllowUserToAddRows = false;
            this.dataGridViewClinicClient.AllowUserToDeleteRows = false;
            this.dataGridViewClinicClient.AllowUserToOrderColumns = true;
            this.dataGridViewClinicClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClinicClient.Location = new System.Drawing.Point(3, 30);
            this.dataGridViewClinicClient.Name = "dataGridViewClinicClient";
            this.dataGridViewClinicClient.ReadOnly = true;
            this.dataGridViewClinicClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClinicClient.Size = new System.Drawing.Size(896, 407);
            this.dataGridViewClinicClient.TabIndex = 0;
            this.dataGridViewClinicClient.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewClinicClient_CellMouseDoubleClick);
            // 
            // textBoxSearchNameClinic
            // 
            this.textBoxSearchNameClinic.Location = new System.Drawing.Point(125, 527);
            this.textBoxSearchNameClinic.Name = "textBoxSearchNameClinic";
            this.textBoxSearchNameClinic.Size = new System.Drawing.Size(211, 20);
            this.textBoxSearchNameClinic.TabIndex = 9;
            this.textBoxSearchNameClinic.TextChanged += new System.EventHandler(this.textBoxSearchNameClinic_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "По названию клиники:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 556);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "По дате";
            // 
            // panelMainInformation
            // 
            this.panelMainInformation.Controls.Add(this.label7);
            this.panelMainInformation.Controls.Add(this.label6);
            this.panelMainInformation.Controls.Add(this.label5);
            this.panelMainInformation.Controls.Add(this.maskedTextBoxSearchTimeBefore);
            this.panelMainInformation.Controls.Add(this.maskedTextBoxSearchTimeSince);
            this.panelMainInformation.Controls.Add(this.label2);
            this.panelMainInformation.Controls.Add(this.label4);
            this.panelMainInformation.Controls.Add(this.label1);
            this.panelMainInformation.Controls.Add(this.dataGridViewClinicClient);
            this.panelMainInformation.Controls.Add(this.textBoxSearchNameClinic);
            this.panelMainInformation.Controls.Add(this.label3);
            this.panelMainInformation.Controls.Add(this.dataGridViewClientAnimal);
            this.panelMainInformation.Controls.Add(this.buttonRefresh);
            this.panelMainInformation.Location = new System.Drawing.Point(12, 121);
            this.panelMainInformation.Name = "panelMainInformation";
            this.panelMainInformation.Size = new System.Drawing.Size(1345, 612);
            this.panelMainInformation.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 496);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Фильтровать";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 559);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "По";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 559);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "C";
            // 
            // maskedTextBoxSearchTimeBefore
            // 
            this.maskedTextBoxSearchTimeBefore.Location = new System.Drawing.Point(277, 556);
            this.maskedTextBoxSearchTimeBefore.Mask = "0000-00-00T90:00:00";
            this.maskedTextBoxSearchTimeBefore.Name = "maskedTextBoxSearchTimeBefore";
            this.maskedTextBoxSearchTimeBefore.Size = new System.Drawing.Size(119, 20);
            this.maskedTextBoxSearchTimeBefore.TabIndex = 14;
            this.maskedTextBoxSearchTimeBefore.TextChanged += new System.EventHandler(this.maskedTextBoxSearchTimeBefor_TextChanged);
            // 
            // maskedTextBoxSearchTimeSince
            // 
            this.maskedTextBoxSearchTimeSince.Location = new System.Drawing.Point(125, 556);
            this.maskedTextBoxSearchTimeSince.Mask = "0000-00-00T90:00:00";
            this.maskedTextBoxSearchTimeSince.Name = "maskedTextBoxSearchTimeSince";
            this.maskedTextBoxSearchTimeSince.Size = new System.Drawing.Size(119, 20);
            this.maskedTextBoxSearchTimeSince.TabIndex = 13;
            this.maskedTextBoxSearchTimeSince.TextChanged += new System.EventHandler(this.maskedTextBoxSearchTimeAfter_TextChanged);
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.Location = new System.Drawing.Point(12, 12);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(1205, 719);
            this.listBoxLog.TabIndex = 15;
            this.listBoxLog.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 745);
            this.Controls.Add(this.buttonCheckLog);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelMainInformation);
            this.Controls.Add(this.listBoxLog);
            this.Name = "MainForm";
            this.Text = "ClinicData";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClinicClient)).EndInit();
            this.panelMainInformation.ResumeLayout(false);
            this.panelMainInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonCheckLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewClientAnimal;
        private System.Windows.Forms.DataGridView dataGridViewClinicClient;
        private System.Windows.Forms.TextBox textBoxSearchNameClinic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelMainInformation;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSearchTimeSince;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSearchTimeBefore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}

