#region bad example
//public abstract class Student
//{
//    public virtual void GetGrades() { }

//    public virtual void GetInfo() { }
//}

//public class ITStudent : Student
//{
//    public override void GetGrades()
//    {
//        // some code to get grades
//    }

//    public override void GetInfo()
//    {
//        // some code to get information about student
//    }
//}

//public class DesignStudent : Student
//{
    
//    public override void GetGrades( )
//    {
//        // some code to get grades
//    }

//    //for DesignStudent no information
//    public override void GetInfo()
//    {
//        throw new NotImplementedException();

//    }
//}

#endregion


#region good example
public interface IStudent
{
    void GetInfo();
}

public interface IGrades
{
    void GetGrades();
}

public class ITStudent : IStudent, IGrades
{
    public void GetGrades()
    {
        // some code for getting grades
    }

    public void GetInfo()
    {
        // some code for getting info
    }
}

public class DesignStudent : IGrades
{
    public void GetGrades()
    {
        // some code to get grades
    }
}

#endregion