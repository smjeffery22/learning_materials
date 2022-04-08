"use strict";
// after (), specify data type for return value
// also accepts optional argument
// order is important when using optional argument
// putting age? first would throw an error
const sayHello = (name, age) => {
    return `Hello there, ${name}`;
};
// const sayHello = (name: string, age?: number, treat?: ITreat): void => {
//   // return `Hello there, ${name}`;
// };
// sayHello(); // Expected 1 arguments, but got 0.ts(2554)
sayHello('Alice');
// need to include age even if it is optional to include treat as argument
// sayHello('Jeffery', 22, { name: 'kibbles and bits', tastiness: 7 })
// ASYNC
// promise returning a number when resolved
// write number as return type and it tells you what it should be (Promise<number>)
const returningPromise = (num) => {
    return Promise.resolve(num);
};
returningPromise(7).then((data) => { });
// to assign type for callback function
const higherOrderFunction = (num, callback) => {
    const returnVal = callback(num); // return from callback is a string so the value of returnVal is a string
};
higherOrderFunction(42, (num) => { return 'hello'; });
