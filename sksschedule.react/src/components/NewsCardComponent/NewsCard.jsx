import React from "react";
import './NewsCard.css';

const NewsCard = ({ title, date, description }) => {
  return (
    <div className="news-card">
      <h3>{title}</h3>
      <p className="date">{date}</p>
      <p>{description}</p>
    </div>
  );
};

export default NewsCard;