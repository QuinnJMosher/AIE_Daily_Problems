// thoesBitsLookShifty.cpp : Defines the entry point for the console application.

#include <iostream>

void compareBits(unsigned int in_arg1, unsigned int in_arg2);

int main()
{
	compareBits(1, 2);
	system("pause");
	return 0;
}

void compareBits(unsigned int in_arg1, unsigned int in_arg2) {
	unsigned int comparison = in_arg1 ^ in_arg2;
	unsigned int shifty = 1;
	
	int similarities = 0;
	while (shifty != 0) {
		unsigned int compResult = shifty & comparison;
		if (compResult == 0) {
			similarities++;
		}

		shifty = shifty << 1;
	}

	std::cout << similarities << std::endl;

}