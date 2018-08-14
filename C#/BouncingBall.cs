/*
 * 6 Kyu - Bouncing Balls
 * https://www.codewars.com/kata/5544c7a5cb454edb3c000047
 */

public class BouncingBall {
    public static int bouncingBall(double h, double bounce, double window) {
        if (h > 0 && bounce < 1 && bounce > 0 && window < h) {
            int count = 1;
            while (h * bounce > window) {
                h *= bounce;
                count += 2;
            }
            return count;
        } else {
            return -1;
        }
    }
}