public class Program
{
    // 1. Generic Class Example
    public class MyGenericClass<T>
    {
        private T _value;

        public MyGenericClass(T value)
        {
            _value = value;
        }

        public void DisplayValue()
        {
            Console.WriteLine("Value: " + _value);
        }
    }

    // 2. Generic Method Example
    public class Comparer
    {
        public static T GetMax<T>(T value1, T value2) where T : IComparable<T>
        {
            return value1.CompareTo(value2) > 0 ? value1 : value2;
        }
    }

    // 3. Generic Collection Example with List<T>
    public class GenericCollections
    {
        public static void PrintList<T>(List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    // 4. Generic Constraints Example
    public class MyGenericClassWithConstraint<T> where T : class, new()
    {
        public T CreateInstance()
        {
            return new T();  // Calls the parameterless constructor
        }
    }

    public class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("MyClass instance created!");
        }
    }

    // Main Program demonstrating Generics in action
    public static void Main()
    {
        // 1. Generic Class in Action
        Console.WriteLine("Generic Class Example:");
        MyGenericClass<int> intInstance = new MyGenericClass<int>(10);
        MyGenericClass<string> stringInstance = new MyGenericClass<string>("Generics in C#");

        intInstance.DisplayValue();  // Output: Value: 10
        stringInstance.DisplayValue();  // Output: Value: Generics in C#

        // 2. Generic Method in Action
        Console.WriteLine("\nGeneric Method Example:");
        int maxInt = Comparer.GetMax(10, 20);
        double maxDouble = Comparer.GetMax(7.5, 3.3);

        Console.WriteLine("Max Int: " + maxInt);  // Output: Max Int: 20
        Console.WriteLine("Max Double: " + maxDouble);  // Output: Max Double: 7.5

        // 3. Generic Collection in Action with List<T>
        Console.WriteLine("\nGeneric Collection Example:");
        List<int> intList = new List<int> { 1, 2, 3 };
        GenericCollections.PrintList(intList);  // Output: 1, 2, 3

        // 4. Updated Generic Constraints in Action
        Console.WriteLine("\nGeneric Constraints Example:");
        MyGenericClassWithConstraint<MyClass> instanceCreator = new MyGenericClassWithConstraint<MyClass>();
        MyClass instance = instanceCreator.CreateInstance();  // Output: MyClass instance created!
    }
}
