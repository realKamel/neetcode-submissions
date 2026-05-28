public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        if (position.Length == 1) {
            return 1;
        }

        int fleetCount = 0;

        var cars = position.Zip(speed, (p, s) => (p, s)).OrderByDescending(x => x.p).ToArray();

        var aheadCarTime = double.MinValue;

        for (var i = 0; i < cars.Length; i++) {
            var (p, s) = cars[i];
            var carSpeed = (double)(target - p) / s;
            if (aheadCarTime < carSpeed) {
                aheadCarTime = carSpeed;
                fleetCount++;
            }
        }
        return fleetCount;
    }
}
