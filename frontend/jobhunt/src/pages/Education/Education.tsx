import Container from "../../components/Container/Container";
import React, { useContext, useState } from "react";
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
      year: undefined,
      day: undefined,
      month: undefined,
    },
    studyTo: {
      year: undefined,
      day: undefined,
      month: undefined
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

  const { profileId } = context;

  let { educationId } = useParams();

  const navigate = useNavigate();

  const handleChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement | HTMLSelectElement>
  ) => {
    const { name, value } = e.target;
    console.log(name);
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

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    if (!educationId) {
      educationApi.createEducation(formData, profileId);
    } else {
      educationApi.updateEducation(formData, educationId);
    }
    navigate("/myprofile");
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
          <button type="submit" className="submit-btn">
            {educationId ? "Update Education" : "Add Education"}
          </button>
        </form>
      </div>
    </Container>
  );
};

export default Education;
