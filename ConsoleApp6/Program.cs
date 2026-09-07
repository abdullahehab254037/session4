namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            //Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if the title is "Clean Code",
            //"Nice pick!" if it's "Refactoring", and "Never heard of it" for anything else.
            //string title = "Refactoring";
            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;
            //    case "Refactoring":
            //        Console.WriteLine("nice pick!");
            //        break;
            //        default: Console.WriteLine("Never heard of it");
            //        break;
            //}

            #endregion

            #region question2 
            //Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book" into a variable sizeLabel
            //(same rule as question 8: long if pages > 300). 
            //string sizelabel;
            //int pages = 464;
            //sizelabel = pages > 300 ? "long book" : "short book";
            //Console.WriteLine(sizelabel);
            #endregion

            #region question3
            //Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };,
            //use a for loop to print each book with its position number, like 1. Clean Code.
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //     Console.WriteLine((i+1)+"."+books[i]);
            //   
            //}

            #endregion

            #region question4
            //Using the same books array, use a while loop to print every book title. 
            //int i = 0;
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //while (i<books.Length)
            //{
            //    Console.WriteLine((i + 1) + "." + books[i]);
            //    i++;
            //}
            #endregion

            #region question5
            //Write a do-while loop that prints "Checking book..." exactly 3 times.
            //int count = 0;
            //do
            //{
            //    Console.WriteLine("Checking book");
            //    count++;
            //}
            //while (count < 3);

            #endregion

            #region question6
            //Using the same books array, use a foreach loop to print every book title. 
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //foreach (string book in books) 
            //{
            //    Console.WriteLine(book);
            //}
            #endregion

            #region question7
            //Using the same books array, loop through it and print each
            //title, but stop completely (break) once you reach "Refactoring". 
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //for (int i = 0; i < books.Length; i++)
            //{
            //    if (books[i]== "Refactoring") { break; }
            //     Console.WriteLine((i+1)+"."+books[i]);
            //   
            //}
            #endregion

            #region question8
            //Using the same books array, print every title except "The Pragmatic Programmer"
            //(skip it with continue, don't stop the loop).

            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //
            //foreach (string book in books)
            //{
            //    if (book == "The Pragmatic Programmer")
            //    {
            //        continue;
            //    }
            //
            //    Console.WriteLine(book);
            //}
            #endregion

        }
    }
}
