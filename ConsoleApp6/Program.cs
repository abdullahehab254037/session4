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

            #region question9
            //Write a method PrintFirstBook() that prints the first book in the books array.
            //If the array is empty, use return to exit the method early instead of printing anything.
            //string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            //PrintFirstBook();
            //void PrintFirstBook()
            //{
            //    if (books.Length == 0) { return; }
            //    Console.WriteLine(books[0]);
            //}
            //
            #endregion


            #region question10
            //1-Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.
            //Print both title and upperTitle to show that title did not change.
            //string title = "clean code";
            //string upper=title.ToUpper();
            //Console.WriteLine(upper);
            //Console.WriteLine(title);
            //

            #endregion

            #region question11
            //Declare two separate string variables, both set to the literal "Clean Code".
            //Use ReferenceEquals() to check if they point to the same object in memory.
            //string title1 = "Clean Code";
            //string title2 = "Clean Code";
            //
            //bool sameObject = ReferenceEquals(title1, title2);
            //Console.WriteLine(sameObject);
            #endregion

            #region question14
            //-Given string title = "Clean Code"; and int pages = 464;,
            //build the sentence "Book: Clean Code, Pages: 464" using the + operator. 
            //string title = "Clean Code";
            //int pages = 464;
            //
            //string sentence = "Book: " + title + ", Pages: " + pages;
            //Console.WriteLine(sentence);
            #endregion

            #region question15
            //6-Build the same sentence as above, but using string interpolation ($"...").

            //string title = "Clean Code";
            //int pages = 464;
            //
            //string sentence = $"Book: {title}, Pages: {pages}";
            //Console.WriteLine(sentence);
            #endregion


        }
    }
}
