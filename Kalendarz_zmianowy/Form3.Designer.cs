namespace Kalendarz_zmianowy
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Praca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_day_of_month = new System.Windows.Forms.Label();
            this.lb_shift_work_days_in_month = new System.Windows.Forms.Label();
            this.lb_shift_work_on_1_shift = new System.Windows.Forms.Label();
            this.lb_shift_work_on_2_shift = new System.Windows.Forms.Label();
            this.lb_shift_work_on_3_shift = new System.Windows.Forms.Label();
            this.lb_h_shift_work_in_month_3_shift = new System.Windows.Forms.Label();
            this.lb_h_shift_work_in_month_2_shift = new System.Windows.Forms.Label();
            this.lb_h_shift_work_in_month_1_shift = new System.Windows.Forms.Label();
            this.lb_h_shift_work_in_month = new System.Windows.Forms.Label();
            this.lb_day_of_month_value = new System.Windows.Forms.Label();
            this.lb_shift_work_days_in_month_value = new System.Windows.Forms.Label();
            this.lb_shift_work_on_1_shift_value = new System.Windows.Forms.Label();
            this.lb_shift_work_on_2_shift_value = new System.Windows.Forms.Label();
            this.lb_shift_work_on_3_shift_value = new System.Windows.Forms.Label();
            this.lb_h_shift_work_in_month_value = new System.Windows.Forms.Label();
            this.lb_h_shift_work_in_month_1_shift_value = new System.Windows.Forms.Label();
            this.lb_h_shift_work_in_month_2_shift_value = new System.Windows.Forms.Label();
            this.lb_h_shift_work_in_month_3_shift_value = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.RemotingFormat = System.Data.SerializationFormat.Binary;
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1});
            this.dataTable1.RemotingFormat = System.Data.SerializationFormat.Binary;
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Data";
            this.dataColumn1.DataType = typeof(System.DateTime);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_date,
            this.Praca});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(178, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // col_date
            // 
            this.col_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_date.FillWeight = 80F;
            this.col_date.HeaderText = "Data";
            this.col_date.Name = "col_date";
            this.col_date.ReadOnly = true;
            this.col_date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_date.Width = 80;
            // 
            // Praca
            // 
            this.Praca.HeaderText = "Zmiana";
            this.Praca.Name = "Praca";
            this.Praca.ToolTipText = "Godziny pracy zmiany";
            this.Praca.Width = 80;
            // 
            // lb_day_of_month
            // 
            this.lb_day_of_month.AutoSize = true;
            this.lb_day_of_month.Location = new System.Drawing.Point(200, 9);
            this.lb_day_of_month.Name = "lb_day_of_month";
            this.lb_day_of_month.Size = new System.Drawing.Size(110, 13);
            this.lb_day_of_month.TabIndex = 1;
            this.lb_day_of_month.Text = "Liczba dni w miesiącu";
            // 
            // lb_shift_work_days_in_month
            // 
            this.lb_shift_work_days_in_month.AutoSize = true;
            this.lb_shift_work_days_in_month.Location = new System.Drawing.Point(200, 34);
            this.lb_shift_work_days_in_month.Name = "lb_shift_work_days_in_month";
            this.lb_shift_work_days_in_month.Size = new System.Drawing.Size(162, 13);
            this.lb_shift_work_days_in_month.TabIndex = 2;
            this.lb_shift_work_days_in_month.Text = "Liczba dni roboczych w miesiącu";
            // 
            // lb_shift_work_on_1_shift
            // 
            this.lb_shift_work_on_1_shift.AutoSize = true;
            this.lb_shift_work_on_1_shift.Location = new System.Drawing.Point(200, 60);
            this.lb_shift_work_on_1_shift.Name = "lb_shift_work_on_1_shift";
            this.lb_shift_work_on_1_shift.Size = new System.Drawing.Size(247, 13);
            this.lb_shift_work_on_1_shift.TabIndex = 3;
            this.lb_shift_work_on_1_shift.Text = "Liczba dni roboczych w miesiącu na zmianie rannej";
            // 
            // lb_shift_work_on_2_shift
            // 
            this.lb_shift_work_on_2_shift.AutoSize = true;
            this.lb_shift_work_on_2_shift.Location = new System.Drawing.Point(200, 83);
            this.lb_shift_work_on_2_shift.Name = "lb_shift_work_on_2_shift";
            this.lb_shift_work_on_2_shift.Size = new System.Drawing.Size(288, 13);
            this.lb_shift_work_on_2_shift.TabIndex = 4;
            this.lb_shift_work_on_2_shift.Text = "Liczba dni roboczych w miesiącu na zmianie popołudniowej";
            // 
            // lb_shift_work_on_3_shift
            // 
            this.lb_shift_work_on_3_shift.AutoSize = true;
            this.lb_shift_work_on_3_shift.Location = new System.Drawing.Point(200, 106);
            this.lb_shift_work_on_3_shift.Name = "lb_shift_work_on_3_shift";
            this.lb_shift_work_on_3_shift.Size = new System.Drawing.Size(250, 13);
            this.lb_shift_work_on_3_shift.TabIndex = 5;
            this.lb_shift_work_on_3_shift.Text = "Liczba dni roboczych w miesiącu na zmianie nocnej";
            // 
            // lb_h_shift_work_in_month_3_shift
            // 
            this.lb_h_shift_work_in_month_3_shift.AutoSize = true;
            this.lb_h_shift_work_in_month_3_shift.Location = new System.Drawing.Point(200, 220);
            this.lb_h_shift_work_in_month_3_shift.Name = "lb_h_shift_work_in_month_3_shift";
            this.lb_h_shift_work_in_month_3_shift.Size = new System.Drawing.Size(267, 13);
            this.lb_h_shift_work_in_month_3_shift.TabIndex = 9;
            this.lb_h_shift_work_in_month_3_shift.Text = "Liczba godzin roboczych w miesiącu na zmianie nocnej";
            // 
            // lb_h_shift_work_in_month_2_shift
            // 
            this.lb_h_shift_work_in_month_2_shift.AutoSize = true;
            this.lb_h_shift_work_in_month_2_shift.Location = new System.Drawing.Point(200, 197);
            this.lb_h_shift_work_in_month_2_shift.Name = "lb_h_shift_work_in_month_2_shift";
            this.lb_h_shift_work_in_month_2_shift.Size = new System.Drawing.Size(305, 13);
            this.lb_h_shift_work_in_month_2_shift.TabIndex = 8;
            this.lb_h_shift_work_in_month_2_shift.Text = "Liczba godzin roboczych w miesiącu na zmianie popołudniowej";
            // 
            // lb_h_shift_work_in_month_1_shift
            // 
            this.lb_h_shift_work_in_month_1_shift.AutoSize = true;
            this.lb_h_shift_work_in_month_1_shift.Location = new System.Drawing.Point(200, 174);
            this.lb_h_shift_work_in_month_1_shift.Name = "lb_h_shift_work_in_month_1_shift";
            this.lb_h_shift_work_in_month_1_shift.Size = new System.Drawing.Size(264, 13);
            this.lb_h_shift_work_in_month_1_shift.TabIndex = 7;
            this.lb_h_shift_work_in_month_1_shift.Text = "Liczba godzin roboczych w miesiącu na zmianie rannej";
            // 
            // lb_h_shift_work_in_month
            // 
            this.lb_h_shift_work_in_month.AutoSize = true;
            this.lb_h_shift_work_in_month.Location = new System.Drawing.Point(200, 148);
            this.lb_h_shift_work_in_month.Name = "lb_h_shift_work_in_month";
            this.lb_h_shift_work_in_month.Size = new System.Drawing.Size(179, 13);
            this.lb_h_shift_work_in_month.TabIndex = 6;
            this.lb_h_shift_work_in_month.Text = "Liczba godzin roboczych w miesiącu";
            // 
            // lb_day_of_month_value
            // 
            this.lb_day_of_month_value.AutoSize = true;
            this.lb_day_of_month_value.Location = new System.Drawing.Point(545, 9);
            this.lb_day_of_month_value.Name = "lb_day_of_month_value";
            this.lb_day_of_month_value.Size = new System.Drawing.Size(13, 13);
            this.lb_day_of_month_value.TabIndex = 10;
            this.lb_day_of_month_value.Text = "0";
            // 
            // lb_shift_work_days_in_month_value
            // 
            this.lb_shift_work_days_in_month_value.AutoSize = true;
            this.lb_shift_work_days_in_month_value.Location = new System.Drawing.Point(545, 34);
            this.lb_shift_work_days_in_month_value.Name = "lb_shift_work_days_in_month_value";
            this.lb_shift_work_days_in_month_value.Size = new System.Drawing.Size(13, 13);
            this.lb_shift_work_days_in_month_value.TabIndex = 11;
            this.lb_shift_work_days_in_month_value.Text = "0";
            // 
            // lb_shift_work_on_1_shift_value
            // 
            this.lb_shift_work_on_1_shift_value.AutoSize = true;
            this.lb_shift_work_on_1_shift_value.Location = new System.Drawing.Point(545, 60);
            this.lb_shift_work_on_1_shift_value.Name = "lb_shift_work_on_1_shift_value";
            this.lb_shift_work_on_1_shift_value.Size = new System.Drawing.Size(13, 13);
            this.lb_shift_work_on_1_shift_value.TabIndex = 12;
            this.lb_shift_work_on_1_shift_value.Text = "0";
            // 
            // lb_shift_work_on_2_shift_value
            // 
            this.lb_shift_work_on_2_shift_value.AutoSize = true;
            this.lb_shift_work_on_2_shift_value.Location = new System.Drawing.Point(545, 83);
            this.lb_shift_work_on_2_shift_value.Name = "lb_shift_work_on_2_shift_value";
            this.lb_shift_work_on_2_shift_value.Size = new System.Drawing.Size(13, 13);
            this.lb_shift_work_on_2_shift_value.TabIndex = 13;
            this.lb_shift_work_on_2_shift_value.Text = "0";
            // 
            // lb_shift_work_on_3_shift_value
            // 
            this.lb_shift_work_on_3_shift_value.AutoSize = true;
            this.lb_shift_work_on_3_shift_value.Location = new System.Drawing.Point(545, 106);
            this.lb_shift_work_on_3_shift_value.Name = "lb_shift_work_on_3_shift_value";
            this.lb_shift_work_on_3_shift_value.Size = new System.Drawing.Size(13, 13);
            this.lb_shift_work_on_3_shift_value.TabIndex = 14;
            this.lb_shift_work_on_3_shift_value.Text = "0";
            // 
            // lb_h_shift_work_in_month_value
            // 
            this.lb_h_shift_work_in_month_value.AutoSize = true;
            this.lb_h_shift_work_in_month_value.Location = new System.Drawing.Point(545, 148);
            this.lb_h_shift_work_in_month_value.Name = "lb_h_shift_work_in_month_value";
            this.lb_h_shift_work_in_month_value.Size = new System.Drawing.Size(13, 13);
            this.lb_h_shift_work_in_month_value.TabIndex = 15;
            this.lb_h_shift_work_in_month_value.Text = "0";
            // 
            // lb_h_shift_work_in_month_1_shift_value
            // 
            this.lb_h_shift_work_in_month_1_shift_value.AutoSize = true;
            this.lb_h_shift_work_in_month_1_shift_value.Location = new System.Drawing.Point(545, 174);
            this.lb_h_shift_work_in_month_1_shift_value.Name = "lb_h_shift_work_in_month_1_shift_value";
            this.lb_h_shift_work_in_month_1_shift_value.Size = new System.Drawing.Size(13, 13);
            this.lb_h_shift_work_in_month_1_shift_value.TabIndex = 16;
            this.lb_h_shift_work_in_month_1_shift_value.Text = "0";
            // 
            // lb_h_shift_work_in_month_2_shift_value
            // 
            this.lb_h_shift_work_in_month_2_shift_value.AutoSize = true;
            this.lb_h_shift_work_in_month_2_shift_value.Location = new System.Drawing.Point(545, 197);
            this.lb_h_shift_work_in_month_2_shift_value.Name = "lb_h_shift_work_in_month_2_shift_value";
            this.lb_h_shift_work_in_month_2_shift_value.Size = new System.Drawing.Size(13, 13);
            this.lb_h_shift_work_in_month_2_shift_value.TabIndex = 17;
            this.lb_h_shift_work_in_month_2_shift_value.Text = "0";
            // 
            // lb_h_shift_work_in_month_3_shift_value
            // 
            this.lb_h_shift_work_in_month_3_shift_value.AutoSize = true;
            this.lb_h_shift_work_in_month_3_shift_value.Location = new System.Drawing.Point(545, 220);
            this.lb_h_shift_work_in_month_3_shift_value.Name = "lb_h_shift_work_in_month_3_shift_value";
            this.lb_h_shift_work_in_month_3_shift_value.Size = new System.Drawing.Size(13, 13);
            this.lb_h_shift_work_in_month_3_shift_value.TabIndex = 18;
            this.lb_h_shift_work_in_month_3_shift_value.Text = "0";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 259);
            this.Controls.Add(this.lb_h_shift_work_in_month_3_shift_value);
            this.Controls.Add(this.lb_h_shift_work_in_month_2_shift_value);
            this.Controls.Add(this.lb_h_shift_work_in_month_1_shift_value);
            this.Controls.Add(this.lb_h_shift_work_in_month_value);
            this.Controls.Add(this.lb_shift_work_on_3_shift_value);
            this.Controls.Add(this.lb_shift_work_on_2_shift_value);
            this.Controls.Add(this.lb_shift_work_on_1_shift_value);
            this.Controls.Add(this.lb_shift_work_days_in_month_value);
            this.Controls.Add(this.lb_day_of_month_value);
            this.Controls.Add(this.lb_h_shift_work_in_month_3_shift);
            this.Controls.Add(this.lb_h_shift_work_in_month_2_shift);
            this.Controls.Add(this.lb_h_shift_work_in_month_1_shift);
            this.Controls.Add(this.lb_h_shift_work_in_month);
            this.Controls.Add(this.lb_shift_work_on_3_shift);
            this.Controls.Add(this.lb_shift_work_on_2_shift);
            this.Controls.Add(this.lb_shift_work_on_1_shift);
            this.Controls.Add(this.lb_shift_work_days_in_month);
            this.Controls.Add(this.lb_day_of_month);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Praca zmiany";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.Label lb_day_of_month;
        private System.Windows.Forms.Label lb_shift_work_days_in_month;
        private System.Windows.Forms.Label lb_shift_work_on_1_shift;
        private System.Windows.Forms.Label lb_shift_work_on_2_shift;
        private System.Windows.Forms.Label lb_shift_work_on_3_shift;
        private System.Windows.Forms.Label lb_h_shift_work_in_month_3_shift;
        private System.Windows.Forms.Label lb_h_shift_work_in_month_2_shift;
        private System.Windows.Forms.Label lb_h_shift_work_in_month_1_shift;
        private System.Windows.Forms.Label lb_h_shift_work_in_month;
        private System.Windows.Forms.Label lb_day_of_month_value;
        private System.Windows.Forms.Label lb_shift_work_days_in_month_value;
        private System.Windows.Forms.Label lb_shift_work_on_1_shift_value;
        private System.Windows.Forms.Label lb_shift_work_on_2_shift_value;
        private System.Windows.Forms.Label lb_shift_work_on_3_shift_value;
        private System.Windows.Forms.Label lb_h_shift_work_in_month_value;
        private System.Windows.Forms.Label lb_h_shift_work_in_month_1_shift_value;
        private System.Windows.Forms.Label lb_h_shift_work_in_month_2_shift_value;
        private System.Windows.Forms.Label lb_h_shift_work_in_month_3_shift_value;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Praca;
    }
}