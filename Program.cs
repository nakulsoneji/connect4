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
            while (check(board) == 0)
            {
                Turn(board);
            
                PrintBoard(board);
            }
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
            Console.WriteLine($"type the column you want to place a {playerTurn} on");
            string column = Console.ReadLine()!;
            while (Int32.TryParse(column, out int res) != true)
            {
                Console.WriteLine("invalid input, try again");
                Console.WriteLine($"type the column you want to place a {playerTurn} on");
                column = Console.ReadLine()!;
            }
            while (Int32.Parse(column) > 7 || Int32.Parse(column) < 1 || array[0, Int32.Parse(column) - 1] != 0)
            {
                Console.WriteLine("you can only input from 1 - 7 and not in a filled column");
                Console.WriteLine($"type the column you want to place a {playerTurn} on");
                column = Console.ReadLine()!;
            }
            for (int i = 5; i > -1; i--)
            {
                if (array[i, Int32.Parse(column) - 1] == 0)
                {
                    array[i, Int32.Parse(column) - 1] = playerTurn;
                    break;
                }
                else
                {
                    continue;
                }
            }
            switch (playerTurn)
            {
                case 1:
                    playerTurn = 2;
                    break;
                case 2:
                    playerTurn = 1;
                    break;
            }
        }   

        private static int check(int[,] array)
        {
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (c + 3 <= 6 && c + 2 <= 6 && c + 1 <= 6)
                    {
                        if (array[r, c] == array[r, c + 1] &&
                            array[r, c + 1] == array[r, c + 2] &&
                            array[r, c + 2] == array[r, c + 3] &&
                            array[r, c + 3] == array[r, c] &&
                            array[r, c] != 0)
                        {
                            Console.WriteLine($"{array[r, c]} wins!");
                            return array[r, c];  
                        }
                        
                    }
                }
            }
            for (int c = 0; c < 7; c++)
            {
                for (int r = 0; r < 6; r++)
                {
                    if (r + 3 <= 5 && r + 2 <= 5 && r + 1 <= 5)
                    {
                        if (array[r, c] == array[r + 1, c] &&
                            array[r + 1, c] == array[r + 2, c] &&
                            array[r + 2, c] == array[r + 3, c] &&
                            array[r + 3, c] == array[r, c] &&
                            array[r, c] != 0)
                        {
                            Console.WriteLine($"{array[r, c]} wins!");
                            return array[r, c];  
                        }
                        
                    }
                }
            }
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    if (c + 3 <= 6 && c + 2 <= 6 && c + 1 <= 6 && 
                    r + 3 <= 5 && r + 2 <= 5 && r + 1 <= 5)
                    {
                        if (array[r, c] == array[r + 1, c + 1] &&
                            array[r + 1, c + 1] == array[r + 2, c + 2] &&
                            array[r + 2, c + 2] == array[r + 3, c + 3] &&
                            array[r + 3, c + 3] == array[r, c] &&
                            array[r, c] != 0)
                        {
                            Console.WriteLine($"{array[r, c]} wins!");
                            return array[r, c];  
                        }
                        
                    }
                    if (c - 3 >= 0 && c - 2 >= 0 && c - 1 >= 0 && 
                    r - 3 >= 0 && r - 2 >= 0 && r - 1 >= 0)
                    {
                        Console.WriteLine($"r: {r}");
                        Console.WriteLine($"c: {c}");
                        if (array[r, c] == array[r - 1, c - 1] &&
                            array[r - 1, c - 1] == array[r - 2, c - 2] &&
                            array[r - 2, c - 2] == array[r - 3, c - 3] &&
                            array[r - 3, c - 3] == array[r, c] &&
                            array[r, c] != 0)
                        {
                            Console.WriteLine($"{array[r, c]} wins!");
                            return array[r, c];  
                        }
                        
                    }
                }
            }
            

            return 0;
        }
    }
}
