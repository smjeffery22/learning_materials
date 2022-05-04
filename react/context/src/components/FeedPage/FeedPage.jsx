import React, { useContext } from 'react';

import AppContext from '../../context/app-context';

const FeedPage = () => {
	const { message } = useContext(AppContext);

	return (
		<div>
			<h2 style={{ background: '#eee' }}>This is the feed page</h2>

			<p>{message}</p>
		</div>
	);
};

export default FeedPage;