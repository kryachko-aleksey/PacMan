
Console.CursorVisible = false;             // Отключаем видимость курсора

MapDev mapDev = new MapDev();
Player player = new Player();
InterFace interFace = new InterFace();

Console.Clear();



char[,] map = mapDev.ReadMap("map.txt");   // Создаем карту

mapDev.PrintMap(map);                      // Рисуем карту
bool gameOff = true;

while (gameOff)
{
    interFace.PrintBag();                 // Рисуем интерфес

    player.MovePlayer(map);               // Движение игрока

    interFace.WorkBag(map);               // Работа сумки

    gameOff = interFace.GameFinish();     // Проверяем собрали ли мы все сокровища
}

Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Конец игры");
Console.ForegroundColor = default;
Console.CursorVisible = true;