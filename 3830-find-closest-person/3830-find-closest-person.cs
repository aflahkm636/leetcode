public class Solution {
    public int FindClosest(int x, int y, int z) {
        int distX = x < z ? z - x : x - z;
        int distY = y < z ? z - y : y - z;

        if (distX < distY) {
            return 1;
        } else if (distX == distY) {
            return 0;
        } else {
            return 2;
        }
    }
}
