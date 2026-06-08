
try {
   Console.WriteLine("Please enter the first of two integers > 0.");
   long m = Convert.ToInt64(Console.ReadLine());
   Console.WriteLine("Please enter the second of two integers > 0.");
   long n = Convert.ToInt64(Console.ReadLine());
   // insure that n is smallest of two integers
   if (m < n){ 
      var temp = m;
      m = n;
      n = temp;
   }
   Console.WriteLine($"Starting with m:{m} n:{n}");
   long r = m % n;
   Console.WriteLine($"r = m % n : r = {r}");
   while (r > 0) {
      m = n;
      n = r;
      r = m % n;
      Console.WriteLine($"r = m % n : r = {r}");
   }
   Console.WriteLine($"The answer is n = {n}");
}
catch (Exception ex){
   Console.WriteLine($"Error: {ex.Message}");
}
