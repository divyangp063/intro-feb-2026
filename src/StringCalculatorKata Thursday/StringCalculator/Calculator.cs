
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
            // or you can do:
            // return numbers - "1,2,3,4"
            // .Split(delimiters) - ["1", "2", "3", "4"]
            // .Select(int.Parse) - [1, 2, 3, 4]
            // .Sum(); - 1 + 2 + 3 + 4
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
