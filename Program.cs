using ProceduralCaveGeneration.CaveGenerator;

Cave minorCave = new Cave(seed:0, width:50, height: 25, randomFillPercent: 40);
Cave middleCave = new Cave(seed:123, width:100, height: 50, randomFillPercent: 45);
Cave bigCave = new Cave(seed:456, width:180, height: 90, randomFillPercent: 50);

CaveDrawer.Draw(minorCave);
CaveDrawer.Draw(cave:middleCave, wallColor: ConsoleColor.Magenta, backgroundColor:ConsoleColor.Black, wallChar:'o');
CaveDrawer.Draw(cave:bigCave, wallColor: ConsoleColor.Green, backgroundColor:ConsoleColor.DarkBlue, wallChar:'O');

Console.WriteLine();
Console.WriteLine("Press enter to close...");
Console.ReadLine();