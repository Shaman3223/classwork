namespace ShoppingList;

class Program
{
    static void Main(string[] args)
    {
        bool userWantsToContinueShopping = true;
        
        string msJetson = """"
                                   .-""',.-"""-.
                             ,_  .'.--. /_.---. `-.__.,
                             '\`'-'  _ /___    `-._.-/
                               '-..-'_'` _ `'-._  _.;
                               .'   /_   _      \`  \
                              /    /(_9 (_9  .   |   \
                              ;  _/   (      \`-'    /
                               `(_\  .===,    '.___.'
                                   '. `""`     _(_)
                                     '-.   .-'`
                              .====="""|   |""======,
                              '.       |   |      .'
                                `-.    |_.-'   .-'
                                   `-. `   _.-'
                                      '-.-'
                          """";
        
        List<Dictionary<String, decimal>> myShoppingList = new List<Dictionary<String, decimal>>();
        
        Dictionary<String, decimal> items = new Dictionary<String, decimal>();
        items.Add("Apple", 12.80m);
        items.Add("Banana", 2.88m);
        items.Add("Pear", 3.12m);
        items.Add("Pineapple", 4.65m);
        items.Add("Bread", 17.99m);
        items.Add("Cherry", 5.99m);
        items.Add("Tomato", 6.99m);
        items.Add("Grapes", 8.99m);
        items.Add("Milk", 9.99m);
        items.Add("Beef", 10.99m);
        items.Add("Chocolate", 11.99m);
        items.Add("chicken", 12.99m);
        items.Add("cucumber", 13.99m);

        do
        {
            bool userRequestedAValidItem = false;
            
            Console.WriteLine("\n \n The Items In Store:");
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            Console.WriteLine(msJetson);

            Console.WriteLine("Hey waddup, What do you want?");

            string input = Console.ReadLine();

            foreach (var item in items)
            {
                if (input == item.Key)
                {
                    Console.WriteLine("you have obtained " + input + " it costs " + item.Value);
                    Dictionary<string, decimal> newEntry = new Dictionary<string, decimal>();
                    newEntry.Add(item.Key, item.Value);

                    myShoppingList.Add(newEntry);
                    
                    userRequestedAValidItem = true;
                    break;
                }
            }

            if (!userRequestedAValidItem)
            {
                Console.WriteLine("Uhhh, dude you might be in the wrong store, We dont have that item.");
            }
            Console.WriteLine("Do you want to continue shopping? y/n");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "y":
                    userWantsToContinueShopping = true;
                    Console.Clear();
                    break;
                
                case "n":
                    userWantsToContinueShopping = false;
                
                    Console.Clear();
                    Console.WriteLine("Alrighty, heres what you ordered:");
                    decimal total = 0m;
                    foreach (var itemDict in myShoppingList)
                    {
                        foreach (var dict in itemDict)
                        {
                            Console.WriteLine($"{dict.Key}: {dict.Value}");
                            total += dict.Value;
                        }
                    }
                    Console.WriteLine();

                    Console.WriteLine($"The total iss: {total}");
                    break;
                
                default:
                    userWantsToContinueShopping = true;
                    Console.WriteLine("is that shoppenese? Im not fluent but I think you want to continue shopping yes?");
                    break;
            }

        } while(userWantsToContinueShopping);

    }
}