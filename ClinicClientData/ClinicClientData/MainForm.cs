using ClinicClientData.Entity;
using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace ClinicClientData
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Кнопка просмотр логов
        /// </summary>
        bool buttonCheck = true;
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Обработчик загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridViewClinicClient.DataSource = LoadData.GetData().Tables[0];
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message, Kernel.Exception, MessageBoxButtons.OK);
            }

        }
        /// <summary>
        /// Обработчик отображения логов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCheckLog_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Kernel.RootFolderPath, Kernel.LogFilePath);
            string[] ArrayLog;
            try
            {
                if (buttonCheck)
                {
                    buttonCheckLog.Text = "Скрыть логи";
                    panelMainInformation.Visible = false;
                    listBoxLog.Visible = true;
                    ArrayLog = File.ReadAllLines(path);
                    listBoxLog.Items.AddRange(ArrayLog);
                    this.buttonCheck = false;
                }
                else
                {
                    buttonCheckLog.Text = "Показать логи";
                    panelMainInformation.Visible = true;
                    listBoxLog.Visible = false;
                    listBoxLog.Items.Clear();
                    this.buttonCheck = true;
                }
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message, Kernel.Exception, MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// Обработчик закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Обработчик двойного нажатия мышью по выделенной строке для отображения животных клиента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewClinicClient_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridViewClinicClient.Rows[e.RowIndex] != null)
            {
                try
                {
                    ArrayList Empty = new ArrayList();
                    dataGridViewClientAnimal.DataSource = Empty;
                    Customer customer = new Customer();
                    customer.Id = Convert.ToInt32(dataGridViewClinicClient.Rows[e.RowIndex].Cells[3].Value);
                    dataGridViewClientAnimal.DataSource = LoadData.GetAnimalData(customer).Tables[0];
                }
                catch (Exception f)
                {
                    MessageBox.Show(f.Message, Kernel.Exception, MessageBoxButtons.OK);
                }
            }
        }
        /// <summary>
        /// Обработчик кнопки обновления данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList Empty = new ArrayList();
                dataGridViewClientAnimal.DataSource = Empty;
                dataGridViewClinicClient.DataSource = Empty;
                dataGridViewClinicClient.DataSource = LoadData.GetData().Tables[0];
                maskedTextBoxSearchTimeBefore.Text = "";
                maskedTextBoxSearchTimeSince.Text = "";
                textBoxSearchNameClinic.Text = "";
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message, Kernel.Exception, MessageBoxButtons.OK);
            }
        }
        private void textBoxSearchNameClinic_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }
        private void maskedTextBoxSearchTimeAfter_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }
        private void maskedTextBoxSearchTimeBefor_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }
        /// <summary>
        /// Фильтр
        /// </summary>
        public void Filter()
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataGridViewClinicClient.DataSource;
            bindingSource.Filter = $"Type LIKE '{textBoxSearchNameClinic.Text}%'";
            if (!(maskedTextBoxSearchTimeBefore.Text == Kernel.DateFilterMask))
            {
                bindingSource.Filter += $"and Time <='{maskedTextBoxSearchTimeBefore.Text}%'";
            }
            if (!(maskedTextBoxSearchTimeSince.Text == Kernel.DateFilterMask))
            {
                bindingSource.Filter += $"and Time >= '{maskedTextBoxSearchTimeSince.Text}%'";
            }
            dataGridViewClinicClient.DataSource = bindingSource;
        }
    }
}
