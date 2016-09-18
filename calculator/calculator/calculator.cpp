// This is the main DLL file.

#include <iostream>
#include <string>
#include <sstream>

#include "stdafx.h"

#include "calculator.h"

using namespace std;
using namespace calculator;

/**/
//calculator::FractionException(const string& m) : message(m) {}
//
//string& calculator::FractionException::what() {
//	return message;
//}


calculator::Fraction::Fraction(int n) {
	num = n;
	den = 1;
	divisor = 1;
}//end Fraction with one parameter.

calculator::Fraction::Fraction(int n, int d) {
	num = n;
	den = d;
	if (d == 0)
		//throw FractionException("0 denominator");
	reduce();
}//end Fraction with two parameter.

void calculator::Fraction::reduce() {
	divisor = 1; //initialized
	if (((num<0) && (den<0)) || (den<0)) { //if both numerator and denominator are negative, make both positive.
		num = -num;			//or if only the denominator is neg, make numerator negative and denominator positive.
		den = -den;
	}
	gcd(num, den);
	num = num / divisor;
	den = den / divisor;
} //end reduce

void calculator::Fraction::gcd(int n, int d) {
	//first makes both the numerator and denominator positive
	if (d<0)
		d = -d;
	if (n<0)
		n = -n;
	//calculates the gcd
	if ((d <= n) && ((n%d) == 0)) {
		setDivisor(d);
		return;
	}
	else if (n<d) {
		gcd(d, n);
	}
	else {
		gcd(d, (n%d));
	}
	return;
}//end gcd

void calculator::Fraction::setDivisor(int gcd) {
	divisor = gcd;
}//end setDivisor

int calculator::Fraction::numerator() {
	return num;
}//end numerator accessor

int calculator::Fraction::denominator() {
	return den;
}//end denominator accessor

int calculator::Fraction::difference(calculator::Fraction& fRight) { // Returns the difference between the numerators
	return (num * fRight.denominator() - den * fRight.numerator());
} //end difference

calculator::Fraction calculator::Fraction::operator+(calculator::Fraction fLeft, calculator::Fraction fRight) {
	calculator::Fraction result((fLeft.numerator()*fRight.denominator()) + (fRight.numerator()*fLeft.denominator()),
		(fLeft.denominator() * fRight.denominator()));
	result.reduce();
	return result;
} //end operator+ overload

calculator::Fraction calculator::Fraction::operator-(calculator::Fraction fLeft, calculator::Fraction fRight) {
	calculator::Fraction result((fLeft.numerator()*fRight.denominator()) - (fRight.numerator()*fLeft.denominator()),
		(fLeft.denominator() * fRight.denominator()));
	result.reduce();
	return result;
} //end operator- overload

calculator::Fraction calculator::Fraction::operator*(calculator::Fraction fLeft, calculator::Fraction fRight) {
	calculator::Fraction result(fLeft.numerator() * fRight.numerator(),
		fLeft.denominator() * fRight.denominator());
	result.reduce();
	return result;
} //end operator* overload

calculator::Fraction calculator::Fraction::operator/(calculator::Fraction fLeft, calculator::Fraction fRight) {
	calculator::Fraction result(fLeft.numerator() * fRight.denominator(),
		fLeft.denominator() * fRight.numerator());
	result.reduce();
	return result;
} //end operator/ overload

