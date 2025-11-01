# ✅ Problem 3: Rule Priority and Ordering

## 📋 Requirements
Define a FizzBuzzRule class with the following properties:

int Divider
string Message
int Priority


Accept a list of FizzBuzzRule objects.
Before applying rules:

* Sort them by ascending Priority.

For each number in the range:
* Apply all rules where number % Divider == 0, in priority order.
  * If two rules have the same priority order by the message alphabetically.
* Concatenate all matching messages.
* If no rules match, print the number.


Use the below to add the priorities to the existing rules:
* Fizz (Divider: 3) - Priority: 2
* Buzz (Divider: 5) - Priority: 1
* Bazz (Divider: 7) - Priority: 3
* Jazz (Divider: 11) - Priority: 2
