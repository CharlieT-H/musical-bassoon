# ✅ Problem 6: Implement Rule loader with External Source

## 📋 Requirements
Using the Interface defined in Problem 5, implement a class that loads Rules from an external JSON file.
If the Json File is missing or malformed, the program should handle the error gracefully and fall back to a default set of rules.



The JSON file should have the following structure:
```
{
    Rules:[
        {
            "Divider": 3,
            "Message": "Fizz",
            "Priority": 2
        },
        {
            "Divider": 5,
            "Message": "Buzz",
            "Priority": 1
        },
        {
            "Divider": 7,
            "Message": "Bazz",
            "Priority": 3
        },
        {
            "Divider": 11,
            "Message": "Jazz",
            "Priority": 2
        }
    ]
}
```
