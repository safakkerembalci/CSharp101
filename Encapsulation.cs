class Encapsulation
{
    static void Main(string[] args)
    {

        Student student1 = new Student();
        student1.Name = "Solmaz";
        student1.Surname = "Akar";
        student1.StudentNo = 1981;
        student1.Department = 3;

        student1.getInfoStudent();

        student1.passClass();
        student1.getInfoStudent();

        Student student2 = new Student("Ceren", "Yılmaz", 256, 1);
        student2.getInfoStudent();

        student2.failClass();
        student2.failClass();
        student2.getInfoStudent();
    }
}
class Student
{
    private string name;
    private string surname;
    private int studentNo;
    private int department;

    // public string Name { get => name; set => name = value; }
    // Yukarıdaki ifade aşağıdaki ile birebir aynı işi yapıyor. getter ve setter metotlarının farklı versiyonu diyebiliriz.

    public string Name {
        get { return name; }
        set { name = value; }
    }

    public string Surname { get => surname; set => surname = value; }
    public int StudentNo { get => studentNo; set => studentNo = value; }
    public int Department 
    { 
        get => department; 
        set 
        {
            if(value < 1){
                Console.WriteLine("Department must be minimum 1!");
                department = 1;
            }else {
                department = value; 
            }
        } 
    }

    public Student(string name, string surname, int studentNo, int department) // Tüm özellikleri istenilen Constructor Methodu
    {
        this.name = name;
        this.surname = surname;
        this.studentNo = studentNo;
        this.Department = department;
    }
    public Student(){} // Boş oluşturulan Constructor Methodu

    public void getInfoStudent()
    {
        Console.WriteLine("***** Student Information *****");
        Console.WriteLine("Student Name      : {0}",this.name);
        Console.WriteLine("Student Surname   : {0}",this.surname);
        Console.WriteLine("Student No        : {0}",this.studentNo);
        Console.WriteLine("Student Department: {0}",this.Department);
    }

    public void passClass()
    {
        this.Department = this.Department + 1;
    }
    public void failClass()
    {
        this.Department = this.Department - 1;
    }

}