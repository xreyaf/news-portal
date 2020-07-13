import React from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import { Header, Main, Footer } from './components';
import NewsCard from './components/NewsCard';
import './App.css';

export default function App() {
  return (
    <BrowserRouter>
      <Header />
      <Switch>
        <Route path="/" component={Main} />
        {' '}
        <Route
          path="/news/:title"
          component={NewsCard}
        />
      </Switch>
      <Footer />
    </BrowserRouter>
  );
}
