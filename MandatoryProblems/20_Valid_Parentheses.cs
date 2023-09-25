public class Solution {
    public bool IsValid(string s) {
        Stack<char> stk = new Stack<char>();
        bool flag = true;
        for(int i = 0; i<s.Length; i++){
            switch(s[i]){
                case '(': stk.Push(s[i]);
                break;
                case '{': stk.Push(s[i]);
                break;
                case '[': stk.Push(s[i]);
                break;
                case ']': {
                    if(stk.Count > 0 && stk.Peek() == '['){
                        stk.Pop();
                    }else{
                        flag = false;
                    }
                }
                break;
                case ')': {
                    if(stk.Count > 0 && stk.Peek() == '('){
                        stk.Pop();
                    }else{
                        flag = false;
                    }
                }
                break;
                case '}': {
                    if(stk.Count > 0 && stk.Peek() == '{'){
                        stk.Pop();
                    }else{
                        flag = false;
                    }
                }
                break;
            }
            if(flag == false){
                return false;
            }
        }
        if(stk.Count > 0) return false;
        return true;
    }
}