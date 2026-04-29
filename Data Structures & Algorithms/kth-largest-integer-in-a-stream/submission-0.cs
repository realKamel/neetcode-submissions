public class KthLargest {
  private PriorityQueue<int, int>  pq;
    private int k ;
    public KthLargest(int _k, int[] nums) {
        k = _k;
        pq =new PriorityQueue<int, int>();
        foreach(var num in nums)
        {
            pq.Enqueue(num,-num);
        }
    }
    
    public int Add(int val) {
        pq.Enqueue(val,-val);
        var temp = new PriorityQueue<int, int>();
		foreach(var num in pq.UnorderedItems)
		{
			temp.Enqueue(num.Element,num.Priority);
		}
        for(int i = 0 ; i < k-1;i++)
            temp.Dequeue();
        
        return temp.Peek();
    }
}
