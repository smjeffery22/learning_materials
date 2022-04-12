import React, { useContext, useEffect, useState } from 'react';
import { Cart } from '../Context';
import SingleProduct from './SingleProduct';

const CartPage = () => {
  const [total, setTotal] = useState();
  const { cart, setCart } = useContext(Cart); // destructure value object from Provider

  useEffect(() => {
    setTotal(cart.reduce((acc, curr) => acc + Number(curr.price), 0))
  }, [cart])
  
	return (
		<div style={{ textAlign: 'center' }}>
			<span style={{ fontSize: 30 }}>My Cart</span>
			<br />
			<span style={{ fontSize: 30 }}>Total: {total}</span>
			<div className="productContainer">
				{cart.map((prod) => (
					<SingleProduct
						key={prod.id}
						prod={prod}
					/>
				))}
			</div>
		</div>
	);
};

export default CartPage;
