

public class Student 
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program {
    static void Main(string[] args) {

        List<string> list = new List<string>();

        list.add(new Student("Rahim" , 29 ));
        list.add(new Student("Karim" , 30 ));
        list.add(new Student("Ashiq" , 23 ));
        list.add(new Student("Masud" , 30 ));
        list.add(new Student("Ashiq" , 30 ));


        var sorted = from element in list
                      orderby element.Name ascending
                      select element;

        foreach (string value in sorted)
        {
            Console.WriteLine(value);
        }

    }
}

// For technical reasons i used online editor . i am out of dhaka .
