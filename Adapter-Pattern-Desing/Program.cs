using System;

// Target interface
interface IPrinter
{
    void Print();
}

// Adaptee
class LegacyPrinter
{
    public void PrintDocument()
    {
        Console.WriteLine("Legacy Printer is printing a document.");
    }
}

// Adapter
class PrinterAdapter : IPrinter
{
    private LegacyPrinter legacyPrinter = new LegacyPrinter();

    public void Print()
    {
        legacyPrinter.PrintDocument();
    }
}

// Client code
class Program
{
    static void ClientCode(IPrinter printer)
    {
        printer.Print();
    }

    static void Main(string[] args)
    {
        // Using the Adapter
        PrinterAdapter adapter = new PrinterAdapter();
        ClientCode(adapter);

        // Keep console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
