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
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP_Final_Project
{
    public partial class FrmAddStudent : Form
    {

        public FrmAddStudent()
        {
            InitializeComponent();
        }
        List<int> Scores = new List<int>();
        private Validator validator = new Validator();
        private void BtnAddScore_Click(object sender, EventArgs e)
        {
            int score;
            if (int.TryParse(TxtScore.Text, out score))
            {
                if (validator.NewScoresValid(score))
                {
                    Scores.Add(score);
                    LblScoresOutput.Text = string.Empty;
                    LblScoresOutput.Text = string.Join(", ", Scores); 

                }
                else
                {
                    MessageBox.Show("Please Enter a Whole Number From 0 - 100 ");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Whole Number From 0 - 100 ");
            }
        }

        private void FrmAddStudent_Load(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string fullName = TxtName.Text;
            string[] nameParts = fullName.Split(new[] { ' ' }, 2);

            if (nameParts.Length < 2 || !validator.NameValid(fullName))
            {
                MessageBox.Show("Please enter both first name and last name.");
                return;
            }
            string firstName = nameParts[0];
            string lastName = nameParts[1];
            Student student = new Student(firstName, lastName, Scores);
            this.Tag = student;
            DialogResult = DialogResult.OK;
        }

        private void BtnClearScores_Click(object sender, EventArgs e)
        {
            Scores.Clear();
            LblScoresOutput.Text = string.Empty;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
