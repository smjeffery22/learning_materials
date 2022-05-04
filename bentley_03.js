// array consisting of N integers
// returns the maximum sum of two numbers
// whose digits add up to an equal sum

function solution(A) {
	// write your code in JavaScript (Node.js 8.9.4)

  // create an empty object
  // loop through the array
  // for each number, add each digit
  
	const sums = {};
	let largest = 0;
	let frequent = 0;
	let start = 0;
	let next = 1;

	while (start < A.length - 1) {
		const sum = A[start] + A[next];

		if (!sums[sum]) {
			sums[sum] = 1;
		} else {
			sums[sum] = sums[sum] + 1;
		}

		if (sum > largest && sums[sum] >= frequent) largest = sum;

		if (next === A.length - 1) {
			start++;
			next = start + 1;
		} else {
			next++;
		}
	}

	return largest;
}
