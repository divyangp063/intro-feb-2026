
// what 
// "Interface Segregation Principle"
// you define what you need, don't just use what's available.

public interface ILogger2 { 
    void LogResult(string result); 
};

public class Calculator2(ILogger2 _logger2)
{
    public int Add(string numbers)
    {


        var result = numbers == "" ? 0 : numbers // "1,2,3,4"
            .Split(',', '\n') // ["1", "2", "3", "4"]
            .Select(int.Parse) // [1, 2, 3, 4]
            .Sum(); // 10

        _logger2.LogResult(result.ToString());
        return result;

        // Do something here
        // this is a "non-functional" or "technical" requirement.
        // Side effect just means that something is happening
        // that doesn't change the observable behavior of the 
        // caller of this method.
        //
        // logging is "leaving the escape room" - leaving the process
        // writing to the file system.

    }
}


// Test Double
// Dummy - not really part of the test, just need something so we don't get a NRE
// Stub - a thing that has canned responses to questions. Simulating faults.
// Mock - Record their interactions. 
// Fake - We will do this in our API. It's not our code, it's a "stand in" for something
//  That will be there in "production" - 