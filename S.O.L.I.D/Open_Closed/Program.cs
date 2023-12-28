#region bad example


//public class File
//{
//    public string Name { get; set; }

//    public string Path { get; set; }

//    public string Extension { get; set; }   

//    public int Size { get; set; }
//}

//public class LoadFile
//{
//    public string FileType { get; set; }   

//    public void Load(File file)
//    {
//        if (FileType== "PDF")
//        {
//            //some code for loading PDF file
//        }

//        if (FileType=="DOC")
//        {
//            //some code for loading DOC file
//        }
//    }
//}

#endregion


#region good example

public class File
{
    public string Name { get; set; }

    public string Path { get; set; }

    public string Extension { get; set; }

    public int Size { get; set; }
}


public abstract class  LoadFile
{
    public virtual void  Load(File file)
    {
            // some code for loading file
    }

}

public class LoadPDF : LoadFile
{
    public override void Load(File file)
    {
      // some code for loading PDF file
    }
}

public class LoadDOC : LoadFile
{
    public override void Load(File file)
    {
        // some code for loading DOC file
    }
}

public class LoadXLS : LoadFile
{
    public override void Load(File file)
    {
        // some code for loading XLS file
    }
}


#endregion