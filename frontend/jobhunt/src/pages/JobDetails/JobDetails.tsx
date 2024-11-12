import React, { useState } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import Container from '../../components/Container/Container';
import { FaMapMarkerAlt, FaClock, FaMoneyBillWave, FaBriefcase, FaHome, FaCalendarAlt } from 'react-icons/fa';
import './index.css';

const JobDetails: React.FC = () => {
    const [jobDetails, setJobDetails] = useState([]);
    const { id } = useParams<{ id: string }>();
    const navigate = useNavigate();

    const job = {
        id,
        title: 'Praktykant/Praktykantka do Zespołu .NET',
        company: 'AXA IT Solutions',
        location: 'Chłodna 51, Wola, Warszawa',
        employmentType: 'Umowa zlecenie',
        salaryRate: '32,00 zł brutto / godz.',
        workType: 'Praca zdalna, praca hybrydowa',
        contractDuration: 'Pełny etat / część etatu',
        availability: 'ważna do 23 listopada 2024',
        responsibilities: [
            'Wykonywanie zadań developerskich z zakresu programowania w C# oraz Angular (17+)',
            'Współpraca i wsparcie zespołu testowego przy wykonywaniu testów nowych funkcjonalności i poprawy błędów w już istniejących',
            'Analiza problemów developerskich i możliwości ich rozwiązania z bardziej doświadczonymi osobami w zespole',
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
                <h2 className="job-title">{job.title}</h2>
                <p className="company-name">{job.company}</p>
                <p className="job-location">
                    <FaMapMarkerAlt /> {job.location}
                </p>
            </div>
            <div className="job-body">
                <div className="job-description">
                    <h3>Zakres obowiązków</h3>
                    <ul>
                        {job.responsibilities.map((task, index) => (
                            <li key={index}>{task}</li>
                        ))}
                    </ul>
                    <h3>Nasze wymagania</h3>
                    <ul>
                        {job.requirements.map((requirement, index) => (
                            <li key={index}>{requirement}</li>
                        ))}
                    </ul>
                    <h3>O firmie</h3>
                    <p>{job.aboutCompany}</p>
                </div>
                <div className="job-details">
                    <p className="salary-rate">
                        <FaMoneyBillWave /> {job.salaryRate}
                    </p>
                    <p className="employment-type">
                        <FaBriefcase /> {job.employmentType}
                    </p>
                    <p className="work-type">
                        <FaHome /> {job.workType}
                    </p>
                    <p className="contract-duration">
                        <FaClock /> {job.contractDuration}
                    </p>
                    <p className="availability">
                        <FaCalendarAlt /> {job.availability}
                    </p>
                </div>
            </div>
            <button className="apply-btn" onClick={handleApplyClick}>Aplikuj szybko</button>
        </Container>
    );
};

export default JobDetails;