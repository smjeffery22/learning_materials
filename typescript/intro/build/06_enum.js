"use strict";
var Direction;
(function (Direction) {
    Direction["North"] = "NORTH";
    Direction[Direction["South"] = void 0] = "South";
    Direction[Direction["East"] = void 0] = "East";
    Direction[Direction["West"] = void 0] = "West";
})(Direction || (Direction = {}));
;
console.log('Direction:', Direction.North);
// numeric enum type
// assigns 0 to the first member of numeric enum type by default
var ClassGrade;
(function (ClassGrade) {
    ClassGrade[ClassGrade["Freshman"] = 9] = "Freshman";
    ClassGrade[ClassGrade["Sophomore"] = 10] = "Sophomore";
    ClassGrade[ClassGrade["Junior"] = 11] = "Junior";
    ClassGrade[ClassGrade["Senior"] = 12] = "Senior";
})(ClassGrade || (ClassGrade = {}));
;
// string enum type
var ClassName;
(function (ClassName) {
    ClassName["Freshman"] = "FRESHMAN";
    ClassName["Sophomore"] = "SOPHOMORE";
    ClassName["Junior"] = "JUNIOR";
    ClassName["Senior"] = "SENIOR";
})(ClassName || (ClassName = {}));
;
const studentGrade = ClassGrade.Junior;
const studentClass = ClassName.Junior;
console.log(studentGrade); // 11
console.log(studentClass); // JUNIOR
// This numeric enum type begins with a 1, instead of the default 0
var Weekdays;
(function (Weekdays) {
    Weekdays[Weekdays["Monday"] = 1] = "Monday";
    Weekdays[Weekdays["Tuesday"] = 2] = "Tuesday";
    Weekdays[Weekdays["Wednesday"] = 3] = "Wednesday";
    Weekdays[Weekdays["Thursday"] = 4] = "Thursday";
    Weekdays[Weekdays["Friday"] = 5] = "Friday";
})(Weekdays || (Weekdays = {}));
// This is a numeric enum type with all explicit values
var Grades;
(function (Grades) {
    Grades[Grades["A"] = 90] = "A";
    Grades[Grades["B"] = 80] = "B";
    Grades[Grades["C"] = 70] = "C";
    Grades[Grades["D"] = 60] = "D";
})(Grades || (Grades = {}));
// This numeric enum type has only some explicit values
var Prizes;
(function (Prizes) {
    Prizes[Prizes["Pencil"] = 5] = "Pencil";
    Prizes[Prizes["Ruler"] = 6] = "Ruler";
    Prizes[Prizes["Eraser"] = 10] = "Eraser";
    Prizes[Prizes["Pen"] = 11] = "Pen"; // No error: value is 11
})(Prizes || (Prizes = {}));
;
const day = Weekdays.Wednesday;
const grade = Grades.B;
const prize = Prizes.Pen;
console.log(`On day ${day} of the week, I got ${grade} on my test! I won a prize with ${prize} points!`);
// Prints "On day 3 of the week, I got 80 on my test! I won a prize with 11 points!"
var Weekend;
(function (Weekend) {
    Weekend[Weekend["Friday"] = 5] = "Friday";
    Weekend[Weekend["Saturday"] = 6] = "Saturday";
    Weekend[Weekend["Sunday"] = 7] = "Sunday";
})(Weekend || (Weekend = {}));
;
// Assign a valid value of Weekend
const today = 7; // No error
console.log(`Today is the ${today}th day of the week!`);
// Prints "Today is the 7th day of the week!"
var MaritalStatus;
(function (MaritalStatus) {
    MaritalStatus["Single"] = "SINGLE";
    MaritalStatus["Married"] = "MARRIED";
    MaritalStatus["Separated"] = "SEPARATED";
    MaritalStatus["Divorced"] = "DIVORCED";
    MaritalStatus["Widowed"] = "WIDOWED";
})(MaritalStatus || (MaritalStatus = {}));
;
// Assign a string to a string enum type
let eligibility;
// eligibility = 'SEPARATED';
// Error: Type '"SEPARATED"' is not assignable to type 'MaritalStatus'.
eligibility = MaritalStatus.Separated; // No error
