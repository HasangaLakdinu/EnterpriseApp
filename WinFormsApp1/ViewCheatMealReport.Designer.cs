namespace WinFormsApp1
{
    partial class ViewCheatMealReport
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
            cheatMealReport = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            CheatMealName = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)cheatMealReport).BeginInit();
            SuspendLayout();
            // 
            // cheatMealReport
            // 
            cheatMealReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cheatMealReport.Columns.AddRange(new DataGridViewColumn[] { UserName, Date, CheatMealName, Weight });
            cheatMealReport.Location = new Point(101, 87);
            cheatMealReport.Name = "cheatMealReport";
            cheatMealReport.RowHeadersWidth = 51;
            cheatMealReport.RowTemplate.Height = 29;
            cheatMealReport.Size = new Size(553, 249);
            cheatMealReport.TabIndex = 0;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "UserName";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.Width = 125;
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // CheatMealName
            // 
            CheatMealName.DataPropertyName = "CheatMealName";
            CheatMealName.HeaderText = "CheatMealName";
            CheatMealName.MinimumWidth = 6;
            CheatMealName.Name = "CheatMealName";
            CheatMealName.Width = 125;
            // 
            // Weight
            // 
            Weight.DataPropertyName = "Weight";
            Weight.HeaderText = "Weight";
            Weight.MinimumWidth = 6;
            Weight.Name = "Weight";
            Weight.Width = 125;
            // 
            // ViewCheatMealReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cheatMealReport);
            Name = "ViewCheatMealReport";
            Text = "View Cheat Meal Report";
            Load += ViewCheatMealReport_Load;
            ((System.ComponentModel.ISupportInitialize)cheatMealReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView cheatMealReport;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn CheatMealName;
        private DataGridViewTextBoxColumn Weight;
    }
}