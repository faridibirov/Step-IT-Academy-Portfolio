#include "File.h"
#include <string>

  void File::Open() {
	_finddata_t fileInfo;
	char find[200];
	char fullpath[200];
	char file[200];
	cout << "\t\t\tENTER PATH ( WITH \\\\ AT THE END): ";
	cin.ignore();
	cin.getline(find, 200);
	strcpy_s(path, find);
	strcpy_s(fullpath, find);
	strcat_s(find, "*.*");
	auto res = _findfirst(find, &fileInfo);
	if (res != -1)
	{
		do {
			if (res != -1)
				cout << fileInfo.name << endl;
		} while (_findnext(res, &fileInfo) != -1);
		cout << "\n\t\t\tSELECT FILE: ";
		cin.getline(file, 200);
		SetFile(file);
		strcpy_s(filename, file);
		strcat_s(fullpath, file);
		SetName(fullpath);
		cout << "\n\t\t\t" << filename << " SELECTED.\n";
		
	}
	else {
		check++;
		cout << "\n\t\t\tWRONG DIRECTORY!" << endl;
	}
	
  }


   void File:: Create() {
	  string newname, path;
	  cout << "\t\t\tENTER FILE LOCATION ( WITH \\\\ AT THE END):";
	  cin.ignore();
	  getline(cin, path);
	  cout << "\t\t\tENTER FILE NAME:";
	  getline(cin, newname);
	  path += newname;
	  fstream newFile;
	  newFile.open(path, std::ios::out);
	  if (newFile.is_open()) cout << "\t\t\tFILE WAS SUCCESSFULLY CREATED!" << endl;
	  else cout << "\t\t\tERROR DURING FILE CREATING!" << endl;
  }


    void File::Remove() {
	   char Name[50];
	   strcpy_s(Name, GetName());
	   if (remove(Name) != 0)
		   cout << "\t\t\tERROR! COULDN'T REMOVE FILE.\n";
	   else
		   cout << "\t\t\tFILE SUCCESSFULLY REMOVED.\n";
   }


	 void File::Rename() {
		char newName[50];
		char filepath[200];
		strcpy_s(filepath, path);
		cout << "\t\t\tENTER NEW NAME: ";
		cin.ignore();
		cin.getline(newName, 50);
		strcat_s(filepath, newName);
		if (rename(GetName(), filepath) != 0)
			cout << "\t\t\tERROR! COULDN'T RENAME FILE.\n";
		else
			cout << "\t\t\tOBJECT SUCCESSFULLY RENAMED.\n";
	 }


	  void File::Move() {
		 char name[100], newLocation[100];
		 strcpy_s(name, GetName());
		 cout << "\t\t\tENTER NEW LOCATION (WITH \\\\ AT THE END) : ";
		 cin.ignore();
		 cin.getline(newLocation, 100);
		 strcat_s(newLocation, filename);;
		 if (rename(name, newLocation) != 0)
			 cout << "\t\t\tERROR! COULDN'T MOVE FILE.\n";
		 else
			 cout << "\t\t\tFILE SUCCESSFULLY MOVED.\n";
	 }

	  void File::Copy() {

		  char* buffer;
		  buffer = new char;
		  char newpath[200];
		  char copyname[200];
		  int count = 0;
		  cout << "\t\t\tENTER PATH ( WITH \\\\ AT THE END): ";
		  cin.ignore();
		  cin.getline(newpath, 200);
		  strcpy_s(copyname, filename);
		  strcat_s(newpath, copyname);
		  ifstream infile(GetName(), ios::binary);
		  ofstream outfile(newpath, ios::binary);

		  while (!infile.eof()) {
			  infile.read(buffer, sizeof(char));
			  outfile.write(buffer, sizeof(char));
		  }

		  if (!outfile.is_open()) cout << "\t\t\tERROR! COULDN'T COPY FILE.\n";
		  else  cout << "\t\t\tFILE SUCCESSFULLY COPIED.\n"; 
		  delete buffer;
	  }


	   void File::Info() {

		  _finddata_t fileInfo;
		  auto res = _findfirst(GetName(), &fileInfo);
		  if (res != -1)
			  cout << "\t\t\t\tFILE INFO:\n"
			  << ((fileInfo.attrib & _A_HIDDEN) ? "\t\t\tHIDDEN" : "\t\t\tNOT HIDDEN") << endl
			  << ((fileInfo.attrib & _A_RDONLY) ? "\t\t\tREAD ONLY" : "\t\t\tNOT READ ONLY") << endl
			  << "\n\t\t\tFILENAME: " << fileInfo.name << endl
			  << "\n\t\t\tSIZE: " << fileInfo.size << " BYTES" << endl;

		  else cout << "\t\t\tCANT FIND ANY FILE\n";
	  }

	    void File::Search() {
		   _finddata_t fileInfo;
		   char path[200];
		   char mask[20];
		   cout << "\t\t\tENTER PATH ( WITH \\\\ AT THE END): ";
		   cin.ignore();
		   cin.getline(path, 200);
		   cout << "\t\t\tENTER MASK ( E.G. \"*.txt\"): ";
		   cin >> mask;
		   strcat_s(path, mask);
		   auto res = _findfirst(path, &fileInfo);
		   cout << "\n\t\t\t\tFIDEN FILES: " << endl;
		   if (res != -1)
		   {
			   do
			   {
				   if (res != -1)
					   cout << "\t\t\t" << fileInfo.name << endl;
			   } while (_findnext(res, &fileInfo) != -1);
			   cout << endl;
		   }


		   else cout << "\t\t\tNo such file.\n";
	   }