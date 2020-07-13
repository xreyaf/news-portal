import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Container from '@material-ui/core/Container';
import Typography from '@material-ui/core/Typography';
import Link from '@material-ui/core/Link';
import InstagramIcon from '@material-ui/icons/Instagram';
import GitHubIcon from '@material-ui/icons/GitHub';
import TwitterIcon from '@material-ui/icons/Twitter';
import grey from '@material-ui/core/colors/grey';
import { Copyrights } from './';

const useStyles = makeStyles((theme) => ({
  footer: {
    background: grey[800],
    color:  grey[300],
    position: 'relative',
    padding: theme.spacing(6, 0),
  },
  root: {
    color:  grey[300],
  },
  social: {
     margin: theme.spacing(0, 1, 1, 1),
    '&:hover': {
      color: grey[50],
      transition: 'all 0.2s ease-in',
    },
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
          <Link
            color="inherit"
            href="https://github.com/haniichees/news-portal"
            target="_blank"
            rel="noopener noreferrer"
            underline="none">
          <GitHubIcon className={classes.social}/> 
          </Link>        
          <Link
            color="inherit"
            href="https://twitter.com/"
            target="_blank"
            rel="noopener noreferrer"
            underline="none"> 
          <TwitterIcon className={classes.social}/>
          </Link>    
          <Link
            color="inherit"
            href="https://www.instagram.com/"
            target="_blank"
            rel="noopener noreferrer"
            underline="none">
          <InstagramIcon className={classes.social}/>    
          </Link>    
        </Typography>
        <Copyrights />
      </Container>
    </footer>
  );
}
