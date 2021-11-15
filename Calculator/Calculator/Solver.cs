using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Solver : ISolver
    {
        char[] oper = { '*', '/', '%', '-', '+', '.' };
        string operations = "";
        public void Accumulate(string s)
        {

        }
        public void Clear()
        {

        }
        public double Solve(string s)
        {
            double result = 0;
            for (int i = 0; i < operations.Length; i++)
            {

            }

            return Convert.ToDouble(result);
        }
    }

    delegate void GreetingMethod(string s);

    class Program
    {
        static void FirstGreeting(string s)
        {
            Console.WriteLine(s);
        }
        static void SecondGreeting(string s)
        {
            Console.WriteLine("I say again {0}!", s);
        }
        static void Main(String[] args)
        {
            GreetingMethod del = new GreetingMethod(FirstGreeting);
            del += new GreetingMethod(SecondGreeting);

            del("Hello");

            //del("Hello");

            //GreetingMethod del2 = new GreetingMethod(SecondGreeting);
            //del2("Guten tag");

            //FlexGreeting(del, "Hola");
            //FlexGreeting(del2, "Bonjour");
        }

        static void FlexGreeting(GreetingMethod gd, string s)
        {
            gd(s);
        }
    }

    public delegate void ChangedEventHandler(object sender, EventArgs e);

    public class Student
    {
        int idNum;
        double gpa;
        public event ChangedEventHandler Changed;

        public int IdNum
        {
            get { return idNum; }
            set
            {
                idNum = value;
                Changed(this, EventArgs.Empty);
            }
        }
        public double Gpa
        {
            get { return gpa; }
            set
            {
                gpa = value;
                Changed(this, EventArgs.Empty);
            }
        }
    }

    public class EventListner
    {
        Student stu;
        public EventListner(Student student)
        {
            stu = student;
            stu.Changed += new ChangedEventHandler(StudentChanged);
        }
        void StudentChanged (object sender, EventArgs e)
        {
            Console.WriteLine("The student data has changed!");
            Console.WriteLine("ID#{0} GPA:{1}", stu.IdNum, stu.gpa);
        }
    }
}