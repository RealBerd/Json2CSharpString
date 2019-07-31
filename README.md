# Json to C# string
WinForms-app simple tool to convert raw JSON to valid multiline C# string

Example:

Input
    
```json
{"name":"John Smigh","messages":["hello wolrd","test","ping google.com -t"],"age":119}
```

Output

```csharp
"{\"name\":\"John Smigh\",\"messages\":[" + 
"\"hello wolrd\",\"test\",\"ping google.c" + 
"om -t\"],\"age\":119}"
```
