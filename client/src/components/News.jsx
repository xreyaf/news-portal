import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { makeStyles } from '@material-ui/core/styles';
import Container from '@material-ui/core/Container';
import Typography from '@material-ui/core/Typography';
import Skeletons from './Skeletons';
import { Grid, Card, CardActionArea, CardContent, CardMedia } from './';
import pic from './pic.jpg';

const useStyles = makeStyles((theme) => ({
  newsContainer: {
    padding: theme.spacing(0, 4, 4, 4),
    minHeight: '80vh',
  },
  media: {
    height: '40vh',
    backgroundRepeat: 'no-repeat',
    margin: theme.spacing(2, 2),
    borderRadius: '5px',
  },
  title: {
    padding: theme.spacing(2, 2),
  },
  mainText: {
    padding: theme.spacing(2, 2),
  },
  date: {
    padding: theme.spacing(0, 2),
  },
}));

export default function Main() {
  const classes = useStyles();

  return (
    <Container className={classes.newsContainer} maxWidth="lg">
      <Card className={classes.card}>
        <CardContent>
          <Typography
            gutterBottom
            variant="h4"
            component="h1"
            align="center"
            className={classes.title}
          >
            Vladimir Putin ejus posuit calamo in mensa, et in Russian media
            fecit pelagus fama dies. Ut ' quam nos invenit quod Praeses iratus!
          </Typography>
          <CardMedia className={classes.media} image={pic} />
          <Typography
            gutterBottom
            variant="body1"
            color="inherit"
            component="p"
            className={classes.mainText}
          >
            Res: Vladimir Putin ponit calamum in mensa per conventus in pugna
            flumina et ignes. Videtur quod hoc est finem fabula. Interim,
            Russian media scribere nuntium, quod Putin iratus est et sollicitus,
            Ruteni, ut videos, socialis retiacula,, concurrere in Analytics, et
            partim politica blandit. Evenit, quod Praeses non iustus posuit
            calamo. Et proiecit eam, projecit eam, proiecit eam et fere ledo
            officiales. Ut a praecessi, Putin et eius calamum fere fit,
            consectetur loco de die in Yandex.News". Scilicet, est omnino
            impossibile, ut legere hoc cum gravi faciem (et magis etiam, ut de
            ea). Ita at aliquam lacus in Russian media — sunt, ut semper
            pulchra. Et in omnibus negotium!
          </Typography>
          <Typography
            variant="body2"
            color="textSecondary"
            component="p"
            className={classes.date}
          >
            12/12/12 | Author Name
          </Typography>
        </CardContent>
      </Card>
    </Container>
  );
}
