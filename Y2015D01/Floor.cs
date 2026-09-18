using System.Net.Mime;
using System.Runtime.Intrinsics.X86;

namespace Y2015D01;

public class Floor
{
    public int Check(string floor)
    {
        int currentFloor = 0;


        for (int i = 0; i < floor.Length; i++)
        {
            if (floor[i] == '(')
            {
                currentFloor++;
            }
            else if (floor[i] == ')')
            {
                currentFloor--;
            }
        }

        return currentFloor;
    }

    public int ChangedValue(string floor)
    {
        var changedFloor = floor.Replace('(', ')');
        int currentFloor = 0;

        for (int i = 0; i < changedFloor.Length; i++)
        {
            currentFloor++;
        }

        return currentFloor;
    }
}