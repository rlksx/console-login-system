using Microsoft.Data.SqlClient;
using console_login_system.ContentContext;
using Dapper;
namespace console_login_system
{
    public class SignInAccount
    {
        public void start()
        {
            Console.Clear();
            var canvas = new Canvas(126, 31, false, true);
            canvas.drawCanvas();

            var content = new Content(true);
            var earth = new Earth();

            this.getData();
        }

        private void getData()
        {
            Console.SetCursorPosition(96,18);
            string user = Console.ReadLine().Trim();

            Console.SetCursorPosition(96, 19);
            string userPassword = Console.ReadLine().Trim();

            this.checkData(user, userPassword);
        }

        private void checkData(string user, string pwd)
        {
            const string connectionString = "Server=localhost,1433;Database=ConsoleLoginData;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;";

            using(var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var sql = @"
                SELECT * FROM [Account] WHERE [User]=@user AND [Password]=@pwd";

                var nsei = connection.Query(sql, new {user, pwd});

                Console.Clear();
                foreach(var item in nsei)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}