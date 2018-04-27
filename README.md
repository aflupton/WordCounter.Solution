# _WordCounterApp_

#### _Word Counter App, 4/27/18_

#### By _**Andrew Lupton**_

## Description

_An app that returns the frequency of a specific word in a longer string. The user inputs a word and a sentence string into a webpage, and receives back the frequency as an integer._

## Specs
* _The program should accept two inputs from the user, a word and a longer string._
  * _Ex: input: "the" and "The quick brown fox jumped over the lazy dog." ; output: The word "the" occurs 2 times in the given string._
* _The program should disregard symbols, numbers, and null inputs._
  * _Ex: input: "You" and "Are you?" ; output: The "you"'s should match, despite one having a "?" appended to it. This is handled in the back-end logic, where the string parser ignores special characters._
  * _Ex: input: "3nj0y" and "Did you enjoy the show?" ; output: Should return an error message._
* _The program should treat upper and lower case letters the same, so that "The" and "the" both return a value of 1._
  * _Ex: input: "YOU" and "you only ever order the fish!" ; output: The word "YOU" occurs 1 time in the given string._
* _The program should check for 'full word matches only'._
  * _Ex: input: "the" and "Thelonious Monk" output: would *not* return a positive result, even though "the-" exists within "Thelonious"._

* _The program should split the longer string into its component words so that each word can be compared to the specified word string._
  * _Ex: input: "you" and "Did you follow all the directions carefully?" ; output: Each component of the array {"Did", "you", "follow", "all", "the", "directions", "carefully"} would be compared with "you"._

## Setup/Installation Requirements

* _Clone or download the repository._
* _Open the console and move to the WordCounter project directory_
* _Execute "dotnet restore" in the console._
* _Execute "dotnet run" in the console._
* _Open a web browser._
* _Navigate to "localhost:5000" into the address bar._

## Known Bugs

_Throwing a "stackoverflow" exception when executing "dotnet run" in the console. Working on a solution._

## Support and contact details

_If you have any questions, email me at aflupton@gmail.com_

## Technologies Used

_C#/.NET, HTML, CSS/Bootstrap_

### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 **_Andrew Lupton_**
