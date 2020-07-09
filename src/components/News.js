import React from 'react';


const News = ({ title, description,image, date}) =>{
    return (
     
     <div className="news" >
         <div className="news_info">
             <h2 className="news_title">{title}</h2>
            <p className="news_description">
              {description}
            </p>
            <div className="news_info_footer">
                <time className="timestamp">
                 {date}
                </time>
            </div>
         </div>
         <div style={{backgroundImage: `url(${image})`}} className="news_image"></div>
     </div>
    
    )

}
export default News;