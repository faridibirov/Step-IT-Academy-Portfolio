#include "Folder.h"

 void Folder:: Create() {
	char Name[50];
	char path[200];
	cout << "\t\t\tENTER FOLDER LOCATION ( WITH \\\\ AT THE END):";
	cin.ignore();
	cin.getline(path, 200);
	cout << "\t\t\tENTER FOLDER NAME:";
	cin.getline(Name, 50);
	strcat_s(path, Name);
	if (_mkdir(path) == -1)
		cout << "\t\t\tERROR! COULDN'T CREATE FOLDER.\n";
	else
		cout << "\t\t\tFOLDER WAS SUCCESSFULLY CREATED!" << endl;
}


  void Folder::Remove() {
	 char a[200] = "rmdir /s /q ";
	 strcat_s(a, GetName());
	 if (system(a))
		 cout << "\t\t\tERROR! COULDN'T REMOVE FOLDER.\n";
	 else
		 cout << "\t\t\tFOLDER SUCCESSFULLY REMOVED.\n";
 }

   void Folder::Copy() {
	  char newpath[200];
	  char copyname[200];
	  cout << "\t\t\tENTER PATH ( WITH \\\\ AT THE END): ";
	  cin.ignore();
	  cin.getline(newpath, 200);
	  strcpy_s(copyname, foldername);
	  strcat_s(newpath, copyname);
	  _mkdir(newpath);
	  string copy = "copy " + string(GetName()) + " " + string(newpath);
	  system(copy.c_str());

  }