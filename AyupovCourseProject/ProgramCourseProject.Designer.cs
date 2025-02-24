namespace AyupovCourseProject
{
    partial class ProgramCourseProject
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
            this.buttonChangeData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDeleteDocument = new System.Windows.Forms.Button();
            this.buttonCreateDocument = new System.Windows.Forms.Button();
            this.buttonSaveBD = new System.Windows.Forms.Button();
            this.buttonLoadBD = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSort = new System.Windows.Forms.Button();
            this.buttonFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChangeData
            // 
            this.buttonChangeData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangeData.Location = new System.Drawing.Point(655, 74);
            this.buttonChangeData.Name = "buttonChangeData";
            this.buttonChangeData.Size = new System.Drawing.Size(206, 57);
            this.buttonChangeData.TabIndex = 1;
            this.buttonChangeData.Text = "Изменить данные документа";
            this.buttonChangeData.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 411);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonDeleteDocument
            // 
            this.buttonDeleteDocument.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteDocument.Location = new System.Drawing.Point(655, 137);
            this.buttonDeleteDocument.Name = "buttonDeleteDocument";
            this.buttonDeleteDocument.Size = new System.Drawing.Size(206, 57);
            this.buttonDeleteDocument.TabIndex = 3;
            this.buttonDeleteDocument.Text = "Удалить документ";
            this.buttonDeleteDocument.UseVisualStyleBackColor = true;
            // 
            // buttonCreateDocument
            // 
            this.buttonCreateDocument.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateDocument.Location = new System.Drawing.Point(655, 200);
            this.buttonCreateDocument.Name = "buttonCreateDocument";
            this.buttonCreateDocument.Size = new System.Drawing.Size(206, 57);
            this.buttonCreateDocument.TabIndex = 4;
            this.buttonCreateDocument.Text = "Добавить документ";
            this.buttonCreateDocument.UseVisualStyleBackColor = true;
            // 
            // buttonSaveBD
            // 
            this.buttonSaveBD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveBD.Location = new System.Drawing.Point(13, 492);
            this.buttonSaveBD.Name = "buttonSaveBD";
            this.buttonSaveBD.Size = new System.Drawing.Size(206, 57);
            this.buttonSaveBD.TabIndex = 5;
            this.buttonSaveBD.Text = "Сохранить БД";
            this.buttonSaveBD.UseVisualStyleBackColor = true;
            // 
            // buttonLoadBD
            // 
            this.buttonLoadBD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadBD.Location = new System.Drawing.Point(225, 492);
            this.buttonLoadBD.Name = "buttonLoadBD";
            this.buttonLoadBD.Size = new System.Drawing.Size(206, 57);
            this.buttonLoadBD.TabIndex = 6;
            this.buttonLoadBD.Text = "Загрузить БД";
            this.buttonLoadBD.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(655, 492);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(206, 57);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSort
            // 
            this.buttonSort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSort.Location = new System.Drawing.Point(13, 12);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(206, 57);
            this.buttonSort.TabIndex = 8;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            // 
            // buttonFilter
            // 
            this.buttonFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFilter.Location = new System.Drawing.Point(225, 12);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(206, 57);
            this.buttonFilter.TabIndex = 9;
            this.buttonFilter.Text = "Фильтр";
            this.buttonFilter.UseVisualStyleBackColor = true;
            // 
            // ProgramCourseProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLoadBD);
            this.Controls.Add(this.buttonSaveBD);
            this.Controls.Add(this.buttonCreateDocument);
            this.Controls.Add(this.buttonDeleteDocument);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonChangeData);
            this.Name = "ProgramCourseProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainProgram";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChangeData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDeleteDocument;
        private System.Windows.Forms.Button buttonCreateDocument;
        private System.Windows.Forms.Button buttonSaveBD;
        private System.Windows.Forms.Button buttonLoadBD;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.Button buttonFilter;
    }
}

