export interface User {
	name: string;
	age: number;
	country: string;
	address: Address
	admin: boolean;
}

export interface Address {
  street: string;
  number: number;
  zip: string;
}