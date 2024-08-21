using System.Diagnostics;
using Calculator;
 RCalculator m = new RCalculator();
 bool Check = true;
 while (Check == true)
 {
     m.Result();
     System.Console.WriteLine("Do you Want to Continue ? (y) (n) : ");
     List<string> Users = new List<string>();
     string Result = "(y) (Y) '' (Yes) (yes) ";
     Users.Add(Result);
     foreach (var item in Users)
     {
         string User = Console.ReadLine();
         if (item.Contains(User))
         {
             Check = true;
         }
         else
         {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $"/C clear";
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = false;
            process.Start();
            string Result1 = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            System.Console.WriteLine(Result1);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
             System.Console.WriteLine("Tanks!");
             Console.ResetColor();
             Check = false;
         }
     }
 }

