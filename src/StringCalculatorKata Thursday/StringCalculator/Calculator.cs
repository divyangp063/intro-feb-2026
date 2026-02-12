
public class Calculator
{
    public int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }
        else
        {
            char[] delimiters = { ',', '\n', '/', '#' };
            string[] listOfNumbersString = numbers.Split(delimiters);
            var result = 0;
            foreach(string number in listOfNumbersString)
            {
                if(number != "")
                {
                    var numberInt = int.Parse(number);
                    if(numberInt >= 0)
                    {
                        result += int.Parse(number);
                    }
                    else
                    {
                        throw new Exception("Number can't be negative");
                    }
                }
            }
            return result;
        }
    }
}
