using OOP_Final_Project;
using System;

namespace BuissnessLayer
{
    public delegate void StudentListChange(object sender, EventArgs e);
    public class StudentList
    {
        private List<Student> studentsList = new List<Student>();
        public Student this[int index] //This is my indexer
        {
            get
            {
                return this[index];
            }
            set
            {
                this[index] = value;
            }
        }
        //Needed this to invoke the event 
        public event StudentListChange? StudentListChanged;

        public void add(Student student)
        {
            studentsList.Add(student);
            StudentListChanged?.Invoke(this, EventArgs.Empty);
        }
        public void remove(Student student)
        {
            studentsList.Remove(student);
            StudentListChanged?.Invoke(this, EventArgs.Empty);
        }

        //I was getting errors trying to add to lstStudents so i needed this to loop through my student list 
        public IEnumerator<Student> GetEnumerator()
        {
            return studentsList.GetEnumerator();
        }

    }
}
