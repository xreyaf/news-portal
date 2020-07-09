import React, {Component} from 'react';
import { makeStyles } from '@material-ui/core/styles';
import Typography from '@material-ui/core/Typography';
import Button from '@material-ui/core/Button';
import axios from 'axios';

import News from './News';


class Main extends Component {

  constructor(props) {
      super(props);

      this.state = {
          news: [],
          lenght : 10
      };

      

      this.fetchMorePosts = this.fetchMorePosts.bind(this);
  }

  fetchMorePosts(){
      this.setState({lenght: this.state.lenght+10});
      console.log(this.state.lenght);
  }
  render() {

      const {news} = this.state;
      
      axios
      .get('http://www.json-generator.com/api/json/get/cggSeGGCbm?indent=2')
      .then(res => {
          let newData = res
              .data
              .slice(0, this.state.lenght);
          this.setState({news: newData})
      })
      .catch(err => console.log("Couldn't fetch data. Error: " + err))
      return (
        <div className="NewsContainer" >
         <div className="container">
             { news.map(({ title, description, image, date},key) =>{
             return (
                 <News 
                 key={key}
                 title={title}
                 description={description.slice(0,150) + '...'}
                 image={image}
                 date={date}              />
             );
         })
         } 
         </div>
         <div className="donwContainer">
           <Button id="getMoreButton" onClick={this.fetchMorePosts} variant="outlined" size="small" >
             Get more views
           </Button>
           <svg class="MuiSvgIcon-root jss162" id="toTopBtn" focusable="false" viewBox="0 0 24 24" aria-hidden="true" tabindex="-1" title="KeyboardArrowUp" data-ga-event-category="material-icons" data-ga-event-action="click" data-ga-event-label="KeyboardArrowUp"><path d="M7.41 15.41L12 10.83l4.59 4.58L18 14l-6-6-6 6z"></path></svg>
         </div>
         </div>
      )
  }
}

export default Main


