import React, { useState } from 'react';
import Container from '../../components/Container/Container';
import './index.css';

const ApplicationForm: React.FC = () => {
    const [formData, setFormData] = useState({
        name: '',
        email: '',
        resume: null as File | null,
        coverLetter: ''
    });

    const handleChange = (e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
        const { name, value } = e.target;
        setFormData({ ...formData, [name]: value });
    };

    const handleFileChange = (e: React.ChangeEvent<HTMLInputElement>) => {
        if (e.target.files) {
            setFormData({ ...formData, resume: e.target.files[0] });
        }
    };

    const handleSubmit = (e: React.FormEvent) => {
        e.preventDefault();
        alert('Application submitted successfully!');
    };

    return (
        <Container>
            <h2>Application Form</h2>
            <form className="application-form" onSubmit={handleSubmit}>
                <label>
                    Full Name:
                    <input
                        type="text"
                        name="name"
                        value={formData.name}
                        onChange={handleChange}
                        required
                    />
                </label>
                <label>
                    Email:
                    <input
                        type="email"
                        name="email"
                        value={formData.email}
                        onChange={handleChange}
                        required
                    />
                </label>
                <label>
                    Resume:
                    <input type="file" name="resume" onChange={handleFileChange} required />
                </label>
                <label>
                    Cover Letter:
                    <textarea
                        name="coverLetter"
                        value={formData.coverLetter}
                        onChange={handleChange}
                        required
                    />
                </label>
                <button type="submit" className="submit-btn">Submit Application</button>
            </form>
        </Container>
    );
};

export default ApplicationForm;