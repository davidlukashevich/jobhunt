import React, { useState } from 'react';
import Container from '../../components/Container/Container';
import './index.css';

const PostJobOffer: React.FC = () => {
  const [jobData, setJobData] = useState({
    title: '',
    description: '',
    location: '',
    salary: '',
  });

  const handleChange = (e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
    const { name, value } = e.target;
    setJobData({ ...jobData, [name]: value });
  };

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    // add logic here later

    console.log('Job Offer Submitted:', jobData);
    alert('Job offer posted successfully!');
    setJobData({ title: '', description: '', location: '', salary: '' });
  };

  return (
    <Container>
      <div className="post-job-page">
        <h2>Post a New Job Offer</h2>
        <form className="post-job-form" onSubmit={handleSubmit}>
          <label>
            Job Title:
            <input
              type="text"
              name="title"
              value={jobData.title}
              onChange={handleChange}
              required
            />
          </label>
          <label>
            Description:
            <textarea
              name="description"
              value={jobData.description}
              onChange={handleChange}
              required
            />
          </label>
          <label>
            Location:
            <input
              type="text"
              name="location"
              value={jobData.location}
              onChange={handleChange}
              required
            />
          </label>
          <label>
            Salary:
            <input
              type="text"
              name="salary"
              value={jobData.salary}
              onChange={handleChange}
              placeholder="e.g., $50,000 per year"
            />
          </label>
          <button type="submit" className="submit-btn">
            Post Job
          </button>
        </form>
      </div>
    </Container>
  );
};

export default PostJobOffer;