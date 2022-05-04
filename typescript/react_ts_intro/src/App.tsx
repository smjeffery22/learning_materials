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

const defaultFormData = {
	title: '',
	body: '',
};

const App = () => {
	// common practice to set initial state to null
	// once state changes, set type annotation
	const [user, setUser] = useState<User | null>(null);
	const [formData, setFormData] = useState(defaultFormData);
	const { title, body } = formData;

  // write (e) => onChange(e) and hover over e to get acceptable type
	const onChange = (e: React.ChangeEvent<HTMLInputElement>) => {
		setFormData((prev) => ({
			...prev,
			[e.target.id]: e.target.value,
		}));
	};

	const onSubmit = (e: React.FormEvent<HTMLFormElement>) => {
		e.preventDefault();
		console.log(formData);

		setFormData(defaultFormData);
	};

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

			<h1>Form</h1>
			<p>Create a Post</p>

			<form onSubmit={onSubmit}>
				<label htmlFor="title">Title</label>
				<br />
				<input type="text" id="title" value={title} onChange={onChange} />
				<br />
				<br />
				<label htmlFor="body">Body</label>
				<br />
				<input type="text" id="body" value={body} onChange={onChange} />
				<br />
				<br />
				<button type="submit">Upload Post</button>
			</form>
		</>
	);
};

export default App;
