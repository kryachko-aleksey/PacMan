public class Player
{
    int userX = 6;     
    int userY = 6;
    public void MovePlayer(char[,] map)   // Метод перемещения игрока
    {
        Console.SetCursorPosition(userY, userX);     // Задаем позицию игрока
        Console.Write("@");                          // Отрисовываем игрока
        ConsoleKeyInfo charKey = Console.ReadKey();  // Перемещение Стрелочками
        switch (charKey.Key)
        { 
            case ConsoleKey.UpArrow:                 // Если стрелка Вверх
                if (map[userX - 1, userY] != '#')    // То перемещаем игрока на координату (X-1) 
                {
                    userX--;
                }

                break;
            case ConsoleKey.DownArrow:               // Если стрелка Вниз
                if (map[userX + 1, userY] != '#')    // То перемещаем игрока на координату (X+1) 
                {
                    userX++;
                }
                break;
            case ConsoleKey.LeftArrow:               // Если стрелка Влево
                if (map[userX, userY - 1] != '#')    // То перемещаем игрока на координату (Y-1) 
                {
                    userY--;
                }
                break;
            case ConsoleKey.RightArrow:              // Если стрелка Вправо
                if (map[userX, userY + 1] != '#')    // То перемещаем игрока на координату (Y-1) 
                {
                    userY++;
                }
                break;
        }
    }
}