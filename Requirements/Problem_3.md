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
* Concatenate all matching messages.
* If no rules match, print the number.