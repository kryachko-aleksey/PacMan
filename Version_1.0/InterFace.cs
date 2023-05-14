public class InterFace
{
    int bag = 0;
    public void PrintBag()                       // Отрисовка Сумки
    {
        Console.SetCursorPosition(0, 23);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("Монеты: ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(bag);
        Console.ForegroundColor = default;
    }

    public int WorkBag(char[,] map)         // Работа Сумки
    {
        int userX = Console.CursorTop;         // Получение координат игрока
        int userY = Console.CursorLeft - 2;
        if (map[userX, userY] == 'o')          // Если совпадает с сокровищем
        {
            map[userX, userY] = ' ';
            bag++;
        }
        return bag;
    }

    public bool GameFinish()       //  Проверка на сбор всех сокровищ
    {
        bool gameOff = true;
        if (bag == 145)
        {
            gameOff = false;
        }
        return gameOff;
    }

}