using System;
using System.Collections.Generic;

namespace _04.Re_factorAndImproveTheCode
{
    class Program
    {
		private const int BoardRows = 5;
		private const int BoardColumns = 10;
		private const int BombCount = 15;
		static void Main(string[] args)
		{
			string command = string.Empty;
			char[,] gameField = createGameField();
			char[,] bombs = setBombs();
			int counterOfPoints = 0;
			bool isGameOver = false;
			List<Score> ranking = new List<Score>(6);
			int positionRow = 0;
			int positionColumn = 0;
			bool isFirstInteraction = true;
			const int MaxMoves = BoardColumns * BoardRows - BombCount;
			bool areMadeMaxMoves = false;

			do
			{
				if (isFirstInteraction)
				{
					Console.WriteLine("Let's play 'Mines'. Try your luck to find cells without mines." +
					" Command 'top' show ranking, 'restart' start new game, 'exit' quit the game");
					printGameField(gameField);
					isFirstInteraction = false;
				}
				Console.Write("Input row and column : ");
				command = Console.ReadLine().Trim();
				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out positionRow) &&
					int.TryParse(command[2].ToString(), out positionColumn) &&
						positionRow <= gameField.GetLength(0) && positionColumn <= gameField.GetLength(1))
					{
						command = "turn";
					}
				}
				switch (command)
				{
					case "top":
						printRanking(ranking);
						break;
					case "restart":
						gameField = createGameField();
						bombs = setBombs();
						printGameField(gameField);
						isGameOver = false;
						isFirstInteraction = false;
						break;
					case "exit":
						Console.WriteLine("Bye , bye!");
						break;
					case "turn":
						if (bombs[positionRow, positionColumn] != '*')
						{
							if (bombs[positionRow, positionColumn] == '-')
							{
								makeTurn(gameField, bombs, positionRow, positionColumn);
								counterOfPoints++;
							}
							if (MaxMoves == counterOfPoints)
							{
								areMadeMaxMoves = true;
							}
							else
							{
								printGameField(gameField);
							}
						}
						else
						{
							isGameOver = true;
						}
						break;
					default:
						Console.WriteLine("\nError! Invalid command.\n");
						break;
				}
				if (isGameOver)
				{
					printGameField(bombs);
					Console.Write("\nHrrrrrr! You die heroically with {0} points. " +
						"Input nickname: ", counterOfPoints);
					string nickname = Console.ReadLine();
					Score playerScore = new Score(nickname, counterOfPoints);
					if (ranking.Count < 5)
					{
						ranking.Add(playerScore);
					}
					else
					{
						for (int i = 0; i < ranking.Count; i++)
						{
							if (ranking[i].Points < playerScore.Points)
							{
								ranking.Insert(i, playerScore);
								ranking.RemoveAt(ranking.Count - 1);
								break;
							}
						}
					}
					ranking.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.Name.CompareTo(firstPlayer.Name));
					ranking.Sort((Score firstPlayer, Score secondPlayer) => secondPlayer.Points.CompareTo(firstPlayer.Points));
					printRanking(ranking);

					gameField = createGameField();
					bombs = setBombs();
					counterOfPoints = 0;
					isGameOver = false;
					isFirstInteraction = true;
				}
				if (areMadeMaxMoves)
				{
					Console.WriteLine("\nGood job! You open {0} cells without a drop of blood.", MaxMoves);
					printGameField(bombs);
					Console.WriteLine("Input your nickname: ");
					string nickname = Console.ReadLine();
					Score playerScore = new Score(nickname, counterOfPoints);
					ranking.Add(playerScore);
					printRanking(ranking);
					gameField = createGameField();
					bombs = setBombs();
					counterOfPoints = 0;
					areMadeMaxMoves = false;
					isFirstInteraction = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria!");
			Console.WriteLine("Byee.");
			Console.Read();
		}

		private static void printRanking(List<Score> ranking)
		{
			Console.WriteLine("\nRanking:");
			if (ranking.Count > 0)
			{
				for (int i = 0; i < ranking.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} cells",
						i + 1, ranking[i].Name, ranking[i].Points);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("ranking is empty!\n");
			}
		}

		private static void makeTurn(char[,] gameField, char[,] bombs, int row, int column)
		{
			char countBombs = getCountBombs(bombs, row, column);
			bombs[row, column] = countBombs;
			gameField[row, column] = countBombs;
		}

		private static void printGameField(char[,] board)
		{
			int countRows = board.GetLength(0);
			int countColumns = board.GetLength(1);

			Console.Write("\n    ");
			for (int i = 0; i < countColumns; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < countRows; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < countColumns; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] createGameField()
		{
			int boardRows = BoardRows;
			int boardColumns = BoardColumns;
			char[,] board = new char[boardRows, boardColumns];
			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] setBombs()
		{
			int boardRows = BoardRows;
			int boardColumns = BoardColumns;
			char[,] board = new char[boardRows, boardColumns];

			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '-';
				}
			}

			List<int> randomBombIndexes = new List<int>();
			while (randomBombIndexes.Count < BombCount)
			{
				Random random = new Random();
				int randomNumber = random.Next(boardRows * boardColumns);
				if (!randomBombIndexes.Contains(randomNumber))
				{
					randomBombIndexes.Add(randomNumber);
				}
			}

			foreach (int cellIndex in randomBombIndexes)
			{
				int column = (cellIndex / boardColumns);
				int row = (cellIndex % boardColumns);
				if (row == 0 && cellIndex != 0)
				{
					column--;
					row = boardColumns;
				}
				else
				{
					row++;
				}
				board[column, row - 1] = '*';
			}

			return board;
		}

		private static void smetki(char[,] gameField)
		{
			int countColumns = gameField.GetLength(0);
			int countRows = gameField.GetLength(1);

			for (int i = 0; i < countColumns; i++)
			{
				for (int j = 0; j < countRows; j++)
				{
					if (gameField[i, j] != '*')
					{
						char countBombs = getCountBombs(gameField, i, j);
						gameField[i, j] = countBombs;
					}
				}
			}
		}

		private static char getCountBombs(char[,] gameField, int row, int column)
		{
			int counterBombs = 0;
			int countRows = gameField.GetLength(0);
			int countColumns = gameField.GetLength(1);

			if (row - 1 >= 0)
			{
				if (gameField[row - 1, column] == '*')
				{
					counterBombs++;
				}
			}
			if (row + 1 < countRows)
			{
				if (gameField[row + 1, column] == '*')
				{
					counterBombs++;
				}
			}
			if (column - 1 >= 0)
			{
				if (gameField[row, column - 1] == '*')
				{
					counterBombs++;
				}
			}
			if (column + 1 < countColumns)
			{
				if (gameField[row, column + 1] == '*')
				{
					counterBombs++;
				}
			}
			if ((row - 1 >= 0) && (column - 1 >= 0))
			{
				if (gameField[row - 1, column - 1] == '*')
				{
					counterBombs++;
				}
			}
			if ((row - 1 >= 0) && (column + 1 < countColumns))
			{
				if (gameField[row - 1, column + 1] == '*')
				{
					counterBombs++;
				}
			}
			if ((row + 1 < countRows) && (column - 1 >= 0))
			{
				if (gameField[row + 1, column - 1] == '*')
				{
					counterBombs++;
				}
			}
			if ((row + 1 < countRows) && (column + 1 < countColumns))
			{
				if (gameField[row + 1, column + 1] == '*')
				{
					counterBombs++;
				}
			}
			return char.Parse(counterBombs.ToString());
		}
	}
}
