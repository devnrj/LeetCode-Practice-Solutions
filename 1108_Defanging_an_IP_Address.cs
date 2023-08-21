public class Solution {
    public string DefangIPaddr(string address) {
        if(
            address is null ||
            address.Equals(string.IsNullOrWhiteSpace(address.Trim()))
        ){
            return address;
        }
        String[] splitString = address.Split('.');
        if(splitString.Length != 4){
            return address;
        }

        string result = string.Join("[.]",splitString);
        return result;
    }
}