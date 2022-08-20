import java.io.IOException;
import java.util.Scanner;
class Main {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int A = input.nextInt();
        int B = input.nextInt();
        input.close();
        int X = A + B;
        System.out.println("X = " + X);
    }
}