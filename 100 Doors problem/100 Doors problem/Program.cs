internal class Program
{
    private static void Main(string[] args)
    {
        bool[] doors = new bool[100];
        for (int i = 0; i < doors.Length; i++)
        {
            doors[i] = false;
            int pos = i + 1;
            Console.WriteLine("Door" + pos + " is closed");
        }
        // Creates array and sets every door to closed.
        for(int i = 1; i <= doors.Length; i++)
        {
            for (int j = i - 1; j < doors.Length; j = j + i)
            {
                doors[j] = !doors[j];
                Console.WriteLine(j);
            }
            //Increments through the doors on each pass.
        }
        // Increments through each pass.
        for(int i = 0; i < doors.Length; i++)
        {
            int pos = i + 1;
            if (doors[i] == true)
            {
                Console.WriteLine("Door" + pos + " is open.");
            }
            else
            {
                Console.WriteLine("Door" + pos + " is closed.");
            }
        }
        //outputs the final array.
    }
}