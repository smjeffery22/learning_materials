// Palindrome
//  if a word is reversed and still the same word

/*
 *  Method #1 - for loops
 */
// const word = 'racecar';
// const characters = [];
// let rWord = '';

// // loop over the word
// //  push each character into an empty array
// //  each element will be the characters of the word
// for (let i = 0; i < word.length; i++) {
//   characters.push(word[i]);
// }
// console.log(characters);
// // loop over the array from the last element
// //  add each element to an empty string
// for (let i = characters.length - 1; i >= 0; i--) {
//   rWord += characters[i]
// }

// // if the empty string at the end === original word
// //  palindrome
// // if not => not palindrome
// if (word === rWord) {
//   console.log(`${word} is a palindrome!`);
// } else {
//   console.log(`${word} is not a palindrome!`);
// }

/*
 *  Method #2 - array methods
 */
// convert to lower case
// transform string into an array using .split() method
//  each element will represent the characters
// reverse the array
// transform array into string using .join() method
// if it equals to the original word, palindrome
const word = 'racecar';

const palindrome = (word) => {
  let rWord = word.toLocaleLowerCase();
  
  if (word === rWord.split('').reverse().join('')) {
    console.log(`${word} is a palindrome!`);
  } else {
    console.log(`${word} is not a palindrome!`);
  }
}

palindrome(word);