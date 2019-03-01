using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace as145200
{
    public partial class Form1 : Form
    {
        SqlClass Sql;
        WordReport Word;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Word = new WordReport(this);

            Sql = new SqlClass(this);
            Sql.ShowInstruction();
            Sql.ShowWork();
            Sql.ShowWorker();

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Sql.Dispose();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            DataRow row = Sql.data_set_instruction.Tables[0].NewRow(); // добавляем новую строку в DataTable
            Sql.data_set_instruction.Tables[0].Rows.Add(row);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Instruction_delete_row_Click(object sender, EventArgs e)
        {
            DeleteRow(dataGridView1);
        }

        private void Instruction_update_Click(object sender, EventArgs e)
        {
            Sql.SaveButton_Instruction();
        }

        private void worker_insert_Click(object sender, EventArgs e)
        {
            DataRow row = Sql.data_set_worker.Tables[0].NewRow(); // добавляем новую строку в DataTable
            Sql.data_set_worker.Tables[0].Rows.Add(row);
        }

        

        private void worker_delete_Click(object sender, EventArgs e)
        {
            DeleteRow(dataGridView2);

        }

        private void work_delete_Click(object sender, EventArgs e)
        {
            DeleteRow(dataGridView3);

        }

        private void worker_update_Click(object sender, EventArgs e)
        {
            Sql.SaveButton_Worker();
        }

        private void work_insert_Click(object sender, EventArgs e)
        {
            DataRow row = Sql.data_set_work.Tables[0].NewRow(); // добавляем новую строку в DataTable
            Sql.data_set_work.Tables[0].Rows.Add(row);
        }

        private void work_update_Click(object sender, EventArgs e)
        {
            Sql.SaveButton_Work();
        }


        private void DeleteRow(DataGridView datagrid)
        {
            foreach (DataGridViewRow row in datagrid.SelectedRows)
            {
                datagrid.Rows.Remove(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Word.MakeReport(dataGridView3, dataGridView2, dataGridView1);
           
            //Word.test(dataGridView3);
        }
    }
}
