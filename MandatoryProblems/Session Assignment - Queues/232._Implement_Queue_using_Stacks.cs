public class MyQueue {
    Stack<int> s1;
    public MyQueue() {
        s1 = new Stack<int>();
    }
    Stack<int> Reverse(Stack<int> s){
        int count = s.Count;
        Stack<int> s2 = new Stack<int>();
        for(int i = 0 ; i <count; i++){
            s2.Push(s.Pop());
        }
        return s2;
    }
    public void Push(int x) {
        s1 = Reverse(s1);
        s1.Push(x);
        s1 = Reverse(s1);
    }
    
    public int Pop() {
        return s1.Pop();
    }
    
    public int Peek() {
        return s1.Peek();
    }
    
    public bool Empty() {
        return s1.Count < 1;
    }
}