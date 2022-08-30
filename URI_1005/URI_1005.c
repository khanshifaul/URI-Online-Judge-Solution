#include<stdio.h>

int main(){
    float A, B, MEDIA;
    scanf("%f%f", &A, &B);
    MEDIA = (3.5 * A + 7.5 * B) / (3.5 + 7.5);
    printf("MEDIA = %.5f", MEDIA);
    return 0;
}