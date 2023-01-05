using System;
using Domain.Models;

namespace Domain
{
	public class StudentList
	{
        private Student[] array;

        public StudentList()
        {
            array = new Student[0];
        }

        public void Add(Student student)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = student;
        }

        public void GetAll()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}