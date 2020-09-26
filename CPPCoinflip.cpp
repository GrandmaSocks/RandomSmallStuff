#include <iostream>
#include <Windows.h>
#include <vector>
#include <cstdlib>
#include <time.h>

int flipcoins()
{
	srand(time(0)); // set up seed so there is a psuedo random number
	int flipcoins = rand() % 2 + 1; // varible that will create the value of the coin flip

	return flipcoins; // returns the value of the coin flip
}


int main()
{
	int numberOfFlips; // amount of the flips
	int flipCoin = 0; // this varible hold the value of our coin flip
	int timesHeads = 0;
	int timesTails = 0;
	
	std::cout << "How many times should the coin be flipped? \n";
	std::cin >> numberOfFlips;

	for (int i = 1; i <= numberOfFlips; i++) // for loop that flips multiple coins based on the users input
	{	
		flipCoin = flipcoins();		

		if (numberOfFlips >= 300) // If the amount of flips is higher than 300 make it really fast
		{
			Sleep(0);
		}

		else // if below 300 make it a normal speed
		{
			Sleep(200);
		}

		if (flipCoin == 1) // Converts a number to something the user can understand
		{
			timesHeads++;
			std::cout << "\n";
			std::cout << "Its Heads \n";
		}

		if (flipCoin == 2)
		{
			timesTails++;
			std::cout << "\n";
			std::cout << "Its Tails \n";
		}	

	}

	system("CLS"); // Clears console

	std::cout << "You flipped the coin " << numberOfFlips << " times \n"; // amount of times the coin was flipped

	std::cout << "It was heads " << timesHeads << " Times"<< std::endl; // amount of times it was heads

	std::cout << "It was tails " << timesTails << " Times" << std::endl; // amount of times it was tails

	return 0;
}
