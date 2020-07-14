import React, { useState, useEffect } from 'react';
import axios from 'axios';
import { makeStyles } from '@material-ui/core/styles';
import { Grid } from './';
import Container from '@material-ui/core/Container';
import Skeletons from './Skeletons';

const useStyles = makeStyles((theme) => ({
  newsContainer: {
    padding: theme.spacing(0, 4, 4, 4),
    minHeight: '70vh',
  },
}));

const API_URL = `http://www.json-generator.com/api/json/get/cfwTMGVysy?indent=2`;

export default function Main() {
  const classes = useStyles();
  const [data, setData] = useState([]);

  const loadData = () => {
    const id = this.props.match.params._id;
    axios.get(API_URL + { id }).then((res) => {
      setData(res.data);
      console.log(res.data);
    });
  };

  useEffect(() => {
    loadData();
  }, []);

  return (
    <Container className={classes.newsContainer} maxWidth="lg">
      {data.length === 0 ? (
        <Skeletons />
      ) : (
        <Container className="news">
          <h4>{data.title}</h4>
          <p className="bdy">{data.description}</p>
        </Container>
      )}
    </Container>
  );
}
