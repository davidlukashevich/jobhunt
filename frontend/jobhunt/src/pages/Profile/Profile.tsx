import React, { useContext, useEffect, useState } from "react";
import { AiOutlineMail } from "react-icons/ai";
import { CiBookmarkRemove, CiLocationOn, CiPhone } from "react-icons/ci";
import { FaRegBuilding } from "react-icons/fa";
import { GrCompliance } from "react-icons/gr";
import { MdOutlineDateRange, MdPendingActions } from "react-icons/md";
import { Link, Navigate, useNavigate } from "react-router-dom";
import Container from "../../components/Container/Container";

import { SiLevelsdotfyi } from "react-icons/si";

import Accordion from "@mui/material/Accordion";
import AccordionDetails from "@mui/material/AccordionDetails";
import AccordionSummary from "@mui/material/AccordionSummary";
import moment from "moment";
import jobApi from "../../api/jobApi";
import jobApplicationApi from "../../api/jobApplicationApi";
import profileApi from "../../api/profileApi";
import userApi from "../../api/userApi";
import { Loader } from "../../components/Loader/Loader";
import UserDataContext from "../../components/UserDataMode/UserDataMode";
import "./index.css";
import { error } from "console";

interface JobApplication {
  id: string;
  jobTitle: string;
  jobCompanyName: string;
  jobCompanyLogo: string;
  jobAddressCountry: string;
  jobAddressCity: string;
  createdAt: string;
  status: string;
  jobId: string
}

interface JobApplicationEmployer {
  id: string;
  title: string;
  companyName: string;
  companyLogo: string;
  city: string;
  createdAt: string;
  operationMode: string,
  salary: string
}

interface JobOffer {
  title: string;
  description: string;
  postedDate: string;
  applicationsCount: number;
}

