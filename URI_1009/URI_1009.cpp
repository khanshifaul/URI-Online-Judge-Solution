#include <iostream>
#include <string>
#include <iomanip>
using namespace std;
int main()
{
    string sellerName;
    float fixedSalary, monthlySale, bonus, totalSalary;
    cin >> sellerName >> fixedSalary >> monthlySale;
    bonus = monthlySale * 15 / 100;
    totalSalary = fixedSalary + bonus;
    cout << "TOTAL = R$ " << fixed << setprecision(2) << totalSalary << endl;
}