enum Direction {
  North = 'NORTH',
  South,
  East,
  West
};

console.log('Direction:', Direction.North);

// numeric enum type
// assigns 0 to the first member of numeric enum type by default
enum ClassGrade {
  Freshman = 9,
  Sophomore,
  Junior,
  Senior
};

// string enum type
enum ClassName {
  Freshman = 'FRESHMAN',
  Sophomore = 'SOPHOMORE',
  Junior = 'JUNIOR',
  Senior = 'SENIOR'
};

const studentGrade: ClassGrade = ClassGrade.Junior;
const studentClass: ClassName = ClassName.Junior;

console.log(studentGrade); // 11
console.log(studentClass); // JUNIOR


// This numeric enum type begins with a 1, instead of the default 0
enum Weekdays {
  Monday = 1,
  Tuesday,
  Wednesday,
  Thursday,
  Friday
}
 
// This is a numeric enum type with all explicit values
enum Grades {
  A = 90,
  B = 80,
  C = 70,
  D = 60
}
 
// This numeric enum type has only some explicit values
enum Prizes {
  Pencil = 5,
  Ruler,     // No error: value is 6
  Eraser = 10,
  Pen        // No error: value is 11
};
 
const day: Weekdays = Weekdays.Wednesday;
const grade:Grades = Grades.B;
const prize:Prizes = Prizes.Pen;
console.log(`On day ${day} of the week, I got ${grade} on my test! I won a prize with ${prize} points!`);
// Prints "On day 3 of the week, I got 80 on my test! I won a prize with 11 points!"



enum Weekend {
  Friday = 5,
  Saturday,
  Sunday
};
 
// Assign a valid value of Weekend
const today: Weekend = 7;       // No error
console.log(`Today is the ${today}th day of the week!`);
// Prints "Today is the 7th day of the week!"


enum MaritalStatus {
  Single = 'SINGLE',
  Married = 'MARRIED',
  Separated = 'SEPARATED',
  Divorced = 'DIVORCED',
  Widowed = 'WIDOWED'
};
 
// Assign a string to a string enum type
let eligibility: MaritalStatus;
// eligibility = 'SEPARATED';
// Error: Type '"SEPARATED"' is not assignable to type 'MaritalStatus'.
 
eligibility = MaritalStatus.Separated;  // No error


