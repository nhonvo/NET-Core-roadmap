using L109StaticMembers._1HashPassword;
using System.Resources;

class User
{
    public int Id { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public byte[] Salts { get; set; }
    /// <summary>
    /// create new salt and use it to hash password then assign them
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    public User Register(string username, string password)
    {
        UserName = username;
        Salts = PasswordExtention.CreateSalt();
        Password = PasswordExtention.HashPasword(password, Salts);
        return this;
    }
    /// <summary>
    /// compare username, password with input password it is hashed and compare
    /// 2 hash string
    /// </summary>
    /// <param name="username"></param>
    /// <param name="password"></param>
    /// <returns></returns>
    public bool Login(string username, string password)
    {
        if (username == null || password == null) return false;
        if (UserName == username)
        {
            string hashPassword = password.HashPasword(Salts);
            if (Password == hashPassword)
                return true;
        }
        return false;
    }
}
