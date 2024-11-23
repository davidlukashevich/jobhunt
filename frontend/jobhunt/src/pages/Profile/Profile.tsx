import React, { useState } from "react";
import Container from "../../components/Container/Container";
import { useNavigate } from "react-router-dom";
import { CiLocationOn } from "react-icons/ci";
import { MdOutlineDateRange } from "react-icons/md";
import { CiPhone } from "react-icons/ci";
import { AiOutlineMail } from "react-icons/ai";
import { FaRegBuilding } from "react-icons/fa";
import { FaUniversity } from "react-icons/fa";
import { SiLevelsdotfyi } from "react-icons/si";

import "./index.css";
import Accordion from "@mui/material/Accordion";
import AccordionActions from "@mui/material/AccordionActions";
import AccordionSummary from "@mui/material/AccordionSummary";
import AccordionDetails from "@mui/material/AccordionDetails";

interface ProfileProps {
  role: "Employee" | "Employer";
}

interface JobApplication {
  jobTitle: string;
  companyName: string;
  appliedDate: string;
  status: "Pending" | "Accepted" | "Rejected";
}

interface JobOffer {
  title: string;
  description: string;
  postedDate: string;
  applicationsCount: number;
}

const Profile: React.FC<ProfileProps> = ({ role }) => {
  const [isEditing, setIsEditing] = useState(false);
  const navigate = useNavigate();

  const [employeeData, setEmployeeData] = useState({
    id: "8a6967e8-66d3-47c0-a682-826fffb69fbe",
    name: "Max",
    lastname: "Kryvanos",
    email: "max@gmail.com",
    phone: "12345",
    dateOfBirth: "04/07/2016",
    universities: [
      {
        id: "b18cddbc-57d1-4712-8e92-7ced82872260",
        universityName: "MIT",
        educationLevel: "Bachelor",
        fieldOfStudy: "Computer Science",
        specialization: "Backend",
        studyFrom: "17/10/2022",
        studyTo: "20/06/2026",
      },
    ],
    experiences: [
      {
        id: "26e5b505-e3fc-45a4-a8e7-11425229bf32",
        position: "Junior Backend Developer",
        companyName: "Visa",
        responsibility: "api, test",
        workFrom: "10/10/2020",
        location: "Warsaw",
        workTo: "10/10/2025",
      },
      {
        id: "e25eae28-4611-4e90-9848-9a2caab9c4af",
        position: "Middle Backend Developer",
        companyName: "Microsoft",
        responsibility: "Create api, writing unit tests",
        workFrom: "10/10/2024",
        location: "USA",
        workTo: "10/10/2030",
      },
    ],
    address: {
      id: "47b9773e-9bc0-41bd-a623-135d6110fc08",
      country: "Belarus",
      city: "Minsk",
      street: "st. Janka Kupala 25",
    },
    image: {
      id: "c7661d02-4896-4293-9759-13cd05ef9338",
      imageUrl:
        "https://jobhuntstorage.blob.core.windows.net/images/profile_8a6967e8-66d3-47c0-a682-826fffb69fbe",
    },
  });

  const [employerData, setEmployerData] = useState({
    companyName: "ABC Corp",
    companyAddress: "123 Business Road",
    email: "contact@abccorp.com",
  });

  const [jobApplications, setJobApplications] = useState<JobApplication[]>([
    {
      jobTitle: "Frontend Developer",
      companyName: "Tech Solutions",
      appliedDate: "2024-11-10",
      status: "Pending",
    },
    {
      jobTitle: "Backend Engineer",
      companyName: "Innovatech",
      appliedDate: "2024-11-12",
      status: "Accepted",
    },
    {
      jobTitle: "Full-Stack Developer",
      companyName: "DevHub",
      appliedDate: "2024-11-15",
      status: "Rejected",
    },
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
            <p className="user_profession">Backend Developer</p>
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
          <p className="summary_info">
            Lorem ipsum dolor sit amet consectetur, adipisicing elit. A
            perspiciatis obcaecati maiores, odit quia sint labore provident
            officiis, assumenda neque sequi nesciunt! Ratione hic animi fuga
            veritatis magni minima modi beatae est ipsum nesciunt eligendi
            doloribus atque sequi mollitia nisi quasi dolorem officia nam
            laboriosam error id tempore quis, porro temporibus. Sapiente, earum
            voluptatum! Nostrum architecto error tenetur, temporibus iste nihil
            rem in adipisci numquam harum ea mollitia enim quia delectus maiores
            facilis perspiciatis. Nihil aliquam officiis tempora atque similique
            fugit omnis nulla eos, voluptates, eveniet at autem voluptate quas a
            quae ab consequuntur id assumenda veritatis optio esse doloremque!
          </p>
          <div className="experience_wrapper">
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

                        <p className="experience_responsibility">
                          {e.responsibility}
                        </p>
                      </li>
                    </>
                  ))}
                </ul>
                <button className="experience_button">Add Experience</button>
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
                        </li>
                      </>
                    ))
                  )}
                </ul>
                <button className="education_button">Add Education</button>
              </AccordionDetails>
            </Accordion>
          </div>
        </div>
      </div>
    </Container>
  );
};

export default Profile;
