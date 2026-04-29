public class LRUCache {

    private LinkedList<int> history { get; init; }
private Dictionary<int, int> values { get; init; }
private readonly int Limit;
public LRUCache(int capacity)
{
	history = new LinkedList<int>();
	values = new Dictionary<int, int>(capacity);
	Limit = capacity;
}

public int Get(int key)
{
	if (values.TryGetValue(key, out int result))
	{
		history.Remove(key);
		history.AddLast(key);
		return result;
	}
	return -1;
}

public void Put(int key, int value)
{
	if (values.ContainsKey(key))
	{
		history.Remove(key);
	}
	else if (history.Count >= Limit)
	{
		var keyToRemove = history.First.Value;
		values.Remove(keyToRemove);
		history.RemoveFirst();
	}

	values[key] = value;
	history.AddLast(key);
}
}