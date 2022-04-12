import {createContext, useState} from 'react'

export const Cart = createContext();

const Context = ({children}) => {
  const [cart, setCart] = useState([]);

  return (
    // by putting cart and setCart in value
    // these are accessible in the whole application
    // since App component is wrapped with Cart.Provider
    <Cart.Provider value={{cart, setCart}}>
      {children}
    </Cart.Provider>
  )
}

export default Context