parent(softwarelyngby,discretemath).
parent(softwarelyngby,systemintergration).
parent(softwarelyngby,largesystemdevelopment).

lesson(discretemath,anders).
lesson(systemintergration,tine).
lesson(systemintergration,helge).
lesson(largesystemdevelopment,helge).
lesson(largesystemdevelopment,anders).
lesson(largesystemdevelopment,jens).


course(softwarelyngby).

teacher(anders).
teacher(tine).
teacher(helge).
teacher(jens).

student(daniel).
student(kristian).

studieslesson(X,Y,Z):-
    student(X),
    teacher(Z),
    lesson(Y,Z).

works(X,Y,Z):-
    teacher(X),
    course(Z),
    lesson(Y,X).

studiesat(X,Y,Z):-
    student(X),
    parent(Y,Z).
