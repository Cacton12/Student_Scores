using BuissnessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Final_Project
{
    public enum FormMode
    {
        Add,Update
    }
    public partial class FrmUpdateStudentScores : Form
    {
        private Student updateStudent;
        int Score;

        public FrmUpdateStudentScores(Student updateStudent)
        {
            InitializeComponent();
            this.updateStudent = updateStudent;
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            FrmAddScore addScore = new FrmAddScore(FormMode.Add);
            addScore.ShowDialog();
            if (addScore.Tag != null)
            {
                updateStudent.Scores.Add((int)addScore.Tag);
                LslScoresOutput.Items.Add(addScore.Tag);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Tag = updateStudent;
            this.Close();
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (LslScoresOutput.SelectedItem != null)
            {
                FrmAddScore updateScore = new FrmAddScore(FormMode.Update);
                updateScore.ShowDialog();
                if (updateScore.Tag != null)
                {
                    int selectedIndex = LslScoresOutput.SelectedIndex;
                    updateStudent.Scores[selectedIndex] = (int)updateScore.Tag;
                    LslScoresOutput.Items[selectedIndex] = (int)updateScore.Tag;
                }
            }
            else
            {
                MessageBox.Show("Please select a score");
            }
        }

        private void FrmUpdateStudentScores_Load(object sender, EventArgs e)
        {
            LblNameOutput.Text = $"{updateStudent.First_Name} {updateStudent.Last_Name}";
            if (updateStudent != null)
            {
                foreach (int score in updateStudent.Scores)
                {
                    LslScoresOutput.Items.Add(score);
                }
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (LslScoresOutput.SelectedIndex != -1)
            {
                int selectedIndex = LslScoresOutput.SelectedIndex;
                LslScoresOutput.Items.RemoveAt(selectedIndex);
                updateStudent.Scores.RemoveAt(selectedIndex);
            }
        }

        private void BtnClearScores_Click(object sender, EventArgs e)
        {
            LslScoresOutput.Items.Clear();
            updateStudent.Scores.Clear();
        }
    }
}
