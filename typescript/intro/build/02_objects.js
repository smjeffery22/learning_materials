"use strict";
// const dog: {
//   name: string;
//   breed: string;
//   age: number;
// } = {
//   name: 'Bori',
//   breed: 'Toy Poodle',
//   age: 7,
// };
;
;
const dog = {
    getTreat: (treat) => { return false; },
    name: 'Bori',
    breed: 'Toy Poodle',
    age: 7,
    // array allowed for treats
    treats: [
        {
            name: 'kibbles and bits',
            tastiness: 7,
        }
    ]
};
// Dog type accepted in array
const dogs = [];
dogs.push(dog); // array of object created
// dogs.push({});
// dogs.push(5);
