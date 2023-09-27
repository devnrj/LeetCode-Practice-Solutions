public class Solution {
    public bool Exist(char[][] board, string word) {
        if(board == null || board.Length == 0 ){
            return false;
        }
        for(int i = 0; i<board.Length; i++){
            for(int j = 0; j<board[0].Length; j++){
                if(board[i][j]==word[0]){
                    if(word.Length == 1 || DFS(board,i,j,word,0,new bool[board.Length,board[0].Length])){
                        return true;
                    }
                }
            }
        }
        return false;
    }

    private bool DFS(char[][] board,int i, int j, string word, int n, bool[,] visited){
        if(n==word.Length){
            return true;
        }
        if(i>=board.Length || i<0 || j<0 || j>=board[0].Length){
            return false;
        }else if(!visited[i,j] && word[n]==board[i][j]){
            visited[i,j]=true;
            bool result = DFS(board,i-1,j,word,n+1,visited) ||
            DFS(board,i+1,j,word,n+1,visited) ||
            DFS(board,i,j-1,word,n+1,visited) ||
            DFS(board,i,j+1,word,n+1,visited);
            visited[i,j]=false;
            return result;
        }
        return false;
    }
    
}