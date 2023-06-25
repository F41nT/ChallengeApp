using System.Reflection.Metadata;
using static System.Formats.Asn1.AsnWriter;
using ChallengeApp;

User user1 = new User("Ewa","aaa");
User user2 = new User("Tomek","ppp");
User user3 = new User("Kamil","123");
User user4 = new User("Dorota","ooo");

user1.AddScore(2);
user1.AddScore(5);
var result = user1.Result;
Console.WriteLine(result);


