public class Solution {
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r) {
        bool[] result = new bool[l.Length];
        IList<int> steps = new List<int>();

        for(int i = 0 ; i<l.Length; i++){
            steps.Clear();
            int length = r[i]-l[i]+1;
            int max = nums[l[i]];
            int min = max;
            int previous = max;
            int currentSum = max;
            for(int j = l[i]+1; j<=r[i]; j++){
                
                int current = nums[j];
                currentSum += current;
                steps.Add(current-previous);

                if(min>current){
                    min = current;
                }

                if(max<current){
                    max = current;
                }

                previous = current;
            }

            if((currentSum != (min+max)*length/2) || (((max-min)%(length-1)) != 0)){
                result[i]=false;
                continue;
            }
            int step = (max-min)/(length-1);
            result[i] = step == 0 ? steps.All(s=>s==0) :
            steps.All(s=>s!=0 && s%step == 0);
        }
        return result;
    }
}