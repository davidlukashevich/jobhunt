import React, { useContext, useEffect, useState } from "react";
import { AiOutlineMail } from "react-icons/ai";
import { CiBookmarkRemove, CiLocationOn, CiPhone } from "react-icons/ci";
import { FaHome, FaMoneyBillWave, FaRegBuilding } from "react-icons/fa";
import { GrCompliance } from "react-icons/gr";
import { MdOutlineDateRange, MdPendingActions } from "react-icons/md";
import { Link, Navigate, useLocation, useNavigate } from "react-router-dom";
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

const Profile: React.FC = () => {
  const navigate = useNavigate();
  const location = useLocation();
  const context = useContext(UserDataContext);

  if (!context) {
    throw new Error('Component must be used within a Provider');
  }

  const { role, userId, changeName, changeImageUrl, changeProfileId, deleteData, changeEducationData, changeExperienceData, changeProfile } = context;

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

  const [password, setPassword] = useState({
    currentPassword: "",
    newPassword: ""
  });

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

  const handleInputChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  ) => {
    const { name, value } = e.target;
    if (name === 'currentPassword' || name === 'newPassword') {
      setPassword({ ...password, [name]: value });
    } else {
      setEmployeeData({ ...employeeData, [name]: value });
    }
  };

  const handleViewClick = (jobId: string) => {
    navigate(`/job/${jobId}`);
  }

  const handleLogout = () => {
    userApi.userLogout().then(data => {
      deleteData();
      navigate('/');
    });
  }

  const handleChangePassword = (e: React.FormEvent) => {
    if (password.currentPassword && password.newPassword) {
      e.preventDefault();
    }
    userApi.changePassword(employeeData.email, password.currentPassword, password.newPassword);
    setPassword({ ...password, currentPassword: '', newPassword: '' });
  }



  useEffect(() => {
    if (userId) {
      profileApi.getProfile(userId).then(data => {
        setEmployeeData(data);
        changeName(data.name);
        changeImageUrl(`${data.image.imageUrl}?${new Date().getTime()}`);
        changeProfileId(data.id);
      }).catch(error => {
        navigate('/myprofile/create');
      });
    }
  }, [location]);


  useEffect(() => {
    if (role === 'Employee' && userId) {
      jobApplicationApi.getAllJobApplicationsByUserId(userId).then(data => {
        setJobApplications(data);
        setJobApplications((prevJobApplications) =>
          prevJobApplications.map((jobApplication) => ({
            ...jobApplication,
            createdAt: moment(jobApplication.createdAt).format('YYYY-MM-DD')
          }))
        );
      });
    } else if (role === 'Employer' && userId) {
      jobApi.getAllJobByUserId(userId).then(data => {
        setJobApplicationsEmployer(data);
        setJobApplicationsEmployer((prevJobApplicationsEmployer) =>
          prevJobApplicationsEmployer.map((jobApplication) => ({
            ...jobApplication,
            createdAt: moment(jobApplication.createdAt).format('YYYY-MM-DD')
          }))
        );
      })
    }
  }, [location]);

  if (!userId) {
    return <Navigate to={'/auth'} />
  }

  if (!employeeData.name) {
    return <Loader />
  }

  return (
    <Container>
      <div className="profile-page">
        <div className="user_info">
          <img
            className="user_avatar"
            src={`${employeeData.image.imageUrl}?${new Date().getTime()}`}
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
              {employeeData.address.country}, {employeeData.address.city}, {employeeData.address.street}
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
          <Link onClick={() => changeProfile({
            name: employeeData.name, lastName: employeeData.lastname, email: employeeData.email,
            phone: employeeData.phone, dateOfBirth: employeeData.dateOfBirth, country: employeeData.address.country, city: employeeData.address.city,
            street: employeeData.address.street, profileSummary: employeeData.profileSummary, specialization: employeeData.specialization,
            file: employeeData.image.imageUrl, addressId: employeeData.address.id, imageId: employeeData.image.id
          })} to={`/myprofile/update/${employeeData.id}`}><button className="edit-btn"><div className="edit-btn-link">Edit Profile</div></button></Link>
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
                        <div key={e.id}>
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
                                onClick={() => changeExperienceData(e)}
                              >
                                Update
                              </Link>
                            </div>
                          </li>
                        </div>
                      ))}
                    </ul>
                    <Link
                      to="/myprofile/experience/create"
                      className="experience_button"
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
                          <div key={u.id}>
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
                                  onClick={() => changeEducationData(u)}
                                >
                                  Update
                                </Link>
                              </div>
                            </li>
                          </div>
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
                          <div key={a.id}>
                            <li className="application_list-item" onClick={() => handleViewClick(a.jobId)}>
                              <img src={a.jobCompanyLogo} className="job-logo" />
                              <p className="education_universityname">
                                {a.jobTitle}
                              </p>
                              <div className="experience_company_info">
                                <div className="experience_company_info-bloc1">
                                  <p className="experience_companyname">
                                    <FaRegBuilding className="application_icon" />
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
                          </div>
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
                          <img src={a.companyLogo} className="job-logo" />
                          <p className="education_universityname">
                            {a.title}
                          </p>
                          <div className="experience_company_info">
                            <div className="experience_company_info-bloc1">
                              <p className="experience_companyname">
                                <FaRegBuilding className="application_icon" />
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
                              <FaHome className='info_icon' />
                              {a.operationMode}
                            </p>
                            <p className="experience_date">
                              <FaMoneyBillWave className="info_icon" />
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