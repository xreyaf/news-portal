import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { makeStyles } from '@material-ui/core/styles';
import { Grid } from './';
import NewsCard from './NewsCard';
import useInfiniteScroll from './useInfinite';
import Skeletons from './Skeletons';

const useStyles = makeStyles((theme) => ({
  grid: {
    minHeight: '80vh',
    width: '100%',
    margin: theme.spacing(0, 0),
  },
}));

const API_URL = 'https://fierce-sands-81057.herokuapp.com/api/News/page?page=';
let count = 1;

export default function Main() {
  const classes = useStyles();
  const [data, setData] = useState([]);
  const [length, setLength] = useState(10);
  const [isFetching, setIsFetching] = useInfiniteScroll(fetchMoreData);

  const loadData = () => {
    axios.get(API_URL + '0').then((res) => {
      setData(res.data.slice(0, length));
    });
  };

  function fetchMoreData() {
    axios
      .get(API_URL + `${count}`)
      .then((res) => {
        setData([...data, ...res.data]);
        setLength(10);
        count = count + 1;
        setIsFetching(false);
      })
      .catch((err) => console.log(`Couldn't fetch data. Error: ${err})`));
  }

  useEffect(() => {
    loadData();
  }, []);

  return (
    <Grid container className={classes.grid} spacing={4} justify="center">
      {data.length === 0 ? (
        <Skeletons />
      ) : (
        data.map((item) => (
          <NewsCard
            _id={item.id}
            title={item.title}
            description={item.description}
            image={item.newsImage}
            date={item.creationDateTime}
          />
        ))
      )}
    </Grid>
  );
}
