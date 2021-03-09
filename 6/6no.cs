
public class Program
{
     // Make change in this method only
     public void MyWork(Func<int, int> logic)
     {
         int i = logic(1);

         return i  ;
     }

     // Do not change this method
     public void MyLogic(int t)
     {

     }

     static void Main(string[] args) {
        MyWork(MyLogic);
    }
}

