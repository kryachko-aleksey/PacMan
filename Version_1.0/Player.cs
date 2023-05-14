public class Player
{
    int userX = 6;
    int userY = 6;
    public void MovePlayer(char[,] map)               // Метод перемещения игрока
    {
        Console.SetCursorPosition(userY, userX);     // Задаем позицию игрока
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write("  ");                          // Отрисовываем игрока
        Console.BackgroundColor = default;
        ConsoleKeyInfo charKey = Console.ReadKey();  // Перемещение Стрелочками
        switch (charKey.Key)
        {
            case ConsoleKey.UpArrow:                 // Если стрелка Вверх               
                if (map[userX - 1, userY] != '#' && map[userX - 1, userY + 1] != '#')    // То перемещаем игрока на координату (X-1) 
                {
                    Console.SetCursorPosition(userY, userX); // Ставим курсор на место игрока
                    Console.Write("  ");                     // И стираем старое отображение игрока
                    userX--;                                 // Меняем положение игрока для нового отбражения
                }

                break;
            case ConsoleKey.DownArrow:               // Если стрелка Вниз
                if (map[userX + 1, userY] != '#' && map[userX + 1, userY + 1] != '#')    // То перемещаем игрока на координату (X+1) 
                {
                    Console.SetCursorPosition(userY, userX);
                    Console.Write("  ");
                    userX++;
                }
                break;
            case ConsoleKey.LeftArrow:               // Если стрелка Влево
                if (map[userX, userY - 1] != '#')    // То перемещаем игрока на координату (Y-1) 
                {
                    Console.SetCursorPosition(userY, userX);
                    Console.Write("  ");
                    userY--;
                }
                break;
            case ConsoleKey.RightArrow:              // Если стрелка Вправо
                if (map[userX, userY + 1] != '#' && map[userX, userY + 2] != '#')    // То перемещаем игрока на координату (Y-1) 
                {
                    Console.SetCursorPosition(userY, userX);
                    Console.Write("  ");
                    userY++;
                }
                break;
        }
    }
}