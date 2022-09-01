#include <stdio.h>

int main(){
    int productCode, unit;
    double unitPrice, totalPrice;
    scanf("%d %d %lf", &productCode, &unit, &unitPrice);
    totalPrice = unit * unitPrice;
    scanf("%d %d %lf", &productCode, &unit, &unitPrice);
    totalPrice += unit * unitPrice;
    printf("VALOR A PAGAR: R$ %.2lf\n", totalPrice);
    return 0;
}