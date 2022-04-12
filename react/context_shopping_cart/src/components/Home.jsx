import React, { useContext, useState } from 'react';
import { faker } from '@faker-js/faker';
import SingleProduct from './SingleProduct';
import './styles.css';
import { Cart } from '../Context';

faker.seed(100);

const productsArray = [...Array(20)].map(() => ({
	id: faker.datatype.uuid(),
	name: faker.commerce.product(),
	price: faker.commerce.price(),
	image: faker.image.image(),
}));

const Home = () => {
	const [products, setProducts] = useState(productsArray);

	return (
		<div className="productContainer">
			{products.map((prod) => (
				<SingleProduct
					key={prod.id}
					prod={prod}
				/>
			))}
		</div>
	);
};

export default Home;
