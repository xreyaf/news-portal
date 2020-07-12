import React, { Component } from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import Header from './components/Header';
import Main from './components/Main';
import Footer from './components/Footer';
import './App.css';
import NewsCard from './components/NewsCard'

export default class App extends Component {
    render() {
        return (
          <BrowserRouter>
            <div className="Header">
              <Header />
            </div>
            <br />
            <div className="Main">
              <Switch>
                <Route path="/" component={Main} />
                {<Route path="/news/:title" component={NewsCard} />}
              </Switch>
            </div>
            <div className="Footer">
              <Footer />
            </div>
          </BrowserRouter>
        );
    }
}
