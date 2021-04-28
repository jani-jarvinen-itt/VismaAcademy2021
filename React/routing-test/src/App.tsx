import React from 'react';
import logo from './logo.svg';
import './App.css';
import { Link } from 'react-router-dom';

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        {/*
        <a className="App-link" href="/oma">Mene omalle sivulle</a>
        */}
        <Link to="/oma">Mene omalle sivulle</Link>
      </header>
    </div>
  );
}

export default App;
