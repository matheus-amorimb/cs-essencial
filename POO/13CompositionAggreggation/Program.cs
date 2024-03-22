
using _13CompositionAggreggation;

Teacher teacher1 = new Teacher("Matheus", "Software Engineering");
Teacher teacher2 = new Teacher("Manu", "Introduction to database");
Teacher teacher3 = new Teacher("Arthur", "Algorithms and Data Structures");

Department department = new Department("Computer Science");

department.AddTeacher(teacher1);
department.AddTeacher(teacher2);
department.AddTeacher(teacher3);

department.DisplayTeachers();