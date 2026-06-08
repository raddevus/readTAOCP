
try {
   Console.WriteLine("Please enter the first of two integers > 0.");
   int m = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Please enter the second of two integers > 0.");
   int n = Convert.ToInt32(Console.ReadLine());
   // insure that n is smallest of two integers
   if (m < n){ 
      var temp = m;
      m = n;
      n = temp;
   }
   Console.WriteLine($"Starting with m:{m} n:{n}");
}
catch (Exception ex){
   Console.WriteLine($"Error: {ex.Message}");
}
