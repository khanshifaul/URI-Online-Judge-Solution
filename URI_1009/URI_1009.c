#include <stdio.h>

int main(){
    char sellerName;
    float fixedSalary, monthlySale, bonus, totalSalary;
    scanf("%s", &sellerName);
    scanf("%f", &fixedSalary);
    scanf("%f", &monthlySale);
    bonus = monthlySale * 15 / 100;
    totalSalary = fixedSalary + bonus;
    printf("TOTAL = R$ %.2f\n", totalSalary);
}