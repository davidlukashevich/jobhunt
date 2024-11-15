import React from 'react';
import './index.css';
import { useNavigate } from 'react-router-dom';

interface CardProps {
  id: string
  title: string
  companyLogo: string
  companyName: string
  operationMode: string
  salary: string
  city: string
}

const Card: React.FC<CardProps> = ({ title, id, companyLogo, companyName, operationMode, salary, city }) => {
  const navigate = useNavigate();

  const handleViewClick = () => {
    navigate(`/job/${id}`);
  };

  return (
    <div className="card">
      <div className="card-header">
        <p className="hourly-rate">{salary}</p>
        <button className="bookmark-btn">🔖</button>
      </div>
      <h2 className="job-title">{title}</h2>
      <p className='job-city'>{city}</p>
      <p className='job-operation'>{operationMode}</p>
      <div className="card-arrow">
        <span>→</span>
      </div>
      <div className="card-footer">
        <div className="company-info">
          <img
            src={companyLogo} // Placeholder for the company logo
            alt="Company Logo"
            className="company-logo"
          />
          <p>{companyName}</p>
        </div>
        <button className="view-btn" onClick={handleViewClick}>View</button>
      </div>
    </div>
  );
};

export default Card;