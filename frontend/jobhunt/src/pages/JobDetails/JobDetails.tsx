import React from 'react';
import { useParams } from 'react-router-dom';
import Container from '../../components/Container/Container';
import './index.css';

const JobDetails: React.FC = () => {
    const { id } = useParams<{ id: string }>();

    const job = {
        id,
        title: 'Software Engineer',
        description: 'A detailed description of the Software Engineer position...',
        company: 'Nike',
        hourlyRate: '$120/hr'
    };

    return (
        <Container>
            <h2 className="job-title">{job.title}</h2>
            <p className="company-name">{job.company}</p>
            <p className="hourly-rate">{job.hourlyRate}</p>
            <p className="job-description">{job.description}</p>
            <button className="apply-btn">Apply</button>
        </Container>
    );
};

export default JobDetails;
