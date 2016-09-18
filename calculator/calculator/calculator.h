// calculator.h

#pragma once
#include <string>

using namespace System;
using namespace std;

namespace calculator {

	public value class Fraction
	{
	public:
		Fraction(int n); //Constructor for the case with one input parameter. input is stored as numer and 1 is stored as the denom.
		Fraction(int n, int d); //Constructor for the case of two parameters. n is stored as the numer and d is stored as the denom.
		int numerator(); //accessor for the numerator
		int denominator(); //accessor for the denominator
		int difference(Fraction& fRight); // Returns the difference between the numerators

		static Fraction operator+(Fraction fLeft, Fraction fRight); //Overloads the + operator
		static Fraction operator-(Fraction fLeft, Fraction fRight); //Overloads the - operator
		static Fraction operator*(Fraction fLeft, Fraction fRight); //Overloads the * operator
		static Fraction operator/(Fraction fLeft, Fraction fRight); //Overloads the / operator

	private:
		int num; //holds the fraction's numerator
		int den; //holds the fraction's denominator
		int divisor; //holds the greatest common divisor for the fraction
		void reduce(); //reduces the fraction to its least divisor form
		void gcd(int n, int d); //Calculates the greatest common divisor for a given numerator and denominator
		void setDivisor(int gcd); //Called by function 'gcd' and sets the class attribute "divisor" to the greatest common divisor.
	};


//	public value class FractionException{
//public:
//	FractionException(const std::string& message);
//	std::string& what(); //throws an exception error message if the denominator is zero.
//private:
//	 std::string* message;
//};//end FractionException class

}
