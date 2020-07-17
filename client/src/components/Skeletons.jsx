import React from 'react';
import { Skeleton } from './';
import Grid from '@material-ui/core/Grid';

export default function Skeletons() {
  return (
    <React.Fragment>
      <Grid item xs={11} md={5} lg={5} xl={5}>
        <Skeleton animation="wave" variant="rect" width="auto" height="30vh" />
        <Skeleton variant="text" animation="wave" height="7vh" />
        <Skeleton variant="text" animation="wave" height="4vh" />
      </Grid>
      <Grid item xs={11} md={5} lg={5} xl={5}>
        <Skeleton animation="wave" variant="rect" width="auto" height="30vh" />
        <Skeleton variant="text" animation="wave" height="7vh" />
        <Skeleton variant="text" animation="wave" height="4vh" />
      </Grid>
      <Grid item xs={11} md={5} lg={5} xl={5}>
        <Skeleton animation="wave" variant="rect" width="auto" height="30vh" />
        <Skeleton variant="text" animation="wave" height="7vh" />
        <Skeleton variant="text" animation="wave" height="4vh" />
      </Grid>
      <Grid item xs={11} md={5} lg={5} xl={5}>
        <Skeleton animation="wave" variant="rect" width="auto" height="30vh" />
        <Skeleton variant="text" animation="wave" height="7vh" />
        <Skeleton variant="text" animation="wave" height="4vh" />
      </Grid>
    </React.Fragment>
  );
}
