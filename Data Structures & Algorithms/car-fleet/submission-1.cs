public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
            if (position.Length == 1)
    {
        return 1;
    }

    int fleetCount = 0;

    var sortedList = new SortedList<int, int>(position.Length,
     comparer: Comparer<int>.Create((a, b) => b.CompareTo(a)));

    for (var i = 0; i < position.Length; i++)
    {
        sortedList.Add(position[i], speed[i]);
    }
    var aheadCarSpeed = double.MinValue;
    for (var i = 0; i < sortedList.Count; i++)
    {
        var carPosition = sortedList.GetKeyAtIndex(i);
        var carSpeed = (double)(target - carPosition) / sortedList[carPosition];
        if (aheadCarSpeed < carSpeed)
        {
            aheadCarSpeed = carSpeed;
            fleetCount++;
        }
    }
    return fleetCount;

        
    }
}
