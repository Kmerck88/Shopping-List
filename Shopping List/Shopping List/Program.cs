IDictionary<string, decimal> d = new Dictionary<string, decimal>(); // dict to store product and value
var myList = new List<KeyValuePair<string, decimal>>();

// list  items
d.Add("Apple", 4m);   // atleast 8 items
d.Add("Orange", 3m);
d.Add("Washing Powder", 10m);
d.Add("Strawberries", 7m);
d.Add("Milk", 2.99m);
d.Add("Sugar", 4m);
d.Add("Dish Soap", 6m);
d.Add("Beef", 50m);
d.Add("Bacon", 7m);
Console.WriteLine("Product  Price");
while (true)
{
    foreach (KeyValuePair<string, decimal> kvp in d)
    {
    Console.WriteLine(" {0} {1}", kvp.Key, kvp.Value);
    }
    Console.WriteLine("Press E to Exit");

    Console.WriteLine("Enter Product Name");
    
    string input;
    input = Console.ReadLine();
    
    if (input == "E")
        break;

    if (d.ContainsKey(input)) // if items is in list
    {
        Console.WriteLine("{0},{1}", input, d[input]);
        myList.Add(new KeyValuePair<string, decimal>(input, d[input]));
    }
    else
    {
        Console.WriteLine("Enter Correct Value");
    }
}


decimal sum = 0;
foreach (var val in myList)
{
    Console.WriteLine(" {0}  {1}", val.Key, val.Value);
    sum += val.Value;
}
Console.WriteLine("Total Is {0}", sum / myList.Count);// print average
	
	
	

