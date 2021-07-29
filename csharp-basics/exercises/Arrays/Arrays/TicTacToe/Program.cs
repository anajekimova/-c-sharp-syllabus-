using System;
namespace TicTacToe
{
    class Program
    {
        private static char[,] board = new char[3, 3];
        private static char _player;
        private static void Main(string[] args)
        {
            InitBoard();
            DisplayBoard();
            Play();
            IsTie();
        }
        private static void Play()
        {
            Console.WriteLine("Player choose your location on row from 0-2:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Player choose your location on column from 0 - 2:");
            int column = int.Parse(Console.ReadLine());

            if (board[row, column] != ' ') 
                _player = _player == 'X' ? 'X' : 'O';
            else 
                _player = _player == 'X' ? 'O' : 'X';

            board[row, column] = _player;

            Console.Clear();
            DisplayBoard();

            if ((board[0, 0] == 'X' && board[0, 1] == 'X' && board[0, 2] == 'X') || (board[1, 0] == 'X' && board[1, 1] == 'X' && board[1, 2] == 'X')
            || (board[2, 0] == 'X' && board[2, 1] == 'X' && board[2, 2] == 'X') || (board[2, 2] == 'X' && board[1, 1] == 'X' && board[0, 0] == 'X')
            || (board[0, 2] == 'X' && board[1, 1] == 'X' && board[2, 0] == 'X') || (board[0, 0] == 'X' && board[1, 0] == 'X' && board[2, 0] == 'X')
            || (board[0, 1] == 'X' && board[1, 1] == 'X' && board[2, 1] == 'X') || (board[0, 2] == 'X' && board[1, 2] == 'X' && board[2, 2] == 'X'))
            {
                Console.WriteLine(" Player X is won!");
            }
            else if (((board[0, 0] == 'O' && board[0, 1] == 'O' && board[0, 2] == 'O') || (board[1, 0] == 'O' && board[1, 1] == 'O' && board[1, 2] == 'O')
            || (board[2, 0] == 'O' && board[2, 1] == 'O' && board[2, 2] == 'O') || (board[2, 2] == 'O' && board[1, 1] == 'O' && board[0, 0] == 'O')
            || (board[0, 2] == 'O' && board[1, 1] == 'O' && board[2, 0] == 'O') || (board[0, 0] == 'O' && board[1, 0] == 'O' && board[2, 0] == 'O')
            || (board[0, 1] == 'O' && board[1, 1] == 'O' && board[2, 1] == 'O') || (board[0, 2] == 'O' && board[1, 2] == 'O' && board[2, 2] == 'O'))
            )
            {
                Console.WriteLine(" Player O is won!");
            }
            else
            {
                IsTie();
                Console.ReadKey();
            }
        }
        private static void IsTie()
        {
            int move = 9;
            foreach (var i in board)
            {
                if (i != ' ')
                {
                    move--;
                    if (move == 0)
                    {
                        Console.WriteLine("Game is a tie!");
                    }
                }
                else { Play(); }
            }
            Console.ReadKey();
        }
        private static void InitBoard()
        {
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }
        private static void DisplayBoard()
        {
            Console.WriteLine("\n");
            Console.WriteLine("       0   1   2  ");
            Console.WriteLine("     +---+---+---+");
            Console.WriteLine("  0  | " + board[0, 0] + " | " + board[0, 1] + " | " + board[0, 2] + " |");
            Console.WriteLine("     +---+---+---+");
            Console.WriteLine("  1  | " + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2] + " |");
            Console.WriteLine("     +---+---+---+");
            Console.WriteLine("  2  | " + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2] + " |");
            Console.WriteLine("     +---+---+---+");
            Console.WriteLine("\n");
        }
    }
}
