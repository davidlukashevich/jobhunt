import { FC, useEffect, useState } from 'react';
import jobApi from '../../api/jobApi';
import Card from '../../components/Card/Card';
import Container from '../../components/Container/Container';
import { Loader } from '../../components/Loader/Loader';
import './index.css';

interface Job {
    id: number
    title: string;
}

type JobType = {
    id: string
    title: string
    companyLogo: string
    companyName: string
    operationMode: string
    salary: string
    city: string
}

const Main: FC = () => {
    const [searchQuery, setSearchQuery] = useState('');
    const [error, setError] = useState(false);
    const [isLoading, setIsLoading] = useState(false);
    const [jobs, setJobs] = useState<JobType[]>([]);

    useEffect(() => {
        setIsLoading(true)
        jobApi.getAllJobs().then(data => {
            setIsLoading(false)
            setJobs(data)
        })
    }, [])

    const jobsFilter = [
        { id: 1, title: 'Frontend' },
        { id: 2, title: 'Backend' },
        { id: 3, title: 'Fullstack' },
        { id: 4, title: 'Mobile' },
        { id: 5, title: 'GameDev' }
    ];

    const handleSearch = () => {
        if (searchQuery === "") {
            setError(true);
            return
        }
        setIsLoading(true)
        jobApi.getAllJobsByTitle(searchQuery).then(data => {
            setError(false)
            setIsLoading(false)
            setJobs(data);
        });
    };

    const handleFilter = (filteredJobs: string) => {
        setIsLoading(true)
        jobApi.getAllJobsByFilter(filteredJobs, '', '').then(data => {
            setIsLoading(false)
            setJobs(data);
        });
    }

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
                    {error && <p className='search-error'>Enter a vacancy</p>}
                </div>
                <div className='filter-section'>
                    {jobsFilter.length > 0 ? (
                        jobsFilter.map(job => (
                            <button onClick={() => handleFilter(job.title)} key={job.id} className='filter-btn'>{job.title}</button>
                        ))
                    ) :
                        <p>No filter found</p>
                    }
                </div>
                {isLoading ? <Loader /> : <div className='card-container'>
                    {jobs.length > 0 ? (
                        jobs.map((job) => (
                            <Card key={job.id} id={job.id} title={job.title} companyLogo={job.companyLogo} companyName={job.companyName} city={job.city} salary={job.salary} operationMode={job.operationMode} />
                        ))
                    ) : (
                        <p>No jobs found</p>
                    )}
                </div>}
            </Container>
        </div>
    );
};

export default Main;