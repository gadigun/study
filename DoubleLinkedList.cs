class Node
{
	int _data;
	Node _head;
	Node _tail;
	
	public Node Head { 
    set { _head = value; }
    get { return _head; }
  }
  
  public Node Tail {
    get { return _tail; }
    set { _tail = value; }
  }

	public int Data
  {
    get { return _data; }
    set { _data = value; }
  }

  public void Remove()
  {
    _head = null;
    _tail = null;
  }
}

class DoubleLinkedList
{
	public Node _head;
	public Node _tail;

void List()
{
	_head = new Node();
	_tail = new Node();

	_head.Head = _head;
	_head.Tail = _tail;
	_tail.Head = _head;
	_tail.Tail = _tail;
}

public bool InsertNode(int index, Node node)
{
	Node it = _head;
	int listIndex = 0;
	while (it.Tail != _tail)
  {
    if (listIndex == index)
    {
      node.Head = it;
      node.Tail = it.Tail;
      it.Tail = node;
      return true;
    }

    it = it.tail;
    ++listIndex;
  }

  return false;
}
	
public void AddNode(Node node)
{
	node.SetTail(_tail);
	node.SetHead(_tail.head);
	_tail.SetHead(node);
}

public bool RemoveNode(int index)
{
  Node it = _head;
	int listIndex = 0;
	while (it.tail != _tail)
  {
    if (listIndex == index)
    {
      it.GetHead().SetTail(it.GetTail().GetHead());
      it.GetTail().SeHead(it.GetHead().GetTail());
      it.Remove();
      it = null;
      return true;
    }
    it = it.tail;
    ++listIndex;
  }
  return false;
}

public void RemoveNode(Node node)
{
  Node it = _head;
	while (it.tail != _tail)
  {
    if (it == node)
    {
      it.GetHead().SetTail(it.GetTail().GetHead());
      it.GetTail().SetHead(it.GetHead().GetTail());	
      it.Remove();
      it = null;
      return true;
    }
    it = it.tail;
  }
  return false;
}

public void RemoveAll()
{
  Node it = _head.tail;
	while (_head.tail != _tail)
  {
    Node it = _head.GetTail();
    _head.SetTail(it.GetTail());

    it.Remove();
      it = null;
    }
  }
}
