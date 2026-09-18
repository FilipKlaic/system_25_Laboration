namespace Y2023D01;

public class Trebuchet
{
    public int GetNumbers(string number)
    {
        var sum = 0;
        string numberFromText = string.Empty;
        //firstDigit
        //lastDigit

        for (int i = 0; i < number.Length; i++)
        {
            if (Char.IsDigit(number[i])) numberFromText += number[i];

            sum = int.Parse(numberFromText);
        }

        return sum;
    }
}