#pragma once
#include "AdditionalFunctions.h"
#include <io.h>

WORD Attributes = 0;



void AddSong(Song* songs, Song newsong);

void ShowSong(Song* songs);

void RemoveSong(Song* songs, string songdel);

void Edit(Song* songs);

void SearchbyAuthor(Song* songs, string author);

void SearchbyLyrics(Song* songs, string word);

void Save(Song* songs);
void Load(Song* songs, Song newsong, char* filename);

void Menu() {
	cout << "\n\t\t  ";
	SetConsoleColour(&Attributes, BACKGROUND_INTENSITY | BACKGROUND_RED);
	cout << "*** WELCOME TO MY-MUSIC APP ***";
ResetConsoleColour(Attributes);
	struct _finddata_t fileInfo;

	char pathto[100]="*.txt";
	char pathtocopy[100];

	auto res = _findfirst(pathto, &fileInfo);

	enum options { exit, add, show, remove, edit, searchauthor, searchlyrics };

	const int length = 10;

	Song songs[10];

	

	int choice, day, month, year;
	string name, author, lyrics, namedel;
	string searchaa;
	Song newsong;
	char text[1000];
	bool opt=0;
	char mask[50] = "*.txt";
	int adchoice;
	enum addoptions { load=1, addby };

	int r = 0;

	do
	{
		SetConsoleColour(&Attributes, FOREGROUND_INTENSITY | FOREGROUND_RED);
		cout << "\n\n\t\t\t" << char(201) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(187);
		cout << "\n\t\t\t" << char(186) <<"   OPTIONS   " << char(186);
		cout << "\n\t\t\t" << char(200) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(188) << endl << endl;
		ResetConsoleColour(Attributes);

		SetConsoleColour(&Attributes, FOREGROUND_INTENSITY | FOREGROUND_BLUE);
		cout << "\t\t\t0 -> Exit\n"
			<< "\t\t\t1 -> Add New Song\n"
			<< "\t\t\t2 -> Show all Songs\n"
			<< "\t\t\t3 -> Delete a Song\n"
			<< "\t\t\t4 -> Menu Edit\n"
			<< "\t\t\t5 -> Search by Author\n"
			<< "\t\t\t6 -> Search by Lyrics\n";
			ResetConsoleColour(Attributes);
		
		SetConsoleColour(&Attributes, FOREGROUND_INTENSITY | FOREGROUND_GREEN);
		cout << "\n\t\t\tSelect command: ";
		ResetConsoleColour(Attributes);
		
		cin >> choice;

		switch (choice)
		{
		case exit:
			system("CLS");
			cout << endl;
			cout << "\t\t\t\tClosing the application\n";
			cout << "\t\t\t\t       .";
			Sleep(500);
			cout << ".";
			Sleep(500);
			cout << ".";
			Sleep(500);
			cout << ".\n";
			break;

		case add:
			system("CLS");
			cout << "\t\t\t1 -> Load from file\n"
				<< "\t\t\t2 -> Add New Song\n"
				<< "\n\t\t\tSelect command : ";
			cin >> adchoice;
			switch (adchoice)
			{
			case load:
				system("CLS");
				cout << "\n\t\t\tTo show files in project folder press 0,  to change press 1: ";
				cin >> opt;
				if (opt)
				{
					cout << "\n\t\t\tEnter file location (with \\ at the end): ";
					cin >> pathto;
					strcpy_s(pathtocopy, pathto);
					strcat_s(pathto, mask);

					res = _findfirst(pathto, &fileInfo);
					cout << "\t\t\tFiles in chosen folder:\n";
					if (res != -1) {
						while (r != -1)
						{
							cout << "\t\t\t\t" << fileInfo.name << endl;
							r = _findnext(res, &fileInfo);

						}

					}
					res = _findfirst(pathto, &fileInfo);
					r = 0;
					cout << "\n\t\t\tChoose file: ";
					cin >> filename;
						strcat_s(pathtocopy, filename);
						Load(songs, newsong, pathtocopy);

				}
				
				else
				{
					char pathto[100] = "*.txt";
					res = _findfirst(pathto, &fileInfo);
					cout << "\t\t\tFiles in chosen folder:\n";
					if (res != -1) {
						while (r != -1)
						{
							cout << "\t\t\t\t" << fileInfo.name << endl;
							r = _findnext(res, &fileInfo);

						}

					}
					
					res = _findfirst(pathto, &fileInfo);
					r = 0;
					cout << "\n\t\t\tChoose file: ";
					cin >> filename;
					Load(songs, newsong, filename);
				}
				break;
			case addby:
				system("CLS");
				cin.ignore();
				cout << "\t\t\tEnter Song Name: ";
				getline(cin, name);
				cout << "\t\t\tEnter Author Name: ";
				getline(cin, author);
				cout << "\t\t\tEnter date (day, month, year): ";
				cin >> day >> month >> year;
				cin.ignore();
				cout << "\t\t\tEnter Lyrics (press \"|\" to end): ";
				cin.getline(text, 1000, '|');
				lyrics = string(text);
				newsong.name = name;
				newsong.author = author;
				newsong.date.day = day;
				newsong.date.month = month;
				newsong.date.year = year;
				newsong.lyrics = lyrics;

				AddSong(songs, newsong);
				break;
			}
			break;

		case show:
			system("CLS");
			ShowSong(songs);
			break;

		case remove:
			system("CLS");
			cin.ignore();
			cout << "\t\t\tEnter Song Name: ";
			getline(cin, namedel);
			RemoveSong(songs, namedel);
			break;
		case edit:
			system("CLS");
			Edit(songs);
			break;
		case searchauthor:
			system("CLS");
			cin.ignore();
			cout << "\t\t\tEnter Author Name: ";
			getline(cin, searchaa);
			SearchbyAuthor(songs, searchaa);
			break;
		case searchlyrics:
			system("CLS");
			cout << "\t\t\tEnter a word you want to find in your lyrics: ";
			cin >> searchaa;
			SearchbyLyrics(songs, searchaa);
			break;
		default:
			system("CLS");
			cout << "\t\t\tWrong input";
			Sleep(1000);
			system("CLS");
			break;
		}


	} while (choice);

	Save(songs);
}



