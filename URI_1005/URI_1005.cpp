#include <iostream>
#include <iomanip>
int main()
{
    double A, B;
    std::cin >> A >> B;
    float MEDIA = (A * 3.5 + B * 7.5) / (3.5 + 7.5);
    std::cout << "MEDIA = " << std::fixed << std::setw(5) << std::setprecision(5) << MEDIA << std::endl;
    return 0;
}