namespace connect4
{
    internal static class Code
    {
        private static int playerTurn = 1;
        private static int[,] board = new int[,]
        {
            {0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0},
            {0, 0, 0, 0, 0, 0, 0}
        }; 
        private static void Main(string[] args)
        {
            PrintBoard(board);
            Turn(board);
            PrintBoard(board);
        }

        private static void PrintBoard(int[,] array)
        {
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 7; c++)
                {   
                    if (c + 1 == array.GetLength(1))
                    {
                        Console.Write(board[r, c] + "\n");
                    }
                    else
                    {
                        Console.Write(board[r, c] + "  ");
                    }
                }
            }
        }

        private static void Turn(int[,] array)
        {
            Console.WriteLine($"type the row you want to place a {playerTurn} on");
            string row = Console.ReadLine()!;
            while (Int32.TryParse(row, out int res) != true)
            {
                Console.WriteLine("invalid input, try again");
                Console.WriteLine($"type the row you want to place a {playerTurn} on");
                row = Console.ReadLine()!;
            }
            Console.WriteLine($"type the column you want to place a {playerTurn} on");
            string column = Console.ReadLine()!;
            while (Int32.TryParse(column, out int res) != true)
            {
                Console.WriteLine("invalid input, try again");
                Console.WriteLine($"type the column you want to place a {playerTurn} on");
                column = Console.ReadLine()!;
            }

            int indexrow = Int32.Parse(row) - 1;
            int indexcolumn = Int32.Parse(column) - 1;
            while (array[indexrow, indexcolumn] == 1 || array[indexrow, indexcolumn] == 2)
            {
                Console.WriteLine("that space is already occupied, try again");
                Console.WriteLine($"type the row you want to place a {playerTurn} on");
                row = Console.ReadLine()!;
                Console.WriteLine($"type the column you want to place a {playerTurn} on");
                column = Console.ReadLine()!;
                indexrow = Int32.Parse(row) - 1;
                indexcolumn = Int32.Parse(column) - 1;
            }

            array[indexrow, indexcolumn] = playerTurn;
        }

        private static void check(int[,] array)
        {
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 7; r++)
                {
                   
                }
            }
        }
    }
}
