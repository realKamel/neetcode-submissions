class Node
{
public:
	int data;
	Node *next;
	Node(int new_data)
	{
		this->data = new_data;
		this->next = nullptr;
	}
};
class MinStack
{
	Node *head;

public:
	MinStack()
	{
		this->head = nullptr;
	}
	bool isEmpty()
	{
		return head == nullptr;
	}
	void push(int val)
	{

		Node *newNode = new Node(val);
		newNode->next = head;
		head = newNode;
	}

	void pop()
	{
		Node *temp = head;
		head = head->next;
		delete temp;
	}

	int top()
	{
		if (!isEmpty())
			return head->data;
		else
		{
			cout << "\nStack is empty";
			return INT_MIN;
		}
	}

	int getMin()
	{
		int last_min = INT32_MAX;
		Node *ptr = head;

		while (ptr  != nullptr)
		{
			if (last_min > ptr->data)
				last_min = ptr->data;
			ptr = ptr->next;
		}
		return last_min;
	}
};