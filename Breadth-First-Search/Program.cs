//Create data
//Add data to queue
//Create array to add searched items
//loop throgh queue and check that item not in searched array
//check if item is the target if yes return true 
//if no remove item from item and added in searched queue and add item neighbors to queue
//repeat util find item or queue empty which mean item not found then return false 


Dictionary<string, string[]> graphData = new Dictionary<string, string[]>();

graphData["You"] = new string[] {"School", "Zoo", "Beach", "Farm" }; //1'st degree connection
graphData["Beach"] = new string[] { "Palace" };
graphData["School"] = new string[] { "Gym" };
graphData["Zoo"] = new string[] { "Gym", "High_Way" };
graphData["Farm"] = new string[] { "Fast_Road" };
graphData["Palace"] = new string[0];
graphData["Gym"] = new string[0];
graphData["High_Way"] = new string[0];
graphData["Fast_Road"] = new string[0];
Queue<string> queue = new Queue<string>();
if (!getPath())
{
    Console.WriteLine("Your target not found, please make sure you enter a valid place");
}

bool getPath()
{
    
    List<string> searched = new List<string>(); //for save searched items here so not search again if data duplicate

    addDataToQueue("You");//Add first degree item to queue
    Console.Write("Please Enter where you want to go: ");
    string? target = Console.ReadLine();
    while (queue.Count > 0)
    {
        string place = queue.Dequeue();
        if (!searched.Contains(place))
        {
            if (place == target)
            {
                Console.WriteLine("Here we are, That is the pasth");
                return true;
            }
            else
            {
                searched.Add(place);
                addDataToQueue(place);
            }
        }
    }

    return false;
}

//string? getUserTarget()
//{
//    Console.Write("Please Enter where you want to go: ");    
//    return Console.ReadLine(); ;
//}


void addDataToQueue(string key)
{
    foreach (var item in graphData[key])
    {
        queue.Enqueue(item);
    }
}