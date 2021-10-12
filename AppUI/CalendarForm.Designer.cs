namespace AppUI
{
    public partial class CalendarForm
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
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.labelCalendar = new System.Windows.Forms.Label();
            this.listBoxBirthday = new System.Windows.Forms.ListBox();
            this.listBoxEvent = new System.Windows.Forms.ListBox();
            this.labelEvent = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.checkedListBoxTask = new System.Windows.Forms.CheckedListBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.textBoxAddTask = new System.Windows.Forms.TextBox();
            this.labelAddTask = new System.Windows.Forms.Label();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(348, 215);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // labelCalendar
            // 
            this.labelCalendar.AutoSize = true;
            this.labelCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCalendar.Location = new System.Drawing.Point(395, 28);
            this.labelCalendar.Name = "labelCalendar";
            this.labelCalendar.Size = new System.Drawing.Size(208, 37);
            this.labelCalendar.TabIndex = 1;
            this.labelCalendar.Text = "My Calendar";
            // 
            // listBoxBirthday
            // 
            this.listBoxBirthday.FormattingEnabled = true;
            this.listBoxBirthday.ItemHeight = 20;
            this.listBoxBirthday.Location = new System.Drawing.Point(727, 114);
            this.listBoxBirthday.Name = "listBoxBirthday";
            this.listBoxBirthday.Size = new System.Drawing.Size(210, 104);
            this.listBoxBirthday.TabIndex = 2;
            // 
            // listBoxEvent
            // 
            this.listBoxEvent.FormattingEnabled = true;
            this.listBoxEvent.ItemHeight = 20;
            this.listBoxEvent.Location = new System.Drawing.Point(727, 409);
            this.listBoxEvent.Name = "listBoxEvent";
            this.listBoxEvent.Size = new System.Drawing.Size(210, 104);
            this.listBoxEvent.TabIndex = 3;
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.Location = new System.Drawing.Point(727, 383);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(58, 20);
            this.labelEvent.TabIndex = 4;
            this.labelEvent.Text = "Events";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Location = new System.Drawing.Point(727, 91);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(75, 20);
            this.labelBirthday.TabIndex = 5;
            this.labelBirthday.Text = "Birthdays";
            // 
            // checkedListBoxTask
            // 
            this.checkedListBoxTask.FormattingEnabled = true;
            this.checkedListBoxTask.Location = new System.Drawing.Point(12, 259);
            this.checkedListBoxTask.Name = "checkedListBoxTask";
            this.checkedListBoxTask.Size = new System.Drawing.Size(143, 257);
            this.checkedListBoxTask.TabIndex = 6;
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(12, 236);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(51, 20);
            this.labelTask.TabIndex = 7;
            this.labelTask.Text = "Tasks";
            // 
            // textBoxAddTask
            // 
            this.textBoxAddTask.Location = new System.Drawing.Point(12, 134);
            this.textBoxAddTask.Name = "textBoxAddTask";
            this.textBoxAddTask.Size = new System.Drawing.Size(273, 26);
            this.textBoxAddTask.TabIndex = 8;
            // 
            // labelAddTask
            // 
            this.labelAddTask.AutoSize = true;
            this.labelAddTask.Location = new System.Drawing.Point(12, 111);
            this.labelAddTask.Name = "labelAddTask";
            this.labelAddTask.Size = new System.Drawing.Size(78, 20);
            this.labelAddTask.TabIndex = 9;
            this.labelAddTask.Text = "New Task";
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.BackColor = System.Drawing.Color.Black;
            this.buttonAddTask.ForeColor = System.Drawing.Color.White;
            this.buttonAddTask.Location = new System.Drawing.Point(12, 166);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(98, 31);
            this.buttonAddTask.TabIndex = 10;
            this.buttonAddTask.Text = "Add";
            this.buttonAddTask.UseVisualStyleBackColor = false;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::A21_Ex01_Tal_313489288_Neta_313245177.Properties.Resources.Calendar1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(972, 541);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.labelAddTask);
            this.Controls.Add(this.textBoxAddTask);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.checkedListBoxTask);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelEvent);
            this.Controls.Add(this.listBoxEvent);
            this.Controls.Add(this.listBoxBirthday);
            this.Controls.Add(this.labelCalendar);
            this.Controls.Add(this.monthCalendar);
            this.DoubleBuffered = true;
            this.Name = "CalendarForm";
            this.Text = "Calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label labelCalendar;
        private System.Windows.Forms.ListBox listBoxBirthday;
        private System.Windows.Forms.ListBox listBoxEvent;
        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.CheckedListBox checkedListBoxTask;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.TextBox textBoxAddTask;
        private System.Windows.Forms.Label labelAddTask;
        private System.Windows.Forms.Button buttonAddTask;
    }
}