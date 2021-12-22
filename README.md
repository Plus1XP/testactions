# EVLib
Personal library targeting .NET Standard

**Class Libraries**

[ConsoleTools](#consoletools)

[Converters](#converters)

[Debugging](#debugging)

[Enums](#enums)

[Extensions](#extensions)

[FileIO](#fileio)

[Interfaces](#interfaces)

[Mail](#mail)

[Mathamatics](#mathamatics)

# ConsoleTools

[`TextUI`](#evlibconsoletoolstextui)

[`TextHeader`](#evlibconsoletoolstextheader--textui)

---

## EVLib.ConsoleTools.TextUI

**Constructors** :

[`public TextUI()`]

**Methods**

[`public String GetTextResponse(String DisplayText)`](#gettextresponse-displaytext)

[`public Char GetCharResponse(String DisplayText)`](#getcharresponse-displaytext)

[`public Int32 GetNumericResponse(String DisplayText, Int32 minSelection, Int32 maxSelection)`](#getnumericresponse-displaytext-minselection-maxselection)

[`public String GetResponse()`](#getresponse)

[`public Void AwaitResponse()`](#awaitresponse)

[`public Void ChangeTextColour(ConsoleColor colour)`](#changetextcolour-colour)

[`public Void ResetTextColour()`](#resettextcolour)

[`public Void SetConsoleTitle(String title)`](#setconsoletitle-title)

[`public Void Print(String text)`](#print-text)

[`public Void PrintToCenterScreen(String text)`](#printtocenterscreen-text)

[`public Void PrintBlankLine()`](#printblankline)

[`public Void ClearScreen()`](#clearscreen)

---

### GetTextResponse (DisplayText)

***Summary***

Reads a string (word) from the console using Console.ReadLine.
Method will loop until a valid string is entered.
(Unacceptable values includes non-letters and whitespaces).

***Declaration***

```cs
public string GetTextResponse(string DisplayText)
```

***Parameter***

`string` DisplayText

String to be displayed before user input.

***Return***

`string`

A String in lowercase.

***Usage***

```cs
EVLib.ConsoleTools.TextUI textUI = new EVLib.ConsoleTools.TextUI();

string response = textUI.GetTextResponse("Enter name");
```

---

### GetCharResponse (DisplayText)

***Summary***

Reads a String (single letter) from the console using Console.ReadLine.
Method will loop until a valid string is entered.
(Unacceptable values includes non-letters and whitespaces).

***Declaration***

```cs
public char GetCharResponse(string DisplayText)
```

***Parameter***

`string` DisplayText

String to be displayed before user input.

***Return***

`char`

A Char in lowercase.

***Usage***

```cs
EVLib.ConsoleTools.TextUI textUI = new EVLib.ConsoleTools.TextUI();

char response = textUI.GetCharResponse("Enter initial");
```

---

### GetNumericResponse (DisplayText, MinSelection, MaxSelection)

***Summary***

Reads a String (numbers) from the console using Console.ReadLine.
Method will loop until a valid number is entered.
(Unacceptable values includes non-numeric or Values outside of Min/Max Scope).

***Declaration***

```cs
public int GetNumericResponse(string DisplayText, int minSelection, int maxSelection)
```

***Parameter***

`string` DisplayText

String to be displayed before user input.

`int` minSelection

The minimum Int to be accepted.

`int` maxSelection

the Maximum Int to be accepted.

***Return***

`int`

An Int.

***Usage***

```cs
EVLib.ConsoleTools.TextUI textUI = new EVLib.ConsoleTools.TextUI();

int response = textUI.GetNumericResponse("Enter age", 0, 120);
```

---

### GetResponse

***Summary***

Executes Console.ReadLine Method.

***Declaration***

```cs
public string GetResponse()
```

***Return***

`string`

String of characters from input stream.

***Usage***

```cs
EVLib.ConsoleTools.TextUI textUI = new EVLib.ConsoleTools.TextUI();

string response = textUI.GetResponse();
```

---

### AwaitResponse

***Summary***

Waits for user input by using the Console.ReadKey Method.

***Declaration***

```cs
public void AwaitResponse()
```

***Usage***

```cs
EVLib.ConsoleTools.TextUI textUI = new EVLib.ConsoleTools.TextUI();

textUI.AwaitResponse();
```

---

### ChangeTextColour (Colour)

***Summary***

Sets the foreground colour of the console.

***Declaration***

```cs
public void ChangeTextColour(ConsoleColor colour)
```

***Parameter***

```cs
<param name="colour">The enum of a specified colour.</param>
```

***Usage***

```cs
using System;

EVLib.ConsoleTools.TextUI textUI = new EVLib.ConsoleTools.TextUI();

textUI.ChangeTextColour(ConsoleColor.Green);
```

---

### ResetTextColour

***Summary***

Resets the console colour to default.

***Declaration***

```cs
public void ResetTextColour()
```

***Usage***

```cs
EVLib.ConsoleTools.TextUI textUI = new EVLib.ConsoleTools.TextUI();

textUI.ResetTextColour();
```

---

### SetConsoleTitle (Title)

***Summary***

Sets the console title bar text.

***Declaration***

```cs
public void SetConsoleTitle(string title)
```

***Parameter***

`string` title

Text to be displayed in the console title bar.

***Usage***

```cs
EVLib.ConsoleTools.TextUI textUI = new EVLib.ConsoleTools.TextUI();

textUI.SetConsoleTitle("MobileApp");
```

---

### Print (Text)

***Summary***

Prints a string to the console.

***Declaration***

```cs
public void Print(string text)
```

***Parameter***

`string` text

String value to be printed.

***Usage***

```cs
EVLib.ConsoleTools.TextUI textUI = new EVLib.ConsoleTools.TextUI();

textUI.Print("Sample Text");
```

---

### PrintToCenterScreen (Text)

***Summary***

Prints a string Aligned to the center of the console. Can be used with decoration if used inside menu or header.

***Declaration***

```cs
public void PrintToCenterScreen(string text)
```

***Parameter***

`string` text

Content to center.

***Usage***

```cs
EVLib.ConsoleTools.TextUI textUI = new EVLib.ConsoleTools.TextUI();

textUI.PrintToCenterScreen("<- Center Screen! ->");
```

---

### PrintBlankLine

***Summary***

Prints a blank line using the newline string (Uses Environment.NewLine (\r\n)).

***Declaration***

```cs
public void PrintBlankLine()
```

***Usage***

```cs
EVLib.ConsoleTools.TextUI textUI = new EVLib.ConsoleTools.TextUI();

textUI.PrintBlankLine();
```

---

### ClearScreen

***Summary***

Clears console.

***Declaration***

```cs
public void ClearScreen()
```

***Usage***

```cs
EVLib.ConsoleTools.TextUI textUI = new EVLib.ConsoleTools.TextUI();

textUI.ClearScreen();
```

---

## EVLib.ConsoleTools.TextHeader : [TextUI](#evlibconsoletoolstextui)

**Constructors** :

[`public TextHeader()`]

**Methods** :

[public Void PrintHeader()](#printheader)

[`public Void PrintHeader(String contact)`](#printheader-contact)

[`public Void PrintHeader(String contact, String dismiss)`](#printheader-contact-dismiss)

[`public Void PrintHeader(String title, String version, String release)`](#printheader-title-version-release)

[`public Void PrintHeader(String title, String version, String release, String contact)`](#printheader-title-version-release-contact)

[`public Void PrintHeader(String title, String version, String release, String contact, String dismiss)`](#printheader-title-version-release-contact-dismiss)

---

### PrintHeader

***Summary***

Application header, also sets the console title.

***Declaration***

```cs
public void PrintHeader()
```

***Usage***

```cs
EVLib.ConsoleTools.TextHeader textHeader = new EVLib.ConsoleTools.TextHeader();

textHeader.PrintHeader();
```

---

### PrintHeader (Contact)

***Summary***

Application header, also sets the console title, with the Authors contact information.

***Declaration***

```cs
public void PrintHeader(string contact)
```

***Parameter***

`string` contact

Authors contact information.

***Usage***

```cs
EVLib.ConsoleTools.TextHeader textHeader = new EVLib.ConsoleTools.TextHeader();

textHeader.PrintHeader("https://www.contoso.com");
```

---

### PrintHeader (Contact, Dismiss)

***Summary***

Application header, also sets the console title, with Authors contact information & Message to dismiss header.

***Declaration***

```cs
public void PrintHeader(string contact, string dismiss)
```

***Parameter***

`string` contact

Authors contact information.

`string` dismiss

Message to dismiss header.

***Usage***

```cs
EVLib.ConsoleTools.TextHeader textHeader = new EVLib.ConsoleTools.TextHeader();

textHeader.PrintHeader("https://www.contoso.com", "Press any key to dismiss...");
```

---

### PrintHeader (Title, Version, Release)

***Summary***

Application header, also sets the console title, with Version of application & Date of build.

***Declaration***

```cs
public void PrintHeader(string title, string version, string release)
```

***Parameter***

`string` title

Title of application.

`string` version

Version of application.

`string` release

Date of build.

***Usage***

```cs
EVLib.ConsoleTools.TextHeader textHeader = new EVLib.ConsoleTools.TextHeader();

textHeader.PrintHeader("MobileApp", "Version 1.0.0", "01/Jan/2000");
```

---

### PrintHeader (Title, Version, Release, Contact)

***Summary***

Application header, also sets the console title, with Version of application, Date of build & Authors contact information.

***Declaration***

```cs
public void PrintHeader(string title, string version, string release, string contact)
```

***Parameter***

`string` title

Title of application.

`string` version

Version of application.

`string` release

Date of build.

`string` contact

Authors contact information.

***Usage***

```cs
EVLib.ConsoleTools.TextHeader textHeader = new EVLib.ConsoleTools.TextHeader();

textHeader.PrintHeader("MobileApp", "Version 1.0.0", "01/Jan/2000", "https://www.contoso.com");
```

---

### PrintHeader (Title, Version, Release, Contact, Dismiss)

***Summary***

Application header, also sets the console title, with Version of application, Date of build, Authors contact information & Message to dismiss header.

***Declaration***

```cs
public void PrintHeader(string title, string version, string release, string contact, string dismiss)
```

***Parameter***

`string` title

Title of application.

`string` version

Version of application.

`string` release

Date of build.

`string` contact

Authors contact information.

`string` dismiss

Message to dismiss header.

***Usage***

```cs
EVLib.ConsoleTools.TextHeader textHeader = new EVLib.ConsoleTools.TextHeader();

textHeader.PrintHeader("MobileApp", "Version 1.0.0", "01/Jan/2000", "https://www.contoso.com", "Press any key to dismiss...");
```

---

# Converters

[`BooleanToVisibility`](#evlibconvertersbooleantovisibility--ivalueconverter)

---

## EVLib.Converters.BooleanToVisibility : IValueConverter

**Methods** :

[`public Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture)`](#convert)

[`public Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture)`](#convertback)

---

### Convert

***Summary***

Convert Boolean to Visibility.

***Declaration***

```cs
public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
```

***Parameter***

`Object` value

Boolean.

`Type` targetType

Visibility.

`Object` parameter

Null.

`CultureInfo` culture

Null.

***Return***

`Object`

Visible or Hidden.

***Usage***

```xml
<!--Define Resource-->
<BooleanToVisibilityConverter x:Key="BoolToVisibilityConverter"/>

<!--Use it in binding-->
<Button Visibility="{Binding AllowEditing, Converter={StaticResource BoolToVisibilityConverter}}"/>
```

---

### ConvertBack

***Summary***

Convert Visibility to Boolean.

***Declaration***

```cs
public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
```

***Parameter***

`Object` value

Boolean.

`Type` targetType

Visibility.

`Object` parameter

Null.

`CultureInfo` culture

Null.


***Return***

`Object`

Boolean Value.

***Usage***

```xml
<!--Define Resource-->
<BooleanToVisibilityConverter x:Key="BoolToVisibilityConverter"/>

<!--Use it in binding-->
<Button Visibility="{Binding AllowEditing, Converter={StaticResource BoolToVisibilityConverter}}"/>
```

---

# Debugging

[`Actions`](#evlibdebuggingactions)

---

## EVLib.Debugging.Actions  

**Methods** :

[`public static Void Time(Action action)`](#time-action)  

---

### Time (Action)

***Summary***

Times how long it takes to perform an action.

***Declaration***

```cs
public static string Time(Action action)
```

***Parameter***

`Action` action

Method with no parameters.

***Return***

`string` 

Time elapsed (minutes\seconds\hundredths).

***Usage***

```cs
string timeElapsed = EVLib.Debugging.Actions.Time(() =>
{
    ActionToMeasure()
});
Debug.Print(timeElapsed);
```

---

# Enums

[`Visibility`](#evlibenumsvisibility)

---

## EVLib.Enums.Visibility

---

### Visibility

***Summary***

Gets or Sets the user interface (UI) visibility of this element.

***Declaration***

```cs
Values :
0 : Visible,
1 : Hidden,
2 : Collapsed
```

***Usage***

```cs
return (bool)value ? Visibility.Visible : Visibility.Hidden;
```

---

# Extensions

[`ObjectExtension`](#evlibextensionsobjectextension)

[`StringExtension`](#evlibextensionsstringextension)

---

## EVLib.Extensions.ObjectExtension

**Methods** :

[`public static void ShallowCopy(this object destinationObjct, object sourceObject)`](#shallowcopy)

---

### ShallowCopy

***Summary***

Copies all fields and properties from one Object to another.

***Declaration***

```cs
public static void ShallowCopy(this object destinationObject, object sourceObject)
```

***Parameter***

`object` destinationObject

The destination Object.

`object` sourceObject

The source Object.

***Usage***

```cs
using EVLib.Extensions;

destinationObject.ShallowCopy(sourceObject);
```

---

## EVLib.Extensions.StringExtension

**Methods** :

[`public static string Between(this string value, string a, string b)`](#between)

[`public static string Before(this string value, string a)`](#before)

[`public static string After(this string value, string a)`](#after)

[`public static string RemoveWords(this string value, string[] excludedWords)`](#removewords)

[`public static string ReplaceLetters(this string wordToSearch, char letterToFind, char letterToReplace)`](#replaceletters)

[`public static string ReduceWhitespaces(this string value)`](#reducewhitespaces)

---

### Between

***Summary***

Find the substring value between the **First** (`a`) and **Last** (`b`) values and return the string value between.

***Declaration***

```cs
public static string Between(this string value, string a, string b)
```

***Parameter***

`string` a

First String value.

`string` b

Last String value.

***Returns***

`string`

The substring between the 2 string values.

***Usage***

```cs
using EVLib.Extensions;

string testString = "Hello! i am a simple string for testing";

string results = testString.Between("a ", "for");

Console.WriteLine(results);
```

***Output***

> simple string

---

### Before

***Summary***

Find the first substring value (`a`) and return the string value before.

***Declaration***

```cs
public static string Before(this string value, string a)
```

***Parameter***

`string` a

First String.

***Returns***

`string`

The substring before the first string value.

***Usage***

```cs
using EVLib.Extensions;

string testString = "Hello! i am a simple string for testing";

string results = testString.Before(" for testing");

Console.WriteLine(results);
```

***Output***

> Hello! i am a simple string

---

### After

***Summary***

Find the first substring value (`a`) and return the string value after.

***Declaration***

```cs
public static string After(this string value, string a)
```

***Parameter***

`string` a

Last String.

***Returns***

`string`

The substring After the first string value.

***Usage***

```cs
using EVLib.Extensions;

string testString = "Hello! i am a simple string for testing";

string results = testString.After("for ");

Console.WriteLine(results);
```

***Output***

> testing

---

### RemoveWords

***Summary***

Find each string from the `[excludedWords]` array and remove the equivalent match in the source string.

***Declaration***

```cs
public static string RemoveWords(this string value, string[] excludedWords)
```

***Parameter***

`string[]` excludedWords

Array of strings.

***Returns***

`string`

The substring with the excluded words removed.

***Usage***

```cs
using EVLib.Extensions;

string testString = "Hello! i am a simple string for testing";

string results = testString.RemoveWords(new string[] { "simple", "for", "testing" });

Console.WriteLine(results);
```

***Output***

> Hello! i am a string

---

### ReplaceLetters

***Summary***

Find all char (`letterToFind`) within the source string and replace with alternative char (`letterToReplace`).

***Declaration***

```cs
public static string ReplaceLetters(this string wordToSearch, char letterToFind, char letterToReplace)
```

***Parameter***

`char` letterToFind

Char to find in source string.

`char` letterToReplace

Char to replace.

***Returns***

`string`

The substring with letters replaced upon match.

***Usage***

```cs
using EVLib.Extensions;

string testString = "Hello! i am a simple string for testing";

string results = testString.ReplaceLetters("e", "3");

Console.WriteLine(results);
```

***Output***

> H3llo! i am a simpl3 string for t3sting

---

### ReduceWhitespaces

***Summary***

Get string value after removing any **extra** white spaces.

***Declaration***

```cs
public static string ReduceWhitespaces(this string value)
```

***Parameter***

`string` value

String to inspect for any extra white spaces.

***Returns***

`string`

A Single spaced string.

***Usage***

```cs
using EVLib.Extensions;

string testString = "Hello!  i   am   a   simple  string  for  testing";

string results = testString.ReduceWhitespaces();

Console.WriteLine(results);
```

***Output***

> Hello! i am a simple string for testing"

---

# FileIO

[`FileManager`](#evlibfileiofilemanager)

[`CalendarManager`](#evlibfileiocalendarmanager--filemanager)

[`XMLManager`](#evlibfileioxmlmanager--filemanager)

[`EncryptorManager`](#evlibfileioencryptormanager--filemanager)

[`EncryptionManager`](#evlibfileioencryptionmanager)

---

## EVLib.FileIO.FileManager

**Constructors** :

[`public FileManager()`]

**Methods** :

[`public Boolean IsFolderCreated(folderPath)`](#isfoldercreated-folderpath)

[`public Boolean IsFileCreated(filePath)`](#isfilecreated-filepath)

[`public Void CreateFolder(folderPath)`](#createfolder-folderpath)

[`public Void CreateFile(filePath)`](#createfile-filepath)

[`public Void ClearFile(filePath)`](#clearfile-filepath)

[`public Void DeleteFolder(folderPath)`](#deletefolder-folderpath)

[`public Void DeleteFile(filePath)`](#deletefile-filepath)

[`public Void SaveToFile(filePath, Value)`](#savetofile-filepath-string-value)

[`public Void SaveToFile(filePath, Value)`](#savetofile-filepath-byte-value)

[`public String ReadStringFromFile(filePath)`](#readstringfromfile-filepath)

[`public Byte[] ReadBytesFromFile(filePath)`](#readbytesfromfile-filepath)

[`public String ReadLineFromFile(filePath, lineNumber)`](#readlinefromfile-filepath-linenumber)

---

### IsFolderCreated (FolderPath)

***Summary***

Checks if folder exists.

***Declaration***

```cs
public bool IsFolderCreated(string folderPath)
```

***Parameter***

`string` folderPath

Path to folder.

***Return***

`bool`

Boolean true if folder exists, false if folder does not exist.

***Usage***

```cs

private string folderName = "TestFolder";

private string[] fullFolderPath = new string[] { Directory.GetCurrentDirectory(), folderName };

private string folderPath = Path.Combine(fullFolderPath);

EVLib.FileIO.FileManager fileManager = new EVLib.FileIO.FileManager();

if (!fileManager.IsFolderCreated(folderPath))
{
    fileManager.CreateFolder(folderPath);
}
```

---

### IsFileCreated (filePath)

***Summary***

Checks if file exists.

***Declaration***

```cs
public bool IsFileCreated(string filePath)
```

***Parameter***

`string` filePath

Path to file.

***Return***

`bool`

Boolean true if file exists, false if file does not exist.

***Usage***

```cs
private string fileName = "TestFile.txt";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.FileManager fileManager = new EVLib.FileIO.FileManager();

if (!fileManager.IsFileCreated(filePath))
{
    fileManager.CreateFile(filePath);
}
```

---

### CreateFolder (folderPath)

***Summary***

Creates folder in the specified path.

***Declaration***

```cs
public void CreateFolder(string folderPath)
```

***Parameter***

`string` folderPath

Path to folder.

***Usage***

```cs
private string folderName = "TestFolder";

private string[] fullFolderPath = new string[] { Directory.GetCurrentDirectory(), folderName };

private string folderPath = Path.Combine(fullFolderPath);

EVLib.FileIO.FileManager fileManager = new EVLib.FileIO.FileManager();

fileManager.CreateFolder(folderPath);
```

---

### CreateFile (filePath)

***Summary***

Creates file in the specified path.

***Declaration***

```cs
public void CreateFile(string filePath)
```

***Parameter***

`string` filePath

Path to a file.

***Usage***

```cs
private string fileName = "TestFile.txt";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.FileManager fileManager = new EVLib.FileIO.FileManager();

fileManager.CreateFile(filePath);
```

---

### ClearFile (filePath)

***Summary***

Overwrites file with an empty string.

***Declaration***

```cs
public void ClearFile(string filePath)
```

***Parameter***

`string` filePath

Path to file.

***Usage***

```cs
private string fileName = "TestFile.txt";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.FileManager fileManager = new EVLib.FileIO.FileManager();

fileManager.ClearFile(fileName);
```

---

### DeleteFolder (folderPath)

***Summary***

Deletes folder from the specified path.

***Declaration***

```cs
public void DeleteFolder(string folderPath)
```

***Parameter***

`string` folderPath

Path to folder.

***Usage***

```cs
private string folderName = "TestFolder";

private string[] fullFolderPath = new string[] { Directory.GetCurrentDirectory(), folderName };

private string folderPath = Path.Combine(fullFolderPath);

EVLib.FileIO.FileManager fileManager = new EVLib.FileIO.FileManager();

fileManager.DeleteFolder(folderName);
```

***Remarks***

This operation is recursive and will delete all subdirectories and files.

---

### DeleteFile (filePath)

***Summary***

Deletes file from the specified path and in case of error will wait and try again.

***Declaration***

```cs
public void DeleteFile(string filePath)
```

***Parameter***

`string` filePath

Path to file.

***Usage***

```cs
private string fileName = "TestFile.txt";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.FileManager fileManager = new EVLib.FileIO.FileManager();

fileManager.DeleteFile(filePath);
```

***Remarks***

Retry pattern tries 3 times (NumberOfRetries) with a 1 second delay (DelayOnretry).

---

### SaveToFile (filePath, string value)

***Summary***

Writes a String to a file on disk.

***Declaration***

```cs
public void SaveToFile(string filePath, string Value)
```

***Parameter***

`string` filePath

Path to file.

`string` Value.

String value to save.

***Usage***

```cs
private string sampleString = "Some sample text";

private string fileName = "TestFile.txt";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.FileManager fileManager = new EVLib.FileIO.FileManager();

fileManager.SaveToFile(filePath, sampleString);
```

---

### SaveToFile (filePath, byte value)

***Summary***

Writes an array of bytes to a file on disk.

***Declaration***

```cs
public void SaveToFile(string filePath, byte[] Value)
```

***Parameter***

`string` filePath

Path to file.

`byte[]` Value

Byte array to save.

***Usage***

```cs
private byte[] sampleBytes = { 72, 101, 108, 108, 111, 44, 32, 73, 32, 104, 97, 118, 101, 32, 110, 111, 116, 104, 105, 110, 103, 32, };

private string fileName = "TestFile.txt";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.FileManager fileManager = new EVLib.FileIO.FileManager();

fileManager.SaveToFile(testFile, sampleBytes);
```

---

### ReadStringFromFile (filePath)

***Summary***

Reads text from file on disk.

***Declaration***

```cs
public string ReadStringFromFile(string filePath)
```

***Parameter***

`string` filePath

Path to file.

***Return***

`string`

String containing all text from file.

***Usage***

```cs
private string fileName = "TestFile.txt";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.FileManager fileManager = new EVLib.FileIO.FileManager();

string textFromFile = fileManager.ReadStringFromFile(filePath);
```

---

### ReadBytesFromFile (filePath)

***Summary***

Reads bytes from file on disk.

***Declaration***

```cs
public byte[] ReadBytesFromFile(string filePath)
```

***Parameter***

`string` filePath

Path to file.

***Return***

`byte[]`

Byte Array containing all text from file.

***Usage***

```cs
private string fileName = "TestFile.txt";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.FileManager fileManager = new EVLib.FileIO.FileManager();

byte[] bytesFromFile = fileManager.ReadBytesFromFile(filePath);
```

---

### ReadLineFromFile (filePath, Linenumber)

***Summary***

Reads a specific line from a file on disk.

***Declaration***

```cs
public string ReadLineFromFile(string filePath, int lineNumber)
```

***Parameter***

`string` filePath

Path to file.

`int`

Line number to read.

***Return***

`string`

String containing text from specific line number.

***Usage***

```cs
private int lineToRead = 11;

private string fileName = "TestFile.txt";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.FileManager fileManager = new EVLib.FileIO.FileManager();

string lineFromFile = fileManager.ReadLineFromFile(filePath, lineToRead);
```

---

## EVLib.FileIO.CalendarManager : [FileManager](#evlibfileiofilemanager)

**Constructors** :

[`public CalendarManager()`]

**Methods** :

[`public DateTime ParseDateTimeToUTC(String dateTime)`](#parsedatetimetoutc-datetime)

[`public DateTime ParseDateTimeToLocal(String dateTime)`](#parsedatetimetolocal-datetime)

[`public Void CreateCalendarEntry(String productID)`](#createcalendarentry-productid)

[`public Void CreateGMTCalendarTimeZoneEntry()`](#creategmtcalendartimezoneentry)

[`public Void CreateCalendarEvent(DateTime startTime, DateTime endTime, String subject, String location, String description)`](#createcalendarevent-starttime-endtime-subject-location-description)

[`public Void CreateCalendarAlarmEntry(Int32 trigger, String subject)`](#createcalendaralarmentry-trigger-subject)

[`public Void CloseEventEntry()`](#closeevententry)

[`public Void CloseCalendarEntry()`](#closecalendarentry)

[`public String CreateICSFile(String filePath)`](#createicsfile-filepath)

[`public String ReadICSFile(String filePath)`](#readicsfile-filepath)

[`public String DeleteICSFile(String filePath)`](#deleteicsfile-filepath)

---

### ParseDateTimeToUTC (dateTime)

***Summary***

Converts a String to a UTC DateTime equivalent.

***Declaration***

```cs
public DateTime ParseDateTimeToUTC(string dateTime)
```

***Parameter***

`string` dateTime

String representation of a date and time.

***Return***

`DateTime`

UTC DateTime.

***Usage***

```cs
EVLib.FileIO.CalendarManager calendarManager = new EVLib.FileIO.CalendarManager();

DateTime HalloweenDateTime = calendarManager.ParseDateTimeToUTC("2021-10-31T15:34:56+03:00");

Console.WriteLine(HalloweenDateTime.ToString());
```

***Output***

> 31/10/2021 12:34:56

---

### ParseDateTimeToLocal (dateTime)

***Summary***

converts a String to a Local DateTime equivalent.

***Declaration***

```cs
public DateTime ParseDateTimeToLocal(string dateTime)
```

***Parameter***

`string` dateTime

String representation of a date and time.

***Return***

`DateTime`

Local DateTime.

***Usage***

```cs
EVLib.FileIO.CalendarManager calendarManager = new EVLib.FileIO.CalendarManager();

DateTime HalloweenDateTime = calendarManager.ParseDateTimeToLocal("2021-10-31T15:34:56+03:00");

Console.WriteLine(HalloweenDateTime.ToString());
```

***Output***

> 31/10/2021 12:34:56

---

### CreateCalendarEntry (productID)

***Summary***

Starts an iCaldendar entry.

***Declaration***

```cs
public void CreateCalendarEntry(string productID)
```

***Parameter***

`string` productID

Specifies the identifier for the product that created the iCalendar object.

***Usage***

```cs
EVLib.FileIO.CalendarManager calendarManager = new EVLib.FileIO.CalendarManager();

calendarManager.CreateCalendarEntry("Plus1XP//ReadMe//EN");
```

***Remarks***

(Note: Product ID must be in the format - CompanyName//Product//EN)

---

### CreateGMTCalendarTimeZoneEntry

***Summary***

Adds GMT timezone to the iCalendar entry.

***Declaration***

```cs
public void CreateGMTCalendarTimeZoneEntry()
```

***Usage***

```cs
EVLib.FileIO.CalendarManager calendarManager = new EVLib.FileIO.CalendarManager();

calendarManager.CreateGMTCalendarTimeZoneEntry();
```

---

### CreateCalendarEvent (startTime, endTime, subject, location, description)

***Summary***

Starts an iCalendar event.

***Declaration***

```cs
public void CreateCalendarEvent(DateTime startTime, DateTime endTime, string subject, string location, string description)
```

***Parameter***

`DateTime` startTime

Event UTC DateTime Start.

`DateTime` endTime

Event UTC DateTime End.

`string` subject

Event Subject.

`string` location

Event location.

`string` description

Event Description.

***Usage***

```cs
EVLib.FileIO.CalendarManager calendarManager = new EVLib.FileIO.CalendarManager();

calendarManager.CreateCalendarEvent("2021-10-31T18:00:00+00:00", "2021-10-31T20:00:00+00:00", "Halloween Party", "Plaza Hotel, London", "Annual Halloween party");
```

---

### CreateCalendarAlarmEntry (trigger, subject)

***Summary***

Adds alarm to the iCalendar entry.

***Declaration***

```cs
public void CreateCalendarAlarmEntry(int trigger, string subject)
```

***Parameter***

`int` trigger

Specifies when the alarm will trigger (minutes).

`string` subject

Alarm Subject.

***Usage***

```cs
EVLib.FileIO.CalendarManager calendarManager = new EVLib.FileIO.CalendarManager();

calendarManager.CreateCalendarAlarmEntry(-30, "Halloween Party");
```

***Remarks***

-PT will alaram before the trigger, PT will alarma after the trigger.

---

### CloseEventEntry

***Summary***

Closes the iCalendar event.

***Declaration***

```cs
public void CloseEventEntry()
```

***Usage***

```cs
EVLib.FileIO.CalendarManager calendarManager = new EVLib.FileIO.CalendarManager();

calendarManager.CloseEventEntry();
```

---

### CloseCalendarEntry

***Summary***

Closes the iCalendar entry.

***Declaration***

```cs
public void CloseCalendarEntry()
```

***Usage***

```cs
EVLib.FileIO.CalendarManager calendarManager = new EVLib.FileIO.CalendarManager();

calendarManager.CloseCalendarEntry();
```

---

### CreateICSFile (filePath)

***Summary***

Writes all iCalendar entries to an ICS file.

***Declaration***

```cs
public string CreateICSFile(string filePath)
```

***Parameter***

`string` filePath

Path to file.

***Return***

`string`

Validaton string if succesfull.

***Usage***

```cs
private string fileName = "TestCalendar.ics";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.CalendarManager calendarManager = new EVLib.FileIO.CalendarManager();

string validation = calendarManager.CreateICSFile(string filePath)
```

---

### ReadICSFile (filePath)

***Summary***

Checks if ICS file exists then reads it.

***Declaration***

```cs
public string ReadICSFile(string filePath)
```

***Parameter***

`string` filePath

Path to file.

***Return***

`string`

All lines from ICS file, or "No Data" depending on if file exists.

***Usage***

```cs
private string fileName = "TestCalendar.ics";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.CalendarManager calendarManager = new EVLib.FileIO.CalendarManager();

string results = calendarManager.ReadICSFile(string filePath)
```

---

### DeleteICSFile (filePath)

***Summary***

Checks if ICS file exists then deletes it.

***Declaration***

```cs
public string DeleteICSFile(string filePath)
```

***Parameter***

`string` filePath

Path to file.

***Return***

`string`

Confirmation on if the ICS file was deleted.

***Usage***

```cs
private string fileName = "TestCalendar.ics";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.CalendarManager calendarManager = new EVLib.FileIO.CalendarManager();

string confirmation = calendarManager.DeleteICSFile(string filePath)
```

---

## EVLib.FileIO.XMLManager : [FileManager](#evlibfileiofilemanager)

**Samples**

[`Example XML Document`](#example-xml-document)

**Constructors** :

[`public XMLManager()`]

**Methods** :

[`public bool GetNodeAttributeValueAsBool(string xmlFileLocation, string nodePath, string nodeName, string nodeValue, string attributeName)`](#getnodeattributevalueasbool-xmlfilelocation-nodepath-nodename-nodevalue-attributename)

[`public int GetNodeAttributeValueAsInt(string xmlFileLocation, string nodePath, string nodeName, string nodeValue, string attributeName)`](#getnodeattributevalueasint-xmlfilelocation-nodepath-nodename-nodevalue-attributename)

[`public void SetNodeAttributeValueFromBool(string xmlFileLocation, string nodePath, string nodeName, string nodeValue, string attributeName, bool attributeValue)`](#setnodeattributevaluefrombool-xmlfilelocation-nodepath-nodename-nodevalue-attributename-attributevalue)

[`public void SetNodeAttributeValueFromInt(string xmlFileLocation, string nodePath, string nodeName, string nodeValue, string attributeName, int attributeValue)`](#setnodeattributevaluefromint-xmlfilelocation-nodepath-nodename-nodevalue-attributename-attributevalue)

[`public XmlDocument LoadXmlDocument(string xmlFileLocation)`](#loadxmldocument-xmlfilelocation)

[`public XmlNodeList LoadNodeList(XmlDocument xmlDoc, string nodePath)`](#loadnodelist-xmldoc-nodepath)

[`public void SaveXmlDocument(XmlDocument xmlDoc, string xmlFileLocation)`](#savexmldocument-xmldoc-xmlfilelocation)

[`public XmlNode GetNodeFromNodeList(XmlNodeList nodeList, string nodeName, string nodeValue)`](#getnodefromnodelist-nodelist-nodename-nodevalue)

[`public XmlAttribute GetAttributeFromNodeList(XmlNodeList nodeList, string nodeName, string nodeValue, string attributeName)`](#getattributefromnodelist-nodelist-nodename-nodevalue-attributename)

[`public string GetAttributeValueAsString(XmlAttribute attribute)`](#getattributevalueasstring-attribute)

[`public int GetAttributeValueAsInt(XmlAttribute attribute)`](#getattributevalueasint-attribute)

[`public bool GetAttributeValueAsBool(XmlAttribute attribute)`](#getattributevalueasbool-attribute)

[`public bool GetNodeAttributeValueAsBool(XmlNode node, string attributeName)`](#getnodeattributevalueasbool-node-attributename)

[`public XmlAttribute GetNodeAttribute(XmlNode node, string attributeName)`](#getnodeattribute-node-attributename)

[`public void SetNodeAttributeFromBool(XmlNode node, string attributeName, bool attributeValue)`](#setnodeattributefrombool-node-attributename-attributevalue)

---

### Example XML Document
```xml
<?xml version="1.0" encoding="UTF-8"?>
<Settings>
  <Formula1>
    <Event Name="Practice" Saved="True" />
    <Event Name="Qualifying" Saved="True" />
    <Event Name="Race" Saved="True" />
    <Event Name="Reminder" Saved="True" />
    <Event Name="Trigger" Saved="15" />
  </Formula1>
  <MotoGP>
    <Event Name="Practice" Saved="True" />
    <Event Name="Qualifying" Saved="True" />
    <Event Name="Warmup" Saved="False" />
    <Event Name="Race" Saved="True" />
    <Event Name="Moto2" Saved="False" />
    <Event Name="Moto3" Saved="False" />
    <Event Name="BehindTheScenes" Saved="False" />
    <Event Name="AfterTheFlag" Saved="False" />
    <Event Name="Reminder" Saved="True" />
    <Event Name="Trigger" Saved="15" />
  </MotoGP>
  <WorldSBK>
    <Event Name="Practice" Saved="True" />
    <Event Name="Superpole" Saved="True" />
    <Event Name="Warmup" Saved="False" />
    <Event Name="Race" Saved="True" />
    <Event Name="Reminder" Saved="True" />
    <Event Name="Trigger" Saved="15" />
  </WorldSBK>
</Settings>
```

### GetNodeAttributeValueAsBool (XmlFileLocation, NodePath, NodeName, NodeValue, AttributeName)

***Summary***

Gets boolean value from attribute in XML node.

***Declaration***

```cs
public bool GetNodeAttributeValueAsBool(string xmlFileLocation, string nodePath, string nodeName, string nodeValue, string attributeName)
```

***Parameter***

`string` xmlFileLocation

Path to XML file.

`string` nodePath

XML node path.

`string` nodeName

XML node name.

`string` nodeValue

XML node value.

`string` attributeName

XML attribute name.


***Return***

`bool`

XML attribute value as boolean.

***Usage***

```cs
private string fileName = "Settings.xml";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.XMLManager xmlManager = new EVLib.FileIO.XMLManager();

bool isQualifyingSaved = xmlManager.GetNodeAttributeValueAsBool(filePath, "/Settings/Formula1/Event", "Name", "Qualifying", "Saved");
```

---

### GetNodeAttributeValueAsInt (XmlFileLocation, NodePath, NodeName, NodeValue, AttributeName)

***Summary***

Gets Integer value from attribute in XML node.

***Declaration***

```cs
public int GetNodeAttributeValueAsInt(string xmlFileLocation, string nodePath, string nodeName, string nodeValue, string attributeName)
```

***Parameter***

`string` xmlFileLocation

Path to XML file.

`string` nodePath

XML node path.

`string` nodeName

XML node name.

`string` nodeValue

XML node value.

`string` attributeName

XML attribute name.

***Return***

`int`

XML attribute value as integer.

***Usage***

```cs
private string fileName = "Settings.xml";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.XMLManager xmlManager = new EVLib.FileIO.XMLManager();

int reminderTriggerMins = xmlManager.GetNodeAttributeValueAsInt(filePath, "/Settings/Formula1/Event", "Name", "Trigger", "Saved");
```

---

### SetNodeAttributeValueFromBool (XmlFileLocation, NodePath, NodeName, NodeValue, AttributeName, AttributeValue)

***Summary***

Sets boolean value to attribute in XML node.

***Declaration***

```cs
public void SetNodeAttributeValueFromBool(string xmlFileLocation, string nodePath, string nodeName, string nodeValue, string attributeName, bool attributeValue)
```

***Parameter***

`string` xmlFileLocation

Path to XML file.

`string` nodePath

XML node path.

`string` nodeName

XML node name.

`string` nodeValue

XML node value.

`string` attributeName

XML attribute name.

`string` attributeValue

Boolean value to set XML attribute value.

***Usage***

```cs
private string fileName = "Settings.xml";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.XMLManager xmlManager = new EVLib.FileIO.XMLManager();

xmlManager.SetNodeAttributeValueFromBool(filePath, "/Settings/Formula1/Event", "Name", "Qualifying", "Saved", true);
```

---

### SetNodeAttributeValueFromInt (XmlFileLocation, NdePath, NodeName, NodeValue, AttributeName, AttributeValue)

***Summary***

Sets integer value to attribute in XML node.

***Declaration***

```cs
public void SetNodeAttributeValueFromInt(string xmlFileLocation, string nodePath, string nodeName, string nodeValue, string attributeName, int attributeValue)
```

***Parameter***

`string` xmlFileLocation

Path to XML file.

`string` nodePath

XML node path.

`string` nodeName

XML node name.

`string` nodeValue

XML node value.

`string` attributeName

XML attribute name.

`string` attributeValue

Boolean value to set XML attribute value.

***Usage***

```cs
private string fileName = "Settings.xml";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.XMLManager xmlManager = new EVLib.FileIO.XMLManager();

xmlManager.SetNodeAttributeValueFromInt(filePath, "/Settings/Formula1/Event", "Name", "Trigger", "Saved", -15);
```

---

### LoadXmlDocument (XmlFileLocation)

***Summary***

Loads XML document from file.

***Declaration***

```cs
public XmlDocument LoadXmlDocument(string xmlFileLocation)
```

***Parameter***

`string` xmlFileLocation

Path to XML file.

***Return***

`XmlDocument`

XML Document.

***Usage***

```cs
private string fileName = "Settings.xml";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.XMLManager xmlManager = new EVLib.FileIO.XMLManager();

XmlDocument xmlDoc = xmlManager.LoadXmlDocument(filePath);
```

---

### LoadNodeList (XmlDoc, NodePath)

***Summary***

Loads XML node list from XML document.

***Declaration***

```cs
public XmlNodeList LoadNodeList(XmlDocument xmlDoc, string nodePath)
```

***Parameter***

`XmlDocument` xmlDoc

XML Document to load.

`string` nodePath

XML node path.

***Return***

`XmlNodeList`

XML node list.

***Usage***

```cs
private string fileName = "Settings.xml";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.XMLManager xmlManager = new EVLib.FileIO.XMLManager();

XmlNodeList nodeList = xmlManager.LoadNodeList(xmlManager.LoadXmlDocument(filePath), "/Settings/Formula1/Event");
```

---

### SaveXmlDocument (XmlDoc, XmlFileLocation)

***Summary***

Saves XML document to file.

***Declaration***

```cs
public void SaveXmlDocument(XmlDocument xmlDoc, string xmlFileLocation)
```

***Parameter***

`XmlDocument` xmlDoc

XML Document to load.

`string` xmlFileLocation

Path to XML file.

***Usage***

```cs
private string fileName = "Settings.xml";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.XMLManager xmlManager = new EVLib.FileIO.XMLManager();

XmlDocument xmlDoc = xmlManager.LoadXmlDocument(filePath);

// Amend xmlDoc here.

xmlManager.SaveXmlDocument(xmlDoc, filePath);
```

---

### GetNodeFromNodeList (NodeList, NodeName, NodeValue)

***Summary***

Gets a single node from an XML node list.

***Declaration***

```cs
public XmlNode GetNodeFromNodeList(XmlNodeList nodeList, string nodeName, string nodeValue)
```

***Parameter***

`XmlNodeList` nodeList

XML node list.

`string` nodeName

XML node name.

`string` nodeValue

XML node value.


***Return***

`XmlNode`

Single node.

***Usage***

```cs
private string fileName = "Settings.xml";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.XMLManager xmlManager = new EVLib.FileIO.XMLManager();

XmlDocument xmlDoc = xmlManager.LoadXmlDocument(filePath);

XmlNodeList nodeList = xmlManager.LoadNodeList(xmlDoc, "/Settings/Formula1/Event");

XmlNode node = xmlManager.GetNodeFromNodeList(nodeList, "Name", "Qualifying");
```

---

### GetAttributeFromNodeList (NodeList, NodeName, NodeValue, AttributeName)

***Summary***

Gets attribute from XML node list.

***Declaration***

```cs
public XmlAttribute GetAttributeFromNodeList(XmlNodeList nodeList, string nodeName, string nodeValue, string attributeName)
```

***Parameter***

`XmlNodeList` nodeList

XML node list.

`string` nodeName

XML node name.

`string` nodeValue

XML node value.

`string` attributeName

XML attribute name.

***Return***

`XmlAttribute`

XML attribute.

***Usage***

```cs
private string fileName = "Settings.xml";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.XMLManager xmlManager = new EVLib.FileIO.XMLManager();

XmlDocument xmlDoc = xmlManager.LoadXmlDocument(filePath);

XmlNodeList nodeList = xmlManager.LoadNodeList(xmlDoc, "/Settings/Formula1/Event");

XmlAttribute elementAttribute = xmlManager.GetAttributeFromNodeList(nodeList, "Name", "Qualifying", "Saved");
```

---

### GetAttributeValueAsString (Attribute)

***Summary***

Gets attribute string value from XML attribute.

***Declaration***

```cs
public string GetAttributeValueAsString(XmlAttribute attribute)
```

***Parameter***

`XmlAttribute` attribute

XML attribute.

***Return***

`string`

XML attribute value as string.

***Usage***

```cs
private string fileName = "Settings.xml";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.XMLManager xmlManager = new EVLib.FileIO.XMLManager();

XmlDocument xmlDoc = xmlManager.LoadXmlDocument(filePath);

XmlNodeList nodeList = xmlManager.LoadNodeList(xmlDoc, "/Settings/Formula1/Event");

XmlAttribute elementAttribute = xmlManager.GetAttributeFromNodeList(nodeList, "Name", "Qualifying", "Saved");

string stringAttributeValue = xmlManager.GetAttributeValueAsString(elementAttribute);
```

---

### GetAttributeValueAsInt (Attribute)

***Summary***

Gets attribute integer value from XML attribute.

***Declaration***

```cs
public int GetAttributeValueAsInt(XmlAttribute attribute)
```

***Parameter***

`XmlAttribute` attribute

XML attribute.

***Return***

`int`

XML attribute value as integer.

***Usage***

```cs
private string fileName = "Settings.xml";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.XMLManager xmlManager = new EVLib.FileIO.XMLManager();

XmlDocument xmlDoc = xmlManager.LoadXmlDocument(filePath);

XmlNodeList nodeList = xmlManager.LoadNodeList(xmlDoc, "/Settings/Formula1/Event");

XmlAttribute elementAttribute = xmlManager.GetAttributeFromNodeList(nodeList, "Name", "Qualifying", "Saved");

int intAttributeValue = xmlManager.GetAttributeValueAsInt(elementAttribute);
```

***Remarks***

If attribute is null method will return 0.

---

### GetAttributeValueAsBool (Attribute)

***Summary***

Gets attribute boolean value from XML attribute.

***Declaration***

```cs
public bool GetAttributeValueAsBool(XmlAttribute attribute)
```

***Parameter***

`XmlAttribute` attribute

XML attribute.

***Return***

`bool`

XML attribute value as boolean.

***Usage***

```cs
private string fileName = "Settings.xml";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.XMLManager xmlManager = new EVLib.FileIO.XMLManager();

XmlDocument xmlDoc = xmlManager.LoadXmlDocument(filePath);

XmlNodeList nodeList = xmlManager.LoadNodeList(xmlDoc, "/Settings/Formula1/Event");

XmlAttribute elementAttribute = xmlManager.GetAttributeFromNodeList(nodeList, "Name", "Qualifying", "Saved");

bool boolAttributeValue = xmlManager.GetAttributeValueAsBool(elementAttribute);
```

***Remarks***

If attribute is null method will return false.

---

## EVLib.FileIO.EncryptorManager : [FileManager](#evlibfileiofilemanager)

**Constructors** :

[`public EncryptorManager()`]

**Methods** :

[`public Void EncryptToFile(String filePath, String stringToEncrypt, String password)`](#encrypttofile-filepath-stringtoencrypt-password)

[`public String EncryptToString(String stringToEncrypt, String password)`](#encrypttostring-stringtoencrypt-password)

[`public Byte[] EncryptToByteArray(String stringToEncrypt, String password)`](#encrypttobytearray-stringtoencrypt-password)

[`public String DecryptFromFile(String filePath, String password)`](#decryptfromfile-filepath-password)

[`public String DecryptFromString(String stringToDecrypt, String password)`](#decryptfromstring-stringtodecrypt-password)

[`public String DecryptFromByteArray(Byte[] byteArrayToDecrypt, String password)`](#decryptfrombytearray-bytearraytodecrypt-password)

---

### EncryptToFile (filePath, stringToEncrypt, password)

***Summary***

Encrypts a String of data to a file on disk using AES.

***Declaration***

```cs
public void EncryptToFile(string filePath, string stringToEncrypt, string password)
```

***Parameter***

`string` filePath

Path to file.

`string` stringToEncrypt

String of data to encrypt.

`string` password

Password used to encrypt / decrypt data.

***Usage***

```cs
private string decryptedSampleText = "I am sample text to be encrypted";

private string encryptionKey = "7pGG9!ech449*10";

private string fileName = "EncryptedFile.txt";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.EncryptorManager encryptor = new EVLib.FileIO.EncryptorManager();

encryptor.EncryptToFile(filePath, decryptedSampleText, encryptionKey);
```

---

### EncryptToString (stringToEncrypt, password)

***Summary***

Encrypts a String of data to Base64 using AES.

***Declaration***

```cs
public string EncryptToString(string stringToEncrypt, string password)
```

***Parameter***

`string` stringToEncrypt

String of data to encrypt.

`string` password

Password used to encrypt / decrypt data.

***Return***

`string`

AES Encrypted String in Base64.

***Usage***

```cs
private string decryptedSampleText = "I am sample text to be encrypted";

private string encryptionKey = "7pGG9!ech449*10";

EVLib.FileIO.EncryptorManager encryptor = new EVLib.FileIO.EncryptorManager();

string encryptedString = encryptor.EncryptToString(decryptedSampleText, encryptionKey);

Console.WriteLine(encryptedString);
```
***Output***

> Mpoy/4sA77ouuB3AjBPAlt+QigWa6xt7fmAv1gvEmxVQoioEcnr80e2537bFQevhH8mqOkWvMlJUtkWROZqjdKtNF9h/dQBhtE5PmD8Epqtm/7BJGI8vi/Z/sMMZTBbOZ1daYhCLOFO6v3fhgfjm6JgRPiQn1n6r5ulRNz3mm18=

***Remarks***

Encoding.UTF8.GetString(bytes) does not convert a byte array containing arbitrary bytes to a string. Instead, it converts a byte array that is supposed to contain bytes making up an UTF8 encoded string back to that string.  
If the byte array contains arbitrary bytes, such as the result of encrypting text, it is almost certain to corrupt the data and/or lose bytes. Instead, you should use a different method of converting a byte array to a string and back.  
Base64 encoding has been choosen for this purpose.

---

### EncryptToByteArray (stringToEncrypt, password)

***Summary***

Encrypts a String of data as a Byte Array using AES.

***Declaration***

```cs
public byte[] EncryptToByteArray(string stringToEncrypt, string password)
```

***Parameter***

`string` stringToEncrypt

String of data to encrypt.

`string` password

Password used to encrypt / decrypt data.

***Return***

`byte[]`

AES Encrypted String as Byte Array.

***Usage***

```cs
private string decryptedSampleText = "I am sample text to be encrypted";

private string encryptionKey = "7pGG9!ech449*10";

EVLib.FileIO.EncryptorManager encryptor = new EVLib.FileIO.EncryptorManager();

byte[] encryptedBytes = encryptor.EncryptToByteArray(decryptedSampleText, encryptionKey);

System.Text.StringBuilder encryptedByteValues = new System.Text.StringBuilder();

foreach (byte byteValue in encryptedBytes)
{
    encryptedByteValues.Append($"{byteValue} ");
}

Console.WriteLine(encryptedByteValues.ToString());
```

***Output***

> 143, 110, 29, 111, 47, 41, 235, 67, 167, 18, 126, 10, 29, 167, 66, 8, 92, 105, 184, 7, 170, 46, 183, 200, 208, 71, 50, 117, 187, 14, 91, 121, 232, 245, 213, 229, 142, 114, 127, 183, 148, 54, 97, 51, 70, 81, 54, 128, 192, 126, 250, 33, 143, 73, 194, 174, 59, 90, 45, 245, 254, 3, 13, 237, 80, 126, 161, 71, 125, 179, 251, 172, 71, 85, 8, 92, 214, 123, 8, 51, 13, 225, 31, 57, 54, 141, 17, 30, 161, 121, 244, 172, 121, 224, 20, 59, 41, 164, 216, 5, 29, 224, 89, 44, 140, 12, 238, 202, 95, 226, 46, 151, 129, 37, 101, 218, 113, 253, 108, 60, 139, 83, 80, 91, 116, 162, 107, 42

---

### DecryptFromFile (filePath, password)

***Summary***

Decrypts data to a String from a file on disk using AES.

***Declaration***

```cs
public string DecryptFromFile(string filePath, string password)
```

***Parameter***

`string` filePath

Path to file.

`string` password

Password used to encrypt / decrypt data.

***Return***

`string`

Decrypted String.

***Usage***

```cs
private string encryptionKey = "7pGG9!ech449*10";

private string fileName = "EncryptedFile.txt";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.EncryptorManager encryptor = new EVLib.FileIO.EncryptorManager();

string decryptedFile = encryptor.DecryptFromFile(filePath, encryptionKey);
```

---

### DecryptFromString (stringToDecrypt, password)

***Summary***

Decrypts a Base64 String encrypted of data using AES.

***Declaration***

```cs
public string DecryptFromString(string stringToDecrypt, string password)
```

***Parameter***

`string` stringToDecrypt

String of data to encrypt.

`string` password

Password used to encrypt / decrypt data.

***Return***

`string`

Decrypted String.

***Usage***

```cs
private string encryptedSampleText = "Mpoy/4sA77ouuB3AjBPAlt+QigWa6xt7fmAv1gvEmxVQoioEcnr80e2537bFQevhH8mqOkWvMlJUtkWROZqjdKtNF9h/dQBhtE5PmD8Epqtm/7BJGI8vi/Z/sMMZTBbOZ1daYhCLOFO6v3fhgfjm6JgRPiQn1n6r5ulRNz3mm18=";

private string encryptionKey = "7pGG9!ech449*10";

EVLib.FileIO.EncryptorManager encryptor = new EVLib.FileIO.EncryptorManager();

string decryptedString = encryptor.DecryptFromString(encryptedString, encryptionKey);

Console.WriteLine(encryptedSampleText);
```
***Output***

> I am sample text to be encrypted

***Remarks***

Encoding.UTF8.GetString(bytes) does not convert a byte array containing arbitrary bytes to a string. Instead, it converts a byte array that is supposed to contain bytes making up an UTF8 encoded string back to that string.  
If the byte array contains arbitrary bytes, such as the result of encrypting text, it is almost certain to corrupt the data and/or lose bytes. Instead, you should use a different method of converting a byte array to a string and back.  
Base64 encoding has been choosen for this purpose.

---

### DecryptFromByteArray (byteArrayToDecrypt, password)

***Summary***

Decrypts a Byte Array of encrypted data using AES.

***Declaration***

```cs
public string DecryptFromByteArray(byte[] byteArrayToDecrypt, string password)
```

***Parameter***

`byte[]` byteArrayToDecrypt

Byte Array to decrypt.

`string` password

Password used to encrypt / decrypt data.

***Return***

`string`

Decrypted String.

***Usage***

```cs
private byte[] EncryptedSampleBytes = { 143, 110, 29, 111, 47, 41, 235, 67, 167, 18, 126, 10, 29, 167, 66, 8, 92, 105, 184, 7, 170, 46, 183, 200, 208, 71, 50, 117, 187, 14, 91, 121, 232, 245, 213, 229, 142, 114, 127, 183, 148, 54, 97, 51, 70, 81, 54, 128, 192, 126, 250, 33, 143, 73, 194, 174, 59, 90, 45, 245, 254, 3, 13, 237, 80, 126, 161, 71, 125, 179, 251, 172, 71, 85, 8, 92, 214, 123, 8, 51, 13, 225, 31, 57, 54, 141, 17, 30, 161, 121, 244, 172, 121, 224, 20, 59, 41, 164, 216, 5, 29, 224, 89, 44, 140, 12, 238, 202, 95, 226, 46, 151, 129, 37, 101, 218, 113, 253, 108, 60, 139, 83, 80, 91, 116, 162, 107, 42 };

private string encryptionKey = "7pGG9!ech449*10";

EVLib.FileIO.EncryptorManager encryptor = new EVLib.FileIO.EncryptorManager();

string decryptedSampleText = encryptor.DecryptFromByteArray(EncryptedSampleBytes, encryptionKey);

Console.WriteLine(decryptedSampleText);
```

***Output***

> I am sample text to be encrypted

---

## [Obsolete]
## EVLib.FileIO.EncryptionManager: [FileManager](#evlibfileiofilemanager)

**Constructors** :

[`public EncryptionManager()`](#encryptionmanager)

**Methods** :

[`public void EncryptStringToFile(string filePath, string dataToEncrypt, string keyPhrase)`](#encryptstringtofile-filepath-datatoencrypt-keyphrase)

[`public string DecryptStringF romFile(string filePath, string keyPhrase)`](#decryptstringfromfile-filepath-keyphrase)

---

### EncryptionManager

***Summary***

Create a new instance of the default AES implementation class

***Declaration***

```cs
public EncryptionManager()
```

***Usage***

```cs
EVLib.FileIO.EncryptionManager encryptionManager = new EVLib.FileIO.EncryptionManager();
```

---

### EncryptStringToFile (filePath, DataToEncrypt, KeyPhrase)

***Summary***

Encrypts a String of data to a file on disk using AES.

***Declaration***

```cs
public void EncryptStringToFile(string filePath, string dataToEncrypt, string keyPhrase)
```

***Parameter***

`string` filePath

Path to file.

`string` dataToEncrypt

String of data to encrypt.

`string` keyPhrase

Key to encrypt the data stream.

***Usage***

```cs
private string decryptedSampleText = "I am sample text to be encrypted";

private string encryptionKey = "7pGG9!ech449*10";

private string fileName = "EncryptedFile.txt";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.EncryptionManager encryptionManager = new EVLib.FileIO.EncryptionManager();

encryptionManager.EncryptStringToFile(filePath, decryptedSampleText, encryptionKey);
```

---

### DecryptStringFromFile (filePath, KeyPhrase)

***Summary***

Decrypts data from a file on disk to a String using AES.

***Declaration***

```cs
public string DecryptStringFromFile(string filePath, string keyPhrase)
```

***Parameter***

`string` filePath

Path to file.

`string` keyPhrase

Key to encrypt the data stream.

***Return***

`string`

Decrypted String.

***Usage***

```cs
private string encryptionKey = "7pGG9!ech449*10";

private string fileName = "EncryptedFile.txt";

private string[] fullFilePath = new string[] { Directory.GetCurrentDirectory(), fileName };

private string filePath = Path.Combine(fullFilePath);

EVLib.FileIO.EncryptionManager encryptionManager = new EVLib.FileIO.EncryptionManager();

string decryptedSampleText = encryptionManager.DecryptStringFromFile(filePath, encryptionKey);
```

---

# Interfaces

[`IValueConverter`](#evlibinterfacesivalueconverter)

---

## EVLib.Interfaces.IValueConverter

**Methods** :

[`public abstract Object Convert(Object value, Type targetType, Object parameter, CultureInfo culture)`](#convert-value-targettype-parameter-culture)

[`public abstract Object ConvertBack(Object value, Type targetType, Object parameter, CultureInfo culture)`](#convertback-value-targettype-parameter-culture)

---

### Convert (Value, TargetType, Parameter, Culture)

***Summary***

Converts a value.

***Declaration***

```cs
object Convert(object value, Type targetType, object parameter, CultureInfo culture);
```

***Parameter***

`object` value

The value produced by the binding source.

`Type` targetType

The type of the binding target property.

`object` parameter

The converter parameter to use.

`CultureInfo` culture

The culture to use in the converter.

***Return***

`object`

A converted value. If the method returns null, the valid null value is used.

---

### ConvertBack (Value, TargetType, Parameter, Culture)

***Summary***

Converts a value.

***Declaration***

```cs
object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);
```

***Parameter***

`object` value

The value produced by the binding source.

`Type` targetType

The type of the binding target property.

`object` parameter

The converter parameter to use.

`CultureInfo` culture

The culture to use in the converter.

***Return***

`object`

A converted value. If the method returns null, the valid null value is used.

---

# Mail

[`Client`](#evlibmailclient)

[`MessageField`](#evlibmailmessagefield)

[`ServerSettings`](#evlibmailserversettings)

---

## EVLib.Mail.Client

**Fields** :

[`public MessageField Field`](#evlibmailmessagefield)

[`public ServerSettings Server`](#evlibmailserversettings)

**Constructors** :

[`public Client()`](#client)

[`public Client(ServerSettings serverSettings)`](#client-serversettings)

[`public Client(String host, Int32 port, Boolean enableSsl)`](#client-host-port-enablessl)

[`public Client(String host, Int32 port, String username, String password, Boolean enableSsl)`](#client-host-port-username-password-enablessl)


**Methods** :

[`public String Send()`](#send)

[`public String Send(MessageField messageField)`](#send-messagefield)

[`public String Send(String senderName, String senderEmail, String recipientName, String recipientEmail, String subject, String body, String attachmentPath = null) `](#send-sendername-senderemail-recipientname-recipientemail-subject-body-attachmentpath)

---

### Client ()

***Summary***

Initializes client for sending emails via STMP.

***Declaration***

```cs
public Client()
```

***Usage***

```cs
EVLib.Mail.Client mail = new EVLib.Mail.Client();
```

---

### Client (ServerSettings)

***Summary***

Initializes client for sending emails via STMP.

***Declaration***

```cs
public Client(ServerSettings serverSettings)
```

***Parameter***

`ServerSettings` serverSettings

Initializes a new instance of the Server Settings class with the specified settings.

***Usage***

```cs
EVLib.Mail.ServerSettings serverSettings = new EVLib.Mail.erverSettings()
{
    Host = "smtp.host.com",
    Port = 587,
    Username = "username@host.com",
    Password = "StrongPassword1",
    EnableSsl = true
};

EVLib.Mail.Client mail = new EVLib.Mail.Client(serverSettings);
```

---

### Client (Host, Port, EnableSSL)

***Summary***

Initializes client for sending emails via STMP.

***Declaration***

```cs
public Client(string host, int port, bool enableSsl)
```

***Parameter***

`string` host

Email servers host address.

`int` port

Email servers port.

`bool` enableSsl

Specifies whether the email server requires SSL.

***Usage***

```cs
EVLib.Mail.Client mail = new EVLib.Mail.Client("smtp.host.com", 587, true);
```

***Remarks***

This overload sets "UseDefaultCredentials" to true.
This will use the credentials of the current logged in user.

---

### Client (Host, Port, UserName, Password, EnableSSL)

***Summary***

Initializes client for sending emails via STMP.

***Declaration***

```cs
public Client(string host, int port, string username, string password, bool enableSsl)
```

***Parameter***

`string` host

Email servers host address.

`int` port

Email servers port.

`string` username

Username to login to email Server.

`string` password

Password to login to email server.

`bool` enableSsl

Specifies whether the email server requires SSL.

***Usage***

```cs
EVLib.Mail.Client mail = new EVLib.Mail.Client("smtp.host.com", 587, "username@host.com", "StrongPassword1", true);
```

---

### Send ()

***Summary***

Sends an email via SMTP

***Declaration***

```cs
public String Send()
```

***Return***

`string`

Sent confirmation as String.

***Usage***

```cs
ServerSettings serverSettings = new ServerSettings()
{
    Host = "smtp.host.com",
    Port = 587,
    Username = "username@host.com",
    Password = "StrongPassword1",
    EnableSsl = true
};

MessageField messageField = new MessageField()
{
    SenderName = "Sender",
    SenderEmail = "sender@host.com",
    RecipientName = "Recipient",
    RecipientEmail = "recipient@host.com",
    Subject = "Test Message",
    Body = "Testing mail-flow"
};

EVLib.Mail.Client mail = new EVLib.Mail.Client();

mail.Server = serverSettings;

mail.Field = messageField;

string confirmation = mail.Send();
```

---

### Send (messageField)

***Summary***

Sends an email via SMTP

***Declaration***

```cs
public string Send(MessageField messageField)
```

***Parameter***

`MessageField` messageField

Initializes a new instance of the MessageField class with the specified fields.

***Return***

`string`

Sent confirmation as String.

***Usage***

```cs
ServerSettings serverSettings = new ServerSettings()
{
    Host = "smtp.host.com",
    Port = 587,
    Username = "username@host.com",
    Password = "StrongPassword1",
    EnableSsl = true
};

MessageField messageField = new MessageField()
{
    SenderName = "Sender",
    SenderEmail = "sender@host.com",
    RecipientName = "Recipient",
    RecipientEmail = "recipient@host.com",
    Subject = "Test Message",
    Body = "Testing mail-flow"
};

EVLib.Mail.Client mail = new EVLib.Mail.Client(serverSettings);

string confirmation = mail.Send(messageField);
```

---

### Send (senderName, senderEmail, recipientName, recipientEmail, subject, body, attachmentPath)

***Summary***

Sends an email via SMTP.

***Declaration***

```cs
public string Send(string senderName, string senderEmail, string recipientName, string recipientEmail, string subject, string body, string attachmentPath = null)
```

***Parameter***

`string` senderName

Display name of Sender.

`string` senderEmail

Email address of sender.

`string` recipientName

Display name of recipient.

`string` recipientEmail

Email address of recipient.

`string` subject

Email subject.

`string` body

Email message body.

`string` attachmentPath

Email attachment file path.


***Return***

`string`

Sent confirmation as String.

***Usage***

```cs
EVLib.Mail.Client mail = new EVLib.Mail.Client("smtp.host.com", 587, "username@host.com", "StrongPassword1", true);

string confirmation = mail.Send("Sender", "sender@host.com", "Recipient", "recipient@host.com", "Test Message", "Testing mail-flow");
```

---

## EVLib.Mail.MessageField

**Constructors** :

[`public MessageField()`]

**Methods** :

[`public MessageField(String senderName, String senderEmail, String recipientName, String recipientEmail, String subject, String body, String attachmentPath = null)`](#messagefield-sendername-senderemail-recipientname-recipientemail-subject-body-attachmentpath)

---

### MessageField (senderName, senderEmail, recipientName, recipientEmail, subject, body, attachmentPath)

***Summary***

Provides the properties required to compose an email.

***Declaration***

```cs
public MessageField(string senderName, string senderEmail, string recipientName, string recipientEmail, string subject, string body, string attachmentPath = null)
```

***Parameter***

`string` senderName

Display name of Sender.

`string` senderEmail

Email address of sender.

`string` recipientName

Display name of recipient.

`string` recipientEmail

Email address of recipient.

`string` subject

Email subject.

`string` body

Email message body.

`string` attachmentPath

Email attachment file path.

***Usage***

```cs
EVLib.Mail.MessageField messageField = new EVLib.Mail.MessageField()
{
    SenderName = "Sender",
    SenderEmail = "sender@host.com",
    RecipientName = "Recipient",
    RecipientEmail = "recipient@host.com",
    Subject = "Test Message",
    Body = "Testing mail-flow"
};
```

---
## EVLib.Mail.ServerSettings

**Constructors** :

[`public ServerSettings()`]

**Methods** :

[`public ServerSettings(String host, Int32 port, String username, String password, Boolean enableSsl)`](#serversettings-host-port-username-password-enablessl)

[`public ServerSettings(String host, Int32 port, Boolean enableSsl)`](#serversettings-host-port-enablessl)

---

### ServerSettings (host, port, username, password, enableSSL)

***Summary***

Provides the properties required to send an email.

***Declaration***

```cs
public ServerSettings(string host, int port, string username, string password, bool enableSsl)
```

***Parameter***

`string` host

Email servers host address.

`int` port

Email servers port.

`string` username

Username to login to email Server.

`string` password

Password to login to email server.

`bool` enableSsl

Specifies whether the email server requires SSL.

***Usage***

```cs
EVLib.Mail.ServerSettings serverSettings = new EVLib.Mail.ServerSettings()
{
    Host = "smtp.host.com",
    Port = 587,
    Username = "username@host.com",
    Password = "StrongPassword1",
    EnableSsl = true
};
```

---

### ServerSettings (host, port, enableSSL)

***Summary***

Provides the properties required to send an email.

***Declaration***

```cs
public ServerSettings(string host, int port, bool enableSsl)
```

***Parameter***

`string` host

Email servers host address.

`int` port

Email servers port.

`bool` enableSsl

Specifies whether the email server requires SSL.


***Usage***

```cs
EVLib.Mail.ServerSettings serverSettings = new EVLib.Mail.ServerSettings()
{
    Host = "smtp.host.com",
    Port = 587,
    EnableSsl = true
};
```

***Remarks***

This overload sets "UseDefaultCredentials" to true.
This will use the credentials of the current logged in user.

---

# Mathamatics

[`Calculate`](#evlibmathamaticscalculate)

[`Cipher`](#evlibmathamaticscipher)

---

## EVLib.Mathamatics.Calculate

**Constructors** :

[`public Calculate()`]

**Methods** :

[`public Int64 Power(Int32 baseNumber, Int32 exponent)`](#power-basenumber-exponent)

[`public Double Average(List<Double> listOfNumbers)`](#average-listofnumbers)

[`public Int32 RandomNumber(Int32 minimumValue, Int32 maximumValue)`](#randomnumber-minimumvalue-maximumvalue)

---

### Power (BaseNumber, Exponent)

***Summary***

Returns the power of an Interger without using the Math.Pow Method.

***Declaration***

```cs
public long Power(int baseNumber, int exponent)
```

***Parameter***

`int` baseNumber

he base number to be multiplied.

`int` exponent

The number of times to multiply the base.

***Return***

`long`

The power  of the result.

***Usage***

```cs
EVLib.Mathamatics.Calculate calculate = new EVLib.Mathamatics.Calculate();

int baseNumber = 8;

int exponent = 2;

long result = calculate.Power(baseNumber, exponent);

Console.WriteLine(result.ToString());
```

***Output***

> 64

***Remarks***

The power or exponent of a number says how many times to use the number in multiplication.

---

### Average (ListOfNumbers)

***Summary***

Calculate the average value of a List, using a foreach loop. 

***Declaration***

```cs
public double Average(List<double> listOfNumbers)
```

***Parameter***

`List<double>` listOfNumbers

List of Doubles to be divided by the total amount of numbers in the list.

***Return***

`double`

The average of a set of numbers.

***Usage***

```cs
EVLib.Mathamatics.Calculate calculate = new EVLib.Mathamatics.Calculate();

System.Collections.Generic.List<double> numbers = new System.Collections.Generic.List<double>{ 5, 20, 15, 80, 26, 19 };

double result = calculate.Average(numbers);

Console.WriteLine(result.toString());
```

***Output***

> 27.5

***Remarks***

The average of a set of numbers is simply the sum of the numbers divided by the total number of values in the set.

---
### RandomNumber (MinimumValue, MaximumValue)

***Summary***

Create truely random numbers using an instance of an encryption class (RNGCryptoServiceProvider).

***Declaration***

```cs
public int RandomNumber(int minimumValue, int maximumValue)
```

***Parameter***

`int` minimumValue

Minimum number.

`int` maximumValue

Maximium number.


***Return***

`int`

Random number.

***Usage***

```cs
EVLib.Mathamatics.Calculate calculate = new EVLib.Mathamatics.Calculate();

int randomResult = calculate.RandomNumber(1, 10);
```

***Remarks***

"Random" The .Net framework's built-in random number generating class, doesn’t produce numbers that are really random.  
Using an instance of an encryption class (RNGCryptoServiceProvider) is better at not following a pattern when it creates random numbers.

---

## EVLib.Mathamatics.Cipher

**Constructors** :

[`public Cipher()`]

**Methods** :

[`public String Encode(String data, String key)`](#encode-data-key)

[`public String Decode(String data, String key)`](#decode-data-key)

---

### Encode (Data, Key)

***Summary***

A practical implementation of the XOR encryption technology in C# which is extended from the Vernam cipher.

***Declaration***

```cs
public string Encode(string data, string key)
```

***Parameter***

`string` data

Data to be encoded.

`string` key

Key used to perform cipher.

***Return***

`string`

base64 encoded cipher.

***Usage***

```cs
string decodedData = "Hello World!";

string key = "7H1y23oiws";

EVLib.Mathamatics.Cipher cipher = new EVLib.Mathamatics.Cipher();

string encodedText = cipher.Encode(decodedData, key);

Console.WriteLine(encodedText);
```

***Output***

> g.OfYdG/YdG3QJGDA9KnU1eP

***Remarks***

The longer the key phrase, the longer it will take to crack.  
However, this also makes it more easy it is to decode.  
The optimal solution is to have a key of the same length than the source string.

---

### Decode (Data, Key)

***Summary***

A practical implementation of the XOR encryption technology in C# which is extended from the Vernam cipher.

***Declaration***

```cs
public string Decode(string data, string key)
```

***Parameter***

`string` data

Data to be decoded.

`string` key

Key used to perform cipher.

***Return***

`string`

Decoded cipher.

***Usage***

```cs
string encodedData = "g.OfYdG/YdG3QJGDA9KnU1eP";

string key = "7H1y23oiws";

EVLib.Mathamatics.Cipher cipher = new EVLib.Mathamatics.Cipher();

string decodedText = cipher.Decode(encodedData, key);

Console.WriteLine(decodedText);
```

***Output***

> Hello World!

***Remarks***

The longer the key phrase, the longer it will take to crack.  
However, this also makes it more easy it is to decode.  
The optimal solution is to have a key of the same length than the source string.

---