#pragma once
#include "SongDescription.h"


void EditName(Song* songs, string oldName, string newName);

void EditAuthor(Song* songs, string author, string newAuthor);

void EditPublish(Song* songs, string oldPublish, string newPublish);

string Toupper(string word);


void EditName(Song* songs, string name, string newName)
{
	int check = 0;
	for (size_t i = 0; i < index; i++)
	{
		string srch = songs[i].name;
		for (size_t j = 0; j < srch.length(); j++)
		{
			if (Toupper(srch.substr(j, name.length())) == Toupper(name)) {
				srch.replace(j, name.length(), newName);
				songs[i].name = srch;
				check++;
				cout << "\t\t\tName succesfully edited.\n";
			}
		}

	}
	if (check == 0)
		cout << "\t\t\tThis song doesn't exist";
}

void EditAuthor(Song* songs, string author, string newauthor)
{
	int check = 0;
	for (size_t i = 0; i < index; i++)
	{
		string srch = songs[i].author;
		for (size_t j = 0; j < srch.length(); j++)
		{
			if (Toupper(srch.substr(j, author.length())) == Toupper(author)) {
				srch.replace(j, author.length(), newauthor);
				songs[i].author = srch;
				check++;
				cout << "\t\t\tAuthor succesfully edited.\n";
			}
		}

	}
	if (check == 0)
		cout << "\t\t\tSong with this author doesn't exist";
}

void EditLyrics(Song* songs, string word, string newword)
{
	int check = 0;
	for (size_t i = 0; i < index; i++)
	{
		string srch = songs[i].lyrics;
		for (size_t j = 0; j < srch.length(); j++)
		{
			if (Toupper(srch.substr(j, word.length())) == Toupper(word)) {
				srch.replace(j, word.length(), newword);
				songs[i].lyrics = srch;
				check++;
				cout << "\t\t\tThis word in your lyrics has been succesfully changed\n";
			}
		}
		if (check == 0)
			cout << "\t\t\tSong with this word doesn't exist";
	}
}


string Toupper(string word) {
	for (int i = 0; i < (word).length(); i++)
	{
		word[i] = toupper((word)[i]);
	}

	return word;

}



bool CheckDate (int day, int month, int year ) {

if ((day>0 && day<32) && (month>0 && month<13) && (year>=1900 && year<=2023) ) return false;

}


bool CheckName(Song* songs, string name, string author)
{    int count=0;

    for (size_t i = 0; i < index; i++)
	{
		if ((songs[i].name) == name && (songs[i].author) == author)
            count ++;
	}

		if (count == 0)
		return false;
}


void SetConsoleColour(WORD* Attributes, DWORD Colour)
{
	CONSOLE_SCREEN_BUFFER_INFO Info;
	HANDLE hStdout = GetStdHandle(STD_OUTPUT_HANDLE);
	GetConsoleScreenBufferInfo(hStdout, &Info);
	*Attributes = Info.wAttributes;
	SetConsoleTextAttribute(hStdout, Colour);
}

void ResetConsoleColour(WORD Attributes)
{
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), Attributes);
}
