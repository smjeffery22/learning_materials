import { useState, useReducer } from 'react';
import './App.css';

const reducerFunction = (state, action) => {
  console.log(state);
  console.log(action);
  // 'action' is sent from dispatch (object)
	switch (action.type) {
		case 'increment':
			return {
				...state,
				count: state.count + 1,
			};
		case 'decrement':
			return {
				...state,
				count: state.count - 1,
			};
    case 'initCount':
      return {
        ...state,
        count: action.payload // 'payload' can be set using dispatch
      }
		default:
			return state;
	}
};

const initialState = {
	count: 2,
};

function App() {
	const [input, setInput] = useState(0);
	// 'dispatch' different action to the reducerFunction
	// to manage or handle the state in different ways
	const [state, dispatch] = useReducer(reducerFunction, initialState);

	return (
		<div className="App">
			<h1>Reducer Example</h1>

			<div>
				<label htmlFor="">Start Count:</label>
				<input
					type="number"
					value={input}
					onChange={(e) => setInput(parseInt(e.target.value))}
				/>
				<br />
				<button onClick={() => dispatch({type: 'initCount', payload: input})}>Initialize Counter</button>
			</div>

			<p>{state.count}</p>
			<button onClick={() => dispatch({type: 'decrement'})}>-</button>
			<button onClick={() => dispatch({type: 'increment'})}>+</button>
		</div>
	);
}

export default App;
