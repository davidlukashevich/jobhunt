import React, { useContext, useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import Container from "../Container/Container";
import UserDataContext from "../UserDataMode/UserDataMode";
import './index.css'
import profileApi from "../../api/profileApi";

const CreateProfile: React.FC = () => {
    const [formData, setFormData] = useState({
        name: "",
        lastName: "",
        email: "",
        phone: "",
        dateOfBirthYear: undefined as undefined | number,
        dateOfBirthMonth: undefined as undefined | number,
        dateOfBirthDay: undefined as undefined | number,
        country: "",
        city: "",
        street: "",
        profileSummary: "",
        specialization: "",
        file: null as File | null
    });

    const days = Array.from({ length: 31 }, (_, i) => i + 1);
    const months = Array.from({ length: 12 }, (_, i) => i + 1);
    const yearsfrom = Array.from({ length: 120 }, (_, i) => 2024 - i);
    const context = useContext(UserDataContext);

    if (!context) {
        throw new Error('Component must be used within a Provider');
    }

    const { userId, profile } = context;

    const { profileId } = useParams();

    const navigate = useNavigate();

    useEffect(() => {
        if (profileId) {
            const dateOfBirth = profile.dateOfBirth.split('/');
            console.log(dateOfBirth)
            console.log(Number(dateOfBirth[2]))
            setFormData({
                ...formData, name: profile.name, lastName: profile.lastName, email: profile.email, phone: profile.phone,
                country: profile.country, city: profile.city, street: profile.street, profileSummary: profile.profileSummary,
                specialization: profile.specialization, dateOfBirthDay: Number(dateOfBirth[0]), dateOfBirthMonth: Number(dateOfBirth[1]), dateOfBirthYear: Number(dateOfBirth[2])
            });
        }
    }, []);

    const handleChange = (
        e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement | HTMLSelectElement>
    ) => {
        const { name, value } = e.target;
        if (name === 'dateOfBirthDay' || name === 'dateOfBirthMonth' || name === 'dateOfBirthYear') {
            setFormData({ ...formData, [name]: Number(value) });
        } else {
            setFormData({ ...formData, [name]: value });
        }
    };

    const handleFileChange = (e: React.ChangeEvent<HTMLInputElement>) => {
        if (e.target.files) {
            setFormData({ ...formData, file: e.target.files[0] });
        }
    };

    const handleSubmit = (e: React.FormEvent) => {
        e.preventDefault();

        if (!profileId) {
            profileApi.createProfile(formData, userId).then(data => {
                navigate('/myprofile');
            });
        } else {
            profileApi.updateProfile(profileId, formData, userId, profile.addressId, profile.imageId).then(data => {
                if (data.statusCode === 200) {
                    navigate('/myprofile');
                }
            });
        }
    };
    return (
        <Container>
            <div className="profile-form-wrapper">
                <form className="profile-form" onSubmit={handleSubmit}>
                    <label className="label_avatar">
                        Avatar
                        <input
                            type="file"
                            className="input"
                            name="file"
                            onChange={handleFileChange}
                            required={!profileId ? true : false}
                        />
                    </label>
                    <label className="label_name">
                        Name
                        <input
                            type="text"
                            className="input"
                            name="name"
                            value={formData.name}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label className="label_lastName">
                        Last Name
                        <input
                            type="text"
                            className="input"
                            name="lastName"
                            value={formData.lastName}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label className="label_email">
                        Email
                        <input
                            type="email"
                            name="email"
                            className="input"
                            value={formData.email}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label className="label_phone">
                        Phone
                        <input
                            type="phone"
                            name="phone"
                            className="input"
                            value={formData.phone}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label className="label_date">
                        Date of Birth
                        <select
                            name="dateOfBirthDay"
                            className="select"
                            value={formData.dateOfBirthDay}
                            onChange={handleChange}
                            required
                        >
                            <option value="">Day</option>
                            {days.map((d) => (
                                <option key={d} value={d}>
                                    {d}
                                </option>
                            ))}
                        </select>
                        <select
                            name="dateOfBirthMonth"
                            className="select"
                            value={formData.dateOfBirthMonth}
                            onChange={handleChange}
                            required
                        >
                            <option value="">Month</option>
                            {months.map((m) => (
                                <option key={m} value={m}>
                                    {m}
                                </option>
                            ))}
                        </select>
                        <select
                            name="dateOfBirthYear"
                            className="select"
                            value={formData.dateOfBirthYear}
                            onChange={handleChange}
                            required
                        >
                            <option value="">Year</option>
                            {yearsfrom.map((y) => (
                                <option key={y} value={y}>
                                    {y}
                                </option>
                            ))}
                        </select>
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
                    <label className="label_specialization">
                        Specialization
                        <input
                            type="text"
                            name="specialization"
                            className="input"
                            value={formData.specialization}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <label className="label_profileSummary">
                        Profile Summary
                        <textarea
                            name="profileSummary"
                            className="textarea"
                            value={formData.profileSummary}
                            onChange={handleChange}
                            required
                        />
                    </label>
                    <button type="submit" className="submit-btn">{!profileId ? 'Create Profile' : 'Update Profile'}</button>
                </form>
            </div>
        </Container>
    );
};

export default CreateProfile;
