namespace as145200
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.naryadNomer = new System.Windows.Forms.TextBox();
            this.workman = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.head = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.MakeReport = new System.Windows.Forms.Button();
            this.work_update = new System.Windows.Forms.Button();
            this.work_delete = new System.Windows.Forms.Button();
            this.work_insert = new System.Windows.Forms.Button();
            this.worker_update = new System.Windows.Forms.Button();
            this.worker_delete = new System.Windows.Forms.Button();
            this.worker_insert = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Instruction_update = new System.Windows.Forms.Button();
            this.Instruction_delete_row = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Instruction_Add_Row = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.naryadNomer);
            this.tabPage2.Controls.Add(this.workman);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.head);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.Date);
            this.tabPage2.Controls.Add(this.MakeReport);
            this.tabPage2.Controls.Add(this.work_update);
            this.tabPage2.Controls.Add(this.work_delete);
            this.tabPage2.Controls.Add(this.work_insert);
            this.tabPage2.Controls.Add(this.worker_update);
            this.tabPage2.Controls.Add(this.worker_delete);
            this.tabPage2.Controls.Add(this.worker_insert);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.Instruction_update);
            this.tabPage2.Controls.Add(this.Instruction_delete_row);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.Instruction_Add_Row);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(964, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редактирование и удаление";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Номер наряда";
            // 
            // naryadNomer
            // 
            this.naryadNomer.Location = new System.Drawing.Point(119, 357);
            this.naryadNomer.Name = "naryadNomer";
            this.naryadNomer.Size = new System.Drawing.Size(100, 20);
            this.naryadNomer.TabIndex = 26;
            // 
            // workman
            // 
            this.workman.Location = new System.Drawing.Point(417, 349);
            this.workman.Name = "workman";
            this.workman.Size = new System.Drawing.Size(133, 20);
            this.workman.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Производитель работ";
            // 
            // head
            // 
            this.head.Location = new System.Drawing.Point(417, 327);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(133, 20);
            this.head.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Отвественный руководитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Дата";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(119, 331);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(100, 20);
            this.Date.TabIndex = 20;
            // 
            // MakeReport
            // 
            this.MakeReport.Location = new System.Drawing.Point(823, 446);
            this.MakeReport.Name = "MakeReport";
            this.MakeReport.Size = new System.Drawing.Size(134, 23);
            this.MakeReport.TabIndex = 15;
            this.MakeReport.Text = "Сформировать отчет";
            this.MakeReport.UseVisualStyleBackColor = true;
            this.MakeReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // work_update
            // 
            this.work_update.Location = new System.Drawing.Point(884, 282);
            this.work_update.Name = "work_update";
            this.work_update.Size = new System.Drawing.Size(75, 23);
            this.work_update.TabIndex = 13;
            this.work_update.Text = "Обновить";
            this.work_update.UseVisualStyleBackColor = true;
            this.work_update.Click += new System.EventHandler(this.work_update_Click);
            // 
            // work_delete
            // 
            this.work_delete.Location = new System.Drawing.Point(434, 282);
            this.work_delete.Name = "work_delete";
            this.work_delete.Size = new System.Drawing.Size(75, 23);
            this.work_delete.TabIndex = 12;
            this.work_delete.Text = "Удалить";
            this.work_delete.UseVisualStyleBackColor = true;
            this.work_delete.Click += new System.EventHandler(this.work_delete_Click);
            // 
            // work_insert
            // 
            this.work_insert.Location = new System.Drawing.Point(722, 282);
            this.work_insert.Name = "work_insert";
            this.work_insert.Size = new System.Drawing.Size(75, 23);
            this.work_insert.TabIndex = 11;
            this.work_insert.Text = "Добавить";
            this.work_insert.UseVisualStyleBackColor = true;
            this.work_insert.Click += new System.EventHandler(this.work_insert_Click);
            // 
            // worker_update
            // 
            this.worker_update.Location = new System.Drawing.Point(515, 282);
            this.worker_update.Name = "worker_update";
            this.worker_update.Size = new System.Drawing.Size(75, 23);
            this.worker_update.TabIndex = 10;
            this.worker_update.Text = "Обновить";
            this.worker_update.UseVisualStyleBackColor = true;
            this.worker_update.Click += new System.EventHandler(this.worker_update_Click);
            // 
            // worker_delete
            // 
            this.worker_delete.Location = new System.Drawing.Point(803, 282);
            this.worker_delete.Name = "worker_delete";
            this.worker_delete.Size = new System.Drawing.Size(75, 23);
            this.worker_delete.TabIndex = 9;
            this.worker_delete.Text = "Удалить";
            this.worker_delete.UseVisualStyleBackColor = true;
            this.worker_delete.Click += new System.EventHandler(this.worker_delete_Click);
            // 
            // worker_insert
            // 
            this.worker_insert.Location = new System.Drawing.Point(353, 282);
            this.worker_insert.Name = "worker_insert";
            this.worker_insert.Size = new System.Drawing.Size(75, 23);
            this.worker_insert.TabIndex = 8;
            this.worker_insert.Text = "Добавить";
            this.worker_insert.UseVisualStyleBackColor = true;
            this.worker_insert.Click += new System.EventHandler(this.worker_insert_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(275, 22);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(410, 254);
            this.dataGridView3.TabIndex = 7;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(711, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(249, 254);
            this.dataGridView2.TabIndex = 6;
            // 
            // Instruction_update
            // 
            this.Instruction_update.Location = new System.Drawing.Point(171, 282);
            this.Instruction_update.Name = "Instruction_update";
            this.Instruction_update.Size = new System.Drawing.Size(75, 23);
            this.Instruction_update.TabIndex = 5;
            this.Instruction_update.Text = "Обновить";
            this.Instruction_update.UseVisualStyleBackColor = true;
            this.Instruction_update.Click += new System.EventHandler(this.Instruction_update_Click);
            // 
            // Instruction_delete_row
            // 
            this.Instruction_delete_row.Location = new System.Drawing.Point(90, 282);
            this.Instruction_delete_row.Name = "Instruction_delete_row";
            this.Instruction_delete_row.Size = new System.Drawing.Size(75, 23);
            this.Instruction_delete_row.TabIndex = 4;
            this.Instruction_delete_row.Text = "Удалить";
            this.Instruction_delete_row.UseVisualStyleBackColor = true;
            this.Instruction_delete_row.Click += new System.EventHandler(this.Instruction_delete_row_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 254);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Instruction_Add_Row
            // 
            this.Instruction_Add_Row.Location = new System.Drawing.Point(9, 282);
            this.Instruction_Add_Row.Name = "Instruction_Add_Row";
            this.Instruction_Add_Row.Size = new System.Drawing.Size(75, 23);
            this.Instruction_Add_Row.TabIndex = 1;
            this.Instruction_Add_Row.Text = "Добавить";
            this.Instruction_Add_Row.UseVisualStyleBackColor = true;
            this.Instruction_Add_Row.Click += new System.EventHandler(this.Show_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(972, 503);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 503);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Формирование документа";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button MakeReport;
        private System.Windows.Forms.Button work_update;
        private System.Windows.Forms.Button work_delete;
        public System.Windows.Forms.Button work_insert;
        private System.Windows.Forms.Button worker_update;
        private System.Windows.Forms.Button worker_delete;
        public System.Windows.Forms.Button worker_insert;
        public System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Instruction_update;
        private System.Windows.Forms.Button Instruction_delete_row;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Button Instruction_Add_Row;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox head;
        public System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox workman;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox naryadNomer;
    }
}

