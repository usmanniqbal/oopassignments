Create a class BankAccount containing private fields that hold the account number and the account balance. Include
a constant static field that holds the annual interest rate (3 percent) earned on accounts at Habib Bank Limited. Create
three public member functions for the class, as follows:
» An enterAccountData() function that prompts the user for values for the account number and balance. Allow neither
a negative account number nor one less than 1000, and do not allow a negative balance; continue to prompt the user
until valid values are entered.
» A computeInterest() function that accepts an integer argument that represents the number of years the account
will earn interest. The function displays the account number, then displays the ending balance of the account each
year, based on the interest rate attached to the BankAccount.
» A displayAccount() function that displays the details of the BankAccount.
Write a main() function that instantiates several objects of the BankAccount class and tests the member functions.