public class MyQueue {
    Stack<int> _queue;

    public MyQueue() {
        _queue = new Stack<int>();
    }
    
    public void Push(int x) {
        _queue.Push(x);
    }
    
    public int Pop() {
        var tempStack = new Stack<int>();

        while(_queue.Count != 0)
        {
            int item = _queue.Pop();
            tempStack.Push(item);
        }

        int firstItem = tempStack.Pop();

        while(tempStack.Count != 0)
        {
            int item = tempStack.Pop();
            _queue.Push(item);
        }

        return firstItem;
    }
    
    public int Peek() {
        var tempStack = new Stack<int>();

        while(_queue.Count != 0)
        {
            int item = _queue.Pop();
            tempStack.Push(item);
        }

        int firstItem = tempStack.Peek();

        while(tempStack.Count != 0)
        {
            int item = tempStack.Pop();
            _queue.Push(item);
        }

        return firstItem;
    }
    
    public bool Empty() {
        if (_queue.Count == 0) 
        {
            return true;
        }

        return false;
    }
}