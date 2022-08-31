import java.io.IOException;
import java.util.Scanner;
class Main {
    public static void main(String[] args) throws IOException {
        Scanner input = new Scanner(System.in);
        double A = input.nextDouble();
        double B = input.nextDouble();
        input.close();
        double MEDIA = (3.5 * A + 7.5 * B) / (3.5 + 7.5);
        System.out.printf("MEDIA = %.5f\n", MEDIA);
    }
}