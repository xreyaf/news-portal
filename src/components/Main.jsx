import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { makeStyles } from '@material-ui/core/styles';
import Grid from '@material-ui/core/Grid';
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

export default function Main() {
  const classes = useStyles();
  const [url, setUrl] = useState('http://www.json-generator.com/api/json/get/ceesmrUZnS?indent=2');
  const [data, setData] = useState([]);
  const [length, setLength] = useState(10);
  const [isFetching, setIsFetching] = useInfiniteScroll(moreData);

  const loadData = () => {
    axios
      .get(url)
      .then((res) => {
        setData(res.data.slice(0, length));
      });
  };
  function moreData() {
    axios
      .get(url)
      .then((res) => {
        setData([...data,...res.data.slice(length, length + 4)]);
        if (length <= data.length) {
          setLength(length + 4);
          setIsFetching(false);
        }
      });
  }

  useEffect(() => {
    loadData();
  }, []);

  return (
    <Container className={classes.newsContainer} maxWidth="lg">
      <Grid container spacing={6} justify="center">
        {data.length === 0
          ? (<Skeletons />)
          : (data.map((item) => (
            <NewsCard
              key={item.key}
              title={item.title}
              description={`${item.description.slice(0, 150)}...`}
              image={item.image}
              date={item.date}
            />
          )))}
      </Grid>
    </Container>
  );
}
