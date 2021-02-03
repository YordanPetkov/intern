using System;
using System.Collections.Generic;

namespace _04.Re_factorAndImproveTheCode
{
    class Program
    {
		static void Main(string[] аргументи)
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
			const int maxMoves = 35;
			bool areMadeMaxMoves = false;

			do
			{
				if (isFirstInteraction)
				{
					Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
					" Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
					printGameField(gameField);
					isFirstInteraction = false;
				}
				Console.Write("Daj red i kolona : ");
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
						Console.WriteLine("4a0, 4a0, 4a0!");
						break;
					case "turn":
						if (bombs[positionRow, positionColumn] != '*')
						{
							if (bombs[positionRow, positionColumn] == '-')
							{
								makeTurn(gameField, bombs, positionRow, positionColumn);
								counterOfPoints++;
							}
							if (maxMoves == counterOfPoints)
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
						Console.WriteLine("\nGreshka! nevalidna Komanda\n");
						break;
				}
				if (isGameOver)
				{
					printGameField(bombs);
					Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
						"Daj si niknejm: ", counterOfPoints);
					string niknejm = Console.ReadLine();
					Score t = new Score(niknejm, counterOfPoints);
					if (ranking.Count < 5)
					{
						ranking.Add(t);
					}
					else
					{
						for (int i = 0; i < ranking.Count; i++)
						{
							if (ranking[i].Points < t.Points)
							{
								ranking.Insert(i, t);
								ranking.RemoveAt(ranking.Count - 1);
								break;
							}
						}
					}
					ranking.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
					ranking.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
					printRanking(ranking);

					gameField = createGameField();
					bombs = setBombs();
					counterOfPoints = 0;
					isGameOver = false;
					isFirstInteraction = true;
				}
				if (areMadeMaxMoves)
				{
					Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
					printGameField(bombs);
					Console.WriteLine("Daj si imeto, batka: ");
					string imeee = Console.ReadLine();
					Score to4kii = new Score(imeee, counterOfPoints);
					ranking.Add(to4kii);
					printRanking(ranking);
					gameField = createGameField();
					bombs = setBombs();
					counterOfPoints = 0;
					areMadeMaxMoves = false;
					isFirstInteraction = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.WriteLine("AREEEEEEeeeeeee.");
			Console.Read();
		}

		private static void printRanking(List<Score> ranking)
		{
			Console.WriteLine("\nTo4KI:");
			if (ranking.Count > 0)
			{
				for (int i = 0; i < ranking.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} kutii",
						i + 1, ranking[i].Name, ranking[i].Points);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("prazna klasaciq!\n");
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
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
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
			int boardRows = 5;
			int boardColumns = 10;
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
			int boardRows = 5;
			int boardColumns = 10;
			char[,] board = new char[boardRows, boardColumns];

			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '-';
				}
			}

			List<int> randomBombIndexes = new List<int>();
			while (randomBombIndexes.Count < 15)
			{
				Random random = new Random();
				int randomNumber = random.Next(50);
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
			int kol = gameField.GetLength(0);
			int red = gameField.GetLength(1);

			for (int i = 0; i < kol; i++)
			{
				for (int j = 0; j < red; j++)
				{
					if (gameField[i, j] != '*')
					{
						char countBombs = getCountBombs(gameField, i, j);
						gameField[i, j] = countBombs;
					}
				}
			}
		}

		private static char getCountBombs(char[,] bombs, int row, int column)
		{
			int counterBombs = 0;
			int countRows = bombs.GetLength(0);
			int countColumns = bombs.GetLength(1);

			if (row - 1 >= 0)
			{
				if (bombs[row - 1, column] == '*')
				{
					counterBombs++;
				}
			}
			if (row + 1 < countRows)
			{
				if (bombs[row + 1, column] == '*')
				{
					counterBombs++;
				}
			}
			if (column - 1 >= 0)
			{
				if (bombs[row, column - 1] == '*')
				{
					counterBombs++;
				}
			}
			if (column + 1 < countColumns)
			{
				if (bombs[row, column + 1] == '*')
				{
					counterBombs++;
				}
			}
			if ((row - 1 >= 0) && (column - 1 >= 0))
			{
				if (bombs[row - 1, column - 1] == '*')
				{
					counterBombs++;
				}
			}
			if ((row - 1 >= 0) && (column + 1 < countColumns))
			{
				if (bombs[row - 1, column + 1] == '*')
				{
					counterBombs++;
				}
			}
			if ((row + 1 < countRows) && (column - 1 >= 0))
			{
				if (bombs[row + 1, column - 1] == '*')
				{
					counterBombs++;
				}
			}
			if ((row + 1 < countRows) && (column + 1 < countColumns))
			{
				if (bombs[row + 1, column + 1] == '*')
				{
					counterBombs++;
				}
			}
			return char.Parse(counterBombs.ToString());
		}
	}
}
