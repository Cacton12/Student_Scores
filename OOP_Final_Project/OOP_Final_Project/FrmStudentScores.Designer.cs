namespace OOP_Final_Project
{
    partial class FormStudentScores
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
            LstStudents = new ListBox();
            BtnAddNew = new Button();
            LblStudent = new Label();
            BtnUpdate = new Button();
            BtnDelete = new Button();
            BtnExit = new Button();
            LblScoreTotalText = new Label();
            LblScoreCountText = new Label();
            LblAverageText = new Label();
            LblAverageOuput = new Label();
            LblScoreCountOutput = new Label();
            LblScoreTotalOutput = new Label();
            SuspendLayout();
            // 
            // LstStudents
            // 
            LstStudents.FormattingEnabled = true;
            LstStudents.ItemHeight = 15;
            LstStudents.Location = new Point(12, 22);
            LstStudents.Name = "LstStudents";
            LstStudents.Size = new Size(264, 109);
            LstStudents.TabIndex = 0;
            // 
            // BtnAddNew
            // 
            BtnAddNew.Location = new Point(334, 39);
            BtnAddNew.Name = "BtnAddNew";
            BtnAddNew.Size = new Size(75, 23);
            BtnAddNew.TabIndex = 1;
            BtnAddNew.Text = "&Add New";
            BtnAddNew.UseVisualStyleBackColor = true;
            BtnAddNew.Click += BtnAddNew_Click;
            // 
            // LblStudent
            // 
            LblStudent.AutoSize = true;
            LblStudent.Location = new Point(12, 4);
            LblStudent.Name = "LblStudent";
            LblStudent.Size = new Size(53, 15);
            LblStudent.TabIndex = 2;
            LblStudent.Text = "Students";
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(334, 68);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(75, 23);
            BtnUpdate.TabIndex = 3;
            BtnUpdate.Text = "&Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Location = new Point(334, 97);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(75, 23);
            BtnDelete.TabIndex = 4;
            BtnDelete.Text = "&Delete";
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnExit
            // 
            BtnExit.Location = new Point(383, 206);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(75, 23);
            BtnExit.TabIndex = 5;
            BtnExit.Text = "&Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // LblScoreTotalText
            // 
            LblScoreTotalText.AutoSize = true;
            LblScoreTotalText.Location = new Point(215, 154);
            LblScoreTotalText.Name = "LblScoreTotalText";
            LblScoreTotalText.Size = new Size(67, 15);
            LblScoreTotalText.TabIndex = 6;
            LblScoreTotalText.Text = "Score Total:";
            // 
            // LblScoreCountText
            // 
            LblScoreCountText.AutoSize = true;
            LblScoreCountText.Location = new Point(207, 180);
            LblScoreCountText.Name = "LblScoreCountText";
            LblScoreCountText.Size = new Size(75, 15);
            LblScoreCountText.TabIndex = 8;
            LblScoreCountText.Text = "Score Count:";
            // 
            // LblAverageText
            // 
            LblAverageText.AutoSize = true;
            LblAverageText.Location = new Point(229, 206);
            LblAverageText.Name = "LblAverageText";
            LblAverageText.Size = new Size(53, 15);
            LblAverageText.TabIndex = 10;
            LblAverageText.Text = "Average:";
            // 
            // LblAverageOuput
            // 
            LblAverageOuput.BorderStyle = BorderStyle.Fixed3D;
            LblAverageOuput.Location = new Point(288, 205);
            LblAverageOuput.Name = "LblAverageOuput";
            LblAverageOuput.Size = new Size(57, 24);
            LblAverageOuput.TabIndex = 11;
            // 
            // LblScoreCountOutput
            // 
            LblScoreCountOutput.BorderStyle = BorderStyle.Fixed3D;
            LblScoreCountOutput.Location = new Point(288, 179);
            LblScoreCountOutput.Name = "LblScoreCountOutput";
            LblScoreCountOutput.Size = new Size(57, 24);
            LblScoreCountOutput.TabIndex = 12;
            // 
            // LblScoreTotalOutput
            // 
            LblScoreTotalOutput.BorderStyle = BorderStyle.Fixed3D;
            LblScoreTotalOutput.Location = new Point(288, 153);
            LblScoreTotalOutput.Name = "LblScoreTotalOutput";
            LblScoreTotalOutput.Size = new Size(57, 24);
            LblScoreTotalOutput.TabIndex = 13;
            // 
            // FormStudentScores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 241);
            Controls.Add(LblScoreTotalOutput);
            Controls.Add(LblScoreCountOutput);
            Controls.Add(LblAverageOuput);
            Controls.Add(LblAverageText);
            Controls.Add(LblScoreCountText);
            Controls.Add(LblScoreTotalText);
            Controls.Add(BtnExit);
            Controls.Add(BtnDelete);
            Controls.Add(BtnUpdate);
            Controls.Add(LblStudent);
            Controls.Add(BtnAddNew);
            Controls.Add(LstStudents);
            Name = "FormStudentScores";
            Text = "Student Scores";
            Load += FormStudentScores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox LstStudents;
        private Button BtnAddNew;
        private Label LblStudent;
        private Button BtnUpdate;
        private Button BtnDelete;
        private Button BtnExit;
        private Label LblScoreTotalText;
        private Label LblScoreCountText;
        private Label LblAverageText;
        private Label LblAverageOuput;
        private Label LblScoreCountOutput;
        private Label LblScoreTotalOutput;
    }
}
