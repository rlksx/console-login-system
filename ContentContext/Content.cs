namespace console_login_system.ContentContext
{
    public class Content
    {
        public bool IsLogin { get; set; }

        public Content(bool isLogin)
        {
            this.IsLogin = isLogin;

            this.Title();
            this.Body();

        }

        public void Title()
        {
            if(IsLogin == true)
            {
                /* SIGN - IN */
                Console.SetCursorPosition(80, 2);
                Console.Write(@" _____  _                          _        ");

                Console.SetCursorPosition(80, 3);
                Console.Write(@"/  ___|(_)                        (_)       ");

                Console.SetCursorPosition(80, 4);
                Console.Write(@"\ `--.  _   __ _  _ __    ______   _  _ __  ");

                Console.SetCursorPosition(80, 5);
                Console.Write(@" `--. \| | / _` || '_ \  |______| | || '_ \ ");

                Console.SetCursorPosition(80, 6);
                Console.Write(@"/\__/ /| || (_| || | | |          | || | | |");

                Console.SetCursorPosition(80, 7);
                Console.Write(@"\____/ |_| \__, ||_| |_|          |_||_| |_|");

                Console.SetCursorPosition(80, 8);
                Console.Write(@"            __/ |                           ");

                Console.SetCursorPosition(80, 9);
                Console.Write(@"           |___/                            ");

            } else {
                
                /* SIGN UP */
                Console.SetCursorPosition(78, 2);
                Console.Write(@" _____  _                                       ");

                Console.SetCursorPosition(78, 3);
                Console.Write(@"/  ___|(_)                                      ");

                Console.SetCursorPosition(78, 4);
                Console.Write(@"\ `--.  _   __ _  _ __    ______   _   _  _ __  ");

                Console.SetCursorPosition(78, 5);
                Console.Write(@" `--. \| | / _` || '_ \  |______| | | | || '_ \ ");

                Console.SetCursorPosition(78, 6);
                Console.Write(@"/\__/ /| || (_| || | | |          | |_| || |_) |");

                Console.SetCursorPosition(78, 7);
                Console.Write(@"\____/ |_| \__, ||_| |_|           \__,_|| .__/ ");

                Console.SetCursorPosition(78, 8);
                Console.Write(@"            __/ |                        | |    ");

                Console.SetCursorPosition(78, 9);
                Console.Write(@"           |___/                         |_|    ");
            }
        }

        public void Body()
        {
            if(IsLogin == true)
            {
                /* SENHA */
                Console.SetCursorPosition(84, 16);
                Console.Write(@"___________________________________");

                Console.SetCursorPosition(83, 17);
                Console.Write(@"/                                   \");

                Console.SetCursorPosition(83, 18);
                Console.Write(@"| User     :                        |");

                Console.SetCursorPosition(83, 19);
                Console.Write(@"| Password :                        |");

                Console.SetCursorPosition(83, 20);
                Console.Write(@"\___________________________________/");

                drawCat001();
            } else {

                Console.SetCursorPosition(83, 16);
                Console.Write(@"_____________________________________");

                Console.SetCursorPosition(82, 17);
                Console.Write(@"/                                     \");

                Console.SetCursorPosition(82, 18);
                Console.Write(@"| Email     :                         |");

                Console.SetCursorPosition(82, 19);
                Console.Write(@"| User      :                         |");

                Console.SetCursorPosition(82, 20);
                Console.Write(@"| Password  :                         |");

                Console.SetCursorPosition(82, 21);
                Console.Write(@"|                                     |");

                Console.SetCursorPosition(82, 22);
                Console.Write(@"| Confirm password :                  |");

                Console.SetCursorPosition(82, 23);
                Console.Write(@"\_____________________________________/");

                this.drawDog001();
            }
        }

        public void drawCat001()
        {
            Console.SetCursorPosition(87, 14);
            Console.Write(@"      |\      _,,,---,,_");

            Console.SetCursorPosition(87, 15);
            Console.Write(@"ZZZzz /,`.-'`'    -.  ;-;;,_");

            Console.SetCursorPosition(87, 16);
            Console.Write(@"____ |,4-  ) )-,_. ,\ ( _`'-'");

            Console.SetCursorPosition(87, 17);
            Console.Write(@"    '---''(_/--'  `-'\_)  ");
        }

        public void drawDog001()
        {
            Console.SetCursorPosition(83, 13);
            Console.Write(@"              /\___/\");

            Console.SetCursorPosition(83, 14);
            Console.Write(@"              `)9 9('");
 
            Console.SetCursorPosition(83, 15);
            Console.Write(@"             ={.:Y:.}=");

            Console.SetCursorPosition(83, 16);
            Console.Write(@"______________( )U_'( )");

            Console.SetCursorPosition(83, 17);
            Console.Write(@"              ```   '''");
        }
    }
}