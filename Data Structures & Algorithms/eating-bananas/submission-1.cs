public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int minEatingSpeed = 1;
        int maxEatingSpeed = piles.Max();

        while (minEatingSpeed < maxEatingSpeed) {
            int totalHoursTaken = 0;
            int curEatingSpeed = (maxEatingSpeed + minEatingSpeed) / 2;
            for (int i = 0; i < piles.Length; i++) {
                totalHoursTaken += (int)Math.Ceiling((double)piles[i] / curEatingSpeed);
            }
            if (totalHoursTaken > h) {
                // Too slow
                minEatingSpeed = curEatingSpeed + 1;
            } else {
                // Valid, but maybe we can go slower
                maxEatingSpeed = curEatingSpeed;
            }
        }

        return minEatingSpeed;
    }
}
