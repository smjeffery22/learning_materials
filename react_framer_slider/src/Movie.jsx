import { motion } from 'framer-motion';

const Movie = ({ movie }) => {
	return (
		<motion.div
			animate={{ opacity: 1 }}
			initial={{ opacity: 0 }}
			exit={{ opacity: 0 }}
			layout
			className="item"
		>
			<img
				src={`https://image.tmdb.org/t/p/w342${movie.poster_path}`}
				alt={movie.title}
			/>
		</motion.div>
	);
};

export default Movie;
