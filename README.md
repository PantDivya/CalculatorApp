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

<b>csv: comma seperated value </b><br />
CSV, or Comma-Separated Values, is a file format used to store data in a structured way<br />
To read a CSV file in C#, we can use the StreamReader class. The StreamReader class allows us to read text from a file.<br />
 
add with two level input
add with three level input
add with n level of input

log maintain 

try__catch__finally

exception

field and properties

StackTrace

Task:
1.Display instruction message:
	->Display core instruction: GetCoreInstructionMessage() (Add, sub, multiply, divide)
	->Display sub core instruction. GetSubCoreInstruction(string operationType)
2.GetUserInput()
	2.1 Two level input: GetTwoLevelInputFromUser()
	2.2 three level input: GetThreeLevelInputFromUser()
	2.3 n number of input: int[] GetNNumberOfInput()
3.Perform Operation
	-->Addition
		--->Add(first,second): first+second
		--->Add(first,second,third): first+second+third
		--->Add(int[] number): 1.1 Iterate
							   1.2 Sum
	-->Subtraction
	-->Division 
	-->Multiplication


View:
Please choose below operation:
1.Addition
2.subtraction
3.multiply
4.Division

1