void AddSong(Song* songs, Song newsong) {
    if (CheckDate(newsong.date.day, newsong.date.month, newsong.date.year)) cout << "\n\t\t\tWrong date format\n";
   else if (CheckName(songs, newsong.name, newsong.author)) cout << "\n\t\t\tThis song already exist.\n";
    else
    {
	songs[index] = newsong;
	cout << "\n\t\t\tSong succesfully was added.";
	index++;
    }
}



void ShowSong(Song* songs)
{
	if (index==0) cout << "\t\t\tSong list is empty!\n";
	else {
		for (size_t i = 0; i < index; i++)
		{
			SetConsoleColour(&Attributes, FOREGROUND_INTENSITY | FOREGROUND_RED);
			cout << "Name: ";
			ResetConsoleColour(Attributes);
			cout <<	 songs[i].name << endl;
			SetConsoleColour(&Attributes, FOREGROUND_INTENSITY | FOREGROUND_BLUE);
			cout << "Author: ";
			ResetConsoleColour(Attributes);
			cout << songs[i].author << endl;
			SetConsoleColour(&Attributes, FOREGROUND_INTENSITY | FOREGROUND_GREEN);
			cout << "Date: ";
			ResetConsoleColour(Attributes);
			cout << songs[i].date.day << "." << songs[i].date.month << "." << songs[i].date.year << endl;
			SetConsoleColour(&Attributes, FOREGROUND_INTENSITY | FOREGROUND_RED);
			cout << "Lyrics: ";
			ResetConsoleColour(Attributes);
			cout << songs[i].lyrics << endl;
			cout << endl;
		}
		cout << endl;
	}
}


void RemoveSong(Song* songs, string songdel)
{
	int check = 0;
	for (size_t i = 0; i < index; i++)
	{
		if (Toupper(songs[i].name) == Toupper(songdel))
		{
			swap(songs[i], songs[index - 1]);
			cout << "\t\t\tSong has been removed!\n";
			check++;
			index--;
			break;
		}
	}
	if (check == 0)
		cout << "\t\t\tThis song does not exist!\n";
}


void Edit(Song* songs) {
	enum editing { exit, edname, edauthor, edlyrics};
	int edchoice;
	string name, author, word;
	string newname, newauthor, newword;
	do
	{
		SetConsoleColour(&Attributes, FOREGROUND_INTENSITY | FOREGROUND_RED);
		cout << "\n\n\t\t\t" << char(201) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205)  << char(205) << char(205) << char(205) << char(187);
		cout << "\n\t\t\t" << char(186) << " EDIT  OPTIONS  " << char(186);
		cout << "\n\t\t\t" << char(200) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(205) << char(188) << endl << endl;
		ResetConsoleColour(Attributes);
		SetConsoleColour(&Attributes, FOREGROUND_INTENSITY | FOREGROUND_BLUE);
		cout << "\t\t\t0 -> Back to Main Menu\n"
			<< "\t\t\t1 -> Edit Name\n"
			<< "\t\t\t2 -> Edit Author\n"
			<< "\t\t\t3 -> Edit Lyrics\n";
		ResetConsoleColour(Attributes);
		SetConsoleColour(&Attributes, FOREGROUND_INTENSITY | FOREGROUND_GREEN);
		cout << "\n\t\t\tSelect command: ";
		ResetConsoleColour(Attributes);
		cin >> edchoice;
		switch (edchoice)
		{
		case exit:
			system("CLS");
			break;
		case edname:
			system("CLS");
			cin.ignore();
			cout << "\t\t\tEnter Song  name: ";
			getline(cin, name);
			cout << "\t\t\tEnter Song new name: ";
			getline(cin, newname);
			EditName(songs, name, newname);
			break;

		case edauthor:
			system("CLS");
			cin.ignore();
			cout << "\t\t\tEnter Author  name: ";
			getline(cin, author);
			cout << "\t\t\tEnter Author new name: ";
			getline(cin, newauthor);
			EditAuthor(songs, author, newauthor);
			break;

		case edlyrics:
			system("CLS");
			cout << "\t\t\tEnter a word you want to change in lyrics: ";
			cin >> word;
			cout << "\t\t\tEnter new word: ";
			cin >> newword;
			EditLyrics(songs, word, newword);
			break;

		default:
			system("CLS");
			cout << "\t\t\tWrong input";
			Sleep(1000);
			system("CLS");
			break;
		}

	} while (edchoice);


}


