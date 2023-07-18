using System;
MyQueue<int> myQueue = new MyQueue<int>(3);

myQueue.Enqueue(10);
myQueue.Enqueue(20);
myQueue.Enqueue(30);

Console.WriteLine($"Peek element:{myQueue.Peek()} "); 

int dequeuedItem = myQueue.Dequeue();
Console.WriteLine($"Dequeued Item:{dequeuedItem} " ); 

public class MyQueue<T>
{
    private T[] _items;
    private int _top;
    private int _bottom;

    public MyQueue(int size)
    {
        _items = new T[size];
        _top = 0;
        _bottom = 0;
    }

    public void Enqueue(T item)
    {
        if (_bottom == _items.Length)
        {
            throw new StackOverflowException();
        }

        _items[_bottom] = item;
        _bottom++;
    }

    public T Dequeue()
    {
        if (_top == _bottom)
        {
            throw new InvalidOperationException();
        }

        T dequeuedItem = _items[_top];
        _top++;
        return dequeuedItem;
    }

    public T Peek()
    {
        if (_top == _bottom)
        {
            throw new InvalidOperationException();
        }

        return _items[_top];
    }
}

