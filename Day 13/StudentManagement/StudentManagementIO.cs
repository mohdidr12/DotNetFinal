using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    //class StudentManagementIO
    //{
    //    StudentService studentService = new StudentService();
    //    public byte Menu()
    //    {
    //        Console.WriteLine("1->add student");
    //        Console.WriteLine("2->display");
    //        Console.WriteLine("3->update student");
    //        Console.WriteLine("4->delete student");
    //        Console.WriteLine("0->exit");
    //        Console.WriteLine("enter option");
    //        byte option = Convert.ToByte(Console.ReadLine());
    //        return option;
    //    }
    //    public void AddStudent()
    //    {
    //        Console.Write("Enter name: ");
    //        string name = Console.ReadLine();
    //        Console.Write("Enter age: ");
    //        byte age = Convert.ToByte(Console.ReadLine());
    //        Console.Write("Enter standard: ");
    //        byte standard = Convert.ToByte(Console.ReadLine());
    //        Console.Write("Enter address: ");
    //        string address = Console.ReadLine();
    //        Student student = studentService.AddStudent(name, age, standard, address);
    //        Display(student);
    //        Console.WriteLine("----------------------------");
    //    }
    //    private void Display(Student student)
    //    { }
    //    private void DeleteStudent()
    //    {
    //        Console.Write("Enter id:");
    //        string id = Console.ReadLine();
    //        if(studentService.DeleteStudent(id))
    //        {
    //            Console.WriteLine("student deleted successfully");
    //        }
    //        else
    //        {
    //            Console.WriteLine("student not found");
    //        }
    //    }
    //    public void UpdateStudent()
    //    {
    //        Console.WriteLine("1->update age");
    //        Console.WriteLine("1->update address");
    //        Console.WriteLine("enter option");
    //        switch(Convert.ToByte(Console.ReadLine()))
    //        {
    //            case 1:
    //                {
    //                    Console.Write("enter id: ");
    //                    string id = Console.ReadLine();
    //                    Console.Write("enter new age:");
    //                    byte age = Convert.ToByte(Console.ReadLine());
    //                    Display(studentService.UpdateStudentAge(id, age));
    //                    break;
    //                }
    //            case 2:
    //                {
    //                    Console.Write("enter id:");
    //                    string id = Console.ReadLine();
    //                    Console.Write("enter new address:");
    //                    string address = Console.ReadLine();
    //                    Display(studentService.UpdateStudentAddress(id, address));
    //                    break;
    //                }
    //            default:
    //                {
    //                    Console.WriteLine("enter valid option");
    //                    break;
    //                }
    //        }

    //    }

    //}
}
