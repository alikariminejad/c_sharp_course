class Sample
{
    static void Main()
    {
        decimal a = 10M;
        decimal b = 3M;
        decimal c = a + b; // = 13
        decimal d = a - b; // = 7
        decimal e = a * b; // = 30
        decimal f = a / b; // = 3.3333333
        decimal g = a % b; // = 1

        System.Console.WriteLine(c);
        System.Console.WriteLine(d);
        System.Console.WriteLine(e);
        System.Console.WriteLine(f);
        System.Console.WriteLine(g);
        // Assignment Operators
        a += 20M;
        System.Console.WriteLine(a); // = 30
        a -= 20M;
        System.Console.WriteLine(a); // = 10
        a *= 3M;
        System.Console.WriteLine(a); // = 30
        a /= 3M;
        System.Console.WriteLine(a); // = 10
        a %= 3M;
        System.Console.WriteLine(a); // = 1


        // increment/decrement operators
        a = 10M;
        System.Console.WriteLine(++a); // = 11
        System.Console.WriteLine(a++); // = 11
        System.Console.WriteLine(a);   // = 12
        System.Console.WriteLine(--a); // = 11
        System.Console.WriteLine(a--); // = 11
        System.Console.WriteLine(a);   // = 10

        // comparison operators
        System.Console.WriteLine();
        bool b1 = a == 10;
        System.Console.WriteLine(b1); // true
        bool b2 = a != 10;
        System.Console.WriteLine(b2); // false
        bool b3 = a < 10;
        System.Console.WriteLine(b3); // false
        bool b4 = a > 10;
        System.Console.WriteLine(b4); // false
        bool b5 = a <= 10;
        System.Console.WriteLine(b5); // true
        bool b6 = a >= 10;
        System.Console.WriteLine(b6); // true


        // Logical Operators
        System.Console.WriteLine();
        bool b7 = a == 10 & b == 10;
        System.Console.WriteLine(b7); // = false
        bool b8 = a == 10 && b == 10;
        System.Console.WriteLine(b8); // = false
        bool b9 = a == 10 | b == 10;
        System.Console.WriteLine(b9); // = true
        bool b10 = a == 10 || b == 10;
        System.Console.WriteLine(b10); // = true
        bool b11 = !(a==10);
        System.Console.WriteLine(b11); // = false
        bool b12 = a == 10 ^ b == 10;
        System.Console.WriteLine(b12); // = true

        // concatenation operator
        string name = "Ali";
        int age = 26;
        string message = "Hey " + name + ", your age is: " + age + " years old.";
        System.Console.WriteLine(message);

        // ternary operator
        string title = (age < 13) ? "Child" : (age >= 13 && age <= 19) ? "Teenager" : "Adult"; // = Adult
        System.Console.WriteLine(title);

        // operator precedence
        double z = 10 + 4 * 30 / 10;
        System.Console.WriteLine(z); // = 22

        System.Console.ReadKey();
    }
}