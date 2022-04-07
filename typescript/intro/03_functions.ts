// after (), specify data type for return value
// also accepts optional argument
// order is important when using optional argument
// putting age? first would throw an error
const sayHello = (name: string, age?: number, treat?: ITreat): string => {
  return `Hello there, ${name}`;
};

// const sayHello = (name: string, age?: number, treat?: ITreat): void => {
//   // return `Hello there, ${name}`;
// };

// sayHello(); // Expected 1 arguments, but got 0.ts(2554)
sayHello('Alice');
// need to include age even if it is optional to include treat as argument
sayHello('Jeffery', 22, { name: 'kibbles and bits', tastiness: 7 })

// ASYNC
// promise returning a number when resolved
// write number as return type and it tells you what it should be (Promise<number>)
const returningPromise = (num: number): Promise<number> => {
  return Promise.resolve(num);
}

returningPromise(7).then((data) => {});