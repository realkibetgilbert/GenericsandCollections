// See https://aka.ms/new-console-template for more information
using GenericsandCollections.Generics;

Console.WriteLine("Hello, World!");
//instantiating generics

DataStore<string> stringDataStore = new DataStore<string>();

stringDataStore.Data = "Learning and Understanding Generics";

//generic method......

GenericMethod genericMethod = new GenericMethod();

int sum = genericMethod.AddNumbers(1, 2);



Console.WriteLine($"sum: {sum}");   

GenericProperty<int> intProperty = new GenericProperty<int>();  

intProperty.Data = 1;

Console.WriteLine(intProperty.Data);

Console.WriteLine(genericMethod.DisplayData(12));

Console.WriteLine(stringDataStore.Data);