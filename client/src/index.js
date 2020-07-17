import React from 'react';
import ReactDOM from 'react-dom';
import App from './App';

const port = process.env.PORT || 3001;

ReactDOM.render(
  <React.StrictMode>
    <App />
  </React.StrictMode>,
  document.getElementById('root')
);
