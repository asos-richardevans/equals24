# equals24

The function equalTo24 accepts 4 integer parameters a b c d in the range is 1-13.

Use the operators + - * / to make the final results equal to 24.

If it is not possible to reach a value of 24, then return "It's not possible!"

All four integers must be used, and integers can only be used once.

You just need to return one correct solution, you don't need to find out all the possibilities.

Example:
Input 1,2,3,4  1+2+3*4=24
Input 2,6,7,9  7+2+6+9=24
Input 2,3,3,7  7+2*3-3=24
Input 1,1,1,1  "It's not possible!"

Next step is to include to use of parentheses in the list of operators allowed.

Example:
Input 1,2,3,4  (1+3)*(2+4) or 1*2*3*4
Input 2,3,4,5  (5+3-2)*4 or (3+4+5)*2

The final step is to increase you input value range to 1-100 and ensure tests are executed within a specific time period
