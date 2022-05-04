# RegexPatterns
Realtime regex program in C#. Used to test regex expressions as this can become a very complicated topic. This regex program is made to show results while you type real-time to make it easier to understand how regex works. Below is some information on how the regex expression works. The regex class is from the namespace: System.Text.RegularExpression.

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


**Methods**
--------------
Very useful methods in the regex class. Some of these methods can be seen in my [text editor](https://github.com/Kttra/TextEditor) program.

| Method | Description |
| --- | --- |
| IsMatch(string text) | This method allows the user to provide a character sequence for matching a string. |
| IsMatch(string text, int position) | This method returns a Boolean value and takes two parameters. The string is a regex constructor that will match with the character sequence from the start position given by the integer parameter. |
| IsMatch(String text, String pattern) | Accepts two parameters and returns a Boolean value. The first parameter is the text in which the user needs to find a pattern and the next parameter provide the pattern which the user is searching in the given text. |
| Replace(String text, String replacementText) | Accepts two parameters and returns a string value. The first parameter is the character sequence or regex that you want to use for the match and the second parameter is the replacement string. |
| Split(string text) | Accepts string input as a parameter and returns an array containing substrings. |
