###### *DVP1 - Coding Challenges*
---

# Refactoring

The other challenges require validation of user provided data. Doing so verifies that the data meets requested expectations. [Refactor](https://refactoring.com/) your application by encapsulating this functionality within an external class.

**Note**: *This challenge should be self contained within its own 'Validation' class, making it neccessary only to call it from the other challenges. Doing so allows for flexibility within the larger application should updates need to be made in the future.*

#### Validation Types:
> * String
> * Required Length of String
> * Number of Words
> * Integer 
> * Float
> * Range *- Integer Between Min/Max*

#### Each method should:
> * Prompt the user for the required information
> * Validate user input, requesting it again if necessary
> * Return validated input

##### Example Validation Class:
```
class Validation
{
	// String Required
    public static string ValidateString(string s)
    {
        Console.WriteLine(s);
        string response = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(response))
        {
            Console.WriteLine("Please do not leave this empty...");
            response = Console.ReadLine();
        }
        return response;
    }
    
    ...
}
```
Once completed you shoud be able to refactor your previous challenges. Update them, reducing input gathering to something similar to: 

```
fname = Validation.ValidateString('Please enter your first name...');
```
---