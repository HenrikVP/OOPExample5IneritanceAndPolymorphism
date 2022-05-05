using OOPExample5IneritanceAndPolymorphism;


//Person p1 = new Person();
//p1.Name = "PersonName";

Teacher t1 = new Teacher();
t1.Name = "Henrik";
t1.Subject = "Teacher Subject";
t1.Phone = "12345678";
//Prints Teacher (Type) and number
t1.GetNumber();
//Prints Name and number
t1.GetNumber(true);
//Prints only number
t1.GetNumber(false);

Manager m1 = new Manager();
m1.Name = "Niels";
m1.Phone = "33332211";
//All three gives the admin number because they are OVERRIDE'n
m1.GetNumber();
m1.GetNumber(true);
m1.GetNumber(false);

SubTeacher st1 = new SubTeacher();
st1.Hours = 15;

Student s1 = new Student();
s1.PcId = 10;

Student s2 = new Student() { Name = "Gert", Id = 1 };

Student s3 = new Student("Uma", 69);
Console.WriteLine($"Student3 hedder {s3.Name} og har pcnr {s3.PcId}.");
DateTime dt = new DateTime(1989, 11, 9);
