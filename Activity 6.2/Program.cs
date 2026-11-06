class Program
{
    static void Main()
    {
        Queue<string> deposit = new Queue<string>();
        Queue<string> withdraw = new Queue<string>();
        Queue<string> inquire = new Queue<string>();
        Queue<string> others = new Queue<string>();

        Console.WriteLine("Select Transaction");
        Console.WriteLine("1 - Deposit");
        Console.WriteLine("2 - Withdraw");
        Console.WriteLine("3 - Inquire");
        Console.WriteLine("4 - Others");

        Console.Write("\nEnter Code: ");
        int code = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Account Name: ");
        string name = Console.ReadLine();

        switch (code)
        {
            case 1:
                deposit.Enqueue(name);
                break;
            case 2:
                withdraw.Enqueue(name);
                break;
            case 3:
                inquire.Enqueue(name);
                break;
            case 4:
                others.Enqueue(name);
                break;
            default:
                Console.WriteLine("Invalid Code!");
                return;
        }

        Console.WriteLine("\nNOW SERVING");

        if (deposit.Count > 0)
            Console.WriteLine("DEP : " + deposit.Peek());

        if (withdraw.Count > 0)
            Console.WriteLine("WTD : " + withdraw.Peek());

        if (inquire.Count > 0)
            Console.WriteLine("INQ : " + inquire.Peek());

        if (others.Count > 0)
            Console.WriteLine("OTH : " + others.Peek());

        Console.WriteLine("\nWAITING LIST");

        Console.WriteLine("\nDEPOSIT (" + deposit.Count + ")");
        foreach (string item in deposit)
            Console.WriteLine(item);

        Console.WriteLine("\nWITHDRAW (" + withdraw.Count + ")");
        foreach (string item in withdraw)
            Console.WriteLine(item);

        Console.WriteLine("\nINQUIRE (" + inquire.Count + ")");
        foreach (string item in inquire)
            Console.WriteLine(item);

        Console.WriteLine("\nOTHERS (" + others.Count + ")");
        foreach (string item in others)
            Console.WriteLine(item);
    }
}