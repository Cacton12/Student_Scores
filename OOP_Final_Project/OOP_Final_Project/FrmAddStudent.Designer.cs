namespace OOP_Final_Project
{
    partial class FrmAddStudent
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
            BtnCancel = new Button();
            BtnClearScores = new Button();
            BtnOk = new Button();
            LblName = new Label();
            LblScore = new Label();
            LblScores = new Label();
            TxtName = new TextBox();
            LblScoresOutput = new Label();
            TxtScore = new TextBox();
            BtnAddScore = new Button();
            SuspendLayout();
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(200, 210);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(101, 23);
            BtnCancel.TabIndex = 2;
            BtnCancel.Text = "&Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnClearScores
            // 
            BtnClearScores.Location = new Point(200, 181);
            BtnClearScores.Name = "BtnClearScores";
            BtnClearScores.Size = new Size(101, 23);
            BtnClearScores.TabIndex = 3;
            BtnClearScores.Text = "Clear &Scores";
            BtnClearScores.UseVisualStyleBackColor = true;
            BtnClearScores.Click += BtnClearScores_Click;
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(93, 210);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(101, 23);
            BtnOk.TabIndex = 4;
            BtnOk.Text = "&Ok";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(25, 31);
            LblName.Name = "LblName";
            LblName.Size = new Size(42, 15);
            LblName.TabIndex = 5;
            LblName.Text = "Name:";
            // 
            // LblScore
            // 
            LblScore.AutoSize = true;
            LblScore.Location = new Point(28, 62);
            LblScore.Name = "LblScore";
            LblScore.Size = new Size(39, 15);
            LblScore.TabIndex = 6;
            LblScore.Text = "Score:";
            // 
            // LblScores
            // 
            LblScores.AutoSize = true;
            LblScores.Location = new Point(26, 94);
            LblScores.Name = "LblScores";
            LblScores.Size = new Size(44, 15);
            LblScores.TabIndex = 7;
            LblScores.Text = "Scores:";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(70, 28);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(222, 23);
            TxtName.TabIndex = 8;
            // 
            // LblScoresOutput
            // 
            LblScoresOutput.BorderStyle = BorderStyle.Fixed3D;
            LblScoresOutput.Location = new Point(70, 94);
            LblScoresOutput.Name = "LblScoresOutput";
            LblScoresOutput.Size = new Size(222, 25);
            LblScoresOutput.TabIndex = 9;
            // 
            // TxtScore
            // 
            TxtScore.Location = new Point(70, 59);
            TxtScore.Name = "TxtScore";
            TxtScore.Size = new Size(111, 23);
            TxtScore.TabIndex = 10;
            // 
            // BtnAddScore
            // 
            BtnAddScore.Location = new Point(191, 59);
            BtnAddScore.Name = "BtnAddScore";
            BtnAddScore.Size = new Size(101, 23);
            BtnAddScore.TabIndex = 11;
            BtnAddScore.Text = "&Add Score";
            BtnAddScore.UseVisualStyleBackColor = true;
            BtnAddScore.Click += BtnAddScore_Click;
            // 
            // FrmAddStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 245);
            Controls.Add(BtnAddScore);
            Controls.Add(TxtScore);
            Controls.Add(LblScoresOutput);
            Controls.Add(TxtName);
            Controls.Add(LblScores);
            Controls.Add(LblScore);
            Controls.Add(LblName);
            Controls.Add(BtnOk);
            Controls.Add(BtnClearScores);
            Controls.Add(BtnCancel);
            Name = "FrmAddStudent";
            Text = "Add New Student";
            Load += FrmAddStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCancel;
        private Button BtnClearScores;
        private Button BtnOk;
        private Label LblName;
        private Label LblScore;
        private Label LblScores;
        private TextBox TxtName;
        private Label LblScoresOutput;
        private TextBox TxtScore;
        private Button BtnAddScore;
    }
}