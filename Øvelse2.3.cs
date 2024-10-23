using System;

namespace ØvelseTime2._2
{
	public class Øvelse2
	{


	}
	public class Student
	{
		public string name; public int id;

		public Student(string nameValue, int idValue)
		{
			name = nameValue;
			id = idValue;
		}
		public string GetName()
		{
			return name;
		}
	}
	public class Course
	{
		string name;
		Student[] participants;
		int id;

		public Course(string nameValue)
		{
			name = nameValue; participants = new Student[10];// NOTE: This constant is BAD!}
		}

		public void Enroll(Student student)
		{
			for (int i = 0; i < participants.Length; i++) { if (participants[i] == null) { participants[i] = student; return; } }
		}
		public void Remove(Student student)
		{
			for (int i = 0; i < participants.Length; i++)
			{
				if (participants[i] == student)
				{
					participants[i] = null;
				}
			}
		}

		public Student[] GetParticipants()
		{// count number of entries
			int count = 0;
			foreach (Student student in participants)
			{
				if (student != null)
				{
					count++;
				}
			}
			Student[] result = new Student[count]; 
			int index = 0; 
			foreach (Student student in participants) 
			{ 
				if (student != null) 
				{ 
					result[index++] = student; 
				}
			}
			return result;
		}
	}
	public class EnrollmentSystem 
	{ 
		public Student[] students; 
		public Course[] courses; 
		public void Enroll(Student student, Course course) 
		{ 
			course.Enroll(student); 
		} 
		public void Remove(Student student, Course course) 
		{ 
			course.Remove(student); 
		} 
		public void ShowParticipants(Course course) 
		{ 
			foreach (Student student in course.GetParticipants()) 
			{ 
				Console.WriteLine(student.GetName()); 
			} 
		} 
		public void addStudent(string Studntname)
		{
			Student student = new Student(Studntname,students.Length); 
		}
		public void RemoveStudent(int StudentId)
		{
			var newstudentsArray = new Student[students.Length-1];
			var studentLegngth = students.Length;
			if (studentLegngth!=0)
			{
				for (int i = 0; i < studentLegngth; i++)
				{
					if (students[i].id==StudentId)
					{
						newstudentsArray[i]=students[i];
					}
				}
			}
		}
		public void GetCourses() 
		{ 
			Console.WriteLine("void for a getter?"); 
		} 
		public void GetStudents() 
		{ 
			Console.WriteLine("void for a getter?"); 
		} 
	}
}