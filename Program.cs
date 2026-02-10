
using gruberoo_prg2_final;

List<Restaurant> restaurants = new List<Restaurant>();
List<Customer> customers = new List<Customer>();
List<Order> allOrders = new List<Order>();
Stack<Order> refundStack = new Stack<Order>();

//nig

Startup();
RunMainMenu();


void Startup()
{
    Console.WriteLine("Welcome to the Gruberoo Food Delivery System");
    LoadRestaurants("restaurants.csv");
    LoadFoodItems("fooditems.csv");
    LoadCustomers("customers.csv");
    LoadOrders("orders.csv");

    Console.WriteLine($"{restaurants.Count} restaurants loaded!");
    //Console.WriteLine($"{Fooditem.Count} orders Loaded!");
    Console.WriteLine($"{customers.Count} customers loaded!");
    Console.WriteLine($"{allOrders.Count} orders loaded!\n");
}

void LoadCustomers(string v)
{
    // Use the parameter 'v' instead of a hardcoded string to be more flexible
    string[] customerLines = File.ReadAllLines(v);

    for (int i = 1; i < customerLines.Length; i++)
    {
        string[] data = customerLines[i].Split(',');

        // Matching diagram property names
        Customer newCustomer = new Customer(data[1], data[0]);
        // Note: Check if CSV is Name,Email or Email,Name

        customers.Add(newCustomer);
    }
}

void LoadOrders(string v)
{
    if (!File.Exists(v)) return;
    string[] orderLines = File.ReadAllLines(v);

    for (int i = 1; i < orderLines.Length; i++)
    {
        string[] data = orderLines[i].Split(',');

        Order newOrder = new Order();
        newOrder.orderID = int.Parse(data[0]);
        newOrder.orderDateTime = DateTime.Parse(data[6]);
        newOrder.orderTotal = double.Parse(data[7]);
        newOrder.orderStatus = data[8]; // Required for Feature 4 & 6
        allOrders.Add(newOrder);
    }
}
void LoadRestaurants(string v)
{
    // 1. Load restaurants.csv
    string[] resLines = File.ReadAllLines("restaurants.csv");
    for (int i = 1; i < resLines.Length; i++) // Skip header
    {
        string[] data = resLines[i].Split(',');
        Restaurant res = new Restaurant(data[0], data[1], data[2]);
        restaurants.Add(res);
    }
}
void LoadFoodItems(string v)
{
    // 1. Load Fooditem.csv
    string[] foodLines = File.ReadAllLines("fooditems.csv");
    for (int i = 1; i < foodLines.Length; i++)
    {
        string[] data = foodLines[i].Split(',');

        string resId = data[0];
        string foodName = data[1];
        string fooddesc = data[2];
        double foodprice = double.Parse(data[3]);

        Restaurant targetRes = restaurants.Find(r => r.restaurantID == resId);

        if (targetRes != null)
        {
            if (targetRes.Menus.Count == 0)
                targetRes.AddMenu(new Menu());
            targetRes.Menus[0].AddFoodItem(new FoodItem(foodName, fooddesc, foodprice));
        }
    }
}
void RunMainMenu()
{
    while (true)
    {
        Console.WriteLine("\n===== Gruberoo Food Delivery System =====");
        Console.WriteLine("1. List all restaurants and menu items");
        Console.WriteLine("2. List all orders");
        Console.WriteLine("3. Create a new order");
        Console.WriteLine("4. Process an order");
        Console.WriteLine("5. Modify an existing order");
        Console.WriteLine("6. Delete an existing order");
        Console.WriteLine("0. Exit");
        Console.Write("\nEnter your choice: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            ListRestaurants();
        }
        else if (choice == "2")
        {
            ListAllOrders();
        }
        else if (choice == "3")
        {
            //CreateNewOrder(); 
        }
        else if (choice == "4")
        {
            //ProcessOrder(); 
        }
        else if (choice == "5")
        {
            //ModifyOrder();
        }
        else if (choice == "6")
        {
            //DeleteOrder(); 
        }
        else if (choice == "0")
        {
            return; // Exit the loop/program
        }
        else
        {
            Console.WriteLine("Invalid choice. Try again."); //
        }
    }
}
// Testing
void ListRestaurants()
{
    foreach (var r in restaurants)
    {
        Console.WriteLine($"\nRestaurant: {r.restaurantname} ({r.restaurantID})");
        foreach (var m in r.Menus)
        {
            m.DisplayFoodItems();
        }
    }
}

//push and pull 
void ListAllOrders()
{
    Console.WriteLine("\nAll Orders");
    Console.WriteLine("----------");
    // Header matching Figure 6
    Console.WriteLine($"{"Order ID",-10} {"Customer",-15} {"Restaurant",-15} {"Delivery Date/Time",-20} {"Amount",-10} {"Status",-10}");
    Console.WriteLine($"{"--------",-10} {"--------",-15} {"----------",-15} {"------------------",-20} {"------",-10} {"------",-10}");

    foreach (var o in allOrders)
    {

        Console.WriteLine($"{o.orderID,-10} {o.CustomerName,-15} {o.RestaurantName,-15} {o.orderDateTime,-20} {o.orderTotal,-10:C} {o.orderStatus,-10}");
    }
}

