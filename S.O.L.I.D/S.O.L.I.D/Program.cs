#region bad example

//public class SaveFile
//{
//    public void Save()
//    {
//        if (CheckFile())
//        {
//            //some code for saving file
//        }
//    }

//    public bool CheckFile()
//    {
//        //some code for checking file is exist
//        return true;
//    }

//}

#endregion


#region good example

public class CheckFile
{
    public bool isFileExist()
    {
        //some code for checking file is exist
        return true;
    }
}


public class SaveFile
{
   private CheckFile _checkFile = new CheckFile();

    public void Save()
    {
        if (_checkFile.isFileExist())
        {
            // some code for saving file
        }
    }

}


#endregion