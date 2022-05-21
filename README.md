# RegexPatterns
Realtime regex program in C#. Used to test regex expressions as this can become a very complicated topic. This regex program is made to show results while you type real-time to make it easier to understand how regex works. Below is some information on how the regex expression works. The regex class is from the namespace: System.Text.RegularExpressions.

**Interface**
----------------------
For the most part, using the program is straight-forward. The top textbox takes in the regex expression while the bottom textbox takes in the data value. The IsMatch function is then used to compare the strings. The real-time checkpoint toggles the bottom between checking after each keypress or to standby and wait for the user to press enter or click confirm.

<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/166621943-d3667c2a-fc42-4d4c-80bf-c26eea5b8195.png"><img>
</p>

**Special characters**
----------------------
Special characters in a regex are used to assign several different meanings to a pattern. Below are some of the main ones.

| Characters | Description |
| --- | --- |
| ^ | Denotes the start, the word or pattern after this starts matching from the start of the input text |
| $ | This sign is the opposite of ```^```. It is used for matching words from the end of the string. |
| . | A dot is used for matching a single character in the given string occurring once. |
| \n | A newline |
| \d | Lower case ```d``` is used to match a digit character and upper case ```D``` is used to match non-digit characters. |
| \s | Lower case ```s``` is used to match white spaces and upper case ```S``` is used to match non-white space. |
| \w | Lower case ```w``` is used to match alphanumeric/underscore characters and upper case ```W``` is used to match non-word characters. |
| \[a-z] | Characters in range from the alphabet “a” to “z”. |
| \[1-9] | Characters in range from the numbers “1” to “9” |
| \[^1] | The character ```^``` denotes the negate character class. In this case, it would be characters that are not 1. |
| (A\|B) | The ```\|``` operator is used inside a round bracket for using an alternative pattern. In this case, A or B. |

**Quantifier Characters**
---------------------
Different from special characters, the quantifier characters are used to count or quantify the matching requirements. An example would be if you wanted a string to contain a number n times in a row (where n is any number).

| Characters | Description |
| --- | --- |
| * | Used to match the preceding character. |
| + | Used to match one or more characters in a row. |
| {n} | Used to match the number of the preceding character defined by numeric inside curly braces. |
| {n,} | Used to make sure that it matches at least n times. |
| {n, m} | Matching from preceding character from n number of times to m number of times. |
| ? | Makes preceding characters match as optional. |


**Methods**
--------------
Very useful methods in the regex class. Some of these methods can be seen in my [text editor program](https://github.com/Kttra/TextEditor).

| Method | Description |
| --- | --- |
| IsMatch(string text) | This method allows the user to provide a character sequence for matching a string. |
| IsMatch(string text, int position) | This method returns a Boolean value and takes two parameters. The string is a regex constructor that will match with the character sequence from the start position given by the integer parameter. |
| IsMatch(String text, String pattern) | Accepts two parameters and returns a Boolean value. The first parameter is the text in which the user needs to find a pattern and the next parameter provide the pattern which the user is searching in the given text. |
| Replace(String text, String replacementText) | Accepts two parameters and returns a string value. The first parameter is the character sequence or regex that you want to use for the match and the second parameter is the replacement string. |
| Split(string text) | Accepts string input as a parameter and returns an array containing substrings. |

**Regex Methods in Action**
-----------------------------------
Examples of how some of the methods work.

```csharp
string patternText = "Hello";
Regex reg = new Regex(patternText);

//IsMatch(string input)
Console.WriteLine(reg.IsMatch("Hello World")); //True

//IsMatch(string input, int index) - input string and the index from where the match has to start
Console.WriteLine(reg.IsMatch("Hello", 0)); //True

//IsMatch(string input, string pattern)
Console.WriteLine(Regex.IsMatch("Hello World", patternText)); //True

//Replace(string input, string replacement)
Console.WriteLine(reg.Replace("Hello World", "Replace")); //Replace World

//Split(string input, string pattern)
string[] arr = Regex.Split("Hello_World_Today", "_");
foreach(string subStr in arr)
{
    Console.Write(subStr + " "); //Hello World Today
}
```

**Pattern Example**
------------------------
The pattern below specifies that we want a word consisting of any letters and it has to be 6 characters long.

```csharp
string patternText = @"^[a-zA-Z]{6}$";
Regex reg = new Regex(patternText);

//When pattern matches
Console.WriteLine(reg.IsMatch("active")); //True

//When pattern doesnt match
Console.WriteLine(reg.IsMatch("aced")); //False
```

This is another example. In this pattern we want the string to **start with "hello"** and **has a space after** it.
```csharp
string patternText = @"^Hello\s";
Regex reg = new Regex(patternText);

//When pattern matches
Console.WriteLine(reg.IsMatch("Hello world")); //True

Console.WriteLine(reg.IsMatch("Well, Hello to you too")); //False

//When pattern doesnt match
Console.WriteLine(reg.IsMatch("HelloWorld")); //False
```

Below is an example of wanting a string with a **specific ending extension**. The "\w" denotes we will accept any character (alphanumeric and special characters) while the "+" means that we will allow for the "\w" condition can repeat 1 or more times.

```csharp
string patternText = @"(\w+)\.(jpg|png|jpeg|gif)$";

Regex reg = new Regex(patternText);

//When pattern matches, All True
Console.WriteLine(reg.IsMatch("abc.jpg"));
Console.WriteLine(reg.IsMatch("abcd.gif"));
Console.WriteLine(reg.IsMatch("abcde.png"));

//When pattern doesnt match, All false
Console.WriteLine(reg.IsMatch(".jpg"));
Console.WriteLine(reg.IsMatch("ask.jpegj"));
```

Below is an example of of a **website pattern**.

```csharp
string patternText = @"^www.[a-zA-Z0-9]{3,20}.(com|in|org|co\.in|net|dev)$";

Regex reg = new Regex(patternText);

//When pattern matches, true
Console.WriteLine(reg.IsMatch("www.yahoo.com"));

//When pattern doesnt match, false
Console.WriteLine(reg.IsMatch("ww.bgerg40j.movie"));
```

Below is an example of a **email pattern**.

```csharp
string patternText = @"^[a-zA-Z0-9\._-]{5,25}.@.[a-z]{2,12}.(com|org|co\.in|net)";
 
Regex reg = new Regex(patternText);

//When pattern matches, true
Console.WriteLine(reg.IsMatch("myName@gmail.com"));
Console.WriteLine(reg.IsMatch("personal.Mail@yahoo.co.in"));

//When pattern doesnt match, false
Console.WriteLine(reg.IsMatch("ww.htr23d.su@b.dot"));
```

