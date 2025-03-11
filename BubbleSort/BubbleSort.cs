public class Home{
  public static void Main(){
    int[] arr = {64, 34, 25, 12, 22, 11, 90};
    for(int j=0; j<arr.Length-2; j++){
      for(int i=0; i<arr.Length-2; i++){
        if(arr[i]>arr[i+1]){
          int temp = arr[i];
          arr[i] = arr[i+1];
          arr[i+1] = temp;
        }
      }
    }

    foreach(int i in arr){
      Console.Write(i+" ");
    }
    Console.WriteLine();
  }
}
