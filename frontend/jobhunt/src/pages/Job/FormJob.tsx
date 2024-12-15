import Container from "../../components/Container/Container";
import React, { useContext, useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import UserDataContext from "../../components/UserDataMode/UserDataMode";
import '../Job/index.css';
import jobApi from "../../api/jobApi";

const FormJob: React.FC = () => {
    const [formData, setFormData] = useState({
        title: "",
        companyName: "",
        operationMode: "",
        contractType: "",
        jobLevel: "",
        responsibilities: "",
        requirements: "",
        country: "",
        city: "",
        street: "",
        file: null as File | null,
        type: "",
        technology: "",
        createdBy: "" as string | null,
        aboutCompany: "",
        salary: ""
    });

    const context = useContext(UserDataContext);

    if (!context) {
        throw new Error('Component must be used within a Provider');
    }

    const { userId } = context;

    let { jobId } = useParams();

    const navigate = useNavigate();

    useEffect(() => {
        setFormData({...formData, createdBy: userId});
    }, []);

    const handleChange = (
        e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement | HTMLSelectElement>
    ) => {
        const { name, value } = e.target;
        setFormData({ ...formData, [name]: value });
    };

    const handleFileChange = (e: React.ChangeEvent<HTMLInputElement>) => {
        if (e.target.files) {
            setFormData({ ...formData, file: e.target.files[0] });
        }
    };

    const handleSubmit = (e: React.FormEvent) => {
        e.preventDefault();
        if (!jobId) {
            jobApi.createJob(formData).then(data => {
                navigate("/myprofile");
            });
        }
    };
    return (
        <Container>
            <div className="job-form-wrapper">
                <form className="job-form" onSubmit={handleSubmit}>
                    <label className="label_logo">
                        Logo
                        <input
                            type="file"
                            className="input"
                            name="logo"
                            onChange={handleFileChange}
                            required
                        />
                    </label>
                    <label className="label_title">
                        Title
                        <input
                            type="text"
                            className="input"
                            name="title"
                            value={formData.title}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label className="label_companyname">
                        Company Name
                        <input
                            type="text"
                            className="input"
                            name="companyName"
                            value={formData.companyName}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label className="label_level">
                        Job Level
                        <input
                            type="text"
                            name="jobLevel"
                            className="input"
                            value={formData.jobLevel}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label className="label_operation">
                        Operation Mode
                        <input
                            type="text"
                            name="operationMode"
                            className="input"
                            value={formData.operationMode}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label className="label_contract">
                        Contract Type
                        <input
                            type="text"
                            name="contractType"
                            className="input"
                            value={formData.contractType}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label className="label_country">
                        Country
                        <input
                            type="text"
                            name="country"
                            className="input"
                            value={formData.country}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label className="label_city">
                        City
                        <input
                            type="text"
                            name="city"
                            className="input"
                            value={formData.city}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label className="label_street">
                        Street
                        <input
                            type="text"
                            name="street"
                            className="input"
                            value={formData.street}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label className="label_type">
                        Type
                        <input
                            type="text"
                            name="type"
                            className="input"
                            value={formData.type}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label className="label_technology">
                        Technology
                        <input
                            type="text"
                            name="technology"
                            className="input"
                            value={formData.technology}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label className="label_salary">
                        Salary
                        <input
                            type="text"
                            name="salary"
                            className="input"
                            value={formData.salary}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label className="label_about">
                        About Company
                        <textarea
                            name="aboutCompany"
                            className="textarea"
                            value={formData.aboutCompany}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label className="label_responsibilities">
                        Responsibilities
                        <textarea
                            name="responsibilities"
                            className="textarea"
                            value={formData.responsibilities}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label className="label_requirements">
                        Requirements
                        <textarea
                            name="requirements"
                            className="textarea"
                            value={formData.requirements}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <button type="submit" className="submit-btn">
                        {jobId ? "Update Job" : "Add Job"}
                    </button>
                </form>
            </div>
        </Container>
    );
};

export default FormJob;