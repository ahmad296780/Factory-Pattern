


using Factory_Pattern_Exercise_2;

Console.WriteLine("what type you want to access?");
var user = Console.ReadLine();

IDataAccess stored = DataAccessFactory.GetDataAccessType(user);
 List<Product> products = stored.LoadData();
stored.SaveData();
Console.WriteLine("-------------------");
foreach (var item in products)
{
    Console.WriteLine($"{item.price}, " +
                      $"{item.name}");

    
    
}

