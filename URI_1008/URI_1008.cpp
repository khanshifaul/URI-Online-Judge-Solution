#include <iostream>
#include <iomanip>

using namespace std;
int main()
{
    int idNumber, workedHour;
    double salaryPerHour, totalSalary;
    cin >> idNumber >> workedHour >> salaryPerHour;
    totalSalary = workedHour * salaryPerHour;
    cout << "NUMBER = " << idNumber << endl;
    cout << "SALARY = U$ " << fixed << setprecision(2) << totalSalary << endl;
    return 0;
}
