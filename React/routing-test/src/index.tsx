import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import OmaKomponentti from './OmaKomponentti';
import TokaKomponentti from './TokaKomponentti';

import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import HookDemo1 from './HookDemo1';

ReactDOM.render(
  <React.StrictMode>
    <Router>
      {/* A <Switch> looks through its children <Route>s and
    renders the first one that matches the current URL. */}
      <Switch>
        <Route path="/oma">
          <OmaKomponentti />
        </Route>
        <Route path="/toinen">
          <TokaKomponentti />
        </Route>
        <Route path="/laskin">
          <HookDemo1 />
        </Route>
        <Route path="/">
          <App />
        </Route>
      </Switch>
    </Router>
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
