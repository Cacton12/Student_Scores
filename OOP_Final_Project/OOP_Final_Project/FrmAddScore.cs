using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using static System.Net.Mime.MediaTypeNames;

namespace OOP_Final_Project
{
    public partial class FrmAddScore : Form
    {
        private Student? selectedStudent;
        private FormMode mode;
        private Validator validator = new Validator();
        public FrmAddScore(FormMode mode, Student selectedStudent = null)
        {
            InitializeComponent();
            this.mode = mode;
            this.selectedStudent = selectedStudent;

            if (mode == FormMode.Add)
            {
                this.Text = "Add Student";
                BtnAdd.Text = "Add";
            }
            else if (mode == FormMode.Update)
            {
                if (selectedStudent != null)
                {
                    this.Text = "Update Student";
                    TxtScore.Text = selectedStudent.ToString();
                    BtnAdd.Text = "Update";
                }
            }
        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {

            int score;
            if (int.TryParse(TxtScore.Text, out score))
            {
                if (validator.NewScoresValid(score))
                {
                    this.Tag = score;
                    this.Close();
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

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddScore_Load(object sender, EventArgs e)
        {

        }
    }
}
