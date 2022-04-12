import { useState } from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Header from './components/Header';
import Home from './components/Home';
import CartPage from './components/CartPage';
import './App.css';

function App() {

	return (
		<Router>
			<Header />
			<div className="app">
				<Routes>
					<Route path="/" element={<Home />} />
					<Route
						path="/cart"
						element={<CartPage />}
					/>
				</Routes>
			</div>
		</Router>
	);
}

export default App;