const Profile: React.FC = () => {
  const [isEditing, setIsEditing] = useState(false);
  const navigate = useNavigate();
  const [isOpen, setIsOpen] = useState(false);
  const [educationUpdate, setEducationUpdate] = useState(false);
  const context = useContext(UserDataContext);

  if (!context) {
    throw new Error('Component must be used within a Provider');
  }

  const { role, userId, changeName, changeImageUrl, changeProfileId, deleteData } = context;

  const [isLoading, setIsLoading] = useState(false);

  const [employeeData, setEmployeeData] = useState({
    id: "",
    name: "",
    lastname: "",
    email: "",
    specialization: "",
    profileSummary: "",
    phone: "",
    dateOfBirth: "",
    universities: [
      {
        id: "",
        universityName: "",
        educationLevel: "",
        fieldOfStudy: "",
        specialization: "",
        studyFrom: "",
        studyTo: "",
      },
    ],
    experiences: [
      {
        id: "",
        position: "",
        companyName: "",
        responsibility: "",
        workFrom: "",
        location: "",
        workTo: "",
      }
    ],
    address: {
      id: "",
      country: "",
      city: "",
      street: "",
    },
    image: {
      id: "",
      imageUrl: "",
    },
  });

  const [employerData, setEmployerData] = useState({
    companyName: "ABC Corp",
    companyAddress: "123 Business Road",
    email: "contact@abccorp.com",
  });

  const [jobApplications, setJobApplications] = useState<JobApplication[]>([
    {
      id: "",
      jobTitle: "",
      jobCompanyName: "",
      jobCompanyLogo: "",
      jobAddressCountry: "",
      jobAddressCity: "",
      createdAt: "",
      status: "",
      jobId: ''
    }
  ]);

  const [jobApplicationsEmployer, setJobApplicationsEmployer] = useState<JobApplicationEmployer[]>([
    {
      id: "",
      title: "",
      companyName: "",
      companyLogo: "",
      city: "",
      createdAt: "",
      operationMode: "",
      salary: ""
    }
  ]);

  const [jobOffers, setJobOffers] = useState<JobOffer[]>([
    {
      title: "Frontend Developer",
      description: "Looking for a frontend developer with React experience.",
      postedDate: "2024-11-01",
      applicationsCount: 5,
    },
    {
      title: "UI/UX Designer",
      description: "Seeking a creative UI/UX designer for mobile apps.",
      postedDate: "2024-11-05",
      applicationsCount: 8,
    },
  ]);

  const handleInputChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>,
    target: "employee" | "employer"
  ) => {
    const { name, value } = e.target;

    if (target === "employee") {
      setEmployeeData({ ...employeeData, [name]: value });
    } else {
      setEmployerData({ ...employerData, [name]: value });
    }
  };

  // const handleFileChange = (e: React.ChangeEvent<HTMLInputElement>) => {
  //   if (e.target.files) {
  //     setEmployeeData({ ...employeeData, resume: e.target.files[0] });
  //   }
  // };

  const handleUpdate = (e: React.FormEvent) => {
    e.preventDefault();
    setIsEditing(false);
    alert(`${role} profile updated successfully!`);
  };

  const handleViewClick = (jobId: string) => {
    navigate(`/job/${jobId}`);
  }

  const handleLogout = () => {
    userApi.userLogout();
    deleteData();
    navigate('/');
  }

  useEffect(() => {
    if (userId) {
      profileApi.getProfile(userId).then(data => {
        setEmployeeData(data);
        changeName(data.name);
        changeImageUrl(data.image.imageUrl);
        changeProfileId(data.id);
      }).catch(error => {
        navigate('/myprofile/create');
      });
    }
  }, [isLoading]);

  useEffect(() => {
    if (role === 'Employee' && userId) {
      jobApplicationApi.getAllJobApplicationsByUserId(userId).then(data => {
        const formattedDate = moment(data.createdAt).format('YYYY-MM-DD');
        setJobApplications(data);
      });
    } else if (role === 'Employer' && userId) {
      jobApi.getAllJobByUserId(userId).then(data => {
        setJobApplicationsEmployer(data);
      })
    }
  }, []);

  if (!userId) {
    return <Navigate to={'/auth'} />
  }

  if (!employeeData.name) {
    return <Loader />
  }

  return (
    <Container>
      <div className="profile-page">
        {/* <h2 className="profile-title">{role} Profile</h2>  */}

        {/* Profile Details Form */}
        {/* <form className="profile-details" onSubmit={handleUpdate}>
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
        </form> */}

        {/* My Applications Section for Employees */}
        {/* {role === 'Employee' && (
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
        )} */}

        {/* My Job Offers Section for Employers */}
        {/* {role === 'Employer' && (
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
        )} */}

        {/* <div className="profile-menu">
          <button className="menu-button" onClick={() => setIsEditing(!isEditing)}>
            {isEditing ? 'Cancel' : 'Edit Profile'}
          </button>
          {
            role === 'Employer' && (
              <button
                className="post-job-btn"
                onClick={() => navigate('/post-job-offer')}
              >
                Post Job Offer
              </button>
            )
          }
        </div> */}
        <div className="user_info">
          <img
            className="user_avatar"
            src={employeeData.image.imageUrl}
            alt=""
          />
          <div className="user_data">
            <p className="user_fullname">
              {employeeData.name} <br />
              {employeeData.lastname}
            </p>
            <p className="user_profession">{employeeData.specialization}</p>
            <p className="user_address">
              <CiLocationOn className="icon" />
              {employeeData.address.country}, {employeeData.address.city}
            </p>
            <p className="user_email">
              <AiOutlineMail className="icon" />
              {employeeData.email}
            </p>
            <p className="user_mobile">
              <CiPhone className="icon" />
              {employeeData.phone}
            </p>
            <p className="user_dateofbirth">
              <MdOutlineDateRange className="icon" />
              {employeeData.dateOfBirth}
            </p>
          </div>
          <button className="user_button">Download Resume</button>
        </div>

        <div className="user_additional-data">
          <h3 className="summary_title">Professional Summary</h3>
          <p className="summary_info">{employeeData.profileSummary}</p>
          {role === 'Employee' &&
            <div className="experience_wrapper">
              <div>
                <Accordion>
                  <AccordionSummary
                    aria-controls="panel1-content"
                    id="panel1-header"
                  >
                    Work Experience
                  </AccordionSummary>
                  <AccordionDetails>
                    <ul className="experience_list">
                      {employeeData.experiences.map((e) => (
                        <>
                          <li className="experience_list-item">
                            <p className="experience_position">{e.position}</p>
                            <div className="experience_company_info">
                              <div className="experience_company_info-bloc1">
                                <p className="experience_companyname">
                                  <FaRegBuilding className="experience_icon" />
                                  {e.companyName}
                                </p>
                                <p className="experience_location">
                                  <CiLocationOn className="experience_icon" />
                                  {e.location}
                                </p>
                              </div>
                              <div className="">
                                <p className="experience_date">
                                  <MdOutlineDateRange className="experience_icon" />
                                  {e.workFrom} / {e.workTo}
                                </p>
                              </div>
                            </div>
                            <p className="responsibility">Responsibility:</p>
                            <p className="experience_responsibility">
                              {e.responsibility}
                            </p>
                            <div className="experience_buttons-wrapper">
                              <Link
                                className="experience_update-button"
                                to={`/myprofile/experience/update/${e.id}`}
                              >
                                Update
                              </Link>
                            </div>
                          </li>
                        </>
                      ))}
                    </ul>
                    <Link
                      to="/myprofile/experience/create"
                      className="experience_button"
                      onClick={() => setIsLoading(!isLoading)}
                    >
                      Add Experience
                    </Link>
                  </AccordionDetails>
                </Accordion>
              </div>
              <div className="education_wrapper">
                <Accordion>
                  <AccordionSummary
                    aria-controls="panel1-content"
                    id="panel1-header"
                  >
                    Education
                  </AccordionSummary>
                  <AccordionDetails>
                    <ul className="education_list">
                      {employeeData.universities.length == 0 ? (
                        <p>no</p>
                      ) : (
                        employeeData.universities.map((u) => (
                          <>
                            <li className="education_list-item">
                              <p className="education_universityname">
                                {u.universityName}
                              </p>
                              <p className="education_level">
                                <SiLevelsdotfyi className="education_icon" />
                                {u.educationLevel}
                              </p>
                              <div className="education_info">
                                <div className="education_info_block1">
                                  <p className="education_fieldofstudy">
                                    {u.fieldOfStudy}
                                  </p>
                                  <p className="education_specialization">
                                    {u.specialization}
                                  </p>
                                </div>
                                <div className="education_info_block2">
                                  <p className="education_date">
                                    <MdOutlineDateRange className="education_icon" />
                                    {u.studyFrom} / {u.studyTo}
                                  </p>
                                </div>
                              </div>
                              <div className="education_buttons-wrapper">
                                <Link
                                  className="education_update-button"
                                  to={`/myprofile/education/update/${u.id}`}
                                >
                                  Update
                                </Link>
                              </div>
                            </li>
                          </>
                        ))
                      )}
                    </ul>
                    <Link
                      to="/myprofile/education/create"
                      className="education_button"
                    >
                      Add Education
                    </Link>
                  </AccordionDetails>
                </Accordion>
              </div>
              <div className="education_wrapper">
                <Accordion>
                  <AccordionSummary
                    aria-controls="panel1-content"
                    id="panel1-header"
                  >
                    All Aplications
                  </AccordionSummary>
                  <AccordionDetails>
                    <ul className="education_list">
                      {jobApplications.length == 0 ? (
                        <p>no</p>
                      ) : (
                        jobApplications.map((a) => (
                          <>
                            <li className="application_list-item" onClick={() => handleViewClick(a.jobId)}>
                              <p className="education_universityname">
                                {a.jobTitle}
                              </p>
                              <div className="experience_company_info">
                                <div className="experience_company_info-bloc1">
                                  <p className="experience_companyname">
                                    <img src={a.jobCompanyLogo} className="application_icon" />
                                    {a.jobCompanyName}
                                  </p>
                                  <p className="experience_location">
                                    <CiLocationOn className="experience_icon" />
                                    {a.jobAddressCountry}, {a.jobAddressCity}
                                  </p>
                                </div>
                              </div>
                              <div className="experience_company_info">
                                <p className="experience_date">
                                  {a.status === 'Pending' ? <MdPendingActions className="experience_icon" /> :
                                    a.status === 'Accepted' ? <GrCompliance className="experience_icon" /> : <CiBookmarkRemove className="experience_icon" />}
                                  {a.status}
                                </p>
                                <p className="education_date">
                                  <MdOutlineDateRange className="education_icon" />
                                  {a.createdAt}
                                </p>
                              </div>
                            </li>
                          </>
                        ))
                      )}
                    </ul>
                  </AccordionDetails>
                </Accordion>
              </div>
            </div>}
          {role === 'Employer' && <div className="experience_wrapper">
            <Accordion>
              <AccordionSummary
                aria-controls="panel1-content"
                id="panel1-header"
              >
                All Aplications
              </AccordionSummary>
              <AccordionDetails>
                <ul className="education_list">
                  {jobApplicationsEmployer.length == 0 ? (
                    <p>no</p>
                  ) : (
                    jobApplicationsEmployer.map((a) => (
                      <>
                        <li className="application_list-item" onClick={() => handleViewClick(a.id)}>
                          <p className="education_universityname">
                            {a.title}
                          </p>
                          <div className="experience_company_info">
                            <div className="experience_company_info-bloc1">
                              <p className="experience_companyname">
                                <img src={a.companyLogo} className="application_icon" />
                                {a.companyName}
                              </p>
                              <p className="experience_location">
                                <CiLocationOn className="experience_icon" />
                                {a.city}
                              </p>
                            </div>
                          </div>
                          <div className="experience_company_info">
                            <p className="experience_date">
                              {a.operationMode}
                            </p>
                            <p className="experience_date">
                              {a.salary}
                            </p>
                            <p className="education_date">
                              <MdOutlineDateRange className="education_icon" />
                              {a.createdAt}
                            </p>
                          </div>
                        </li>
                      </>
                    ))
                  )}
                </ul>
                <Link
                  to="/myprofile/job/create"
                  className="education_button"
                >
                  Add Job
                </Link>
              </AccordionDetails>
            </Accordion>
          </div>}
          <button className="logout-btn" onClick={handleLogout}><div className="logout-btn-link">Logout</div></button>
        </div>
      </div>
    </Container>
  );
};

export default Profile;
