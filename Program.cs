namespace SortedListCollection;

class Program
{
    static void Main(string[] args)
    {
        SortedList<int, string> sortedList = new SortedList<int, string>();

        sortedList.Add(3, "Apple");
        sortedList.Add(1, "Banana");
        sortedList.Add(5, "Orange");
        sortedList.Add(2, "Grapes");
        sortedList.Add(4, "Pineapple");

        // Allow the user to enter a key and value
        Console.WriteLine("Enter a key:");
        int key = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a value:");
        string value = Console.ReadLine();

        // Check if the key already exists
        if (sortedList.ContainsKey(key))
        {
            Console.WriteLine($"Key {key} already exists. Updating value...");
            sortedList[key] = value; // Update the value for existing key
        }
        else
        {
            sortedList.Add(key, value); // Add new key-value pair
        }

        Console.WriteLine("Enter the key to remove an item:");
        int keyToRemove = int.Parse(Console.ReadLine());

        if (sortedList.ContainsKey(keyToRemove))
        {
            sortedList.Remove(keyToRemove);
            Console.WriteLine($"Item with key {keyToRemove} removed.");
        }
        else
        {
            Console.WriteLine($"Item with key {keyToRemove} does not exist in the list.");
        }

        Console.WriteLine("Sorted List:");
        foreach (var kvp in sortedList)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
}

