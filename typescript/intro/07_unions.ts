function getMarginLeft(margin: string | number) {
  // margin may be a string or number here
 
  if (typeof margin === 'string') {
    // margin must be a string here
    return margin.toLowerCase();
  }

  // margin.toLowerCase(); // error since toLowerCase method doesn't exist on number type
  return `${margin}px`; // works because string type is checked in the above conditional
}

type Goose = { 
  isPettable: boolean; 
  hasFeathers: boolean;
  canThwartAPicnic: boolean;
}
 
type Moose = {
  isPettable: boolean; 
  hasHoofs: boolean;
}
 
const pettingZooAnimal: Goose | Moose = { isPettable: true };
 
console.log(pettingZooAnimal.isPettable); // No TypeScript error
console.log(pettingZooAnimal.hasHoofs); // TypeScript error