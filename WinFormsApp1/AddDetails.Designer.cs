namespace WinFormsApp1
{
    partial class AddDetails
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
            dateTimePicker1 = new DateTimePicker();
            Date = new Label();
            label1 = new Label();
            label2 = new Label();
            workOutHours = new TextBox();
            weight = new Label();
            weightBox = new TextBox();
            submitBtn = new Button();
            label3 = new Label();
            burntCalories = new TextBox();
            workoutType = new ComboBox();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(310, 107);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Location = new Point(136, 114);
            Date.Name = "Date";
            Date.Size = new Size(41, 20);
            Date.TabIndex = 1;
            Date.Text = "Date";
            Date.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 153);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 2;
            label1.Text = "Workout Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 199);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 2;
            label2.Text = "Workout Hours";
            label2.Click += label2_Click;
            // 
            // workOutHours
            // 
            workOutHours.Location = new Point(310, 199);
            workOutHours.Name = "workOutHours";
            workOutHours.Size = new Size(125, 27);
            workOutHours.TabIndex = 3;
            workOutHours.TextChanged += textBox2_TextChanged;
            // 
            // weight
            // 
            weight.AutoSize = true;
            weight.Location = new Point(136, 246);
            weight.Name = "weight";
            weight.Size = new Size(56, 20);
            weight.TabIndex = 2;
            weight.Text = "Weight";
            weight.Click += label2_Click;
            // 
            // weightBox
            // 
            weightBox.Location = new Point(310, 246);
            weightBox.Name = "weightBox";
            weightBox.Size = new Size(125, 27);
            weightBox.TabIndex = 3;
            weightBox.TextChanged += textBox2_TextChanged;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(310, 332);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(94, 29);
            submitBtn.TabIndex = 4;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 286);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 2;
            label3.Text = "Burnt Calories";
            label3.Click += label2_Click;
            // 
            // burntCalories
            // 
            burntCalories.Location = new Point(310, 286);
            burntCalories.Name = "burntCalories";
            burntCalories.Size = new Size(125, 27);
            burntCalories.TabIndex = 3;
            burntCalories.TextChanged += textBox2_TextChanged;
            // 
            // workoutType
            // 
            workoutType.FormattingEnabled = true;
            workoutType.Items.AddRange(new object[] { "Cycling", "Swimming", "Jogging", "Workout In Gym" });
            workoutType.Location = new Point(310, 153);
            workoutType.Name = "workoutType";
            workoutType.Size = new Size(151, 28);
            workoutType.TabIndex = 5;
            // 
            // AddDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(workoutType);
            Controls.Add(submitBtn);
            Controls.Add(burntCalories);
            Controls.Add(label3);
            Controls.Add(weightBox);
            Controls.Add(weight);
            Controls.Add(workOutHours);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Date);
            Controls.Add(dateTimePicker1);
            Name = "AddDetails";
            Text = "AddDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label Date;
        private Label label1;
        private Label label2;
        private TextBox workOutHours;
        private Label weight;
        private TextBox weightBox;
        private Button submitBtn;
        private Label label3;
        private TextBox burntCalories;
        private ComboBox workoutType;
    }
}