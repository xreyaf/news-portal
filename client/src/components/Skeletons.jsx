import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import { Skeleton } from './';
import Grid from '@material-ui/core/Grid';

const useStyles = makeStyles((theme) => ({
  loading: {
    margin: theme.spacing(2, 2),
  },
}));

export default function Skeletons() {
  const classes = useStyles();

  return (
    <Grid container className={classes.loading} spacing={6} justify="center">
      <Grid item xs={12} md={6} lg={6}>
        <Skeleton animation="wave" variant="rect" width="auto" height="30vh" />
        <Skeleton variant="text" animation="wave" height="7vh" />
        <Skeleton variant="text" animation="wave" height="4vh" />
      </Grid>
      <Grid item xs={12} md={6} lg={6}>
        <Skeleton animation="wave" variant="rect" width="auto" height="30vh" />
        <Skeleton variant="text" animation="wave" height="7vh" />
        <Skeleton variant="text" animation="wave" height="4vh" />
      </Grid>
      <Grid item xs={12} md={6} lg={6}>
        <Skeleton animation="wave" variant="rect" width="auto" height="30vh" />
        <Skeleton variant="text" animation="wave" height="7vh" />
        <Skeleton variant="text" animation="wave" height="4vh" />
      </Grid>
      <Grid item xs={12} md={6} lg={6}>
        <Skeleton animation="wave" variant="rect" width="auto" height="30vh" />
        <Skeleton variant="text" animation="wave" height="7vh" />
        <Skeleton variant="text" animation="wave" height="4vh" />
      </Grid>
    </Grid>
  );
}
