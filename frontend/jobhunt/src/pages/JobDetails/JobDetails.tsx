import React, { useState } from 'react';
import { FaBriefcase, FaHome, FaMapMarkerAlt, FaMoneyBillWave } from 'react-icons/fa';
import { SiLevelsdotfyi } from 'react-icons/si'
import { useNavigate, useParams } from 'react-router-dom';
import Container from '../../components/Container/Container';
import { IoMdCheckmarkCircleOutline } from "react-icons/io";
import './index.css';

const JobDetails: React.FC = () => {
    const [jobDetails, setJobDetails] = useState([]);
    const { id } = useParams<{ id: string }>();
    const navigate = useNavigate();

    const job = {
        id,
        title: 'Praktykant/Praktykantka do Zespołu .NET',
        icon: 'https://cdn-icons-png.freepik.com/256/3673/3673360.png?semt=ais_hybrid',
        company: 'AXA IT Solutions',
        location: 'Chłodna 51, Wola, Warszawa',
        employmentType: 'Umowa zlecenie',
        salaryRate: '32,00 zł brutto / godz.',
        workType: 'Praca zdalna, praca hybrydowa',
        level: 'Praktykant',
        responsibilities: [
            'Wykonywanie zadań developerskich z zakresu programowania w C# oraz Angular (17+)',
            'Współpraca i wsparcie zespołu testowego przy wykonywaniu ',
            'Analiza problemów developerskich i możliwości ich rozwiązania z bardziej doświadczonymi',
            'Praca zgodnie z metodyką Agile/DSDM',
        ],
        requirements: [
            'Znajomość dobrych praktyk tworzenia oprogramowania',
            'Doświadczenie w tworzeniu aplikacji w C# (.Net Framework, .Net Core)',
            'ASP.NET Web API',
            'Znajomość Angular (lub podobny framework SPA)',
            'Znajomość relacyjnych baz danych',
            'Znajomość SQL (T-SQL)',
            'Komunikatywna znajomość języka angielskiego',
            'Git',
        ],
        aboutCompany: 'AXA IT Solutions to wiodąca firma w branży technologii informacyjnych, oferująca nowoczesne rozwiązania dla sektora ubezpieczeń oraz finansów.',
    };

    const handleApplyClick = () => {
        navigate(`/apply/${id}`);
    };

    return (
        <Container>
            <div className="job-header">
                <div className='job-icon-wrapper'>
                    <img className='job-icon' src={job.icon} />
                </div>
                <div className='job-company-info'>
                    <h2 className="job-title">{job.title}</h2>
                    <p className="company-name">{job.company}</p>
                </div>
            </div>
            <div className='job-body'>
                <div className="job-description">
                    <div className='job-info'>
                        <h3>Zakres obowiązków</h3>
                        <ul>
                            {job.responsibilities.map((task, index) => (
                                <div className='job-response'><IoMdCheckmarkCircleOutline className='check-icon' /><li key={index}>{task}</li></div>
                            ))}
                        </ul>
                    </div>
                    <div className='job-info'>
                        <h3 className='job-skills-title'>Nasze wymagania</h3>
                        <ul>
                            {job.requirements.map((requirement, index) => (
                                <div className='job-requirements'><IoMdCheckmarkCircleOutline className='check-icon' /><li key={index}>{requirement}</li></div>
                            ))}
                        </ul>
                    </div>
                    <div className='job-info'>
                        <h3 className='about-firm-title'>O firmie</h3>
                        <p>{job.aboutCompany}</p>
                    </div>
                </div>
                <div className="job-details">
                    <p className="salary-rate">
                        <FaMoneyBillWave /> {job.salaryRate}
                    </p>
                    <p className="job-location">
                        <FaMapMarkerAlt /> {job.location}
                    </p>
                    <p className="employment-type">
                        <FaBriefcase /> {job.employmentType}
                    </p>
                    <p className="work-type">
                        <FaHome className='work-type-icon' /> {job.workType}
                    </p>
                    <p className='work-level'>
                        <SiLevelsdotfyi />{job.level}
                    </p>
                </div>
            </div>
            <button className="apply-btn" onClick={handleApplyClick}>Aplikuj szybko</button>
        </Container>
    );
};

export default JobDetails;