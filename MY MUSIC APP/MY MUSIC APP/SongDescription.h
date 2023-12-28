#pragma once
#include<iostream>
#include <string> 
#include<windows.h>
#include<time.h>
#include <stdio.h>

using namespace std;

int index = 0;


const char* path = "savedsongs.txt";
char filename[50];

struct Date {
	int day;
	int month;
	int year;
};


struct Song {
	string name;
	string author;
	Date date;
	string lyrics;
};