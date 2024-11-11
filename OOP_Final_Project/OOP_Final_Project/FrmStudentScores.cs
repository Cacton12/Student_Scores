using BuissnessLayer;

namespace OOP_Final_Project
{
    public partial class FormStudentScores : Form, ICloneable
    {
        StudentList studentList = new StudentList();
        Student? updateStudent;
        Student? OrigonalStudent;
        public FormStudentScores()
        {
            InitializeComponent();
            LstStudents.SelectedIndexChanged += LstStudents_SelectedIndexChanged;
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BtnAddNew_Click(object sender, EventArgs e)
        {   
            LstStudents.Items.Clear();
            FrmAddStudent addstudent = new FrmAddStudent();
            DialogResult result = addstudent.ShowDialog();
            Student? studentTag = addstudent.Tag as Student;
            if (studentTag != null)
            {
                studentList.add(studentTag);
                foreach (Student student in studentList)
                {
                    LstStudents.Items.Add(student);
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (LstStudents.SelectedItem != null)
            {
                OrigonalStudent = LstStudents.SelectedItem as Student;
                updateStudent = OrigonalStudent.Clone() as Student;
            }
            FrmUpdateStudentScores updateStudentScores = new FrmUpdateStudentScores(updateStudent);
            updateStudentScores.ShowDialog();
            updateStudent = updateStudentScores.Tag as Student;
            if(updateStudent != null)
            {
                studentList.remove(OrigonalStudent);
                LstStudents.Items.Remove(OrigonalStudent);
                studentList.add(updateStudent);
                LstStudents.Items.Add(updateStudent);
            }
        }

        private void FormStudentScores_Load(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (LstStudents.SelectedItem != null) //deletes a student from lstStudents
            {
                Student studentRemove = (Student)LstStudents.SelectedItem;
                studentList.remove(studentRemove);
                LstStudents.Items.Remove(studentRemove);
                LblScoreCountOutput.Text = "";
                LblAverageOuput.Text = "";
                LblScoreTotalOutput.Text = "";
            }
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }
        private void LstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstStudents.SelectedItem != null)
            {

                Student? selectedStudent = LstStudents.SelectedItem as Student;
                if (selectedStudent != null)
                {
                    if(selectedStudent.Scores.Count() > 0)
                    {
                        LblScoreCountOutput.Text = selectedStudent.Scores.Count().ToString();
                        LblAverageOuput.Text = selectedStudent.scoresAverage().ToString();
                        LblScoreTotalOutput.Text = selectedStudent.scoresTotal().ToString();
                    }
                    else
                    {
                        LblScoreCountOutput.Text = "";
                        LblAverageOuput.Text = "";
                        LblScoreTotalOutput.Text = "";
                    }
                }
            }
        }
    }
}
