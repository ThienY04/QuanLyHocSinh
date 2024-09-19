using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTrenLop
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(int iD, string name, int age)
        {
            this.ID = iD;
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Age: {Age}";
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Student> students = new List<Student>
            {
                new Student(1, "Nguyen Van A", 16),
                new Student(2, "Tran Thi B", 17),
                new Student(3, "Le Van C", 18),
                new Student(4, "Pham Thi D", 20),
                new Student(5, "Anh Pham Tran", 15)
            };
                // a.
                Console.WriteLine("Danh sach toan bo hoc sinh:");
                foreach (var student in students)
                {
                    Console.WriteLine(student);
                }
                // b.
                var timtuoi = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
                Console.WriteLine("\nDanh sach hoc sinh co tuoi tu 15 den 18:");
                if (!timtuoi.Any())
                {
                    Console.WriteLine("Khong co hoc sinh nao o do tuoi nay!");
                }
                else
                {
                    foreach (var student in timtuoi)
                    {
                        Console.WriteLine(student);
                    }
                }
                // c.
                var timten = students.Where(s => s.Name.StartsWith("A")).ToList();
                Console.WriteLine("\nDanh sach hoc sinh co ten bat dau bang chu 'A':");
                foreach (var student in timten)
                {
                    Console.WriteLine(student);
                }

                // d.
                int Tongtuoi = students.Sum(s => s.Age);
                Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {Tongtuoi}");

                // e. 
                var HSNT = students.OrderByDescending(s => s.Age).FirstOrDefault();
                Console.WriteLine("\nHoc sinh co tuoi lon nhat:");
                if (HSNT != null)
                {
                    Console.WriteLine(HSNT);
                }

                // f.
                var SXDS = students.OrderBy(s => s.Age).ToList();
                Console.WriteLine("\nDanh sach hoc sinh sap xep theo tuoi tang dan:");
                foreach (var student in SXDS)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}
