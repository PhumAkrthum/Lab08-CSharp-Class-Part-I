// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main()
    {
        // สร้าง Object ของ Person โดยใช้ Constructor ที่กำหนดค่าเริ่มต้น
        Person p = new Person("Rambo", 1987, 2500);
        
        // แสดงผลค่าของ object p
        Console.WriteLine($"Type of p is {p.GetType()}");
        Console.WriteLine($"p.name = {p.name}\ttype = {p.name.GetType()}");
        Console.WriteLine($"p.id = {p.id}\ttype = {p.id.GetType()}");
        Console.WriteLine($"p.income = {p.income}\ttype = {p.income.GetType()}");
    }
}

// คลาส Person ที่แก้ไขให้ถูกต้อง
class Person
{
    // ใช้ public property แทน private field
    public string name { get; set; }
    public int id { get; set; }
    public int income { get; set; }

    // Constructor ที่กำหนดค่าเริ่มต้นให้ name, id, และ income
    public Person(string name, int id, int income)
    {
        this.name = name;
        this.id = id;
        this.income = income;
    }
}
