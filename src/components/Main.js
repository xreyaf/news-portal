import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Typography from '@material-ui/core/Typography';

import news from './news.json';
import News from './News';

const useStyles = makeStyles((theme) => ({
    content: {
    padding: theme.spacing(3, 0),
    minHeight: '70vh',
    
  },
}));

export default function Main(props) {
    const classes = useStyles();

  return (
      <div className={classes.content} >
       <Typography 
          variant="h4" 
          component="h2"
          color="insherit"
          align="center">
        Latest news
        </Typography>
        <div className="container">
            { news.map(({ title, description, image},key) =>{
            return (
                <News 
                key={key}
                title={title}
                description={description.slice(0,150) + '...'}
                image={image}
                />
            );
        })

        }
        </div>
        </div>
  );
}
