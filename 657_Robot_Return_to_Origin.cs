public class Solution {
    public bool JudgeCircle(string moves) {
        
        int distanceX = 0, distanceY = 0;
        foreach(char move in moves){
            switch(move){
                case 'U' : distanceY++;
                break;
                case 'R' : distanceX++;
                break;
                case 'D' : distanceY--;
                break;
                case 'L' : distanceX--;
                break;
            }
        }

        return distanceX == 0 && distanceY == 0 ? true : false;
    }
}