void SearchbyAuthor(Song* songs, string author)
{
	int check = 0;
	for (size_t i = 0; i < index; i++)
	{
		string srch = songs[i].author;
		for (size_t j = 0; j < srch.length(); j++)
		{
			if (Toupper(srch.substr(j, author.length())) == Toupper(author)) {
				check++;
				cout << "Name: " << songs[i].name << endl;
				cout << "Author: " << songs[i].author << endl;
				cout << "Date: " << songs[i].date.day << "." << songs[i].date.month << "." << songs[i].date.year << endl;
				cout << "Lyrics: " << songs[i].lyrics << endl;
				break;
			}
			cout << endl;
		}
	}

	if (check == 0)
		cout << "\t\t\tThis author doesn't exist";
}


void SearchbyLyrics(Song* songs, string word)
{
	int check = 0;
	for (size_t i = 0; i < index; i++)
	{
		string srch = songs[i].lyrics;
		for (size_t j = 0; j < srch.length(); j++)
		{
			if (Toupper(srch.substr(j, word.length())) == Toupper(word)) {
				check++;
				cout << "Name: " << songs[i].name << endl;
				cout << "Author: " << songs[i].author << endl;
				cout << "Date: " << songs[i].date.day << "." << songs[i].date.month << "." << songs[i].date.year << endl;
				cout << "Lyrics: " << songs[i].lyrics << endl;
				break;
			}
		}
	}
			if (check == 0)
				cout << "\t\t\tSong with this word doesn't exist";

}


//void Load(Song* songs) {
//	FILE* f;
//	Song newsong;
//
//	if (fopen_s(&f, path, "r") != NULL) cout << "Couldn't open file!\n";
//	else {
//		while (!feof(f))
//		{
//			
//			char name[50];
//			char author[50];
//			char buff[1000];
//			fgets(name, 50, f);
//			name[strlen(name) - 1] = '\0';
//			songs[index].name += string(name);
//			fgets(author, 50, f);
//			author[strlen(author) - 1] = '\0';
//			songs[index].author += string(author);
//			fscanf_s(f, "%d.%d.%d\n", &songs[index].date.day, &songs[index].date.month, &songs[index].date.year);
//				fgets(buff, 1000, f);
//				//buff[strlen(buff) - 1] = '\0';
//				songs[index].lyrics += string(buff);
//	
//			//AddSong(songs, newsong);
//		}
//			index++;
//		fclose(f);
//	}
//}


void Load(Song* songs, Song newsong, char* filename) {
	FILE* f;
	//Song newsong;

	if (fopen_s(&f, filename, "r") != NULL) cout << "\t\t\tWrong file name!\n";
	else {
		while (!feof(f))
		{
			char name[50];
			char author[50];
			char buff[1000];
			fgets(name, 50, f);
			name[strlen(name) - 1] = '\0';
			newsong.name += string(name);
			fgets(author, 50, f);
			author[strlen(author) - 1] = '\0';
			newsong.author += string(author);
			fscanf_s(f, "%d.%d.%d\n", &newsong.date.day, &newsong.date.month, &newsong.date.year);
			fgets(buff, 1000, f);
			buff[strlen(buff)] = '\0';
			newsong.lyrics += string(buff);

			//while (newsong.lyrics[newsong.lyrics.length()] != '|')
			//{
			//	fgets(buff, 1000, f);
			//	buff[strlen(buff) - 1] = '\0';
			//	newsong.lyrics += string(buff);
			//}

		
		}
			AddSong(songs, newsong);
		fclose(f);
	}
}

void Save(Song* songs)

{
	FILE* f;
	if (fopen_s(&f, path, "w") != NULL) cout << "\t\t\tCouldn't open file!\n";
	else {
		for (size_t i = 0; i < index; i++)
		{
			const char* name = songs[i].name.c_str();
			const char* author = songs[i].author.c_str();
			int day = songs[i].date.day;
			int month = songs[i].date.month;
			int year = songs[i].date.year;
			const char* lyrics = songs[i].lyrics.c_str();

			fprintf_s(f, "%s\n%s\n%d.%d.%d\n%s", name, author, day, month, year, lyrics);

		}
		fclose(f);
		cout << "\t\t\t\tData has been saved!\n";
	}
}
