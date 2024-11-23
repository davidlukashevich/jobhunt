import React, { useState } from "react";
import Container from "../../components/Container/Container";
import "./index.css";
import { useNavigate } from "react-router-dom";

const Experience: React.FC = () => {
  const [formData, setFormData] = useState({
    position: "",
    companyname: "",
    location: "",
    responsibility: "",
    workfrom: "",
    workto: "",
  });

  const navigate = useNavigate();

  const handleChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>
  ) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    alert("Experience was created successfully!");

    navigate("/myprofile");
  };
  return (
    <Container>
      <div className="experience-form-wrapper">
        <form className="experience-form" onSubmit={handleSubmit}>
          <label className="label_position">
            Position
            <input
              type="text"
              className="input"
              name="position"
              value={formData.position}
              onChange={handleChange}
              required
            />
          </label>
          <label className="label_company">
            Company name
            <input
              type="test"
              name="companyname"
              className="input"
              value={formData.companyname}
              onChange={handleChange}
              required
            />
          </label>
          <label className="label_location">
            Location
            <input
              type="test"
              name="location"
              className="input"
              value={formData.location}
              onChange={handleChange}
              required
            />
          </label>
          <label className="label_workfrom">
            Work from
            <input
              type="date"
              name="workfrom"
              className="input"
              value={formData.workfrom}
              onChange={handleChange}
              required
            />
          </label>
          <label className="label_workto">
            Work to
            <input
              type="date"
              name="workto"
              className="input"
              value={formData.workto}
              onChange={handleChange}
              required
            />
          </label>

          <label className="label_responsibility">
            Responsibility
            <textarea
              className="textarea"
              name="responsibility"
              value={formData.responsibility}
              onChange={handleChange}
              required
            />
          </label>
          <button type="submit" className="submit-btn">
            Add Experience
          </button>
        </form>
      </div>
    </Container>
  );
};

export default Experience;
