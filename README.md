# Procedural Cave Generation in Console

This implementation uses the pseudo System.Random to generate values in the range of 0 to 100. These values are used as a basis for establishing the height of the cave walls and uses Cellular Automaton to smooth them. And then each Tile represented by a Char in a Color is printed in the Console.

### Example of implementation

    //Generate cave data
    Cave cave = new Cave(seed:0, width:50, height: 25, randomFillPercent: 40);

    //Draw Cave in Console
    CaveDrawer.Draw(cave:cave, wallColor: ConsoleColor.Green, backgroundColor:ConsoleColor.DarkBlue, wallChar:'O');   

### References

Sebastian Lague Cave Generation in Unity - https://www.youtube.com/watch?v=v7yyZZjF1z4&t=1110s
Cellular Automaton - https://mathworld.wolfram.com/CellularAutomaton.html