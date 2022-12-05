namespace C_sharp_lb_3;

public class Student
{
    private string iDrecordBook;

    public string[] FullName { get; set; } = new string[3]; //Name Surname Patronymic
    public string Faculty { get; set; }
    public Sex sex { get; set; }
    public string Group { get; set; }
    public string IDrecordBook {
        get => iDrecordBook;
        set
        {
            if (value.Length == 8) iDrecordBook = value;
            else throw new Exception("IDrecordBook error");
        }
    }
    public CourseNumber Course { get; set; }

    Student(string[] fullName, string Faculty, Sex sex, string Group, string IDrecordBook, CourseNumber Course)
    {
        FullName = fullName;
        this.Faculty = Faculty;
        this.sex = sex;
        this.Group = Group;
        this.IDrecordBook = IDrecordBook;
        this.Course = Course;
    }
}

public enum Sex
{
    Male,
    Female
}

public enum CourseNumber
{
    I = 1,
    II = 2,
    III = 3,
    IV = 4,
    V = 5
}