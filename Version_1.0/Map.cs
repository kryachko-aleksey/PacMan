public class MapDev
{
    public char[,] ReadMap(string pach)
    {
        string[] file = File.ReadAllLines("map.txt");              // Читаем карту из файла map.txt
        char[,] map = new char[file.Length,file[0].Length];
        for (int x = 0; x < map.GetLength(0); x++)
        {
            for (int y = 0; y < map.GetLength(1); y++)
            {
                map[x, y] = file[x][y];
            }
        }
        return map;
    }

    public void PrintMap(char[,] map)                            // Рисуем карту
    {
        Console.SetCursorPosition(0, 0);                         // Курсор в нулевое положение
        for (int indexLineMap = 0; indexLineMap < map.GetLength(0); indexLineMap++)
        {
            for (int indexColumnMap = 0; indexColumnMap < map.GetLength(1); indexColumnMap++)
            {
                if (map[indexLineMap, indexColumnMap] == '#')    // Если встречается символ #
                {
                    Console.BackgroundColor = ConsoleColor.Blue; // То фон становится синим
                    Console.Write(" ");                          // Выводим пробел
                    Console.BackgroundColor = default;           // Возвращаем фон в черный цвет
                }
                else
                if (map[indexLineMap, indexColumnMap] == 'o')    // Если встречается символ x 
                {
                    Console.ForegroundColor = ConsoleColor.Yellow; // То текст становится желтый
                    Console.Write("o");                          // Рисуем монетку
                    Console.ForegroundColor = default;           // Возвращаем текст в черный цвет
                }
                else
                {
                    Console.Write(" ");                          // Иначе выводим пробел с черным фоном
                }
            }
            Console.WriteLine();
        }
    }
}