import React, { useState } from 'react';
import { User } from './interfaces';

// nested objects in interface - not a good practice
// interface User {
// 	name: string;
// 	age: number;
// 	country: string;
// 	address: {
// 		street: string;
// 		number: number;
// 		zip: string;
// 	};
// 	admin: boolean;
// }

// composed interfaces - referencing interfaces to avoid nested objects
// good practice to create interfaces file and put all global interfaces
// interface User {
// 	name: string;
// 	age: number;
// 	country: string;
// 	address: Address
// 	admin: boolean;
// }

// interface Address {
//   street: string;
//   number: number;
//   zip: string;
// }

// const defaultFormData = {
//   title: "",
// }

const App = () => {
	// common practice to set initial state to null
	// once state changes, set type annotation
	const [user, setUser] = useState<User | null>(null);

	const fetchUser = () =>
		setUser({
			name: 'Jeffery',
			age: 29,
			country: 'Canada',
			address: {
				street: 'Valhalla Crt.',
				number: 500,
				zip: 'L6L 5M6',
			},
			admin: false,
		});

	return (
		<>
			<button onClick={fetchUser}>Fetch user on click</button>
			{user && <p>{`Welcome ${user.name}!`}</p>}
		</>
	);
};

export default App;
