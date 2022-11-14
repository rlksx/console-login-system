namespace console_login_system.ContentContext
{
  public class Content
  {
    public Guid IdUser { get; set; }

    public Content(Guid idUser)
    {
      this.IdUser = idUser;
      Console.Clear();
      Console.Write(idUser);
    }
  }
}