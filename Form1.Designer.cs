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
            InputText = new TextBox();
            ResultButton = new Button();
            TaskText = new Label();
            SuspendLayout();
            // 
            // InputText
            // 
            InputText.Location = new Point(32, 83);
            InputText.Name = "InputText";
            InputText.Size = new Size(280, 27);
            InputText.TabIndex = 0;
            // 
            // ResultButton
            // 
            ResultButton.Location = new Point(356, 78);
            ResultButton.Name = "ResultButton";
            ResultButton.Size = new Size(67, 37);
            ResultButton.TabIndex = 1;
            ResultButton.Text = "Result";
            ResultButton.UseVisualStyleBackColor = true;
            ResultButton.Click += ResultButton_Click;
            // 
            // TaskText
            // 
            TaskText.AutoSize = true;
            TaskText.Location = new Point(29, 35);
            TaskText.Name = "TaskText";
            TaskText.Size = new Size(394, 20);
            TaskText.TabIndex = 2;
            TaskText.Text = "Введите текст для подсчета одинаковых соседних букв ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 186);
            Controls.Add(TaskText);
            Controls.Add(ResultButton);
            Controls.Add(InputText);
            Name = "Form1";
            Text = "Task 4.2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputText;
        private Button ResultButton;
        private Label TaskText;
    }
}
