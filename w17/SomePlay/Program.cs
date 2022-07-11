// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("What's up?!");
namespace Solution
{
  public static class Program
  {
    public static findSum (int n){
        
      int num = 0;
      for (int i = 0; i<=n; i++){
            if (i % 3 == 0 || i % 5 == 0){
                num+=i;
            }
        }
      return num;
        }
    }
}