import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import { Skeleton, Container } from './';

const useStyles = makeStyles((theme) => ({
  loading: {
    padding: theme.spacing(2, 3, 3, 3),
  },
}));

export default function NewsSkeleton() {
  const classes = useStyles();

  return (
    <Container className={classes.loading}>
      <Skeleton variant="text" animation="wave" height="10vh" />
      <Skeleton animation="wave" variant="rect" height="60vh" />
      <Skeleton variant="text" animation="wave" height="10vh" />
    </Container>
  );
}
