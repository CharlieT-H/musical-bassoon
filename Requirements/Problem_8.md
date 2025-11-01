# ✅ Problem 8: Parrelising FizzBuzz execution

## 📋 Requirements
When executing the FizzBuzz logic over a large range of numbers (e.g., 1 to 1,000,000), the program should utilize parallel processing to improve performance. The implementation should ensure that the output remains in the correct order, from 1 to 1,000,000, despite the parallel execution.  
The program should be able to divide the workload across multiple threads or processes, ensuring that each thread/process handles a subset of the total range of numbers. After processing, the results from all threads/processes should be combined and printed in the correct order.
The implementation should support a maximum amount of allowed parralel threads/processes, which can be configured by the user before execution begins. This limit should be respected to avoid overwhelming system resources.
