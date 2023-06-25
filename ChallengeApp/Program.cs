using System.Reflection.Metadata;

User user1 = new User("Ewa","aaa");
User user2 = new User("Tomek","ppp");
User user3 = new User("Kamil","123");
User user4 = new User("Dorota","ooo");

class User
{
  
    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
      
    }
    public string Login { get; private set; }
    public string Password { get; private set; }
}