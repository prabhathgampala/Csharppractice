//using System;
//class BankAccount
//{
//    private int _balance { get; set; }
//    public BankAccount(int balance)
//    {
//        _balance = balance;
//    }

//    public void deposit(int amount)
//    {
//        if (amount > 0)
//        {



//            _balance += amount;
//            Console.WriteLine("total balance " + _balance);
//        }
//        else
//        {
//            Console.WriteLine("Invalid amount");
//        }
//    }

//    public void withdraw(int amount)
//    {
//        if (amount < _balance)
//        {


//            _balance -= amount;
//            Console.WriteLine("total balance " + _balance);
//        }
//        else
//        {
//            Console.WriteLine("Insufficient balance");
//        }
//    }

//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        BankAccount b = new BankAccount(1000);
//        int a;
//        Console.WriteLine("enter amount to be deposited");
//        a = int.Parse(Console.ReadLine());
//        b.deposit(a);
//        int c;
//        Console.WriteLine("enter amount to be withdrawn");
//        c = int.Parse(Console.ReadLine());



//        b.withdraw(c);


//    }
//}

//----------------------------------------------------------------------------------//


//class Student
//{

//    private string name { get; set; }

//    private int roll { get; set; }

//    private  string Names
//    {
//        get { return name; }

//        set
//        {
//            if (string.IsNullOrWhiteSpace(value))
//            {
//                throw new Exception("name cannot be empty");
//            }
//            name = value;
//        }
//    }
//    private int Rollno
//    {
//        get { return roll; }
//        set 
//        {
//            if (value < 0)
//            {
//                throw new Exception("rollno cannot be negative ");
//            }
//            roll = value;
//        }
//    }

//    public Student(string name1,int roll2)
//    {
//        this.Names = name1;
//        this.Rollno = roll2;
//    }

//    public void Show()
//    {
//        Console.WriteLine($"NAME :{Names} ROLL {Rollno}");
//    }


//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        try
//        {
//            Student stu = new Student("rajesh", 100);

//            stu.Show();
//        }
//        catch(Exception e)
//        {
//            Console.Write(e);
//        }
//    }
//}

//------------------------------------------------------------------------------------------//



//class Book
//{
//    public string author;
//    public int isbn;
//    public string title;
//    public Book()
//    {
//        Console.WriteLine("hello books");
//    }
//    public Book(string author,string title)
//    {
//        this.author = author;
//        this.title = title;
//        Console.WriteLine($"author name : {author}\n title : {title}");
//    }
//    public Book(string author,int isbn,string title)
//    {
//        this.author = author;
//        this.title = title;
//        this.isbn = isbn;
//        Console.WriteLine($"author name : {author}\n isbn no: {isbn} \n title : {title}");

//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Book b = new Book();
//        Book b1 = new Book("jk rowling", "harrypotter");
//        Book b3 = new Book("Rajesh Reddy",100, "Life");
//    }
//}


//------------------------------------------------------------------------------------------//


//abstract class Area
//{
//    public  abstract void  calculateArea();

//}

//class Rectangle:Area
//{
//    public int a, b;
//    public Rectangle(int a,int b)
//    {
//        this.a = a;
//        this.b = b;
//    }
//    public override void  calculateArea()
//    {
//        Console.WriteLine($"area :{a * b}");
//    }
//}

//class Circle : Area
//{
//    public double r;

//    public Circle(double r)
//    {
//        this.r = r;
//    }

//    public override void calculateArea()
//    {
//        Console.WriteLine($"area :{3.14 * r*r}");
//    }
//}


//class Program { 

//public static void Main(string[] args)
//    {
//        Circle c = new Circle(5);
//        c.calculateArea();

//        Rectangle r = new Rectangle(4,5);
//        r.calculateArea();
//    }

//}

//------------------------------------------------------------------------------------//
//class Vehicle { 


//public  virtual void start()
//    {
//        Console.WriteLine("vehicle started");
//    }
//}

//class Bike : Vehicle
//{
//    public override void start()
//    {
//        Console.WriteLine("bike started");
//    }
//}

//class Car : Vehicle {

//    public override void start()
//    {
//        Console.WriteLine("car started");
//    }

//}


//class Program
//{
//    public static void Main(string[] args)
//    {
//        Car c = new Car();
//        c.start();
//        Bike b = new Bike();
//        b.start();
//    }
//}


//-----------------------------------------------------------------//



//class Person
//{
//    public virtual void getDetails()
//    {
//        Console.WriteLine("This is person");
//    }
//}

//class Student:Person
//{
//    public string name;
//    public Student(string name){
//        this.name = name;

//        }
//    public override void getDetails()
//    {
//        base.getDetails();
//        Console.WriteLine($"student name {name}");
//    }



//}


