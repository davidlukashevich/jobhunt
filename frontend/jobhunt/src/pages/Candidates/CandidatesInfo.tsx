import moment from "moment";
import { useContext, useEffect, useState } from "react";
import { AiOutlineMail } from "react-icons/ai";
import { CiPhone } from "react-icons/ci";
import { MdOutlineDateRange } from "react-icons/md";
import { useNavigate, useParams } from "react-router";
import jobApplicationApi from "../../api/jobApplicationApi";
import UserDataContext from "../../components/UserDataMode/UserDataMode";
import './index.css';

type CandidateInfoType = {
    aboutInformation: string
    createdAt: string
    cv: string
    email: string
    id: string
    lastname: string
    name: string
    phone: string
}

const CandidatesInfo = () => {
    const [candidateInfo, setCandidateInfo] = useState<CandidateInfoType>({
        aboutInformation: "",
        createdAt: "",
        cv: "",
        email: "",
        id: "",
        lastname: "",
        name: "",
        phone: ""
    });
    const { applicationId } = useParams();
    const context = useContext(UserDataContext);

    if (!context) {
        throw new Error('Component must be used within a Provider');
    }

    const { jobId } = context;

    const navigate = useNavigate();

    useEffect(() => {
        jobApplicationApi.getJobApplicationById(applicationId).then(data => {
            const formattedDate = moment(data.createdAt).format('YYYY-MM-DD');
            setCandidateInfo({
                ...candidateInfo, aboutInformation: data.aboutInformation, createdAt: formattedDate, cv: data.cv,
                email: data.email, id: data.id, lastname: data.lastname, name: data.name, phone: data.phone
            });
        });
    }, []);

    const handleSubmit = (e: any) => {
        const { name } = e.target;

        jobApplicationApi.changeStatus(applicationId, name).then(data => {
            navigate(`/apply/candidates/${jobId}`);
        });
    }

    return (
        <div className="user_info">
            <div className="user_data">
                <p className="user_fullname">
                    {candidateInfo.name} {candidateInfo.lastname}
                </p>
                <p className="about_info">{candidateInfo.aboutInformation}</p>
                <p className="user_email">
                    <AiOutlineMail className="icon" />
                    {candidateInfo.email}
                </p>
                <p className="user_mobile">
                    <CiPhone className="icon" />
                    {candidateInfo.phone}
                </p>
                <p className="user_dateofbirth">
                    <MdOutlineDateRange className="icon" />
                    {candidateInfo.createdAt}
                </p>
            </div>
            <a href={candidateInfo.cv} download className="user_button">Download Resume</a>
            <div className="candidate-btn">
                <button onClick={handleSubmit} name="Accepted" className="btn-accept">Accepted</button>
                <button onClick={handleSubmit} name="Rejected" className="btn-reject">Rejected</button>
            </div>
        </div>
    )
}

export default CandidatesInfo;