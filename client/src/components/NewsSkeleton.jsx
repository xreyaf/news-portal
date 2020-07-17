import React, { Fragment } from 'react';
import { Skeleton } from './';

export default function NewsSkeleton() {
  return (
    <Fragment>
      <Skeleton variant="text" animation="wave" widht="auto" height="10vh" />
      <Skeleton animation="wave" variant="rect" widht="auto" height="60vh" />
      <Skeleton variant="text" animation="wave" widht="auto" height="10vh" />
    </Fragment>
  );
}
