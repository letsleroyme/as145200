using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Reflection;
using System.Threading;

namespace as145200
{
    class WordReport
    {
        Word._Application application; //объявление переменных для работы с Word'ом
        Word._Document document;

        Object missingObj = System.Reflection.Missing.Value;
        Object trueObj = true;
        Object falseObj = false;

        private Form1 form;
        public WordReport(Form1 tmp) 
        {
            form = tmp;

        }

        /*public string[] SaveDataFromDGV1(DataGridView datagrid) // Сохранение информации из dataGridview
        {
            string[] selectedCell1 = new string[datagrid.SelectedCells.Count]; // СОздание двумерного массива
            for (int i = 0; i < datagrid.SelectedCells.Count; i++) // в цикле проходим по все выделенным строкам
            {
                selectedCell1[i] = datagrid.SelectedCells[i].Value.ToString(); // добавляем информацию
            }
            return selectedCell1;
        }*/

        public string[,] SaveDataFromDGV(DataGridView datagrid)// Сохранение информации из dataGridview
        {
            int i = 0;
            string[,] selectedCell1 = new string[datagrid.SelectedRows.Count, 2]; // СОздание двумерного массива

            foreach (DataGridViewRow dr in datagrid.SelectedRows) // в цикле проходим по все выделенным строкам
            {
                selectedCell1[i, 0] = dr.Cells[0].Value.ToString(); // добавляем информацию в массив в зависимости от столбца
                selectedCell1[i, 1] = dr.Cells[2].Value.ToString();
                i++;
            }
            
            return selectedCell1;

        }

        public string[,] SaveInstructionAndWorkFromDGV(DataGridView datagrid) // здесь тоже самое, но для другого столбца
        {
            string[,] selectedCell1 = new string[datagrid.SelectedRows.Count, 2];
            int i = 0;
            foreach (DataGridViewRow dr in datagrid.SelectedRows)
            {
                selectedCell1[i, 0] = dr.Cells[0].Value.ToString();
                selectedCell1[i, 1] = dr.Cells[1].Value.ToString();
                i++;
            }
            return selectedCell1;
        }

        public void MakeReport(DataGridView WorkerGrid, DataGridView WorkGrid, DataGridView InstructionGrid)
        {
            
            string[,] Worker = SaveDataFromDGV(WorkerGrid); // инициализация двумерного массива для работы 
            string[,] Instruction = SaveInstructionAndWorkFromDGV(InstructionGrid);

            application = new Word.Application(); // инициализация ворд документа
            object templatePathObj = Application.StartupPath + @"\Template.docx"; // путь до документа
            try
            {
                document = application.Documents.Add(ref templatePathObj, ref missingObj, ref missingObj, ref missingObj); // открытие документа
            }
            catch (Exception error) // в случае ошибки подчищаем память и показываем ошибку. 
            {
                document.Close(ref falseObj, ref missingObj, ref missingObj);
                application.Quit(ref missingObj, ref missingObj, ref missingObj);
                document = null;
                application = null;
                //throw error;
                MessageBox.Show(error.ToString(), "OK", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            string workStart = "08:00";
            string workEnd = "17:00";
            //application.Visible = true;

            object bookmarkObj = "Naryad_Number"; // здесь и ниже заполняем текст в документе.
            Word.Range bookmarkRange = document.Bookmarks.get_Item(ref bookmarkObj).Range;
            bookmarkRange.Text = form.naryadNomer.Text;

            bookmarkObj = "Naryad_Date";
            bookmarkRange = document.Bookmarks.get_Item(ref bookmarkObj).Range;
            bookmarkRange.Text = form.Date.Text;

            

            bookmarkObj = "Workman";
            bookmarkRange = document.Bookmarks.get_Item(ref bookmarkObj).Range;
            bookmarkRange.Text = form.workman.Text;


            bookmarkObj = "AmountWorkers";
            bookmarkRange = document.Bookmarks.get_Item(ref bookmarkObj).Range;
            bookmarkRange.Text = WorkerGrid.SelectedRows.Count.ToString();

            bookmarkObj = "WorkStart";
            bookmarkRange = document.Bookmarks.get_Item(ref bookmarkObj).Range;
            bookmarkRange.Text = workStart;

            bookmarkObj = "Date";
            bookmarkRange = document.Bookmarks.get_Item(ref bookmarkObj).Range;
            bookmarkRange.Text = form.Date.Text;

            bookmarkObj = "WorkEnd";
            bookmarkRange = document.Bookmarks.get_Item(ref bookmarkObj).Range;
            bookmarkRange.Text = workEnd;

            bookmarkObj = "Date2";
            bookmarkRange = document.Bookmarks.get_Item(ref bookmarkObj).Range;
            bookmarkRange.Text = form.Date.Text;

            bookmarkObj = "Head";
            bookmarkRange = document.Bookmarks.get_Item(ref bookmarkObj).Range;
            bookmarkRange.Text = form.head.Text;

            bookmarkObj = "Date3";
            bookmarkRange = document.Bookmarks.get_Item(ref bookmarkObj).Range;
            bookmarkRange.Text = form.Date.Text;

            Print("WhatWork", WorkGrid);
            Print("Instruction", InstructionGrid);
            Print("InstructionID", InstructionGrid);



            bookmarkObj = "AmountWorkers2";
            bookmarkRange = document.Bookmarks.get_Item(ref bookmarkObj).Range;
            bookmarkRange.Text = WorkerGrid.SelectedRows.Count.ToString();

            Word.Table _table = document.Tables[1];
            Word.Range _currentRange;
            for (int i = 0; i < WorkerGrid.SelectedRows.Count; i++) // в этом циеле заполняется таблица
            {
                _currentRange = _table.Cell(i+2, 2).Range;
                _currentRange.Text = Worker[i, 0];

                _currentRange = _table.Cell(i+2, 3).Range;
                _currentRange.Text = Worker[i, 1];           
            }
            //печать и закрытие документа
            document.PrintOut(ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj, ref missingObj);
            document.Close(Word.WdSaveOptions.wdDoNotSaveChanges);

            application.Quit();
        }

        public void Print(string bookmark, DataGridView datagrid) // вывод информации из datagriview
        {
            string[,] grid = SaveInstructionAndWorkFromDGV(datagrid);

            object bookmarkObj = bookmark;
            Word.Range bookmarkRange = document.Bookmarks.get_Item(ref bookmarkObj).Range;
            if (bookmark == "InstructionID" || bookmark == "WorkID")
            {
                for (int i = 0; i < datagrid.SelectedRows.Count; i++)
                {
                    bookmarkRange.Text += String.Format("{0} ", grid[i, 0]);
                }
            }
            else
            {
                for (int i = 0; i < datagrid.SelectedRows.Count; i++)
                {
                    bookmarkRange.Text += String.Format("{0} ", grid[i, 1]);
                }
            }
            
        }

    }
}
