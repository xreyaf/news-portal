import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Typography from '@material-ui/core/Typography';
import Link from '@material-ui/core/Link';

const useStyles = makeStyles((theme) => ({
    root: {
      color: 'lightgray',
    },
  }));

export default  function Copyrights() {
    const classes = useStyles();
    
    return (
      <Typography
        className={classes.root}
        variant="body2"
        color="textSecondary"
        align="center"
      >
        {`© `}
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
   