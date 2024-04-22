<h2> Calculator_App </h2>

This is a console app that perform basic operation of a calculator.

The purpose of writing this is to understand the basic concept and logic of c# language and creating the calculator app using those concept.


<b> Interpolation:</b> Allows developers to insert variables or expressions into string literals. <br />
Example: Console.WriteLine($"Hello world!!! {Name}" ); </br>
...In this example "Name" is variable which is inserted wich the sting "Hello world!!!"...

<b>Data type, memory and their range: </b> <br />
	int : 32 bit <br />
	float : 32 bit <br />
	double : 64 bit <br />
	decimal : 128 bit <br />
	sbyte : 8 bit__(-128 to 127) <br />
	byte : 8 bit__(-128 to 127) <br />
	short : 16 bit <br />
	ushort : 16 bit <br />
	long : 64 bit <br />
	ulong : 64 bit <br /><br />
	string <br />
	char : 16 bit <br /><br />
	bool <br />


<table>
	<tr>
		<th>Data Type</th>
		<th>Memory</th>
		<th>Description</th>
	</tr>
	<tr>
		<td>int</td>
		<td>4 bytes</td>
		<td>Stores whole numbers from -2,147,483,648 to 2,147,483,647</td>
	</tr>
	<tr>
		<td>long</td>
		<td>8 bytes</td>
		<td>Stores whole numbers from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807</td>
	</tr>
	<tr>
		<td>float</td>
		<td>4 bytes</td>
		<td>Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits</td>
	</tr>
	<tr>
		<td>double</td>
		<td>8 bytes</td>
		<td>Stores fractional numbers. Sufficient for storing 15 decimal digits</td>
	</tr>
	<tr>
		<td>double</td>
		<td>8 bytes</td>
		<td>Stores fractional numbers. Sufficient for storing 15 decimal digits</td>
	</tr>
	<tr>
		<td>string</td>
		<td>2 bytes per character</td>
		<td>Stores a sequence of characters, surrounded by double quotes</td>
	</tr>
	<tr>
		<td>char</td>
		<td>2 bytes</td>
		<td>Stores a single character/letter, surrounded by single quotes</td>
	</tr>
	<tr>
		<td>bool</td>
		<td>1 bit</td>
		<td>Stores true or false values</td>
	</tr>
</table>

<b>Topic to understand:</b><br />
<b>1.csv: comma seperated value </b><br />
CSV, or Comma-Separated Values, is a file format used to store data in a structured way<br />
To read a CSV file in C#, we can use the StreamReader class. The StreamReader class allows us to read text from a file.<br /><br />
<b>2.Input(Console.ReadLine) </b><br />
add with two level input<br />
add with three level input<br />
add with n level of input<br /><br />

<b>Task to compelete:</b><br />
1.log maintain <br />

2.try__catch__finally<br />

3.exception<br />

4.field and properties<br />

5.StackTrace<br />

<b>Task:</b><br /><br />
1.Display instruction message:<br />
	->Display core instruction: GetCoreInstructionMessage() (Add, sub, multiply, divide)<br />
	->Display sub core instruction. GetSubCoreInstruction(string operationType)<br />
2.GetUserInput()<br />
	2.1 Two level input: GetTwoLevelInputFromUser()<br />
	2.2 three level input: GetThreeLevelInputFromUser()<br />
	2.3 n number of input: int[] GetNNumberOfInput()<br />
3.Perform Operation<br />
	-->Addition<br />
		--->Add(first,second): first+second<br />
		--->Add(first,second,third): first+second+third<br />
		--->Add(int[] number): 1.1 Iterate<br />
							   1.2 Sum<br />
	-->Subtraction<br />
	-->Division <br />
	-->Multiplication<br />


View:<br />
Please choose below operation:<br />
1.Addition<br />
2.subtraction<br />
3.multiply<br />
4.Division<br />

1

Task: 4/21/2024<br />
Log File<br />
1,Ans,5,69,88,55<br />

Stream: StreamWriter (a class), StreamReader<br />

program--->Stream--->notepad<br />


What to save in log file?<br \><br />
:)



