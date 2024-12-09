import { useEffect, useState } from "react";
import Card from "../../components/Card/Card";
import Container from "../../components/Container/Container"
import { useParams } from "react-router";
import jobApplicationApi from "../../api/jobApplicationApi";
import CardCandidate from "../../components/Card/CardCandidate";

type InfoType = {
    id: string
    name: string
    lastname: string
    email: string
    phone: string
    createdAt: string
}

const Candidates = () => {
    const [info, setInfo] = useState<InfoType[]>([]);
    const { jobId } = useParams();

    useEffect(() => {
        jobApplicationApi.getAllJobApplicationsByJobId(jobId).then(data => {
            setInfo(data);
        });
    }, []);

    return (
        <Container>
            <div className='card-container'>
                {info.length > 0 ? (
                    info.map((i) => (
                        <CardCandidate key={i.id} id={i.id} name={i.name} lastname={i.lastname} email={i.email} phone={i.phone} createdAt={i.createdAt} />  
                    ))
                ) : (
                    <p>No candidates found</p>
                )}
            </div>
        </Container>
    )
}

export default Candidates;