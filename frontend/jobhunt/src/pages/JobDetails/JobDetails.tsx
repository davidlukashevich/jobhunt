import React from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import Container from '../../components/Container/Container';
import './index.css';

const JobDetails: React.FC = () => {
    const { id } = useParams<{ id: string }>();
    const navigate = useNavigate();

    const job = {
        id,
        title: 'Spawacz',
        company: 'WT-Polska Sp. z o.o.',
        location: 'Hawelańska 1, Stare Miasto, Poznań',
        employmentType: 'Umowa o pracę',
        salaryRange: '5 500–8 000 zł brutto / mies.',
        workType: 'Praca stacjonarna',
        availability: 'Praca od zaraz',
        description: 'Opis pracy dla pozycji Spawacza...',
        workingHours: '7:00-15:00, możliwe nadgodziny',
        days: 'Poniedziałek - Piątek',
        benefits: 'Stała podstawa wynagrodzenia + premia za wyniki + premia świąteczna + nadgodziny'
    };

    const handleApplyClick = () => {
        navigate(`/apply/${id}`);
    };

    return (
        <Container>
            <div className="job-header">
                <h2 className="job-title">{job.title}</h2>
                <p className="company-name">{job.company}</p>
                <p className="job-location">{job.location}</p>
            </div>
            <div className="job-details">
                <p className="salary-range">{job.salaryRange}</p>
                <p className="employment-type">{job.employmentType}</p>
                <p className="work-type">{job.workType}</p>
                <p className="availability">{job.availability}</p>
            </div>
            <div className="job-description">
                <h3>Opis stanowiska</h3>
                <p>{job.description}</p>
                <p className="working-hours">Godziny pracy: {job.workingHours}</p>
                <p className="days">{job.days}</p>
                <p className="benefits">{job.benefits}</p>
            </div>
            <button className="apply-btn" onClick={handleApplyClick}>Aplikuj szybko</button>
        </Container>
    );
};

export default JobDetails;