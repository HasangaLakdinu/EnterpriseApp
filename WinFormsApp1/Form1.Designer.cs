namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            enterWorkoutDetailsBtn = new Button();
            cheatMealBtn = new Button();
            workoutReportBtn = new Button();
            cheatMealReportBtn = new Button();
            predictBtn = new Button();
            SuspendLayout();
            // 
            // enterWorkoutDetailsBtn
            // 
            enterWorkoutDetailsBtn.Location = new Point(292, 100);
            enterWorkoutDetailsBtn.Name = "enterWorkoutDetailsBtn";
            enterWorkoutDetailsBtn.Size = new Size(173, 29);
            enterWorkoutDetailsBtn.TabIndex = 0;
            enterWorkoutDetailsBtn.Text = "Enter Workout Details";
            enterWorkoutDetailsBtn.UseVisualStyleBackColor = true;
            enterWorkoutDetailsBtn.Click += enterDetailsBtn_Click;
            // 
            // cheatMealBtn
            // 
            cheatMealBtn.Location = new Point(292, 150);
            cheatMealBtn.Name = "cheatMealBtn";
            cheatMealBtn.Size = new Size(173, 29);
            cheatMealBtn.TabIndex = 2;
            cheatMealBtn.Text = "Enter Cheat Meal";
            cheatMealBtn.UseVisualStyleBackColor = true;
            cheatMealBtn.Click += cheatMealBtn_Click;
            // 
            // workoutReportBtn
            // 
            workoutReportBtn.Location = new Point(270, 220);
            workoutReportBtn.Name = "workoutReportBtn";
            workoutReportBtn.Size = new Size(216, 30);
            workoutReportBtn.TabIndex = 3;
            workoutReportBtn.Text = "View report for workout";
            workoutReportBtn.UseVisualStyleBackColor = true;
            workoutReportBtn.Click += workoutReportBtn_Click;
            // 
            // cheatMealReportBtn
            // 
            cheatMealReportBtn.Location = new Point(270, 284);
            cheatMealReportBtn.Name = "cheatMealReportBtn";
            cheatMealReportBtn.Size = new Size(221, 29);
            cheatMealReportBtn.TabIndex = 4;
            cheatMealReportBtn.Text = "View Report For Cheat Meal ";
            cheatMealReportBtn.UseVisualStyleBackColor = true;
            cheatMealReportBtn.Click += cheatMealReportBtn_Click;
            // 
            // predictBtn
            // 
            predictBtn.Location = new Point(250, 340);
            predictBtn.Name = "predictBtn";
            predictBtn.Size = new Size(256, 29);
            predictBtn.TabIndex = 5;
            predictBtn.Text = "Predict the health status and weight";
            predictBtn.UseVisualStyleBackColor = true;
            predictBtn.Click += predictBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 534);
            Controls.Add(predictBtn);
            Controls.Add(cheatMealReportBtn);
            Controls.Add(workoutReportBtn);
            Controls.Add(cheatMealBtn);
            Controls.Add(enterWorkoutDetailsBtn);
            Name = "Form1";
            Text = "Your Details";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button enterWorkoutDetailsBtn;
        private Button cheatMealBtn;
        private Button workoutReportBtn;
        private Button cheatMealReportBtn;
        private Button predictBtn;
    }
}