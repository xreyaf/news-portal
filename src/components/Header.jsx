import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Link from '@material-ui/core/Link';
import Toolbar from '@material-ui/core/Toolbar';
import Button from '@material-ui/core/Button';
import Typography from '@material-ui/core/Typography';

const useStyles = makeStyles((theme) => ({
  toolbar: {
    color: '#f1f1f1',
    background: '#212121',
  },
  toolbarTitle: {
    flex: 1,
    fontFamily: [
      'Galada',
      'cursive',
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
    color: '#ededed',
    fontSize: '18px',
    '&:hover': {
      color: '#ffffff',
      transition: 'all 0.2s ease-in',
    },
  },
  SignInBtn: {
    border: '0px',
    fontSize: '18px',
    color: '#d09959',
    '&:hover': {
      color: '#ffca87',
      transition: 'all 0.2s ease-in',
    },
  },
  ToTopButton: {
    display: 'inline-block',
    backgroundColor: '#d09959',
    width: '50px',
    height: '50px',
    textAlign: 'center',
    borderRadius: '30px',
    position: 'fixed',
    bottom: '3%',
    right: '3%',
    transition: theme.transitions.create('opacity', {
      easing: theme.transitions.easing.easeIn,
      duration: theme.transitions.duration.enteringScreen,
    }),
    opacity: '0',
    visibility: 'hidden',
    zIndex: '1000',
    border: 'none',
    outline: 'none',
    '&:hover': {
      transition: 'all 0.5s ease-in-out',
      cursor: 'pointer',
      border: 'none',
      outline: 'none',
      backgroundColor: '#e0a765',
    },
    '&.show': {
      opacity: '0.9',
      visibility: 'visible',
    },
  },
}));

export default function Header() {
  const classes = useStyles();
  return (
    <>
      <Toolbar className={classes.toolbar}>
        <Link href="/" underline="none">
          <Button className={classes.HomeBtn} size="small">Home</Button>
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
      </Toolbar>
      {' '}
      <svg
        className={classes.ToTopButton}
        id="toTopBtn"
        focusable="false"
        viewBox="0 0 24 24"
        aria-hidden="true"
        tabIndex="-1"
        title="KeyboardArrowUp"
        data-ga-event-category="material-icons"
        data-ga-event-action="click"
        data-ga-event-label="KeyboardArrowUp"
      >
        <path d="M7.41 15.41L12 10.83l4.59 4.58L18 14l-6-6-6 6z" />
      </svg>
    </>
  );
}
