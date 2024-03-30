using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

public class ParallelAndAsync
{
    // Parallel Programming
    // Prallel prog ko side effects ho asynchronous
    // Tasks -Tasks takes time and independent
    int [] numbers = [2234,34545,6756567,3446,4545567];
    private void  CalculateSquare(int n)
{


var square = n*n;
Console.WriteLine($"Square of {n} is {square}");    
Thread.Sleep(1000); // 1 second sleep hunxa

}
// Sequntial
public void ProcessNuumbers()
{
    Console.WriteLine("Sequential loop");
  foreach(var num in numbers)
  {
    CalculateSquare(num);   // euta le arko lai farak pardaina vani we can parellelise
  }
}

public void ProcessNumbersParallel()
{
Console.Write("Parallel Loop");
Parallel.ForEach(numbers, CalculateSquare);

}
// Asynchronous Programming - async and await
public async Task  MakeTea()
{
await IgniteStove();
await BoilWaterOnTeaPot();
await PrepareMasala();
await AddIngrediants();
}
private async Task IgniteStove() // void ko thau ma async task rakhya - async task return garxa
{
    await Task.Delay(1000); // kunai method le task return garxa vane we can await that
}
private async Task<bool> BoilWaterOnTeaPot()
{
 return false;
}
private async Task PrepareMasala()
{

}
private async Task AddIngrediants()
{

}
}