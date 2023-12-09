using Studentask.Domain.Entity;

Student student1 = new Student(1,"Fidan", 100);
Student student2 = new Student(2,"Teymur", 100);
Student student3 = new Student(3,"Nihad", 100);
Student student4 = new Student(4,"Fuad", 100);

Group group = new(7, "318A");
group.AddStudent(student1);
group.AddStudent(student2);
group.AddStudent(student3);
group.AddStudent(student4);





