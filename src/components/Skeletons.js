import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Skeleton from '@material-ui/lab/Skeleton';
import Grid from '@material-ui/core/Grid';

const useStyles = makeStyles((theme) => ({
  loading: {
    margin: theme.spacing(2, 2),
    width: '70vh',
  },
}));

export default function Variants() {
  const classes = useStyles();
  return (
    <div className={classes.loading}>
      <Grid container spacing={5} justify="center">
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
    </div>
  );
}
