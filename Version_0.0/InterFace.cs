public class InterFace
{
    char[] bag = new char[0];
    public void PrintBag()                       // Отрисовка Сумки
    {
        Console.SetCursorPosition(0, 10);
        Console.Write("Сумка:");
        for (int indexBag = 0; indexBag < bag.Length; indexBag++)
        {
            Console.Write(bag[indexBag] + " ");
        }
    }

    public char[] WorkBag(char[,] map)         // Работа Сумки
    {
        int userX = Console.CursorTop;         // Получение координат игрока
        int userY = Console.CursorLeft - 1;
        if (map[userX, userY] == 'x')          // Если совпадает с сокровищем
        {
            map[userX, userY] = ' ';           // Меняем отрисовку на пустое место
            char[] tempBag = new char[bag.Length + 1]; // Созлаем временную сумку на один больше прежней
            for (int indexTempBag = 0; indexTempBag < bag.Length; indexTempBag++)
            {
                tempBag[indexTempBag] = bag[indexTempBag]; // Ложим во временную сумку основную сумку
            }
            tempBag[tempBag.Length - 1] = 'x'; // На последнее место Вр. сумки ложим сокровище
            bag = tempBag;                     // Возвращаем в основную сумку все (Старая сумка расширилась на 1)
        }
        return bag;
    }

    public void TextHelp()       // Вывод подсказок справа
    {
        Console.SetCursorPosition(30, 0);
        Console.Write("Игрок это @ . Собирайте x");
        Console.SetCursorPosition(30, 1);
        Console.Write("Перемещение игрока стрелочками. Выход из программы Cntl+C");
    }

    public bool GameOff()       //  Проверка на сбор всех сокровищ
    {
        bool gameOff = true;
        if (bag.Length == 4)
        {
            gameOff = false;
        }
        return gameOff;
    }
}