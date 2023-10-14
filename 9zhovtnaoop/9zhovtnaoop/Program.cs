using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

var fileContent = File.ReadAllText("myfile.json");

var books = JsonSerializer.Deserialize<List<Book>>(fileContent);

foreach (var item in books)
{
    if (item.PublishingHouseId != 0) 
    {
        Console.WriteLine($"PublishingHouseId: {item.PublishingHouseId}");
    }
    Console.WriteLine($"Title: {item.Title}");
    Console.WriteLine($"PublishingHouse: \nId: {item.PublishingHouseId}");
    Console.WriteLine($"Name: {item.PublishingHouse.Name}");
    Console.WriteLine($"Adress: {item.PublishingHouse.Adress}\n");
}

public class PublishingHouse
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Adress { get; set; }
}

public class Book
{
    [JsonIgnore]
    public int PublishingHouseId { get; set; }

    [JsonPropertyName("Name")]
    public string Title { get; set; }

    public PublishingHouse PublishingHouse { get; set; }
}