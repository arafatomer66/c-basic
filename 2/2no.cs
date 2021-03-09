class Program {
    static void Main(string[] args) {
            var number = 1;
            var text = number.ToEnglishNumber(); // Consider only 0 to 9 conversion
            Console.WriteLine(text); // This will output: One
    }
}


public static class ExtensionMethodClass {  
    public static bool ToEnglishNumber(this int input) {  
        // converting 
        return result;  
    }  
} 