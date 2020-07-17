import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Typography from '@material-ui/core/Typography';
import Link from '@material-ui/core/Link';

const useStyles = makeStyles((theme) => ({
  root: {
    color: 'lightgray',
  },
  links: {
    color: 'inherit',
    target: '_blank',
    rel: 'noopener noreferrer',
  },
}));

export default function Copyrights() {
  const classes = useStyles();

  return (
    <Typography
      className={classes.root}
      variant="body2"
      color="textSecondary"
      align="center"
    >
      {`© `}
      {new Date().getFullYear()}{' '}
      <Link
        href="http://bmstu-kaluga.ru/"
        target="_blank"
        rel="noopener noreferrer"
        className={classes.links}
      >
        BMSTU KALUGA
      </Link>
      {` `}
      <Link
        href="https://vk.com/eic5_kb"
        target="_blank"
        rel="noopener noreferrer"
        className={classes.links}
      >
        IPS
      </Link>
    </Typography>
  );
}
