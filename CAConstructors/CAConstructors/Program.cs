using System;

class Wallet
{
    public int Balance { get; private set; }

    public Wallet(int[] initialBalance)
    {
        if (initialBalance.Length > 0)
        {
            Balance = initialBalance[0];
        }
        else
        {
            Balance = 0;
        }
    }

    public void AddMoney(int amount)
    {
        Balance += amount;
    }
}

class Store
{
    private string[] items;

    public Store(string[] availableItems)
    {
        items = availableItems;
    }

    public void DisplayItems()
    {
        Console.WriteLine("Items Available:");
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] initialBalanceArray = { 20000 };
        Wallet wallet = new Wallet(initialBalanceArray);

        string[] availableItemsArray = { "Mobile", "TV", "Laptop", "Desktop" };
        Store store = new Store(availableItemsArray);

        Console.WriteLine("Wallet balance is: " + wallet.Balance);
        store.DisplayItems();

        Console.Write("Select an Item: ");
        string selectedItem = Console.ReadLine();

        // Assuming user buys the selected item and deducts its price from the wallet balance
        wallet.AddMoney(10000);

        Console.WriteLine("Add more 10000 to wallet");
        Console.WriteLine("Wallet Balance is: " + wallet.Balance);
    }
}