//class Teacher : Person {


//    public string tname;
//    public Teacher(string name)
//    {
//        this.tname = name;

//    }
//    public override void getDetails()
//    {
//        base.getDetails();
//        Console.WriteLine($"teacher name {tname}");
//    }

//}



//class Program {

//public static void Main(string[] args)
//    {
//        Teacher t = new Teacher("sai");
//        t.getDetails();
//        Student s = new Student("raj");
//        s.getDetails();

//    }

//}

//-----------------------------------------------------------------//


//interface Iplayable
//{
//    public void play();
//}

//class MusicPlayer : Iplayable
//{
//    public  void play()
//    {
//        Console.WriteLine("Playing music");
//    }
//}

//class VideoPlayer : Iplayable
//{
//    public void play()
//    {
//        Console.WriteLine("Playing video");

//    }
//}

//class Program
//{
//    public static void Main(string[]args){

//        VideoPlayer v = new VideoPlayer();
//        v.play();
//        MusicPlayer m = new MusicPlayer();
//        m.play();
//    }
//}

//----------------------------------------------------------------------------------------//

//interface Iprintable
//{
//     void Print();
//}

//interface Iserializable
//{
//    void save_file(string filename);
//}

//class Report : Iprintable, Iserializable
//{
//    public string title;
//    public string content;
//    public Report(string title,string content)
//    {
//        this.title = title;
//        this.content = content;
//    }
//    public void Print()
//    {
//        Console.WriteLine("details \n title "+title);
//    }

//    public void save_file(string filename)
//    {
//        File.WriteAllLines(filename, new string[] { $"title {title} content {content} " });
//    }

//}
//class Program {

//public static void Main(string[] args)
//    {
//        Report r = new Report("life", "it is full of mysteries");
//        r.Print();
//        r.save_file("report.txt");
//    }

//}

//-----------------------------------------------------------------------------------------//

//using System;

//// Define the Manager class (Reference Type)
//class Manager
//{
//    public string Name { get; set; }

//    public Manager(string name)
//    {
//        Name = name;
//    }
//}

//// Define the Department class
//class Department
//{
//    public string DepartmentName { get; set; }
//    public Manager Manager { get; set; }  // Reference type

//    public Department(string departmentName, string managerName)
//    {
//        DepartmentName = departmentName;
//        Manager = new Manager(managerName);
//    }

//    // Implementing Shallow Copy
//    public Department ShallowCopy()
//    {
//        return (Department)this.MemberwiseClone(); // Copies only the reference, not the actual object
//    }

//    // Implementing Deep Copy
//    public Department DeepCopy()
//    {
//        return new Department(this.DepartmentName, this.Manager.Name); // Creates a new Manager object
//    }

//    public void Display()
//    {
//        Console.WriteLine($"Department: {DepartmentName}, Manager: {Manager.Name}");
//    }
//}

//// Testing Shallow and Deep Copy
//class Program
//{
//    static void Main()
//    {
//        // Original object
//        Department original = new Department("IT", "Alice");
//        Console.WriteLine("Original:");
//        original.Display();

//        // Performing Shallow Copy
//        Department shallowCopy = original.ShallowCopy();
//        Console.WriteLine("\nShallow Copy before modification:");
//        shallowCopy.Display();

//        // Performing Deep Copy
//        Department deepCopy = original.DeepCopy();
//        Console.WriteLine("\nDeep Copy before modification:");
//        deepCopy.Display();

//        // Modify the Manager's name in the original object
//        original.Manager.Name = "Bob";

//        Console.WriteLine("\nAfter modifying the original manager's name:");
//        Console.WriteLine("Original:");
//        original.Display();
//        Console.WriteLine("Shallow Copy:");
//        shallowCopy.Display();  // Affected (Shares same reference)
//        Console.WriteLine("Deep Copy:");
//        deepCopy.Display();  // Unaffected (Has separate reference)
//    }
//}

// Removed the using directive for CSharpPractice as it is not defined in the provided context
using System;
class Program
{
    public static void Main()
    {
        // Assuming Collections is defined in the same file or another file in the same project
        //Collections c = new Collections();
        //c.minArray();

        //int p = int.Parse(Console.ReadLine());

        //if(c.isPrime(p))
        //{
        //    Console.WriteLine("prime");
        //}
        //else
        //{
        //    Console.WriteLine("not prime");
        //}

        //ReverseString rs = new ReverseString();
        //Console.WriteLine(rs.Reverse("hello"));
        int [] a = new int[5];
        string s="hello";
        int i=2;
        try
        {
            Console.WriteLine(s.Substring(10, 10));
            i = i / 0;
            a[100] = 100;
        }
        catch (System.ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }

        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);

        }
        finally
        {
            Console.WriteLine("finally block");
        }

    }
}