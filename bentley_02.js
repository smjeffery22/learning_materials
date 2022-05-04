// array consisting of N integers
// return the biggest value X
//  that occurs X times
// if no such value, return 0

function solution(A) {
  // write your code in JavaScript (Node.js 8.9.4)

  // declare an empty object
  // loop through the array, check if element exists as a key in object
  // if no  => add as key with value of 1
  // if yes => increment its value
  const numsObj = {};
  
  for (const num of A) {
    if (!numsObj[num]) {
      numsObj[num] = 1;
    } else {
      numsObj[num] = numsObj[num] + 1;
    }
    // console.log('current numbObj:', numsObj);
  }

  // loop through the object
  // check if key === value
  // if yes => assign as largest
  // if another one meets the condition and greater than current largest
  //  reassign largest
  // if no match, it would return 0 (initially declared largest value)
  let largest = 0;

  for (const nums in numsObj) {
    if (numsObj[nums] === parseInt(nums) && parseInt(nums) > largest) {
      largest = parseInt(nums);
    }
    // console.log('current largest:', largest)
  }

  // console.log('final largest:', largest);
  return largest;
}

const A = [3, 8, 2, 3, 3, 2];
solution(A);