import { useEffect, useRef, useState } from 'react';
import Movie from './Movie';
import Filter from './Filter';
import { motion, AnimatePresence } from 'framer-motion';
import './App.css';

function App() {
	const [popular, setPopular] = useState([]);
	const [filtered, setFiltered] = useState([]);
	const [activeGenre, setActiveGenre] = useState(0);
	const [width, setWidth] = useState(0);
	const carousel = useRef();

	useEffect(() => {
		// wait for movie data to load first before setting the width
		fetchPopular().then(() => {
			setWidth(carousel.current.scrollWidth - carousel.current.offsetWidth);
		});
	}, []);

	// useEffect(() => {
	// 	// carousel.current.scrollWidth
	// 	//	width of the whole carousel
	// 	// carousel.current.offsetWidth
	// 	//	width of the carousel shown on the screen on initial load
	// 	// console.log(carousel.current.scrollWidth)
	// 	// console.log(carousel.current.offsetWidth)

	// 	setWidth(carousel.current.scrollWidth - carousel.current.offsetWidth);
	// }, [carousel.current]);

	// fetch popular movies from TMDB api
	const fetchPopular = async () => {
		const data = await fetch(
			`https://api.themoviedb.org/3/movie/popular?api_key=${process.env.REACT_APP_API_KEY}&language=en-US&page=1`
		);
		const movies = await data.json();

		setPopular(movies.results);
		setFiltered(movies.results);
	};

	return (
		<div className="App">
			<Filter
				popular={popular}
				setFiltered={setFiltered}
				activeGenre={activeGenre}
				setActiveGenre={setActiveGenre}
			/>
			<motion.div
				className="carousel"
				ref={carousel}
				whileTap={{ cursor: 'grabbing' }}
			>
				<motion.div
					drag="x" // allows dragging horizontally
					dragConstraints={{ right: 0, left: -width }} // stops dragging beyond left-end and right-end
					className="inner-carousel"
				>
					{filtered.map((movie) => {
						return <Movie key={movie.id} movie={movie} />;
					})}
				</motion.div>
			</motion.div>
		</div>
	);
}

export default App;

