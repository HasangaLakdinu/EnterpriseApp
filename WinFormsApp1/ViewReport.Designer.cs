namespace WinFormsApp1
{
    partial class ViewReport
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
            workoutReport = new DataGridView();
            WeekNumber = new DataGridViewTextBoxColumn();
            TotalWorkoutHours = new DataGridViewTextBoxColumn();
            AverageWeight = new DataGridViewTextBoxColumn();
            TotalBurntCalories = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)workoutReport).BeginInit();
            SuspendLayout();
            // 
            // workoutReport
            // 
            workoutReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            workoutReport.Columns.AddRange(new DataGridViewColumn[] { WeekNumber, TotalWorkoutHours, AverageWeight, TotalBurntCalories });
            workoutReport.Location = new Point(105, 65);
            workoutReport.Name = "workoutReport";
            workoutReport.RowHeadersWidth = 51;
            workoutReport.RowTemplate.Height = 29;
            workoutReport.Size = new Size(553, 347);
            workoutReport.TabIndex = 0;
            // 
            // WeekNumber
            // 
            WeekNumber.DataPropertyName = "WeekNumber";
            WeekNumber.HeaderText = "Week Number";
            WeekNumber.MinimumWidth = 6;
            WeekNumber.Name = "WeekNumber";
            WeekNumber.Width = 125;
            // 
            // TotalWorkoutHours
            // 
            TotalWorkoutHours.DataPropertyName = "TotalWorkoutHours";
            TotalWorkoutHours.HeaderText = "Total Workout Hours";
            TotalWorkoutHours.MinimumWidth = 6;
            TotalWorkoutHours.Name = "TotalWorkoutHours";
            TotalWorkoutHours.Width = 125;
            // 
            // AverageWeight
            // 
            AverageWeight.DataPropertyName = "AverageWeight";
            AverageWeight.HeaderText = "Average Weight";
            AverageWeight.MinimumWidth = 6;
            AverageWeight.Name = "AverageWeight";
            AverageWeight.Width = 125;
            // 
            // TotalBurntCalories
            // 
            TotalBurntCalories.DataPropertyName = "TotalBurntCalories";
            TotalBurntCalories.HeaderText = "Total Burnt Calories";
            TotalBurntCalories.MinimumWidth = 6;
            TotalBurntCalories.Name = "TotalBurntCalories";
            TotalBurntCalories.Width = 125;
            // 
            // ViewReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 450);
            Controls.Add(workoutReport);
            Name = "ViewReport";
            Text = "ViewReport";
            Load += ViewReport_Load;
            ((System.ComponentModel.ISupportInitialize)workoutReport).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView workoutReport;
        private DataGridViewTextBoxColumn WeekNumber;
        private DataGridViewTextBoxColumn TotalWorkoutHours;
        private DataGridViewTextBoxColumn AverageWeight;
        private DataGridViewTextBoxColumn TotalBurntCalories;
    }
}