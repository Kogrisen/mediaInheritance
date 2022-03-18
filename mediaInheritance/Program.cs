using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaInheritance
{
    internal class Program
    {
        static List<Book> book_item = new List<Book>();
        static List<Film> film_item = new List<Film>();
        static List<Game> game_item = new List<Game>();

        static void Main(string[] args)
        {

            bool quit = false;
            char user_choice;

            while (quit == false)
            {
                Console.WriteLine("What would you like to do:\nEnter a\n1. book\n2. Film\n3. Game\n\nor\n4. View list(s)\n5. exit");
                char.TryParse(Console.ReadLine(), out user_choice);

                switch (user_choice)
                {
                    case '1':
                        AddBook();
                        Console.WriteLine();
                        break;
                    case '2':
                        AddFilm();
                        Console.WriteLine();
                        break;
                    case '3':
                        AddGame();
                        Console.WriteLine();
                        break;
                    case '4':
                        Console.WriteLine("What list would you like to view?\n1. Books\n2. Films\n3. Games\n4. All");
                        ViewList(int.Parse(Console.ReadLine()));
                        Console.WriteLine();
                        break;
                    case '5':
                        //exit
                        quit = true;
                        break;
                    default:
                        break;
                }
            }
        }

        private static void AddGame()
        {
            Console.Write("Title: ");
            string temp_game_title = Console.ReadLine().ToString();
            Console.Write("Genre: ");
            string temp_game_genre = Console.ReadLine().ToString();
            Console.Write("Multiplayer (y/n): ");
            var input = Console.ReadLine().ToString();
            bool temp_multiplayer = input == "y" || input == "Y" || input == "yes" || input == "Yes";
            Console.Write("Year of Release: ");
            string temp_game_year = Console.ReadLine().ToString();
            Console.Write("Studio: ");
            string temp_game_studio = Console.ReadLine().ToString();
            Console.Write("Publisher: ");
            string temp_game_publisher = Console.ReadLine().ToString();
            game_item.Add(new Game(temp_game_title, temp_game_genre, temp_game_year, temp_multiplayer, temp_game_studio, temp_game_publisher));
        }

        private static void AddFilm()
        {

            bool parse_success = false;
            int temp_length_film = 0;

            Console.Write("Title: ");
            string temp_name_film = Console.ReadLine().ToString();
            Console.Write("Director: ");
            string temp_director = Console.ReadLine().ToString();
            while (!parse_success)
            {
                Console.Write("Length in minutes: ");
                if (int.TryParse(Console.ReadLine(), out temp_length_film) && temp_length_film > 0)
                {
                    parse_success = true;
                }
                else
                {
                    Console.WriteLine("Incorrect value, please enter a numeric value greater then 0.");
                }
            }
            Console.Write("Year of Premiere: ");
            string temp_year_film = Console.ReadLine().ToString();
            Console.Write("Studio: ");
            string temp_filmstudio = Console.ReadLine().ToString();
            film_item.Add(new Film(temp_name_film, temp_year_film, temp_director, temp_length_film, temp_filmstudio));
        }

        private static void AddBook()
        {
            bool parse_success = false;
            int temp_length = 0;

            Console.Write("Title: ");
            string temp_name = Console.ReadLine().ToString();
            Console.Write("Author: ");
            string temp_author = Console.ReadLine().ToString();
            while (!parse_success)
            { 
                Console.Write("Number of pages: ");
                if (int.TryParse(Console.ReadLine(), out temp_length) && temp_length > 0)
                {
                    parse_success = true;
                }
                else
                {
                    Console.WriteLine("Incorrect value, please enter a numeric value greater then 0.");
                }
            }
            Console.Write("Year first published: ");
            string temp_year = Console.ReadLine();
            Console.Write("Publisher: ");
            string temp_publisher = Console.ReadLine().ToString();
            book_item.Add(new Book(temp_name, temp_year, temp_author, temp_length, temp_publisher));
        }

        private static void ViewList(int choice)
        {
            switch (choice)
            {
                case 1:
                    ViewBooks();
                    break;
                case 2:
                    ViewFilms();
                    break;
                case 3:
                    ViewGames();
                    break;
                case 4:
                    ViewBooks();
                    ViewFilms();
                    ViewGames();
                    break;
                default:
                    break;
            }
        }

        private static void ViewGames()
        {
            Console.WriteLine();
            Console.WriteLine("Complete list of games:");
            Console.WriteLine();
            for (int current_item = 0; current_item < game_item.Count; current_item++)
            {
                Console.WriteLine(game_item[current_item].ToString());
            }
        }

        private static void ViewFilms()
        {
            Console.WriteLine();
            Console.WriteLine("Complete list of films:");
            Console.WriteLine();
            for (int current_item = 0; current_item < film_item.Count; current_item++)
            {
                Console.WriteLine(film_item[current_item].ToString());
            }
        }

        private static void ViewBooks()
        {
            Console.WriteLine();
            Console.WriteLine("Complete list of books:");
            Console.WriteLine();
            for (int current_item = 0; current_item < book_item.Count; current_item++)
            {
                Console.WriteLine(book_item[current_item].ToString());
            }
        }
    }
}
