namespace TestGI
{
    partial class FormTest
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.textBoxUserAnswer = new System.Windows.Forms.TextBox();
            this.buttonNextQuestion = new System.Windows.Forms.Button();
            this.buttonNewStart = new System.Windows.Forms.Button();
            this.labelNumberOfQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.Location = new System.Drawing.Point(232, 139);
            this.labelQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(109, 39);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "label1";
            // 
            // textBoxUserAnswer
            // 
            this.textBoxUserAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserAnswer.Location = new System.Drawing.Point(236, 206);
            this.textBoxUserAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUserAnswer.Name = "textBoxUserAnswer";
            this.textBoxUserAnswer.Size = new System.Drawing.Size(419, 46);
            this.textBoxUserAnswer.TabIndex = 1;
            // 
            // buttonNextQuestion
            // 
            this.buttonNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextQuestion.Location = new System.Drawing.Point(236, 273);
            this.buttonNextQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNextQuestion.Name = "buttonNextQuestion";
            this.buttonNextQuestion.Size = new System.Drawing.Size(420, 58);
            this.buttonNextQuestion.TabIndex = 2;
            this.buttonNextQuestion.Text = "Следующий вопрос";
            this.buttonNextQuestion.UseVisualStyleBackColor = true;
            this.buttonNextQuestion.Click += new System.EventHandler(this.buttonNextQuestion_Click);
            // 
            // buttonNewStart
            // 
            this.buttonNewStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNewStart.Location = new System.Drawing.Point(236, 361);
            this.buttonNewStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNewStart.Name = "buttonNewStart";
            this.buttonNewStart.Size = new System.Drawing.Size(420, 59);
            this.buttonNewStart.TabIndex = 3;
            this.buttonNewStart.Text = "Начать сначала";
            this.buttonNewStart.UseVisualStyleBackColor = true;
            this.buttonNewStart.Visible = false;
            this.buttonNewStart.Click += new System.EventHandler(this.buttonNewStart_Click);
            // 
            // labelNumberOfQuestion
            // 
            this.labelNumberOfQuestion.AutoSize = true;
            this.labelNumberOfQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberOfQuestion.Location = new System.Drawing.Point(232, 79);
            this.labelNumberOfQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumberOfQuestion.Name = "labelNumberOfQuestion";
            this.labelNumberOfQuestion.Size = new System.Drawing.Size(109, 39);
            this.labelNumberOfQuestion.TabIndex = 4;
            this.labelNumberOfQuestion.Text = "label1";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelNumberOfQuestion);
            this.Controls.Add(this.buttonNewStart);
            this.Controls.Add(this.buttonNextQuestion);
            this.Controls.Add(this.textBoxUserAnswer);
            this.Controls.Add(this.labelQuestion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormTest";
            this.Text = "Тест ГЕНИЙ - ИДИОТ";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.TextBox textBoxUserAnswer;
        private System.Windows.Forms.Button buttonNextQuestion;
        private System.Windows.Forms.Button buttonNewStart;
        private System.Windows.Forms.Label labelNumberOfQuestion;
    }
}

