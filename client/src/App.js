import React from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import { createMuiTheme, ThemeProvider } from '@material-ui/core/styles';
import CssBaseline from '@material-ui/core/CssBaseline';
import { Header, Main, Footer } from './components';
import NewsCard from './components/NewsCard';

export default function App() {
  const theme = createMuiTheme({
    overrides: {
      MuiCssBaseline: {
        '@global': {
          body: {
            WebkitFontSmoothing: 'auto',
            backgroundColor: '#212121',
            color: '#ebebeb',
          },
        },
      },
    },
  });

  return (
    <ThemeProvider theme={theme}>
      <CssBaseline />
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

    </ThemeProvider>
  );
}
