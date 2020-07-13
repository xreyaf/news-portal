import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Container from '@material-ui/core/Container';
import Typography from '@material-ui/core/Typography';
import Link from '@material-ui/core/Link';

function Copyright() {
  const classes = useStyles();
  return (
    <Typography
      className={classes.root}
      variant="body2"
      color="textSecondary"
      align="center"
    >
      {'© '}
      {new Date().getFullYear()}
      {' '}
      <Link
        color="inherit"
        href="http://bmstu-kaluga.ru/"
        target="_blank"
        rel="noopener noreferrer"
        underline="none"
      >
        BMSTU
      </Link>
    </Typography>

  );
}

const useStyles = makeStyles((theme) => ({
  footer: {
    background: '#424242',
    color: '#ebebeb',
    position: 'relative',
    padding: theme.spacing(6, 0),
  },
  root: {
    color: 'lightgray',
  },
}));

export default function Footer() {
  const classes = useStyles();

  return (
    <footer className={classes.footer}>
      <Container maxWidth="lg">
        <Typography
          variant="subtitle1"
          align="center"
          color="inherit"
          component="p"
        >
          w0w
        </Typography>
        <Copyright />
      </Container>
    </footer>
  );
}
