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

const API_URL = 'https://fierce-sands-81057.herokuapp.com/api/News/id?id=';

export default function News() {
  const [data, setData] = useState([]);
  const loadData = function () {
    const search = window.location.search;
    const params = new URLSearchParams(search);
    const id = params.get('id');
    axios.get(API_URL + id).then((res) => {
      setData(res.data);
      console.log(id);
    });
  };
  useEffect(() => {
    loadData();
  }, []);

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
            {data.title}
          </Typography>
          <CardMedia
            className={classes.media}
            image="https://medialeaks.ru/wp-content/uploads/2017/09/breaking-news-6-600x338.jpg"
          />
          <Typography
            gutterBottom
            variant="body1"
            color="inherit"
            component="p"
            className={classes.mainText}
          >
            {data.mainText}
          </Typography>
          <Typography
            variant="body2"
            color="textSecondary"
            component="p"
            className={classes.date}
          >
            {data.creationDateTime}| {data.authorName}
          </Typography>
        </CardContent>
      </Card>
    </Container>
  );
}
