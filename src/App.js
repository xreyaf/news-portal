import React, { Component } from 'react'
import { BrowserRouter, Route, Switch, Redirect } from 'react-router-dom';
import Header from './components/Header';
import Main from './components/Main';
import Footer from './components/Footer';
import './App.css';

export default class App extends Component {
  render() {
      return (
        <BrowserRouter>
        <div className='Header'>
        <Header/>
        </div>
        <br />
        <div className='Main'>
        <Main/>
        </div>
        <div className='Footer'>
        <Footer/>
        </div>
    </BrowserRouter>          
      )
  }
}
