import React, { useContext, useEffect, useState } from 'react';
import { FaBriefcase, FaHome, FaMapMarkerAlt, FaMoneyBillWave } from 'react-icons/fa';
import { IoMdCheckmarkCircleOutline } from "react-icons/io";
import { SiLevelsdotfyi } from 'react-icons/si';
import { useNavigate, useParams } from 'react-router-dom';
import jobApi from '../../api/jobApi';
import Container from '../../components/Container/Container';
import UserDataContext from '../../components/UserDataMode/UserDataMode';
import './index.css';

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
        id: string
        street: string
        city: string
        country: string
    }
    contractType: string
    jobLevel: string
    createdBy: string
    type: string
    technology: string
}

const JobDetails: React.FC = (props) => {
    const [jobDetails, setJobDetails] = useState<JobDetailsType>({
        id: "",
        title: "",
        companyName: "",
        operationMode: "",
        image: { id: "", imageUrl: "" },
        responsibilities: [],
        requirements: [],
        aboutCompany: "",
        salary: "",
        address: {
            id: "",
            street: "",
            city: "",
            country: "",
        },
        contractType: "",
        jobLevel: "",
        createdBy: "",
        type: "",
        technology: ""
    });

    const { id } = useParams<{ id: string }>();
    const navigate = useNavigate();
    const [isUpdate, setIsUpdate] = useState(false);
    const context = useContext(UserDataContext);

    if (!context) {
        throw new Error('Component must be used within a Provider');
    }

    const { userId, role } = context;

    useEffect(() => {
        jobApi.getJobById(id).then(data => {
            setJobDetails(data)
            console.log(data);
        });
    }, [])

    const handleApplyClick = () => {
        if (userId) {
            navigate(`/apply/${id}`);
        } else {
            navigate('/auth');
        }
    };

    const saveChange = () => {
        jobApi.updateJob(id, jobDetails);
        setIsUpdate(false)
    }

    console.log(jobDetails)

    const handleDelete = () => {
        jobApi.deleteJob(id, jobDetails.address.id, jobDetails.image.id);
        navigate('/myprofile');
    }

    const handleChange = (
        e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement | HTMLSelectElement>
    ) => {
        const { name, value } = e.target;
        if(name === 'street' || name === 'city' || name === 'country') {
            setJobDetails({ ...jobDetails, address: {...jobDetails.address, [name] : value }});
        } else if(name === 'requirements' || name === 'responsibilities') {
            setJobDetails({ ...jobDetails, [name] : [value] });
        } else {
            setJobDetails({ ...jobDetails, [name]: value });
        }
    };

    return (
        <Container>
            {!isUpdate ? <><div className="job-header">
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
                <div className='btns'>
                    {role === null || role === 'Employee' ? <button className="apply-btn" onClick={handleApplyClick}>Aplikuj szybko</button> : ''}
                    {role === 'Employer' &&
                        <div className="education_buttons-wrapper">
                            <button
                                className="job_update-button"
                                onClick={() => setIsUpdate(true)}
                            >
                                Update
                            </button>
                            <button onClick={handleDelete} className="job_delete-button">
                                Delete
                            </button>
                            <button onClick={() => navigate(`/apply/candidates/${id}`)} className="job_delete-button">
                                Candidates
                            </button>
                        </div>}
                </div></> : <><div className="job-header">
                    <div className='job-icon-wrapper'>
                        <img className='job-icon' src={jobDetails?.image.imageUrl} />
                    </div>
                    <div className='job-company-info'>
                        <input
                            type="text"
                            name="title"
                            className="job-input"
                            value={jobDetails?.title}
                            onChange={handleChange}
                        />
                        <input
                            type="text"
                            name="companyName"
                            className="job-input"
                            value={jobDetails?.companyName}
                            onChange={handleChange}
                        />
                    </div>
                </div>
                <div className='job-body'>
                    <div className="job-description">
                        <div className='job-info'>
                            <h3>Zakres obowiązków</h3>
                            <textarea
                                name="responsibilities"
                                className="job-textarea"
                                value={jobDetails?.responsibilities}
                                onChange={handleChange}
                            />
                        </div>
                        <div className='job-info'>
                            <h3 className='job-skills-title'>Nasze wymagania</h3>
                            <textarea
                                name="requirements"
                                className="job-textarea"
                                value={jobDetails?.requirements}
                                onChange={handleChange}
                            />
                        </div>
                        <div className='job-info'>
                            <h3 className='about-firm-title'>O firmie</h3>
                            <textarea
                                name="aboutCompany"
                                className="job-textarea"
                                value={jobDetails?.aboutCompany}
                                onChange={handleChange}
                            />
                        </div>
                    </div>
                    <div className="job-details">
                        <p className="salary-rate">
                            <FaMoneyBillWave />  <input
                                type="text"
                                name="salary"
                                className="job-input"
                                value={jobDetails?.salary}
                                onChange={handleChange}
                            />
                        </p>
                        <p className="job-location">
                            <FaMapMarkerAlt />  <input
                                type="text"
                                name="street"
                                className="job-input"
                                value={jobDetails?.address.street}
                                onChange={handleChange}
                            />  <input
                                type="text"
                                name="city"
                                className="job-input"
                                value={jobDetails?.address.city}
                                onChange={handleChange}
                            />  <input
                                type="text"
                                name="country"
                                className="job-input"
                                value={jobDetails?.address.country}
                                onChange={handleChange}
                            />
                        </p>
                        <p className="employment-type">
                            <FaBriefcase />  <input
                                type="text"
                                name="contractType"
                                className="job-input"
                                value={jobDetails?.contractType}
                                onChange={handleChange}
                            />
                        </p>
                        <p className="work-type">
                            <FaHome className='work-type-icon' /> <input
                                type="text"
                                name="operationMode"
                                className="job-input"
                                value={jobDetails?.operationMode}
                                onChange={handleChange}
                            />
                        </p>
                        <p className='work-level'>
                            <SiLevelsdotfyi /> <input
                                type="text"
                                name="jobLevel"
                                className="job-input"
                                value={jobDetails?.jobLevel}
                                onChange={handleChange}
                            />
                        </p>
                    </div>
                </div>
                <div className='btns'>
                    <button
                        className="job_update-button"
                        onClick={saveChange}
                    >
                        Save changes
                    </button>
                </div></>}
        </Container>
    );
};

export default JobDetails;