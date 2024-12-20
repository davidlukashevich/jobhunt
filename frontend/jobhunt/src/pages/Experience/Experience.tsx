import React, { useContext, useEffect, useState } from "react";
import Container from "../../components/Container/Container";
import "./index.css";
import { useNavigate, useParams } from "react-router-dom";
import experienceApi from "../../api/experienceApi";
import UserDataContext from "../../components/UserDataMode/UserDataMode";
import exp from "constants";

type formDataType = {
  position: string
  companyname: string
  location: string
  responsibility: string
  workfrom: {
    year: number | undefined
    day: number | undefined
    month: number | undefined
  }
  workto: {
    year: number | undefined
    day: number | undefined
    month: number | undefined
  }
}


const Experience: React.FC = () => {
  const [formData, setFormData] = useState<formDataType>({
    position: '',
    companyname: "",
    location: "",
    responsibility: "",
    workfrom: {
      year: undefined as undefined | number,
      day: undefined as undefined | number,
      month: undefined as undefined | number
    },
    workto: {
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

  const { profileId, experience } = context;

  let { experienceId } = useParams();

  const navigate = useNavigate();

  useEffect(() => {
    if (experienceId) {
      const workFrom = experience.workFrom.split('/');
      const workTo = experience.workTo.split('/');
      setFormData({
        ...formData, position: experience.position, companyname: experience.companyName,
        location: experience.location, responsibility: experience.responsibility, workfrom: {
          ...formData.workfrom,
          year: Number(workFrom[2]), day: Number(workFrom[0]), month: Number(workFrom[1])
        }, workto: {
          ...formData.workto,
          year: Number(workTo[2]), day: Number(workTo[0]), month: Number(workTo[1])
        }
      })
    }
  }, []);

  const handleChange = (
    e: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement | HTMLSelectElement>
  ) => {
    const { name, value } = e.target;
    const [, date] = name.split('_');
    const valueNum = parseInt(value)
    if (name === "workfrom_year" || name === "workfrom_month" || name === "workfrom_day") {
      setFormData({ ...formData, workfrom: { ...formData.workfrom, [date]: valueNum } });
    } else if (name === "workto_year" || name === "workto_month" || name === "workto_day") {
      setFormData({ ...formData, workto: { ...formData.workto, [date]: valueNum } });
    } else {
      setFormData({ ...formData, [name]: value });
    }
  };

  const handleDeleteExperience = () => {
    experienceApi.deleteExperience(experienceId).then(data => {
      navigate("/myprofile");
    });
  }

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    if (!experienceId) {
      experienceApi.createExperience(formData, profileId).then(data => {
        navigate("/myprofile");
      })
    } else {
      experienceApi.updateExperience(formData, experienceId).then(data => {
        navigate("/myprofile");
      });
    }
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
              type="text"
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
            <select
              name="workfrom_day"
              className="select"
              value={formData.workfrom.day}
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
              name="workfrom_month"
              className="select"
              value={formData.workfrom.month}
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
              name="workfrom_year"
              className="select"
              value={formData.workfrom.year}
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
          <label className="label_workto">
            Work to
            <select
              name="workto_day"
              className="select"
              value={formData.workto.day}
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
              name="workto_month"
              className="select"
              value={formData.workto.month}
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
              name="workto_year"
              className="select"
              value={formData.workto.year}
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
          {!experienceId && <button type="submit" className="submit-btn-experience-add">
            Add Experience
          </button>}
          {experienceId && <><button type="submit" className="submit-btn-experience">
            Update Experience
          </button>
            <button onClick={handleDeleteExperience} className="experience_delete-button">
              Delete
            </button></>}
        </form>
      </div>
    </Container>
  );
};

export default Experience;
