Console.CursorVisible = false;             // Отключаем видимость курсора

MapDev mapDev = new MapDev();
Player player = new Player();
InterFace interFace = new InterFace();

Console.Clear();
char[,] map = mapDev.CreatMap();          // Создаем карту
bool gameOff = true;
while (gameOff)
{
    mapDev.PrintMap(map);                 // Рисуем карту
    interFace.PrintBag();                 // Рисуем интерфес
    interFace.TextHelp();

    player.MovePlayer(map);               // Движение игрока

    interFace.WorkBag(map);               // Работа сумки

    gameOff = interFace.GameOff();        // Проверяем собрали ли мы все сокровища

    Console.Clear();
}
Console.WriteLine("Конец игры");