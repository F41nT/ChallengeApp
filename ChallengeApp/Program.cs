using System.Reflection.Metadata;
using static System.Formats.Asn1.AsnWriter;

User user1 = new User("Ewa","aaa");
User user2 = new User("Tomek","ppp");
User user3 = new User("Kamil","123");
User user4 = new User("Dorota","ooo");

user1.AddScore(2);
user1.AddScore(5);
var result = user1.Result;
Console.WriteLine(result);

class User
{
    private List<int> score = new List<int>();
    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
      
    }
    public string Login { get; private set; }
    public string Password { get; private set; }

    public int Result
    {
        get 
        {
            return this.score.Sum();
        }
    }

    public void AddScore(int number)
    {
        this.score.Add(number);
    }
}
