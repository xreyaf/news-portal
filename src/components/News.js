import React from 'react';


const News = ({ title, description,image}) =>{
    return (
     
     <div className="news" >
         <div className="news_info">
             <h2 className="news_title">{title}</h2>
            <p className="news_description">
              {description}
            </p>
         </div>
         <div style={{backgroundImage: `url(${image})`}} className="news_image"></div>
     </div>
    
    )

}
export default News;