
namespace OOP_Final_Project
{
    partial class FrmAddScore
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
            TxtScore = new TextBox();
            BtnAdd = new Button();
            BtnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 29);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Score:";
            // 
            // TxtScore
            // 
            TxtScore.Location = new Point(59, 26);
            TxtScore.Name = "TxtScore";
            TxtScore.Size = new Size(128, 23);
            TxtScore.TabIndex = 1;
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(23, 67);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(83, 23);
            BtnAdd.TabIndex = 15;
            BtnAdd.Text = "&Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click_1;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(112, 67);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 23);
            BtnCancel.TabIndex = 19;
            BtnCancel.Text = "&Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // FrmAddScore
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(212, 102);
            Controls.Add(BtnCancel);
            Controls.Add(BtnAdd);
            Controls.Add(TxtScore);
            Controls.Add(label1);
            Name = "FrmAddScore";
            Text = "Add Score";
            Load += FrmAddScore_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtScore;
        private Button BtnAdd;
        private Button BtnCancel;
    }
}