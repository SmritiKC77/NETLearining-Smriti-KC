// Single Inheritance(Euta base class Student bata derrived class CSStudent)
class CSStudent: Student, IGradeable // Multiple inheritance
{
    public CSStudent(string name, byte rn, string pTitle) : base(name, rn) // base keyword is used to call class of parent constructor
    {
        ProjectTitle = pTitle;
    }
public string ProjectTitle {get;set;}
public string InternWork {get;set;}
public double GetGrade() => 32;

}