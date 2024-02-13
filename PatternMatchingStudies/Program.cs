using PatternMatchingStudies;
using PatternMatchingStudies.Models;


internal class Program
{
    public static void Main(string[] args)
    {
        Car car = new(EnCarColor.Black, "Civic", "The best", DateTime.Now, false);

        //Console.WriteLine("This is switch result:: " + GetTest(2));
        //TypoTest();
        
        Console.WriteLine(IsCivicCar(car));
    }


    //verify typo and apply operations
    private static void TypoTest()
    {
        object greeting = 1;
        
        if (greeting is string message)
        {
            Console.WriteLine(message.ToLower());
        }
    }


    //switch statement
    private static int GetTest(int a) =>
        a switch
        {
            1 => 20,
            2 => 40,
            _ => throw new ArgumentOutOfRangeException(nameof(a), a, null) // the discard is used to any other options
        };

    
    //switch multiple inputs
    private static bool IsApproved(Student student) =>
        student switch
        {
            {Age: > 18, Average: < 10} => true,
            {Age: < 18, Average: > 7} => true,
            {Age: < 18, Average: < 7} => false,
            _ => throw new ArgumentOutOfRangeException(nameof(student), student, null)
        };


    //pattern match expression
    private static bool IsCivicCar(Car car) => car is { Brand: "Civic", Color: EnCarColor.Black };


    private static bool IsMyCivic(Car car)
    {
        return car.Brand == "Civic" || car.Color == EnCarColor.Black;
    }
}