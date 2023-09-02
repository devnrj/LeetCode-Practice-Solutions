public class Solution {
    public bool IsMatch(string s, string p) {
        Dictionary<(int,int),bool> dp = new Dictionary<(int,int),bool>();
        return DFS(0,0,s,p,dp);
    }

    public bool DFS(int i, int j, string s, string p,Dictionary<(int,int),bool> dp){
        if(dp.ContainsKey((i,j))) return dp[(i,j)];
        if(i>=s.Length && j>=p.Length){
            return true;
        }else if( j>=p.Length){
            return false;
        }

        bool match = i<s.Length && (s[i]==p[j] || p[j] =='.');
        bool result = false;
        if((j+1) < p.Length && p[j+1] == '*'){
            result = DFS(i,j+2,s,p,dp) || (match && DFS(i+1,j,s,p,dp));
        }else if(match){
            result = DFS(i+1,j+1,s,p,dp);
        }
        dp.Add((i,j),result);
        return dp[(i,j)];
    }
}