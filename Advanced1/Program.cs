using Advanced1;

internal class Program
{
    private static void Main(string[] args)
    {

        // 1 ir 2 exercise---------------
        //Person person = new Person("Tadas", 50);
        //person.Height = 1.50;

        //Console.WriteLine($"Name: {person.Name}, age: {person.Age}, height: {person.Height} m.");

        //Exercise 3 and 4 ---------------

        //School school = new School();

        //Console.WriteLine($"School name: {school.SchoolName}\n" +
        //    $"City: {school.City}\n" +
        //    $"Students in school: {school.StudentNumber}\n");

        //Exercise 5 and 6 ---------------

        //Book book = new Book();
        //book.Title = "YEY";
        //book.Author = "LALA";
        //book.Year = 2024;

        //Console.WriteLine($"Book name: {book.Title}\n" +
        //    $"Author: {book.Author}\n" +
        //    $"Year of publication of the book: {book.Year}\n" +
        //    $"Release country: {book.BookReleaseCountry}\n");

        //Exercise 7 ---------------
        //List<Book> bookList = new List<Book>();

        //Book firstBook = new Book("AaaA1", "First author", 1998, "Warsaw");
        //bookList.Add(firstBook);

        //Book secondBook = new Book("AaaA2", "First author", 2000, "London");
        //bookList.Add(secondBook);

        //Book thirdBook = new Book("AaaA3", "Second author", 2014, "Miami");
        //bookList.Add(thirdBook);

        //Book fourthBook = new Book("AaaA4", "First author", 2020, "Washington");
        //bookList.Add(fourthBook);

        //List<Book> bookList2 = Book.SearchForAuthor(bookList, "First author");

        //foreach (Book book in bookList2)
        //{
        //    Console.WriteLine(book.Title);
        //}

        //Exercise 2.4. ---------------

        //List<string> items1 = new List<string>() { "Orange", "Cucumber", "Banana" };
        //List<string> items2 = new List<string>() { "Coke", "Sprite", "Mirinda" };

        //Store firstStore = new Store(items1);
        //Store secondStore = new Store(items2);
        //Store thirdStore = new Store();

        //firstStore.Name = "Maxima";
        //secondStore.Name = "Lidl";
        //thirdStore.Name = "Rimi";

        //List<string> items3 = Store.ReturnItemList();

        //Store.Print(firstStore.Name, items3);
        //Store.Print(secondStore.Name, items3);


        //Exercise 3.1. ---------------

        PetColor brown = new PetColor();
        brown.Color = "Brown";

        PetColor yellow = new PetColor();
        yellow.Color = "Yellow";

        PetColor green = new PetColor();
        green.Color = "Green";

        PetName dogName = new PetName();
        dogName.Name = "Squeezi";

        PetName catName = new PetName();
        catName.Name = "Whitee";

        PetName hamsterName = new PetName();
        hamsterName.Name = "Hamsti";

        PetWeight dogWeight = new PetWeight();
        dogWeight.Weight = 20;

        PetWeight catgWeight = new PetWeight();
        catgWeight.Weight = 10;

        PetWeight hamsterWeight = new PetWeight();
        hamsterWeight.Weight = 0.2;

        Dog dog = new Dog(dogName, dogWeight, brown);
        Cat cat = new Cat(catName, catgWeight, yellow);
        Hamster hamster = new Hamster(hamsterName, hamsterWeight, green);

        //PrintNames(dog, cat, hamster);

        //Exercise 3.2. ---------------

        List<Dog> dogs = new List<Dog>();
        List<Cat> cats = new List<Cat>();
        List<Hamster> hamsters = new List<Hamster>();

        dogs.Add(dog);
        dogs.Add(dog);
        dogs.Add(dog);
        dogs.Add(dog);
        dogs.Add(dog);
        dogs.Add(dog);

        cats.Add(cat);
        cats.Add(cat);
        cats.Add(cat);

        hamsters.Add(hamster);
        hamsters.Add(hamster);
        hamsters.Add(hamster);
        hamsters.Add(hamster);
        hamsters.Add(hamster);
        hamsters.Add(hamster);

        //PetNameAntQtyDictionary(dogs, cats, hamsters);

        //Exercise 3.3. ---------------
    }

    //Exercise 3.1. ---------------
    public static void PrintNames(Dog dog, Cat cat, Hamster hamster)
    {
        Console.WriteLine(dog.DogName.Name);
        Console.WriteLine(cat.CatName.Name);
        Console.WriteLine(hamster.HamsterName.Name);
    }

    //Exercise 3.2. ---------------
    public static Dictionary<string, int> PetNameAntQtyDictionary(List<Dog> dogs, List<Cat> cats, List<Hamster> hamsters)
    {
        Dictionary<string, int> petNameAntQty = new Dictionary<string, int>();

        petNameAntQty.Add("Dog", dogs.Count);
        petNameAntQty.Add("Cat", cats.Count);
        petNameAntQty.Add("Hamster", hamsters.Count);

        return petNameAntQty;
    }
}
