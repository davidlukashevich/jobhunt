import React, { useState } from 'react';
import Container from '../../components/Container/Container';
import './index.css';

interface ProfileProps {
  role: 'Employee' | 'Employer';
}

interface JobApplication {
  jobTitle: string;
  companyName: string;
  appliedDate: string;
  status: 'Pending' | 'Accepted' | 'Rejected';
}

interface JobOffer {
  title: string;
  description: string;
  postedDate: string;
  applicationsCount: number;
}

const Profile: React.FC<ProfileProps> = ({ role }) => {
  const [isEditing, setIsEditing] = useState(false);

  const [employeeData, setEmployeeData] = useState({
    name: 'John Doe',
    email: 'johndoe@example.com',
    resume: null as File | null,
    coverLetter: 'This is a sample cover letter.',
  });

  const [employerData, setEmployerData] = useState({
    companyName: 'ABC Corp',
    companyAddress: '123 Business Road',
    email: 'contact@abccorp.com',
  });

  const [jobApplications, setJobApplications] = useState<JobApplication[]>([
    {
      jobTitle: 'Frontend Developer',
      companyName: 'Tech Solutions',
      appliedDate: '2024-11-10',
      status: 'Pending',
    },
    {
      jobTitle: 'Backend Engineer',
      companyName: 'Innovatech',
      appliedDate: '2024-11-12',
      status: 'Accepted',
    },
    {
      jobTitle: 'Full-Stack Developer',
      companyName: 'DevHub',
      appliedDate: '2024-11-15',
      status: 'Rejected',
    },
  ]);

  const [jobOffers, setJobOffers] = useState<JobOffer[]>([
    {
      title: 'Frontend Developer',
      description: 'Looking for a frontend developer with React experience.',
      postedDate: '2024-11-01',
      applicationsCount: 5,
    },
    {
      title: 'UI/UX Designer',
      description: 'Seeking a creative UI/UX designer for mobile apps.',
      postedDate: '2024-11-05',
      applicationsCount: 8,
    },
  ]);

  const handleInputChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>,
    target: 'employee' | 'employer'
  ) => {
    const { name, value } = e.target;

    if (target === 'employee') {
      setEmployeeData({ ...employeeData, [name]: value });
    } else {
      setEmployerData({ ...employerData, [name]: value });
    }
  };

  const handleFileChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    if (e.target.files) {
      setEmployeeData({ ...employeeData, resume: e.target.files[0] });
    }
  };

  const handleUpdate = (e: React.FormEvent) => {
    e.preventDefault();
    setIsEditing(false);
    alert(`${role} profile updated successfully!`);
  };

  return (
    <Container>
      <div className="profile-page">
        <h2 className="profile-title">{role} Profile</h2>

        {/* Profile Details Form */}
        <form className="profile-details" onSubmit={handleUpdate}>
          {role === 'Employee' ? (
            <>
              <label>
                Full Name:
                <input
                  type="text"
                  name="name"
                  value={employeeData.name}
                  onChange={(e) => handleInputChange(e, 'employee')}
                  required
                  disabled={!isEditing}
                />
              </label>
              <label>
                Email:
                <input
                  type="email"
                  name="email"
                  value={employeeData.email}
                  onChange={(e) => handleInputChange(e, 'employee')}
                  required
                  disabled={!isEditing}
                />
              </label>
              <label>
                Resume:
                <input
                  type="file"
                  name="resume"
                  onChange={handleFileChange}
                  disabled={!isEditing}
                />
                {employeeData.resume && (
                  <p>Uploaded: {employeeData.resume.name}</p>
                )}
              </label>
              <label>
                Cover Letter:
                <textarea
                  name="coverLetter"
                  value={employeeData.coverLetter}
                  onChange={(e) => handleInputChange(e, 'employee')}
                  required
                  disabled={!isEditing}
                />
              </label>
            </>
          ) : (
            <>
              <label>
                Company Name:
                <input
                  type="text"
                  name="companyName"
                  value={employerData.companyName}
                  onChange={(e) => handleInputChange(e, 'employer')}
                  required
                  disabled={!isEditing}
                />
              </label>
              <label>
                Company Address:
                <input
                  type="text"
                  name="companyAddress"
                  value={employerData.companyAddress}
                  onChange={(e) => handleInputChange(e, 'employer')}
                  required
                  disabled={!isEditing}
                />
              </label>
              <label>
                Email:
                <input
                  type="email"
                  name="email"
                  value={employerData.email}
                  onChange={(e) => handleInputChange(e, 'employer')}
                  required
                  disabled={!isEditing}
                />
              </label>
            </>
          )}

          {isEditing && (
            <button type="submit" className="save-button">
              Save Changes
            </button>
          )}
        </form>

        {/* My Applications Section for Employees */}
        {role === 'Employee' && (
          <div className="applications-section">
            <h3>My Applications</h3>
            <div className="applications-list">
              {jobApplications.length > 0 ? (
                jobApplications.map((application, index) => (
                  <div key={index} className="application-card">
                    <h4>{application.jobTitle}</h4>
                    <p>
                      <strong>Company:</strong> {application.companyName}
                    </p>
                    <p>
                      <strong>Applied Date:</strong> {application.appliedDate}
                    </p>
                    <p>
                      <strong>Status:</strong>{' '}
                      <span className={`status-${application.status.toLowerCase()}`}>
                        {application.status}
                      </span>
                    </p>
                  </div>
                ))
              ) : (
                <p>No applications found.</p>
              )}
            </div>
          </div>
        )}

        {/* My Job Offers Section for Employers */}
        {role === 'Employer' && (
          <div className="job-offers-section">
            <h3 className='job-offers-title'>My Job Offers</h3>
            <div className="job-offers-list">
              {jobOffers.length > 0 ? (
                jobOffers.map((offer, index) => (
                  <div key={index} className="job-offer-card">
                    <h4>{offer.title}</h4>
                    <p>
                      <strong>Description:</strong> {offer.description}
                    </p>
                    <p>
                      <strong>Posted Date:</strong> {offer.postedDate}
                    </p>
                    <p>
                      <strong>Applications:</strong> {offer.applicationsCount}
                    </p>
                    <div className="offer-actions">
                      <button className="edit-btn">Edit</button>
                      <button className="delete-btn">Delete</button>
                    </div>
                  </div>
                ))
              ) : (
                <p>No job offers found.</p>
              )}
            </div>
          </div>
        )}

        <div className="profile-menu">
          <button className="menu-button" onClick={() => setIsEditing(!isEditing)}>
            {isEditing ? 'Cancel' : 'Edit Profile'}
          </button>
        </div>
      </div>
    </Container>
  );
};

export default Profile;