using System.Reflection.Metadata;

User user1 = new User();
User user2 = new User();
User user3 = new User();
User user4 = new User();

user1.login = "Wojtek";
class User
{
    public string login;
    public string password;
    private string username;
}