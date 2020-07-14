import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Typography from '@material-ui/core/Typography';
import Link from '@material-ui/core/Link';
import Button from '@material-ui/core/Button';
import Toolbar from '@material-ui/core/Toolbar';
import { amber, grey } from '@material-ui/core/colors';

const useStyles = makeStyles((theme) => ({
  toolbar: {
    color: grey[50],
    background: grey[900],
  },
  toolbarTitle: {
    flex: 1,
    fontFamily: [
      '-apple-system',
      'BlinkMacSystemFont',
      'Galada',
      'cursive',
      'Roboto',
      'Arial',
      'sans-serif',
      '"Apple Color Emoji"',
      '"Segoe UI Emoji"',
      '"Segoe UI Symbol"',
    ].join(','),
    margin: theme.spacing(1, 0),
  },
  toolbarSecondary: {
    justifyContent: 'space-between',
    overflowX: 'auto',
  },
  toolbarLink: {
    padding: theme.spacing(1),
    flexShrink: 0,
  },
  HomeBtn: {
    color: grey[300],
    fontSize: '18px',
    '&:hover': {
      color: grey[50],
      transition: 'all 0.2s ease-in',
    },
  },
  SignInBtn: {
    border: '0px',
    fontSize: '18px',
    color: amber[800],
    '&:hover': {
      color: amber[700],
      transition: 'all 0.2s ease-in',
    },
  },
}));

export default function Header() {
  const classes = useStyles();

  return (
    <>
      <Toolbar className={classes.toolbar} id="back-to-top-anchor">
        <Link href="/" underline="none">
          <Button className={classes.HomeBtn} size="small">
            Home
          </Button>
        </Link>
        <Typography
          variant="h3"
          component="h2"
          color="inherit"
          align="center"
          noWrap
          className={classes.toolbarTitle}
        >
          News Portal
        </Typography>
        <Button className={classes.SignInBtn} variant="outlined" size="small">
          Sign in
        </Button>
      </Toolbar>{' '}
    </>
  );
}
