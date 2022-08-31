#include <stdio.h>

int main()
{
    int idNumber, workedHour;
    double salaryPerHour, totalSalary;
    scanf("%d", &idNumber);
    scanf("%d", &workedHour);
    scanf("%lf", &salaryPerHour);
    totalSalary = workedHour * salaryPerHour;

    printf("NUMBER = %d\n", idNumber);
    printf("SALARY = U$ %.2lf\n", totalSalary);
    return 0;
}