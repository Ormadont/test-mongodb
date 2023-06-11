using MongoDB.Bson;
using MongoDB.Driver;

var client = new MongoClient("mongodb://localhost:27017");
var database = client.GetDatabase("foo");
var collection = database.GetCollection<BsonDocument>("bar");

await collection.InsertOneAsync(new BsonDocument("Name", "Jack"));

var list = await collection.Find(new BsonDocument("Name", "Jack"))
    .ToListAsync();

foreach (var document in list)
{
    Console.WriteLine(document["Name"]);
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
