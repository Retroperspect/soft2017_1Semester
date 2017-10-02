Assignment #2 - Programming in logic
==========================
I choose to make a hybrid of the first suggested problem, and made a program designed around students and their relation to teachers, lessons and software lyngby course.

[Link to the file](https://github.com/Retroperspect/soft2017_1Semester/blob/master/handins/discrete_math/Soft2017DM_assignment2.pl)

mearningfull questions would be the following.
    
this ask for all lessons kristian partakes in the software lyngby course.
```prolog
studiesat(kristian,softwarelyngby,Y).
```
this ask for all students under anders care in the discrete math lesson
```prolog
works(anders,discretemath,softwarelyngby),
    studieslesson(X,discretemath,anders).
```
This ask for all lessons and what teachers assigned to them that are in software lyngby course
```prolog
works(X,Y,softwarelyngby).
```
This ask if both helge and anders works on the large system development couse
```prolog
works(anders,largesystemdevelopment,softwarelyngby),
    works(helge,largesystemdevelopment,softwarelyngby).
```
