LinkedList

class Node
{
  int _data;
  Node _next;
  public Node Next
  {
    get { return _next; }
    set { _next = value; }
  }

  public int Data
  {
    get { return _data; }
    set { _data = value; }
  }

  public void Remove()
  {
    _next = null;
  }
}

class LinkedList
{
	public Node _head;
	public Node _tail;

	void LinkedList()
  {
    _head = new Node();
    _tail = new Node();

    _head.Next = _tail;
    _tail.Next = null;
  }

  public bool InsertNode(int index, Node node)
  {
    Node it = _head;
    int listIndex = 0;
    
    while (it.Next != _tail)
    {
      if (listIndex == index)
      {
        node.Next = it.Next;
        it.Next = node;
        return true;
      }

      it = it.Next;
      ++listIndex;
    }

    return false;
  }

  public void AddNode(Node node)
  {
    Node it = _head;
    while (it.Next != tail)
    {
      it = it.Next;
    }
    
    it.Next = node;
    node.Next = _tail;
  }

  public bool RemoveNode(int index)
  {
    Node it = _head;
    int listIndex = 0;
    while (it.Next != tail)
    {
      if (listIndex == index - 1)
      {
        Node removeNode = it.Next;
        it.Next = removeNode.Next;        
        removeNode.Remove();
        removeNode = null;
        return true;
      }
      it = it.Next;
      ++listIndex;
    }
    return false;
  }

  public void RemoveNode(Node node)
  {
    Node it = _head;
    while (it.Next != _tail)
    {
      if (it.Next == node)
      {
        it.Next = node.Next;
        Node.Remove();
        node = null;
        return true;
      }
      it = it.Next;
    }
    return false;
  }

  public void RemoveAll()
  {
    Node it = _head.Next;
    while (_haad.Next != _tail)
    {
      Node it = _head.Next;
      _head.Next = it.Next;
      it.Remove();
      it = null;
    }
  }
}
