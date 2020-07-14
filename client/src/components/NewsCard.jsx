import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Typography from '@material-ui/core/Typography';
import { Grid, Card, CardActionArea, CardContent, CardMedia } from './';

const useStyles = makeStyles({
  card: {
    color: 'black',
    display: 'flex',
  },
  media: {
    height: 270,
    backgroundRepeat: 'no-repeat',
  },
});

const News = ({ title, description, image, date }) => {
  const classes = useStyles();

  return (
    <Grid item xs={11} md={6} lg={6}>
      <Card className={classes.card}>
        <CardActionArea>
          <CardMedia className={classes.media} image={image} />
          <CardContent>
            <Typography gutterBottom variant="h4" component="h1">
              {title}
            </Typography>
            <Typography
              gutterBottom
              variant="subtitle1"
              color="textSecondary"
              component="p"
            >
              {description}
            </Typography>
            <Typography variant="body2" color="textSecondary" component="p">
              {date}
            </Typography>
          </CardContent>
        </CardActionArea>
      </Card>
    </Grid>
  );
};

export default News;
