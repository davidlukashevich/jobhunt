import Container from "../../components/Container/Container";
import React, { useState } from "react";
import "./index.css";
import { useNavigate, useParams } from "react-router-dom";

const Education: React.FC = () => {
  const [formData, setFormData] = useState({
    universityname: "",
    level: "",
    fieldofstudy: "",
    specialization: "",
    studyfrom: "",
    studyto: "",
  });

  let { educationId } = useParams();

  const navigate = useNavigate();

  const handleChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  ) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    alert("Education was created successfully!");
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
              name="universityname"
              value={formData.universityname}
              onChange={handleChange}
              required
            />
          </label>
          <label className="label_level">
            Level of education
            <input
              type="test"
              name="level"
              className="input"
              value={formData.level}
              onChange={handleChange}
              required
            />
          </label>
          <label className="label_field">
            Field of study
            <input
              type="test"
              name="fieldofstudy"
              className="input"
              value={formData.fieldofstudy}
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
            <input
              type="date"
              name="studyfrom"
              className="input"
              value={formData.studyfrom}
              onChange={handleChange}
              required
            />
          </label>

          <label className="label_studyto">
            Study To
            <input
              type="date"
              name="studyto"
              className="input"
              value={formData.studyto}
              onChange={handleChange}
              required
            />
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
