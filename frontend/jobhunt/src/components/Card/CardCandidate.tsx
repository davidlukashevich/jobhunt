import { useNavigate } from "react-router"

interface CardProps {
    id: string
    name: string
    lastname: string
    email: string
    phone: string
    createdAt: string
  }

const CardCandidate: React.FC<CardProps> = ({ id, name, lastname, email, phone, createdAt }) => {
    const navigate = useNavigate();
  
    const handleViewClick = () => {
      navigate(`/apply/candidatesinfo/${id}`);
    };
  
    return (
      <div className="card-candidate">
        <h2 className="job-title">{name} {lastname}</h2>
        <p className='job-city'>{email}</p>
        <p className='job-operation'>{phone}</p>
        <div className="card-footer">
          <div className="company-info">
            <p>{createdAt}</p>
          </div>
          <button className="view-btn" onClick={handleViewClick}>View</button>
        </div>
      </div>
    );
  };
  
  export default CardCandidate;