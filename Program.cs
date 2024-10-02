Console.WriteLine("opg 15.1");
//int iterationer = 10;
//int[] array = { 1, 2, 3, 4, 5 };
// // increment
//for (int i = 0 ; i < iterationer ; i++)
//{
//array[i]++;
//}
// // print
//for (int i = 0 ; i < array.Length ; i++)
//{
//Console.WriteLine(array[i]);
//}
Console.WriteLine("the exception that is cast are IndexOutOfRange");
Console.WriteLine("the array is to small");
Console.WriteLine("the solution is to use a try-catch");
int iterationer = 10;
int[] array = { 1, 2, 3, 4, 5 };
// increment
try
{
	for (int i = 0 ; i < iterationer ; i++)
	{
		array[i]++;
	}
}
catch(System.IndexOutOfRangeException e)
{
	Console.WriteLine("array is out of bounce");
	Console.WriteLine(e);
}
// print
for (int i = 0 ; i < array.Length ; i++)
{
	Console.WriteLine(array[i]);
}
Console.WriteLine();
Console.WriteLine("opg 15.2");
//int[] accounts = { 903, 716, 67 };
//int GetAccountNumber()
//{
//Console.WriteLine("Enter an account number: ");
//return Convert.ToInt32(Console.ReadLine());
//}
//void PrintAccountState(int accountId)
//{
//Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
//}
//while (true)
//{
//int accountId = GetAccountNumber();
//PrintAccountState(accountId);
//}
//hvis input er 3 får vi fejle Out Of Range
int[] accounts = { 903, 716, 67 };
int GetAccountNumber()
{
	Console.WriteLine("Enter an account number: ");
	return Convert.ToInt32(Console.ReadLine());
}
void PrintAccountState(int accountId)
{
	Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
}
while (true)
{
	int accountId = GetAccountNumber();
	PrintAccountState(accountId);
}