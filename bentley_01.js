// function solution(A) {
//   // write your code in JavaScript (Node.js 8.9.4)

//   // check if array includes 0
//   // if it does, return 0
//   if (A.includes(0)) return 0;

//   // loop through the array
//   // multiply all the numbers
//   let result = A[0];

//   for (let i = 1; i < A.length; i++) {
//     result *= A[i];
//     console.log(result);
//   }

//   return (result > 0) ? '+1' : '-1';
// }

// const A = [1, -2, -3, 5, -2, 0];
// console.log(solution(A));

function solution(A) {
	// check if array includes 0
	// if it does, return 0
	if (A.includes(0)) return 0;

  // check how many negative integers there are in the array
  // if even =>  1
  // if odd  => -1
	let counter = 0;

	for (let i = 0; i < A.length; i++) {
		if (A[i] < 0) {
			counter++;
		}
	}

  return (counter % 2 === 0) ? 1 : -1;
}

const A = [1, -2, -3, 5, -5];
console.log(solution(A));