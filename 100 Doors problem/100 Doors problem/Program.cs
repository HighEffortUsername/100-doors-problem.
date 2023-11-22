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
        for(int i = 0; i < doors.Length; i++)
        {
            int j = 0;
            int move = i + 1;
            while(j < doors.Length)
            {
                if (doors[i] == true)
                {
                    doors[j] = false;
                }
                else
                {
                    doors[j] = true;
                }
                j = j + move;
            }
            //Increments through the doors on each pass.
        }
        //
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