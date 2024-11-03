import React, { useState } from 'react';
import './index.css';
import Container from '../../components/Container/Container';
import Card from '../../components/Card/Card';

interface Job {
    id: number;
    title: string;
}

const Main: React.FC = () => {
    const [searchQuery, setSearchQuery] = useState('');
    const [filteredJobs, setFilteredJobs] = useState<Job[]>([]);


    // Just to check Cards and JobDetails page, to be deleted later
    const jobs = [
        {
          id: 1,
          title: "Software Engineer Intern",
          company: "Tech Solutions Inc.",
          location: "New York, NY",
          description: "Join our team as a Software Engineer Intern and work on innovative projects.",
          requirements: "Knowledge of JavaScript, React, and Node.js.",
        },
        {
          id: 2,
          title: "Product Management Intern",
          company: "Global Corp",
          location: "Remote",
          description: "Help manage product life cycles and collaborate with cross-functional teams.",
          requirements: "Strong communication skills and ability to work in a team.",
        },
        {
            id: 3,
            title: "Product Management Intern",
            company: "Global Corp",
            location: "Remote",
            description: "Help manage product life cycles and collaborate with cross-functional teams.",
            requirements: "Strong communication skills and ability to work in a team.",
          },
          {
            id: 4,
            title: "Product Management Intern",
            company: "Global Corp",
            location: "Remote",
            description: "Help manage product life cycles and collaborate with cross-functional teams.",
            requirements: "Strong communication skills and ability to work in a team.",
          },
          {
            id: 5,
            title: "Product Management Intern",
            company: "Global Corp",
            location: "Remote",
            description: "Help manage product life cycles and collaborate with cross-functional teams.",
            requirements: "Strong communication skills and ability to work in a team.",
          },
          {
            id: 6,
            title: "Product Management Intern",
            company: "Global Corp",
            location: "Remote",
            description: "Help manage product life cycles and collaborate with cross-functional teams.",
            requirements: "Strong communication skills and ability to work in a team.",
          },
    ];

    const jobsFilter = [
        { id: 1, title: 'Software Engineer' },
        { id: 2, title: 'Product Manager' },
        { id: 3, title: 'Data Scientist' },
        { id: 4, title: 'UI/UX Designer' },
        { id: 5, title: 'DevOps Engineer' },
        { id: 6, title: 'Business Analyst' },
        { id: 7, title: 'Cyber Security Specialist' },
        { id: 8, title: 'Human Resources' },
        { id: 9, title: 'Sales Manager' },
        { id: 10, title: 'Project Manager' }
    ];

    const handleSearch = () => {
        const results = jobsFilter.filter(job =>
            job.title.toLowerCase().includes(searchQuery.toLowerCase())
        );
        setFilteredJobs(results);
    };

    return (
        <div className='main'>
            <Container>
                <h2 className='main-title'>JobHunt</h2>
                <div className='search-section'>
                    <input
                        type="text"
                        placeholder="Search for jobs..."
                        className='search-bar'
                        value={searchQuery}
                        onChange={(e) => setSearchQuery(e.target.value)}
                    />
                    <button className='search-btn' onClick={handleSearch}>Search</button>
                </div>
                <div className='filter-section'>
                {jobsFilter.length > 0 ? (
                    jobsFilter.map(job => (
                        <button key={job.id} className='filter-btn'>{job.title}</button>
                    ))
                ) : 
                    <p>No filter found</p>
                }
                </div>
                <div className='card-container'>
                    {jobs.length > 0 ? (
                        jobs.map(job => (
                            <Card key={job.id} id={job.id} title={job.title} />
                        ))
                    ) : (
                        <p>No jobs found</p>
                    )}
                </div>
            </Container>
        </div>
    );
};

export default Main;