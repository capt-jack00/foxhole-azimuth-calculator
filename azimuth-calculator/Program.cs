namespace azimuth_calculator;

class Program
{
    public static int oppositeAzi;

    static void Main(string[] args)
    {
        System.Console.Write("Enter an azmiuth: ");
        int azi = int.Parse(Console.ReadLine());

        if (azi >= 180)
        {
            oppositeAzi = azi - 180;
        }
        else if (azi < 180)
        {
            oppositeAzi = azi + 180;
        }

        System.Console.WriteLine($"Opposite azimuth for {azi} is: {oppositeAzi}");
    }
}
