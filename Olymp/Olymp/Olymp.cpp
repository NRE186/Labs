#include "pch.h"
#include "iostream"
#include <string>
using namespace std;


int main()
{
	setlocale(LC_ALL, "Russian");
	int a, b;
	int home = 100;
	int para = 90;
	int perem = 10;
	int b_perem = 40;
	cin >> a;
	cin >> b;
	int count_par = (b - a) + 1;
	int result = 0;
	int x;
	int y;
	string str;
	if (a > 7 || b > 7 || a < 1 || b < 1 || a > b) {
		cout << "Ошибка условия";
	}
	else {
		if (count_par == 1) {
			result = (count_par * para) + home;
		}
		else {
			if (a > 0 && a < 3 && b > 2) {
				if (count_par == 2) {
					result = (count_par * para) + b_perem + home;
				}
				else {
					result = (count_par * para) + ((count_par - 2) * perem) + home + b_perem;
				}
			}
			else {
				result = (count_par * para) + ((count_par - 1) * perem) + home;
			}
		}
		if (result % 60 == 0) {
			x = result / 60;
			if (x < 10) {
				string s = "0";
				string s1 = ":00";
				string s2 = to_string(x);
				str = s + s2 + s1;
			}
			else {
				string s1 = ":00";
				string s2 = to_string(x);
				str = s2 + s1;
			}
		}
		else {
			x = result / 60;
			y = (result % 60);
			if (x < 10) {
				string s = "0";
				string s1 = ":";
				string s2 = to_string(x);
				string s3 = to_string(y);
				str = s + s2 + s1 + s3;
			}
			else {
				string s1 = ":";
				string s2 = to_string(x);
				string s3 = to_string(y);
				str = s2 + s1 + s3;
			}
		}
		cout << str << endl;
	}
}