namespace WinFormsApp1
{
    partial class CheatMeal
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
            label1 = new Label();
            label2 = new Label();
            mealWeight = new TextBox();
            button1 = new Button();
            cheatMealDateTime = new DateTimePicker();
            label3 = new Label();
            cheatMealName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 112);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Cheat Meal Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 158);
            label2.Name = "label2";
            label2.Size = new Size(171, 20);
            label2.TabIndex = 0;
            label2.Text = "Quantity Weight (grams)";
            label2.Click += label2_Click;
            // 
            // mealWeight
            // 
            mealWeight.Location = new Point(263, 155);
            mealWeight.Name = "mealWeight";
            mealWeight.Size = new Size(125, 27);
            mealWeight.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(279, 213);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cheatMealDateTime
            // 
            cheatMealDateTime.Location = new Point(263, 55);
            cheatMealDateTime.Name = "cheatMealDateTime";
            cheatMealDateTime.Size = new Size(250, 27);
            cheatMealDateTime.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 62);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 0;
            label3.Text = "Date";
            // 
            // cheatMealName
            // 
            cheatMealName.Location = new Point(263, 105);
            cheatMealName.Name = "cheatMealName";
            cheatMealName.Size = new Size(125, 27);
            cheatMealName.TabIndex = 1;
            // 
            // CheatMeal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 285);
            Controls.Add(cheatMealDateTime);
            Controls.Add(button1);
            Controls.Add(mealWeight);
            Controls.Add(label2);
            Controls.Add(cheatMealName);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CheatMeal";
            Text = "Enter Cheat Meal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox mealWeight;
        private Button button1;
        private DateTimePicker cheatMealDateTime;
        private Label label3;
        private TextBox cheatMealName;
    }
}