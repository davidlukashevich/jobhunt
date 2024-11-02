import React from 'react';
import './index.css';
import { useNavigate } from 'react-router-dom';

interface CardProps {
  title: string;
  id: number;
}

const Card: React.FC<CardProps> = ({ title, id }) => {
  const navigate = useNavigate();

  const handleViewClick = () => {
    navigate(`/job/${id}`);
  };
  
  return (
    <div className="card">
      <div className="card-header">
        <p className="hourly-rate">$120/hr</p>
        <button className="bookmark-btn">🔖</button>
      </div>
      <h2 className="job-title">{title}</h2>
      <div className="card-arrow">
        <span>→</span>
      </div>
      <div className="card-footer">
        <div className="company-info">
          <img
            src="https://via.placeholder.com/24" // Placeholder for the company logo
            alt="Company Logo"
            className="company-logo"
          />
          <p>Nike</p>
        </div>
        <button className="view-btn" onClick={handleViewClick}>View</button>
      </div>
    </div>
  );
};

export default Card;