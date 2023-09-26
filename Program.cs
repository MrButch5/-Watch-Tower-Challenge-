//Asking the CI location for the X coordinate
using System.ComponentModel.Design;

Console.WriteLine("What is the CI's location of the X coordinate? ");
//Getting the users input of the X location for the watch towers
int ciLocationXCoordinate = Convert.ToInt32(Console.ReadLine());
//Asking the CI location for the Y coordinate
Console.WriteLine("What is the CI's location of the Y coordinate? ");
//Getting the users input of the Y location for the watch towers
int ciLocationYCoordinate = Convert.ToInt32(Console.ReadLine());
//Where all the bools will go for X and Y to calculate where the CI will go for the table
/*So basically all these variables are created to follow the chart in the challenge
 * The first row through third row combination are places holders for the values on the left side
 * aka y values that are top to bottom
 */
bool firstRowCombinationY = ciLocationYCoordinate > 0;
bool secondRowCombinationY = ciLocationYCoordinate == 0;
bool thirdRowCombinationY = ciLocationYCoordinate < 0;
bool northWestXCoordinate = ciLocationXCoordinate < 0;
bool northWestYCoordinate = firstRowCombinationY;
bool northXCoordinate = ciLocationXCoordinate == 0;
bool northYCoordinate = firstRowCombinationY;
bool northEastXCoordinate = ciLocationXCoordinate > 0;
bool northEastYCoordinate = firstRowCombinationY;
bool westXCoordinate = ciLocationXCoordinate < 0;
bool westYCoordinate = secondRowCombinationY;
bool weirdXSymbolCoordinate = ciLocationXCoordinate == 0;
bool weirdYSymbolCoordinate = secondRowCombinationY;
bool eastXCoordinate = ciLocationXCoordinate > 0;
bool eastYCoordinate = secondRowCombinationY;
bool southWestXCoordinate = ciLocationXCoordinate < 0;
bool southWestYCoordinate = thirdRowCombinationY;
bool southXCoordinate = ciLocationXCoordinate == 0;
bool southYCoordinate = thirdRowCombinationY;
bool southEastXCoordinate = ciLocationXCoordinate > 0;
bool southEastYCoordinate = thirdRowCombinationY;



if ( northWestXCoordinate && northWestYCoordinate)
{
    Console.WriteLine("Attention units the  group CI are heading are North West! ");
}
if (northXCoordinate && northYCoordinate)
{
    Console.WriteLine("Attention units the group of CI are heading North!");

}
if (northEastXCoordinate && northEastYCoordinate)
{
    Console.WriteLine("Attention units the group of CI are heading North East!");
}
if (westXCoordinate && westYCoordinate)
{
    Console.WriteLine("Attention units the group of CI are heading West");
}
if (weirdXSymbolCoordinate && weirdYSymbolCoordinate)
{
    Console.WriteLine("The CI are going to an unknown location!");
}
if (eastXCoordinate && eastYCoordinate)
{
    Console.WriteLine("Attention units the group of CI are heading East!");
}
if (southWestXCoordinate && southWestYCoordinate)
{
    Console.WriteLine("Attention units the group of CI are heading South West!");
}
if (southXCoordinate && southYCoordinate)
{
    Console.WriteLine("Attention units the group of CI are heading South!");
}
if (southEastXCoordinate && southEastYCoordinate)
{
    Console.WriteLine("Attention units the group of CI are heading South!");
}