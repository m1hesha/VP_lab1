using System;

public class HW1 {
public static long QueueTime(int[] customers, int n) {
    int bcr; //basy cash registers 
    int time;
    for (time = 0; customers.Length > 0; time++) {
        if (customers.Length < n) {
                bcr = customers.Length;
        }
        else {
                bcr = n;
        }
        for (int i = 0; i < bcr; i++) {
                customers[i]--;
         }
     customers = Array.FindAll(customers, x => x != 0);

     }
    return time;
}

}

class Program {
    public static void Main(string[] args) {
        Console.WriteLine(HW1.QueueTime(new int[] { 5, 3, 4 }, 1));
        Console.WriteLine(HW1.QueueTime(new int[] { 10, 2, 3, 3 }, 2));
        Console.WriteLine(HW1.QueueTime(new int[] { 2, 3, 10 }, 2));
    }
}