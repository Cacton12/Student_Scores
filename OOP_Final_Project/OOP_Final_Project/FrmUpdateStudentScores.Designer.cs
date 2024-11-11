namespace OOP_Final_Project
{
    partial class FrmUpdateStudentScores
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
            LblName = new Label();
            LblScores = new Label();
            LslScoresOutput = new ListBox();
            BtnAdd = new Button();
            BtnUpdate = new Button();
            BtnRemove = new Button();
            BtnClearScores = new Button();
            BtnCancel = new Button();
            BtnOk = new Button();
            LblNameOutput = new Label();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(12, 25);
            LblName.Name = "LblName";
            LblName.Size = new Size(42, 15);
            LblName.TabIndex = 11;
            LblName.Text = "Name:";
            // 
            // LblScores
            // 
            LblScores.AutoSize = true;
            LblScores.Location = new Point(10, 55);
            LblScores.Name = "LblScores";
            LblScores.Size = new Size(44, 15);
            LblScores.TabIndex = 12;
            LblScores.Text = "Scores:";
            // 
            // LslScoresOutput
            // 
            LslScoresOutput.FormattingEnabled = true;
            LslScoresOutput.ItemHeight = 15;
            LslScoresOutput.Location = new Point(60, 55);
            LslScoresOutput.Name = "LslScoresOutput";
            LslScoresOutput.Size = new Size(150, 124);
            LslScoresOutput.TabIndex = 13;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(217, 71);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(83, 23);
            BtnAdd.TabIndex = 14;
            BtnAdd.Text = "&Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAddNew_Click;
            // 
            // BtnUpdate
            // 
            BtnUpdate.Location = new Point(217, 100);
            BtnUpdate.Name = "BtnUpdate";
            BtnUpdate.Size = new Size(83, 23);
            BtnUpdate.TabIndex = 15;
            BtnUpdate.Text = "&Update";
            BtnUpdate.UseVisualStyleBackColor = true;
            BtnUpdate.Click += BtnUpdate_Click;
            // 
            // BtnRemove
            // 
            BtnRemove.Location = new Point(217, 129);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(83, 23);
            BtnRemove.TabIndex = 16;
            BtnRemove.Text = "&Remove";
            BtnRemove.UseVisualStyleBackColor = true;
            BtnRemove.Click += BtnRemove_Click;
            // 
            // BtnClearScores
            // 
            BtnClearScores.Location = new Point(217, 158);
            BtnClearScores.Name = "BtnClearScores";
            BtnClearScores.Size = new Size(83, 23);
            BtnClearScores.TabIndex = 17;
            BtnClearScores.Text = "Clear &Scores";
            BtnClearScores.UseVisualStyleBackColor = true;
            BtnClearScores.Click += BtnClearScores_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(225, 193);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 18;
            BtnCancel.Text = "&Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(144, 193);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(75, 23);
            BtnOk.TabIndex = 19;
            BtnOk.Text = "&Ok";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // LblNameOutput
            // 
            LblNameOutput.BorderStyle = BorderStyle.Fixed3D;
            LblNameOutput.Location = new Point(60, 24);
            LblNameOutput.Name = "LblNameOutput";
            LblNameOutput.Size = new Size(240, 25);
            LblNameOutput.TabIndex = 10;
            // 
            // FrmUpdateStudentScores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 228);
            Controls.Add(BtnOk);
            Controls.Add(BtnCancel);
            Controls.Add(BtnClearScores);
            Controls.Add(BtnRemove);
            Controls.Add(BtnUpdate);
            Controls.Add(BtnAdd);
            Controls.Add(LslScoresOutput);
            Controls.Add(LblScores);
            Controls.Add(LblName);
            Controls.Add(LblNameOutput);
            Name = "FrmUpdateStudentScores";
            Text = "Update Student Scores";
            Load += FrmUpdateStudentScores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblName;
        private Label LblScores;
        private ListBox LslScoresOutput;
        private Button BtnAdd;
        private Button BtnUpdate;
        private Button BtnRemove;
        private Button BtnClearScores;
        private Button BtnCancel;
        private Button BtnOk;
        private Label LblNameOutput;
    }
}