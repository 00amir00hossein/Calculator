using System.Diagnostics;
namespace Calculator;
public class RCalculator : ICalculator
{
    public string Function()
    {
        while (true)
        {
            try
            {
                List<string> Function = new List<string>();
                string m = "(+) (-) (*) (/) (**) (r) (tan) (cot) (sin) (cos) (=) : ";
                Function.Add(m);
                foreach (var item in Function)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    RCalculator newCalculator = new RCalculator();
                    newCalculator.Message("Function" + item);
                    Console.ResetColor();
                    string UserFunction = Console.ReadLine();
                    if (item.Contains(UserFunction))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        System.Console.WriteLine("Tanks!");
                        Console.ResetColor();
                        return UserFunction;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Pleas Enter Valid Input ! ");
                    Console.ResetColor();
                }

            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                continue;
            }
        }
    }

    public string Function2()
    {
        while (true)
        {
            try
            {
                List<string> Function2 = new List<string>();
                string m = "(+) (-) (*) (/) (**) (r) (tan) (cot) (sin) (cos) (=) : ";
                Function2.Add(m);
                foreach (var item in Function2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    RCalculator newCalculator = new RCalculator();
                    newCalculator.Message("Function" + item);
                    Console.ResetColor();
                    string UserFunction = Console.ReadLine();
                    if (item.Contains(UserFunction))
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        System.Console.WriteLine("Tanks!");
                        Console.ResetColor();
                        return UserFunction;
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Pleas Enter Valid Input ! ");
                    Console.ResetColor();
                }

            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                continue;
            }
        }
    }

    public double GetNumber()
    {
        while (true)
        {
            double number;
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Pleas Enter Number : ");
            Console.ResetColor();
            string Number = Console.ReadLine();
            bool IsValid = double.TryParse(Number, out number);
            if (Number == " " || Number == null)
            {
                Number = "0";
                number = 0;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                System.Console.WriteLine("Tanks!");
                Console.ResetColor();
                return number;
            }
            if (IsValid)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                System.Console.WriteLine("Tanks!");
                Console.ResetColor();
                return number;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Pleas Enter Valid Input ! ");
            Console.ResetColor();
            continue;

        }
    }

    public string Message(string Message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine("Pleas Enter  " + Message);
        Console.ResetColor();
        return Message;
    }


    public void Result()
    {
        RCalculator rCalculator = new RCalculator();
        bool check = true;
        while (check == true)
        {
            double Number1 = rCalculator.GetNumber();
            string Function = rCalculator.Function();
            if (Function == "r")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                double f = Math.Sqrt(Number1);
                System.Console.WriteLine($"{Number1} {Function} = {f}");
                Console.ResetColor();
                check = false;
                break;
            }
            if (Function == "tan")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                double f = Math.Tan(Number1);
                System.Console.WriteLine($"{Number1} {Function} = {f}");
                Console.ResetColor();
                check = false;
                break;
            }
            if (Function == "cot")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                double f = Math.Atan(Number1);
                System.Console.WriteLine($"{Number1} {Function} = {f}");
                Console.ResetColor();
                check = false;
                break;
            }
            if (Function == "sin")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                double f = Math.Sin(Number1);
                System.Console.WriteLine($"{Number1} {Function} = {f}");
                Console.ResetColor();
                check = false;
                break;
            }
            if (Function == "cos")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                double f = Math.Cos(Number1);
                System.Console.WriteLine($"{Number1} {Function} = {f}");
                Console.ResetColor();
                check = false;
                break;
            }
            double Number2 = rCalculator.GetNumber();
            string Function22 = rCalculator.Function2();
            Process process = new Process();
            if (Function22 == "=" || Function22 == "")
            {
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/C clear";
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = false;
                process.Start();
                string Result = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                System.Console.WriteLine(Result);


                switch (Function)
                {
                    case "+":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        double Result1 = Number1 + Number2;
                        System.Console.WriteLine($"{Number1} {Function} {Number2} = {Result1}");
                        Console.ResetColor();
                        check = false;
                        break;

                    case "-":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine($"{Number1} {Function} {Number2} = {Number1 - Number2}");
                        Console.ResetColor();
                        check = false;
                        break;
                    case "*":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine($"{Number1} {Function} {Number2} = {Number1 * Number2}");
                        Console.ResetColor();
                        check = false;
                        break;
                    case "/":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine($"{Number1} {Function} {Number2} = {Number1 / Number2}");
                        Console.ResetColor();
                        check = false;
                        break;
                    case "**":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        double m = Math.Pow(Number1, Number2);
                        System.Console.WriteLine($"{Number1} {Function} {Number2} = {m}");
                        Console.ResetColor();
                        check = false;
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Errors");
                        Console.ResetColor();
                        check = false;
                        break;
                }
            }
        }
    }
}
