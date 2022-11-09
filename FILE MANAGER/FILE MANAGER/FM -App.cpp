#include <iostream>
#include "UserInterface.h"

const int NotUsed = system("color 17");



int main() {

	UserInterface ui;
	
	try {
		ui.Стартуем;
	}
	catch (...)
	{
		cout << "\nFatal Error\n";
	}
}




