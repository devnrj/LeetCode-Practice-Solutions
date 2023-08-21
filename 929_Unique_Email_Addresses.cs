public class Solution {
    public int NumUniqueEmails(string[] emails) {
        HashSet<string> set = new HashSet<string>();
        
        for(int i = 0 ; i < emails.Length; i++){
            int indexOfAt = emails[i].IndexOf('@');

            string localName = getValidLocalName(emails[i].Substring(0,indexOfAt));
            
            set.Add(localName + '@' + emails[i].Substring(indexOfAt+1,emails[i].Length-indexOfAt-1));
        }

        return set.Count;
    }

    private string getValidLocalName(string name){
        int indexOfPlus = name.IndexOf('+');
        string validName = null;
        if(indexOfPlus <0){
            validName = name;
        }else{
            validName = name.Substring(0,indexOfPlus);
        }
        StringBuilder sb = new StringBuilder();
        for(int i = 0 ; i < validName.Length; i++){
            if(validName[i] != '.'){
                sb.Append(validName[i]);
            }
        }
        return sb.ToString();
    }
}