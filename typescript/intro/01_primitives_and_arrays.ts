// PRIMITIVES
// let username: string = 'Alice';
// let username: string | number = 'Alice';
let username: string | number | boolean = 'Alice';

username = 'Bob';
username = 42;
username = false;

// ARRAYS
// const numbers: number[] = [];
// const numbers: number[] = [1, 2, 3];
const numbers: (string | number)[] = [1, 2, 3];

numbers.push(4);
numbers.push('four');
// numbers.push(true);

const result = numbers.pop(); // data type of result is number since the elements in the array are numbers

let empty = undefined;
empty = 22;