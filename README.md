# Json2CSharpString
WinForms-app simple tool to convert raw JSON to valid multiline C# string

Example:

input
{"name":"John Smigh","messages":["hello wolrd","test","ping google.com -t"],"age":119}

output
"{\"name\":\"John Smigh\",\"messages\":[" + 
"\"hello wolrd\",\"test\",\"ping google.c" + 
"om -t\"],\"age\":119}"