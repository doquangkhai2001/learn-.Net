class process{
      public int tinhtongcacso(List<int> numbers){
        
        int sum = 0;
        foreach(int n in numbers){
            sum +=n;
        } 
        return sum;
      }

      public static List<int> timhaisonguyen(List<int> lst, int target){
        target = 9;
             for(int i = 0; i < lst.Count - 1 ; i++)
             {
                 for(int j = i+1; i < lst.Count; j++)
                 {
                    if(lst[i]+lst[j]==target){
                        return new List<int>{i,j};
                    }
                 }                              
             }
             return null;
             
             

      }
    
}