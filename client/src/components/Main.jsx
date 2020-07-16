import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { makeStyles } from '@material-ui/core/styles';
import { Grid } from './';
import Container from '@material-ui/core/Container';
import NewsCard from './NewsCard';
import useInfiniteScroll from './useInfinite';
import Skeletons from './Skeletons';

const useStyles = makeStyles((theme) => ({
  newsContainer: {
    padding: theme.spacing(0, 4, 4, 4),
    minHeight: '70vh',
  },
}));

const API_URL =
  'https://localhost:5001/api/News/page?page=';
let count= 1;

export default function Main() {
  const classes = useStyles();
  const [data, setData] = useState([]);
  const [length, setLength] = useState(10);
  const [isFetching, setIsFetching] = useInfiniteScroll(fetchMoreData);

  const loadData = () => {
    axios.get(API_URL+'0').then((res) => {
      setData(res.data.slice(0, length));
    });
  };



  function fetchMoreData() {
    axios.get(API_URL+`${count}`).then((res) => {
      setData([...data, ...res.data]);
      setLength(10);
      count = count + 1;
      console.log(count);
      console.log(API_URL+`${count}`);
      setIsFetching(false);
      
    }).catch((err) => console.log(`Couldn't fetch data. Error: ${err})`));
  }

  useEffect(() => {
    loadData();
  }, []);

  return (
    <Container className={classes.newsContainer} maxWidth="lg">
      <Grid container spacing={6} justify="center">
        {data.length === 0 ? (
          <Skeletons />
        ) : (
          data.map((item) => (
            <NewsCard
              _id={item._id}
              title={item.title}
              description={item.description}
              image={item.image}
              date={item.date}
            />
          ))
        )}
      </Grid>
    </Container>
  );
}
