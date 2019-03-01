using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Windows.Forms;

namespace as145200
{
    class SqlClass
    {
        // ниже идет объяевление переменных для работы с базой
        private SQLiteCommandBuilder CommandBuilder;
        private SQLiteDataAdapter adapter_instruction;
        private SQLiteDataAdapter adapter_work;
        private SQLiteDataAdapter adapter_worker;
        public DataSet data_set_instruction;
        public DataSet data_set_work;
        public DataSet data_set_worker;
        private string databaseName = @"as145200.db";
        private Form1 tmp;
        private SQLiteConnection conn;

        //Конструктор класса, в класс передается переменная формы для работы с формой, в конструкторе открывается соединение с базой данных
        public SqlClass(Form1 Temp)
        {
            tmp = Temp; // операция для работы с формой
            conn = new SQLiteConnection(string.Format("Data Source={0};", databaseName)); // инициализация переменной подключения к БД
            try
            {
                conn.Open(); // подключение к БД
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.ToString(), "OK", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        //метод закрытия подключения к базе данных
        public void Dispose()
        {
            conn.Dispose();
        } 

        //Метод для сохранения результатов В БД
        public void SaveButton_Instruction ()
        {
            adapter_instruction.Update((DataTable)tmp.dataGridView1.DataSource);
        }
        public void SaveButton_Work()
        {
            adapter_work.Update((DataTable)tmp.dataGridView2.DataSource);
        }
        public void SaveButton_Worker()
        {
            adapter_worker.Update((DataTable)tmp.dataGridView3.DataSource);
        }

        //Метод, выводящий результаты на форму из базы данных
        public void ShowInstruction()
        {
            tmp.dataGridView1.AllowUserToAddRows = false; //определение свойства формы, запрещащющее пользователю добавлять новые строки в dataGridView
            tmp.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            string sql_command = "select * from Instruction"; // строка запроса к БД
            adapter_instruction = new SQLiteDataAdapter(sql_command, conn); // инициализация и выполнение запроса
            CommandBuilder = new SQLiteCommandBuilder(adapter_instruction); // формирование адаптера
            adapter_instruction.UpdateCommand = CommandBuilder.GetUpdateCommand(); // добавление комманды к адаптеру
            adapter_instruction.InsertCommand = CommandBuilder.GetInsertCommand();
            adapter_instruction.DeleteCommand = CommandBuilder.GetDeleteCommand();
            data_set_instruction = new DataSet(); // формирование дата-сет элемента
            adapter_instruction.Fill(data_set_instruction); // заполнение данными из базы 
            tmp.dataGridView1.DataSource = data_set_instruction.Tables[0]; // вывод базы на экран
        }
        // в двух методах ниже, код почти повторяется с методом выше.
        public void ShowWorker()
        {
            tmp.dataGridView2.AllowUserToAddRows = false;
            tmp.dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sql_command = "select * from Work";
            adapter_work = new SQLiteDataAdapter(sql_command, conn);
            CommandBuilder = new SQLiteCommandBuilder(adapter_work);
            adapter_work.UpdateCommand = CommandBuilder.GetUpdateCommand();
            adapter_work.InsertCommand = CommandBuilder.GetInsertCommand();
            adapter_work.DeleteCommand = CommandBuilder.GetDeleteCommand();
            data_set_work = new DataSet();
            adapter_work.Fill(data_set_work);
            tmp.dataGridView2.DataSource = data_set_work.Tables[0];
        }

        public void ShowWork()
        {
            tmp.dataGridView3.AllowUserToAddRows = false;
            tmp.dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            string sql_command = "select * from Worker";
            adapter_worker = new SQLiteDataAdapter(sql_command, conn);
            CommandBuilder = new SQLiteCommandBuilder(adapter_worker);
            adapter_worker.UpdateCommand = CommandBuilder.GetUpdateCommand();
            adapter_worker.InsertCommand = CommandBuilder.GetInsertCommand();
            adapter_worker.DeleteCommand = CommandBuilder.GetDeleteCommand();
            data_set_worker = new DataSet();
            adapter_worker.Fill(data_set_worker);
            tmp.dataGridView3.DataSource = data_set_worker.Tables[0];

        }

    }
}
