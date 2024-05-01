using L109StaticMembers._1HashPassword;
User user = new User();
user.Register("nhon", "P@sssw0rd");
Console.WriteLine(user.Login("nhon", "P@sssw0rd") ? "true" : "false");
