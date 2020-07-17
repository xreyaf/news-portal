import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Typography from '@material-ui/core/Typography';
import Link from '@material-ui/core/Link';
import { Grid, Card, CardActionArea, CardContent, CardMedia } from './';

const useStyles = makeStyles((theme) => ({
  card: {
    color: 'black',
    display: 'flex',
  },
  media: {
    height: 270,
    backgroundRepeat: 'no-repeat',
  },
  title: {
    [theme.breakpoints.down('sm')]: {
      fontSize: '1.6rem',
    },
  },
}));

const News = ({ _id, title, description, image, date }) => {
  const classes = useStyles();

  return (
    <Grid item xs={11} md={6} lg={6}>
      <Link href={'/news/id?id=' + `${_id}`} underline="none">
        <Card className={classes.card}>
          <CardActionArea>
            <CardMedia className={classes.media} image={image} />
            <CardContent>
              <Typography
                gutterBottom
                variant="h4"
                component="h1"
                className={classes.title}
              >
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
      </Link>
    </Grid>
  );
};

export default News;
