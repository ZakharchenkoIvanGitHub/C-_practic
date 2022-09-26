// Запрос данных пользователяю, принимает строку заголовок.
// Выдает введеное число, в случае ошибки выдает 0.
int ReadData(string greeting = "Введите данные")
{
    Console.WriteLine(greeting);
    int.TryParse((Console.ReadLine() ?? "0"), out int number); // переводим в число
    return (number);
}

//Вывод кадра
int[,] PrintBox(int[,] frame, List<(int, int)> snake)
{
    int[,] newFrame = new int[frame.GetLength(0), frame.GetLength(1)];
    newFrame = AddBorder(newFrame);
    newFrame = AddSnake(newFrame, snake);

    for (int i = 0; i < frame.GetLength(0); i++)
    {
        for (int j = 0; j < frame.GetLength(1); j++)
        {
            if (
                newFrame[i, j] != frame[i, j] /* && newFrame[i, j] != 0 */
            )
            {
                Console.SetCursorPosition(i * 2, j);
                if (newFrame[i, j] == 1)
                    Console.Write("*");
                if (newFrame[i, j] == 2)
                    Console.Write("0");
                if (newFrame[i, j] == 0)
                    Console.Write(" ");
            }
        }
    }
    return newFrame;
}

// добавлет змейку
int[,] AddSnake(int[,] frame, List<(int, int)> snake)
{
    foreach ((int, int) item in snake)
    {
        frame[item.Item2, item.Item1] = 2;
    }

    return frame;
}

// Добавляет рамку
int[,] AddBorder(int[,] frame)
{
    int startCol = 0;
    int finishCol = frame.GetLength(0) - 1;
    int startRow = 0;
    int finishRow = frame.GetLength(1) - 1;
    int symbol = 1;

    for (int i = startCol; i <= finishCol; i++)
    {
        frame[startRow, i] = symbol;
    }
    startRow++;

    for (int i = startRow; i <= finishRow; i++)
    {
        frame[i, finishCol] = symbol;
    }
    finishCol--;

    for (int i = finishCol; i >= startCol; i--)
    {
        frame[finishRow, i] = symbol;
    }
    finishRow--;

    for (int i = finishRow; i >= startRow; i--)
    {
        frame[i, startCol] = symbol;
    }
    startCol++;

    return frame;
}
;

//Печатает двумерный массив
void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Определяет нажатую клавишу
int DefineKey(ConsoleKeyInfo input)
{
    switch (input.Key)
    {
        case ConsoleKey.LeftArrow
        or ConsoleKey.A:
            return 1;
        case ConsoleKey.RightArrow
        or ConsoleKey.D:
            return 2;
        case ConsoleKey.UpArrow
        or ConsoleKey.W:
            return 3;
        case ConsoleKey.DownArrow
        or ConsoleKey.D:
            return 4;
        case ConsoleKey.Escape:
            return 5;
        default:
            return 0;
    }
}

//двигать змейку
List<(int, int)> MoveSnake(List<(int, int)> snake, int direction)
{
    (int, int) newPosition = (0, 0);
    //Console.WriteLine("w");
    switch (direction)
    {
        case 1:
            newPosition = (snake[snake.Count - 1].Item1, snake[snake.Count - 1].Item2 - 1);
            break;
        case 2:
            newPosition = (snake[snake.Count - 1].Item1, snake[snake.Count - 1].Item2 + 1);
            break;
        case 3:
            newPosition = (snake[snake.Count - 1].Item1 - 1, snake[snake.Count - 1].Item2);
            break;
        case 4:
            newPosition = (snake[snake.Count - 1].Item1 + 1, snake[snake.Count - 1].Item2);
            break;
    }
    snake.Add(newPosition);
   //  Console.WriteLine(newPosition);
    snake.RemoveAt(0);
    return snake;
}

// Основная программа
int boxSizeX = 10; // ReadData("Введите количество строк матрицы");
int boxSizeY = 10; //ReadData("Введите количество столбцов матрицы");
if (boxSizeX < 7)
    boxSizeX = 7;
if (boxSizeY < 7)
    boxSizeY = 7;
Console.Clear();
int[,] frame = new int[boxSizeX, boxSizeY];
List<(int, int)> snake = new List<(int, int)> { (2, 2), (2, 3), (2, 4) };
bool run = true;
int direction = 4; //направление 4-вниз,3-вверх, 1-влево, 2-вправо
DateTime time = DateTime.Now;

while (run) //основной цикл
{
    //Опрос клавиатуры
    if (Console.KeyAvailable)
    {
        int key = DefineKey(Console.ReadKey(true));
        if (key != 0)
        {
            if (key == 5)
            {
                run = false;
            }
            else
                direction = key;
        }
    }

    if ((DateTime.Now - time) > TimeSpan.FromMilliseconds(400))
    {
        snake = MoveSnake(snake, direction);
        frame = PrintBox(frame, snake);
        time = DateTime.Now;
        Console.SetCursorPosition(0, 0);
        // Console.WriteLine(snake.ToString());
    }
}
