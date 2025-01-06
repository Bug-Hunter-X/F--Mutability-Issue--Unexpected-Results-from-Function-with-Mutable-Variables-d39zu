# F# Mutability Issue: Unexpected Results from Function with Mutable Variables

This example demonstrates a potential issue in F# when dealing with mutable variables and their use within functions.  The function `add` uses the initial values of `x` and `y`, even after they are changed outside the function's scope.

The `bug.fs` file contains the code exhibiting the problem. The solution (`bugSolution.fs`) shows how to handle this scenario using function arguments directly and avoiding unnecessary mutable variables.

## How to Reproduce

1. Run the code in a F# interpreter.
2. Observe the output. The result does not reflect the modification to `x` after the first function call.

## Solution

The `bugSolution.fs` file shows a corrected approach that uses function parameters to ensure the function always uses the most up-to-date values.