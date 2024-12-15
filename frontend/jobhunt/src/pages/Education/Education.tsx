import Container from "../../components/Container/Container";
import React, { useContext, useEffect, useState } from "react";
import "./index.css";
import { useNavigate, useParams } from "react-router-dom";
import UserDataContext from "../../components/UserDataMode/UserDataMode";
import educationApi from "../../api/educationApi";

const Education: React.FC = () => {
  const [formData, setFormData] = useState({
    universityName: "",
    educationLevel: "",
    fieldOfStudy: "",
    specialization: "",
    studyFrom: {
      year: undefined as undefined | number,
      day: undefined as undefined | number,
      month: undefined as undefined | number,
    },
    studyTo: {
      year: undefined as undefined | number,
      day: undefined as undefined | number,
      month: undefined as undefined | number
    }
  });

  const days = Array.from({ length: 31 }, (_, i) => i + 1);
  const months = Array.from({ length: 12 }, (_, i) => i + 1);
  const yearsfrom = Array.from({ length: 120 }, (_, i) => 2024 - i);
  const yearsto = Array.from({ length: 131 }, (_, i) => 2035 - i);

  const context = useContext(UserDataContext);

  if (!context) {
    throw new Error('Component must be used within a Provider');
  }

  const { profileId, education } = context;

  useEffect(() => {
    if (educationId) {
      const studyFrom = education.studyFrom.split('/');
      const studyTo = education.studyTo.split('/');
      setFormData({
        ...formData, universityName: education.universityName, educationLevel: education.educationLevel,
        fieldOfStudy: education.fieldOfStudy, specialization: education.specialization, studyFrom: {
          ...formData.studyFrom,
          year: Number(studyFrom[2]), day: Number(studyFrom[0]), month: Number(studyFrom[1])
        }, studyTo: {
          ...formData.studyTo,
          year: Number(studyTo[2]), day: Number(studyTo[0]), month: Number(studyTo[1])
        }
      })
    }
  }, [])

  let { educationId } = useParams();

  const navigate = useNavigate();

  const handleChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement | HTMLSelectElement>
  ) => {
    const { name, value } = e.target;
    const [, date] = name.split('_');
    const valueNum = parseInt(value)
    if (name === "studyfrom_year" || name === "studyfrom_month" || name === "studyfrom_day") {
      setFormData({ ...formData, studyFrom: { ...formData.studyFrom, [date]: valueNum } });
    } else if (name === "studyto_year" || name === "studyto_month" || name === "studyto_day") {
      setFormData({ ...formData, studyTo: { ...formData.studyTo, [date]: valueNum } });
    } else {
      setFormData({ ...formData, [name]: value });
    }
  };

  const handleDeleteEducation = (e: React.FormEvent) => {
    educationApi.deleteEducation(educationId).then(data => {
      navigate("/myprofile");
    });
  }

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    if (!educationId) {
      educationApi.createEducation(formData, profileId).then(data => {
        navigate("/myprofile");
      });;
    } else {
      educationApi.updateEducation(formData, educationId).then(data => {
        navigate("/myprofile");
      });;
    }
  };
  return (
    <Container>
      <div className="education-form-wrapper">
        <form className="education-form" onSubmit={handleSubmit}>
          <label className="label_university">
            University
            <input
              type="text"
              className="input"
              name="universityName"
              value={formData.universityName}
              onChange={handleChange}
              required
            />
          </label>
          <label className="label_level">
            Level of education
            <input
              type="test"
              name="educationLevel"
              className="input"
              value={formData.educationLevel}
              onChange={handleChange}
              required
            />
          </label>
          <label className="label_field">
            Field of study
            <input
              type="test"
              name="fieldOfStudy"
              className="input"
              value={formData.fieldOfStudy}
              onChange={handleChange}
              required
            />
          </label>
          <label className="label_specialization">
            Specialization
            <input
              type="test"
              name="specialization"
              className="input"
              value={formData.specialization}
              onChange={handleChange}
              required
            />
          </label>

          <label className="label_studyfrom">
            Study From
            <select
              name="studyfrom_day"
              className="select"
              value={formData.studyFrom.day}
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
              name="studyfrom_month"
              className="select"
              value={formData.studyFrom.month}
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
              name="studyfrom_year"
              className="select"
              value={formData.studyFrom.year}
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

          <label className="label_studyto">
            Study To
            <select
              name="studyto_day"
              className="select"
              value={formData.studyTo.day}
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
              name="studyto_month"
              className="select"
              value={formData.studyTo.month}
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
              name="studyto_year"
              className="select"
              value={formData.studyTo.year}
              onChange={handleChange}
              required
            >
              <option value="">Year</option>
              {yearsto.map((y) => (
                <option key={y} value={y}>
                  {y}
                </option>
              ))}
            </select>
          </label>
          {!educationId && <button type="submit" className="submit-btn-education-add">
            Add Education
          </button>}
          {educationId && <><button type="submit" className="submit-btn-education">
            Update Education
          </button> <button onClick={handleDeleteEducation} className="education_delete-button">
              Delete
            </button></>}
        </form>
      </div>
    </Container>
  );
};

export default Education;
