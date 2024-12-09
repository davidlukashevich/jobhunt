import { useEffect, useState } from "react";
import { useParams } from "react-router";
import jobApplicationApi from "../../api/jobApplicationApi";
import { AiOutlineMail } from "react-icons/ai";
import { CiPhone } from "react-icons/ci";
import { MdOutlineDateRange } from "react-icons/md";
import jsPDF from "jspdf";

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

    useEffect(() => {
        jobApplicationApi.getJobApplicationById(applicationId).then(data => {
            setCandidateInfo(data);
        });
    }, []);

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
        </div>
    )
}

export default CandidatesInfo;