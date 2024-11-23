import React, { useState } from 'react';
import Container from '../../components/Container/Container';
import './index.css';

const ApplicationForm: React.FC = () => {
    const [formData, setFormData] = useState({
        name: '',
        email: '',
        lastname : '',
        mobile : '',
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
            <div className="application-form-wrapper">
                <div className="job_info-wrapper">
                    <img className='job_logo' src="https://jobhuntstorage.blob.core.windows.net/images/jbd.jpg" alt="" />
                    <h2>Junior Backend Developer</h2>
                </div>
               <h3>Dane osobowe:</h3>
                <form className="application-form" onSubmit={handleSubmit}>
                    <label className='label_name'>
                        First Name
                        <input
                            type="text"
                            className='input'
                            name="name"
                            value={formData.name}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label  className='label_lastname'>
                        Last name
                        <input
                            type="test"
                            name="lastname"
                            className='input'
                            value={formData.lastname}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label  className='label_email'>
                        E-mail
                        <input
                            type="test"
                            name="email"
                            className='input'
                            value={formData.email}
                            placeholder='example@gmail.com'
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label  className='label_mobile'>
                        Mobile
                        <input
                            type="test"
                            name="mobile"
                            className="input"
                            value={formData.mobile}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label  className='label_cv'>
                        CV
                        <input 
                        type="file" 
                        name="resume" 
                        onChange={handleFileChange} 
                        required
                    
                        className='input'
                         />
                    </label>
                    <label  className='label_coverletter'>
                        Is there something more we should know about you?
                        <textarea
                        className='textarea'
                            name="coverLetter"
                            value={formData.coverLetter}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <button type="submit" className="submit-btn">Submit Application</button>
                </form>
              
            </div>
        </Container>
    );
};

export default ApplicationForm;