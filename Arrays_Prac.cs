public class Array_Prac1
{
    public static void array1()
    {
        int[] marks = new int[5];
        marks[0] = 10;
        marks[1] = 11;
        marks[2] = 12;
        marks[3] = 13;
        marks[4] = 14;

        Console.WriteLine("\nPrinting array");
        for(int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine(marks[i]);
        }

        //Accessing elemnets

        int highestMarks=0;
        for(int i = 0; i < marks.Length; i++)
        {
            if (marks[i] > highestMarks)
            {
                highestMarks = marks[i];
            }
            
        }
        Console.WriteLine("Highest " + highestMarks);

        int sum = 0;
        for (int i = 0; i < marks.Length; i++) { 
            sum=sum+marks[i];
        }
        Console.WriteLine("\nTotal" + sum);


    }

    public static void MultiArray()
    {
        int[,] matrix = new int[2, 3];
        matrix[0,0]= 1;
        matrix[0,1] = 2;
        matrix[0,2] = 3;
        matrix[1, 0] = 4;
        matrix[1, 1] = 5;
        matrix[1, 2] = 6;

        Console.WriteLine("\nMatrix values:");
        for (int i = 0; i < 2; i++)        // Rows
        {
            for (int j = 0; j < 3; j++)    // Columns
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine(); 
        }

    }

    public static void JaggedArray()
    {
        int[][] jaggedArray = new int[3][];

        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 2, 3 };
        jaggedArray[2] = new int[] { 4, 5, 9, 12, 11 };

        Console.WriteLine(jaggedArray[2][4]);

        Console.WriteLine(jaggedArray[0][2]);
        Console.Write(jaggedArray[1][1]);
    }


}