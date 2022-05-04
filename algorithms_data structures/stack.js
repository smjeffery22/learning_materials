// Stack

// push: placing data onto a stack
// pop: removing the top element of a stack
// peek: displaying the top element of a stack
// length: determining how many elements are on a stack

// in JS, array object already has all the functions to use it as a stack
//  can use array as a stack

const Stack = function () {
  this.count = 0; // keeps track of how many items there are in the stack
  this.storage = {};

  // adds a value onto the end of the stack
  this.push = function (value) {
    // add the value at 'this.count' key
    //  ex. { count: value }
    this.storage[this.count] = value;

    // increment count after the value is added
    this.count++;
  }

  // removes and returns the value at the end of the stack
  this.pop = function () {
    // nothing to remove when the stack is empty
    if (this.count === 0) return undefined;

    // decrement count since the count is 1 greater than the length of stack
    this.count--;

    // last item int he stack
    const result = this.storage[this.count];
    delete this.storage[this.count];

    return result;
  }

  // returns the size of the stack
  this.size = function () {
    return this.count;
  }

  // returns the value at the end of the stack
  this.peek = function () {
    return this.storage[this.count - 1];
  }

  //
  this.showStack = function () {
    return this.storage;
  }
};

const myStack = new Stack();

myStack.push(2);
myStack.push(4);
myStack.push(6);
myStack.push(8);
console.log(myStack.showStack());
console.log('removed:', myStack.pop());
console.log(myStack.showStack());
console.log('size:', myStack.size());
console.log('last element:', myStack.peek());