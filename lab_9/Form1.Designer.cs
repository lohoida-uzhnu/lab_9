namespace lab_9
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
            dtpBirthDate = new DateTimePicker();
            ageResult = new Label();
            resultButton = new Button();
            label1 = new Label();
            label2 = new Label();
            downloadFileDate = new Button();
            SuspendLayout();
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(145, 27);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(200, 23);
            dtpBirthDate.TabIndex = 7;
            // 
            // ageResult
            // 
            ageResult.AutoSize = true;
            ageResult.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ageResult.Location = new Point(169, 225);
            ageResult.Name = "ageResult";
            ageResult.Size = new Size(0, 17);
            ageResult.TabIndex = 8;
            // 
            // resultButton
            // 
            resultButton.Location = new Point(170, 55);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(150, 55);
            resultButton.TabIndex = 9;
            resultButton.Text = "Натисни щоб побачити результат!";
            resultButton.UseVisualStyleBackColor = true;
            resultButton.Click += resultButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 15);
            label1.TabIndex = 10;
            label1.Text = "Оберіть свою дату народження:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(62, 225);
            label2.Name = "label2";
            label2.Size = new Size(101, 17);
            label2.TabIndex = 11;
            label2.Text = "Ваш результат:";
            // 
            // downloadFileDate
            // 
            downloadFileDate.Location = new Point(170, 116);
            downloadFileDate.Name = "downloadFileDate";
            downloadFileDate.Size = new Size(150, 55);
            downloadFileDate.TabIndex = 12;
            downloadFileDate.Text = "Завантажити дату з файлу date.txt";
            downloadFileDate.UseVisualStyleBackColor = true;
            downloadFileDate.Click += downloadFileDate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 341);
            Controls.Add(downloadFileDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resultButton);
            Controls.Add(ageResult);
            Controls.Add(dtpBirthDate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpBirthDate;
        private Label ageResult;
        private Button resultButton;
        private Label label1;
        private Label label2;
        private Button downloadFileDate;
    }
}
