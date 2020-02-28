/*  

    Module 9 - Day 5 Homework

    # TEAM PROJECT #


    You just spoke with your client, who's in charge of a small multi-media library.
    They used to have a small program, written in 1998, to handle their loans... but since the last Windows update it's no longer working.

    He wants you to develop a new software, but it needs to be able to read the old archive.
    Here's what he said to you:

    "Aaah, those damn machines. The day before it was working and then, BAM, that nasty error message... and we cannot run it anymore.
    I need you to develop another one.

    It has to handle all of the media we are dealing with: Movies, Albums, Books and Videogames.
    We used to have a lot of information there... Titles, authors, release date... and other things like distributor, 
    or total length, number of pages, multiplayer capabilities.. stuff like that.

    You know, we need this application to be able to show us the list of media sorted by all those different properties.
    And also to show them only by type, like if I want to order them by number of pages of course I only want to see books.

    It's all in that file that I sent you, that Media_Library_Database.csv.

    So first make sure you import all of our data from there, and then provide me a program that I can use to see items sorted by the properties I want..
    You see, the old program... it usually asked which kind of media we want to see, and then what property they should be ordered by.

    Ah, I was about to forget: in that file we have the information about our loans.. so in each media listed there's also a value
    that tells if we lent that item or not.
    
    And if you do a good job, maybe I will pay you even more to develop a Website to allow our guests to perform the same operations from home!"


    # CONSIDERATIONS #

    1. DO NOT DIVE INTO VISUAL STUDIO.
       BEFORE starting to write code, ANALYZE your REQUIREMENTS and THEN MODEL YOUR ENTITIES.
       Only at the end move to coding.

    2. You're a team. The better you analyze and design your software together, the easier it will be to split tasks 
       and work on different aspects SIMULTANEOUSLY.

    3. Split your solution in 2 projects: a library in charge of reading, organizing and sorting data, 
       and a console application to take inputs and display results.
       Do not use Console.Anything inside the library project.

    4. The analysis/design part should last AT LEAST until 10:30 and no longer than 12:00.

    5. If you have questions, just open up Slack and write to the tutors... but only AFTER you analyzed your issues for at least 5 minutes,
       also discussing it with your teammates (that's where true learning is).
       Yes, I actually mean 300 seconds.

    6. You will have to read a file from the disk, and also to split strings: we didn't see how to do that yet.
       But that's part of the learning process as well: the .NET Framework is full of resources, and Google is your friend (also Bing, if you're a weirdo).
       Just ensure that ONE SINGLE TEAM MEMBER is in charge of that, and you don't waste all the time of the entire team just trying to read a file.

    7. OOP is your friend. You will be tempted to follow a development style you're used to, in order to be quicker: you won't.
       Think about it 10 more minutes, and it will save you 40 minutes of coding... plus, you'll learn something.

    8. Using Inheritance, Polymorphism and Interfaces is REALLY recommended. Beware though: do not OVERUSE them! They have to make sense.

    9. Google Sheets and Lucidchart both allow realtime online collaboration: they should be good tools to use.
       Unfortunately, Lucidchart has the 3-documents-max limitation: either create another account with another email, or delete your old exercises.

 */ 