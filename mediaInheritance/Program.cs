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
                Console.WriteLine("What would you like to enter:\n1. a book\n2. a Film\n3. a Game\n4. View list\n5. exit");
                char.TryParse(Console.ReadLine(), out user_choice);

                switch (user_choice)
                {
                    case '1':
                        //add a film
                        Console.Write("Title: ");
                        string temp_name = Console.ReadLine().ToString();
                        Console.Write("Author: ");
                        string temp_author = Console.ReadLine().ToString();
                        Console.Write("Number of pages: ");
                        int temp_length = int.Parse(Console.ReadLine());
                        Console.Write("Year first published: ");
                        string temp_year = Console.ReadLine();
                        Console.Write("Publisher: ");
                        string temp_publisher = Console.ReadLine().ToString();
                        book_item.Add(new Book(temp_name, temp_year, temp_author, temp_length, temp_publisher));
                        break;
                    case '2':
                        //add a film
                        Console.WriteLine("Title: ");
                        string temp_name_film = Console.ReadLine().ToString();
                        Console.Write("Director: ");
                        string temp_director = Console.ReadLine().ToString();
                        Console.Write("Length in minutes: ");
                        int temp_length_film = int.Parse(Console.ReadLine());
                        Console.Write("Year of Premiere: ");
                        string temp_year_film = Console.ReadLine().ToString();
                        Console.Write("Studio");
                        string temp_filmstudio = Console.ReadLine().ToString();
                        film_item.Add(new Film (temp_name_film, temp_year_film, temp_director, temp_length_film, temp_filmstudio));
                        break;
                    case '3':
                        //add a game
                        //public Game(string title, string genre, string release_year, bool multiplayer, string creator, string publisher)

                        Console.Write("Title: ");
                        string temp_game_title = Console.ReadLine().ToString();
                        Console.Write("Genre: ");
                        string temp_game_genre = Console.ReadLine().ToString();
                        Console.Write("Multiplayer (y/n): ");
                        var input = Console.ReadLine();
                        bool temp_multiplayer = input == "y" || input == "Y" || input == "yes" || input == "Yes";
                        Console.Write("Year of Release: ");
                        string temp_game_year = Console.ReadLine().ToString();
                        Console.Write("Studio: ");
                        string temp_game_studio = Console.ReadLine().ToString();
                        Console.Write("Publisher: ");
                        string temp_game_publisher = Console.ReadLine().ToString();
                        game_item.Add(new Game(temp_game_title, temp_game_genre, temp_game_year, temp_multiplayer, temp_game_studio, temp_game_publisher));
                        break;
                    case '4':
                        //view list
                        Console.Write("What list would you like to view?\n1. Books\n2. Films\n3. Games\n4. All");
                        ViewList(int.Parse(Console.ReadLine()));
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

        private static void ViewList(int choice)
        {
            var list_choice = choice;

            switch (choice)
            {
                case 1:
                    //view book lists
                    Console.WriteLine();
                    for (int current_item = 0; current_item < book_item.Count; current_item++)
                    {
                        Console.WriteLine(book_item[current_item].ToString());
                    }
                    break;
                case 2:
                    //view film lists
                    Console.WriteLine();
                    for (int current_item = 0; current_item < film_item.Count; current_item++)
                    {
                        Console.WriteLine(film_item[current_item].ToString());
                    }
                    break;
                case 3:
                    //view game lists
                    Console.WriteLine();
                    for (int current_item = 0; current_item < game_item.Count; current_item++)
                    {
                        Console.WriteLine(game_item[current_item].ToString());
                    }
                    break;
                case 4:
                    //view all lists
                    Console.WriteLine();
                    for (int current_item = 0; current_item < book_item.Count; current_item++)
                    {
                        Console.WriteLine(book_item[current_item].ToString());
                    }
                    Console.WriteLine();
                    for (int current_item = 0; current_item < film_item.Count; current_item++)
                    {
                        Console.WriteLine(film_item[current_item].ToString());
                    }
                    Console.WriteLine();
                    for (int current_item = 0; current_item < game_item.Count; current_item++)
                    {
                        Console.WriteLine(game_item[current_item].ToString());
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
