// const dog: {
//   name: string;
//   breed: string;
//   age: number;
// } = {
//   name: 'Bori',
//   breed: 'Toy Poodle',
//   age: 7,
// };

// new type added
interface ITreat {
  name: string;
  tastiness: number;
};

interface IDog {
  name: string;
  breed: string;
  age: number;
  treats: ITreat[]; // nested - array in object
}; 

const dog: IDog = {
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
const dogs: IDog[] = [];
dogs.push(dog); // array of object created
dogs.push({});
dogs.push(5);