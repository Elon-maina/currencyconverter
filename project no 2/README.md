This simple console application in C# allows users to perform basic banking operations, including creating new accounts, making deposits, making withdrawals, and checking account balances. The application is structured into two classes: BankAccount and BankManagementApp.

BankAccount Class
The BankAccount class represents an individual bank account with the following properties:

AccountNumber: The unique account number.
AccountHolder: The account holder's name.
Balance: The current account balance.
It provides methods for depositing, withdrawing, and checking the account balance.

BankManagementApp Class
The BankManagementApp class is the main class that orchestrates the overall functionality of the banking application. It includes a list of BankAccount objects to store multiple accounts.

The main loop of the application allows users to choose from the following options:

Create New Account: Allows users to create a new bank account by providing an account number, account holder name, and initial balance.

Deposit: Allows users to make a deposit into an existing account by specifying the account number and deposit amount.

Withdraw: Allows users to make a withdrawal from an existing account by specifying the account number and withdrawal amount.

Check Balance: Allows users to check the balance of an existing account by providing the account number.

Exit: Exits the application
