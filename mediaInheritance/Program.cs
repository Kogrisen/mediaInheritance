using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaInheritance
{
    internal class Program
    {

        static List<Media> archive_item = new List<Media>();
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
                        break;
                    case '4':
                        //view list
                        for (int current_item = 0; current_item < archive_item.Count; current_item++)
                        {
                            Console.WriteLine(archive_item[current_item].ToString());
                        }
                        break;
                    case '5':
                        //exit
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
