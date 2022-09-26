// Запрос данных пользователяю, принимает строку заголовок.
// Выдает введеное число, в случае ошибки выдает 0.
int ReadData(string greeting = "Введите данные")
{
    Console.WriteLine(greeting);
    int.TryParse((Console.ReadLine() ?? "0"), out int number); // переводим в число
    return (number);
}

//Вывод кадра
int[,] PrintBox(int[,] frame, List<(int, int)> snake, (int, int) positionBug)
{
    int[,] newFrame = new int[frame.GetLength(0), frame.GetLength(1)];
    newFrame = AddBorder(newFrame);
    newFrame = AddSnake(newFrame, snake);
    newFrame[positionBug.Item2, positionBug.Item1] = 3;

    for (int i = 0; i < frame.GetLength(0); i++)
    {
        for (int j = 0; j < frame.GetLength(1); j++)
        {
            if (
                newFrame[i, j] != frame[i, j] 
            )
            {
                Console.SetCursorPosition(i * 2, j);
                if (newFrame[i, j] == 1)
                    Console.Write("*");
                if (newFrame[i, j] == 2)
                    Console.Write("0");
                if (newFrame[i, j] == 3)
                    Console.Write("Ж");
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
    int finishCol = frame.GetLength(1) - 1;
    int startRow = 0;
    int finishRow = frame.GetLength(0) - 1;
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
List<(int, int)> MoveSnake(List<(int, int)> snake, int direction, bool boostSnake)
{
    (int, int) newPosition = (0, 0);
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
    if (boostSnake) { }
    else
        snake.RemoveAt(0);
    return snake;
}

//Добавляет жука
(int, int) AddBug(int boxSizeX, int boxSizeY, List<(int, int)> snake)
{
    (int, int) positionBug = (0, 0);

    Random rnd = new Random();
    do
    {
        positionBug = (rnd.Next(1, boxSizeX - 1), rnd.Next(1, boxSizeY - 1));
    } while (snake.Contains(positionBug));
    return positionBug;
}

//Поймать жука
bool CatchBug(List<(int, int)> snake, (int, int) positionBug)
{
    return snake.Contains(positionBug);
}
;

//Столкновение
bool Collision(int boxSizeX, int boxSizeY, List<(int, int)> snake)
{
    if (
        snake.IndexOf(snake[snake.Count-1]) < snake.Count-1
        || snake[snake.Count - 1].Item1 <= 0
        || snake[snake.Count - 1].Item2 <= 0
        || snake[snake.Count - 1].Item1 >= boxSizeX - 1
        || snake[snake.Count - 1].Item2 >= boxSizeY - 1
    )
    {
        return true;
    }
    return false;
}

//Речатает звезду в указаном месте
void PrintStar(int x, int y)
{
    Console.SetCursorPosition(x, y);
    Console.Write("*");
}

//Гейм овер
void GameOver(int[,] arr2D)
{
    int startCol = 1;
    int finishCol = arr2D.GetLength(1) - 2;
    int startRow = 1;
    int finishRow = arr2D.GetLength(0) - 2;
    int delay = 10;

    while (startCol <= finishCol && startRow <= finishRow)
    {
        for (int i = startCol; i <= finishCol; i++)
        {
            Thread.Sleep(delay);
            PrintStar(startRow* 2, i);
        }
        startRow++;

        for (int i = startRow; i <= finishRow; i++)
        {
            Thread.Sleep(delay);
            PrintStar(i* 2, finishCol);
        }
        finishCol--;

        for (int i = finishCol; i >= startCol; i--)
        {
            Thread.Sleep(delay);
            PrintStar(finishRow* 2, i);
        }
        finishRow--;

        for (int i = finishRow; i >= startRow; i--)
        {
            Thread.Sleep(delay);
            PrintStar(i* 2, startCol);
        }
        startCol++;
    }
}

// Основная программа
int boxSizeX =  ReadData("Введите количество столбцов матрицы");
int boxSizeY =   ReadData("Введите количество строк матрицы");
if (boxSizeX < 7)
    boxSizeX = 7;
if (boxSizeY < 7)
    boxSizeY = 7;
Console.Clear();
int[,] frame = new int[boxSizeY, boxSizeX];
List<(int, int)> snake = new List<(int, int)> { (2, 2), (3, 2), (4, 2) };
bool run = true;
int direction = 4; //направление 4-вниз,3-вверх, 1-влево, 2-вправо
DateTime time = DateTime.Now;
bool noBug = true;
(int, int) positionBug = (0, 0);
bool boostSnake = false;

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

    //Оновление экрана по таймеру
    if ((DateTime.Now - time) > TimeSpan.FromMilliseconds(250))
    {
        if (noBug)
        {
            positionBug = AddBug(boxSizeX, boxSizeY, snake);
            noBug = false;
        }
        snake = MoveSnake(snake, direction, boostSnake);
        boostSnake = false;
        frame = PrintBox(frame, snake, positionBug);
        if (CatchBug(snake, positionBug))
        {
            noBug = true;
            boostSnake = true;
        }
        if (Collision(boxSizeX, boxSizeY, snake))
        {
            GameOver(frame);
            run = false;
        }
        time = DateTime.Now;
        Console.SetCursorPosition(0, 0);
    }
}
