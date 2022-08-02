// Three Basic Arrays

int[] arr = {0, 1, 2, 3, 4, 5, 6, 7, 8};

string[] names;
names = new string[] {"Tim", "Martin", "Nikki", "Sara"};
//testing the array by iterating through it.
// for(int idx = 0; idx < names.Length; idx++)
// {
//     Console.WriteLine(names[idx]);
// }

bool[] boolArray = {true, false, true, false, true, false, true, false, true, false};
//testing the array by iterating through it.
// for(int idx = 0; idx < boolArray.Length; idx++)
// {
//     Console.WriteLine(boolArray[idx]);
// }


// List of Flavors
List<string> iceCreams = new List<string>() {
    "vanilla",
    "strawberry",
    "chocolate",
    "vanilla bean",
    "birthday cake"
}; 
Console.WriteLine(iceCreams.Count);
Console.WriteLine(iceCreams[2]);
iceCreams.RemoveAt(2);
Console.WriteLine(iceCreams.Count);

// User Info Dictionary
Random rand = new Random ();
int flavorIndex = rand.Next(0, iceCreams.Count);
Dictionary<string,string> namesFlavors = new Dictionary<string, string> () {
    {"Tim", iceCreams[flavorIndex]},
    {"Martin", iceCreams[flavorIndex]},
    {"Nikki", iceCreams[flavorIndex]},
    {"", iceCreams[flavorIndex]}
};
// Console.WriteLine(namesFlavors["Tim"]);