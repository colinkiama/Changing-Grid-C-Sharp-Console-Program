using ChangingGrid.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangingGrid
{
    class Program
    {
        static char[,] grid = new char[10, 10];
        static movingChar movingCharacter;
        static void Main(string[] args)
        {
            CreateGrid();

            ConsoleKeyInfo keyInfo;
            while (true)
            {
                keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {

                    case ConsoleKey.LeftArrow:
                        MoveCharBack();
                        UpdateGrid();
                        break;

                    case ConsoleKey.RightArrow:
                        MoveCharForward();
                        UpdateGrid();
                        break;

                    case ConsoleKey.UpArrow:
                        MoveCharUp();
                        UpdateGrid();
                        break;

                    case ConsoleKey.DownArrow:
                        MoveCharDown();
                        UpdateGrid();
                        break;
                }



            }

        }

        private static void MoveCharForward()
        {
            RevertChangesToCurrentPosition();
            movingCharacter.MoveForward();
        }

        private static void MoveCharDown()
        {
            movingCharacter.MoveDown();
            RevertChangesToCurrentPosition();
        }

        private static void UpdateGrid()
        {
            Console.Clear();

            ShowTutorial();
            int[] movingNumPosition = movingCharacter.charPosition;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (movingNumPosition[0] == i && movingNumPosition[1] == j)
                    {
                        grid[i, j] = movingChar.characterMoving;
                    }

                    else
                    {
                        grid[i, j] = '-';
                    }
                    Console.Write(grid[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void RevertChangesToCurrentPosition()
        {
            int[] position = movingCharacter.charPosition;
           

            grid[position[0], position[1]] = '-';
        }

        private static void MoveCharUp()
        {
            RevertChangesToCurrentPosition();
            movingCharacter.MoveUp();


        }


        private static void MoveCharBack()
        {
            RevertChangesToCurrentPosition();
            movingCharacter.MoveBack();
        }

       

        static void ReadConsole()
        {
            Console.ReadLine();
        }

        private static void CreateGrid()
        {
            ShowTutorial();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                   
                    if (i == 0 && j == 0)
                    {
                        grid[i, j] = movingChar.characterMoving;
                        movingCharacter = new movingChar(i, j);
                    }
                    else
                    {
                        grid[i, j] = '-';
                    }
                    Console.Write(grid[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void ShowTutorial()
        {
            Console.WriteLine("Use the arrow keys to move the 'x'");
            Console.WriteLine();
        }
    }
}
