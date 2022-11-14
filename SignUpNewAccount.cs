
using console_login_system.ContentContext;
using Microsoft.Data.SqlClient;
using Dapper;
namespace console_login_system
{
    public class SignUpNewAccount
    {
        public void start()
        {
            Console.Clear();
            var canvas = new Canvas(126, 31, false, true);
            canvas.drawCanvas();
            
            var content = new IndexContent(false);
            var earth = new Earth();

            this.getData();
        }

        private void getData()
        {
            Console.SetCursorPosition(96,18);
            string email = Console.ReadLine().Trim().ToLower();

            Console.SetCursorPosition(96,19);
            string newUser = Console.ReadLine().Trim();

            Console.SetCursorPosition(96,20);
            string newPassword = Console.ReadLine().Trim();

            Console.SetCursorPosition(103,22);
            string passwordConfirmation = Console.ReadLine().Trim();

            if(newPassword != passwordConfirmation) this.start();

            SetData(newUser, email, newPassword);
        }

        private void SetData(string user, string email, string password)
        {
            const string connectionString = "Server=localhost,1433;Database=ConsoleLoginData;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;";

            // conexão
            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var account = new Account();

                account.Id = Guid.NewGuid();
                account.User = user;
                account.Email = email;
                account.Password = password;

                var insertSql = @"
                INSERT INTO
                    [Account]
                VALUES(
                    @Id, @User,
                    @Email, @Password
                )";
            var rows = connection.Execute(insertSql,
                new {
                    account.Id,
                    account.User,
                    account.Email,
                    account.Password
                });
            }
        }
    }
}