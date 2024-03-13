using ExerciseInheritance;

InvestmentAccount investmentAccount = new InvestmentAccount("Matheus");
investmentAccount.Deposit(12500);
investmentAccount.Withdraw(10000);
investmentAccount.Withdraw(10000);

SavingsAccount savingsAccount = new SavingsAccount("Manu");
savingsAccount.Deposit(12500);
savingsAccount.Withdraw(10000);

TransactionAccount transactionAccount = new TransactionAccount("Luan");
transactionAccount.Deposit(12500);
transactionAccount.Withdraw(10000);

