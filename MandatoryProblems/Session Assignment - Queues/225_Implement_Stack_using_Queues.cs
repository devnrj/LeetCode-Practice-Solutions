public class MyStack {
    Queue<int> queue;
    public MyStack() {
        queue = new Queue<int>(); 
    }
    
    public void Push(int x) {
        int count = queue.Count;
        queue.Enqueue(x);
        for(int i = 0 ; i<count; i++){
            queue.Enqueue(queue.Peek());
            queue.Dequeue();
        }
    }
    
    public int Pop() {
        return queue.Dequeue();
    }
    
    public int Top() {
        return queue.Peek();
    }
    
    public bool Empty() {        
        return queue.Count < 1;
    }
}