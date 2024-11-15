import React, { useEffect, useState } from 'react';
import { FaBriefcase, FaHome, FaMapMarkerAlt, FaMoneyBillWave } from 'react-icons/fa';
import { SiLevelsdotfyi } from 'react-icons/si'
import { useNavigate, useParams } from 'react-router-dom';
import Container from '../../components/Container/Container';
import { IoMdCheckmarkCircleOutline } from "react-icons/io";
import './index.css';
import jobApi from '../../api/jobApi';

type JobDetailsType = {
    id: string
    title: string
    companyName: string
    operationMode: string,
    image: { id: string, imageUrl: string }
    responsibilities: string[]
    requirements: string[]
    aboutCompany: string
    salary: string
    address: {
        street: string
        city: string
        country: string
    }
    contractType: string
    jobLevel: string
}

const JobDetails: React.FC = () => {
    const [jobDetails, setJobDetails] = useState<JobDetailsType>();
    const { id } = useParams<{ id: string }>();
    const navigate = useNavigate();
    useEffect(() => {
        jobApi.getJobById(id).then(data => {
            setJobDetails(data)
        });
    }, [])

    const handleApplyClick = () => {
        navigate(`/apply/${id}`);
    };
    return (
        <Container>
            <div className="job-header">
                <div className='job-icon-wrapper'>
                    <img className='job-icon' src={jobDetails?.image.imageUrl} />
                </div>
                <div className='job-company-info'>
                    <h2 className="job-title">{jobDetails?.title}</h2>
                    <p className="company-name">{jobDetails?.companyName}</p>
                </div>
            </div>
            <div className='job-body'>
                <div className="job-description">
                    <div className='job-info'>
                        <h3>Zakres obowiązków</h3>
                        <ul>
                            <div className='job-response'><IoMdCheckmarkCircleOutline className='check-icon' /><li>{jobDetails?.responsibilities}</li></div>
                        </ul>
                    </div>
                    <div className='job-info'>
                        <h3 className='job-skills-title'>Nasze wymagania</h3>
                        <ul>
                            <div className='job-requirements'><IoMdCheckmarkCircleOutline className='check-icon' /><li>{jobDetails?.requirements}</li></div>
                        </ul>
                    </div>
                    <div className='job-info'>
                        <h3 className='about-firm-title'>O firmie</h3>
                        <p>{jobDetails?.aboutCompany}</p>
                    </div>
                </div>
                <div className="job-details">
                    <p className="salary-rate">
                        <FaMoneyBillWave /> {jobDetails?.salary}
                    </p>
                    <p className="job-location">
                        <FaMapMarkerAlt /> {jobDetails?.address.street}, {jobDetails?.address.city}, {jobDetails?.address.country}
                    </p>
                    <p className="employment-type">
                        <FaBriefcase /> {jobDetails?.contractType}
                    </p>
                    <p className="work-type">
                        <FaHome className='work-type-icon' /> {jobDetails?.operationMode}
                    </p>
                    <p className='work-level'>
                        <SiLevelsdotfyi />{jobDetails?.jobLevel}
                    </p>
                </div>
            </div>
            <button className="apply-btn" onClick={handleApplyClick}>Aplikuj szybko</button>
        </Container>
    );
};

export default JobDetails;