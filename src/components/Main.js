import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Typography from '@material-ui/core/Typography';
import Button from '@material-ui/core/Button';

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
        <div className="donwContainer">
          <Button className="getMoreButton" variant="outlined" size="small" >
            Get more views
          </Button>
          <svg class="MuiSvgIcon-root jss162" id="toTopBtn" focusable="false" viewBox="0 0 24 24" aria-hidden="true" tabindex="-1" title="KeyboardArrowUp" data-ga-event-category="material-icons" data-ga-event-action="click" data-ga-event-label="KeyboardArrowUp"><path d="M7.41 15.41L12 10.83l4.59 4.58L18 14l-6-6-6 6z"></path></svg>
        </div>
        </div>
  );
}



