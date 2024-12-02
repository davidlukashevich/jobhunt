import React from "react";
import { BrowserRouter, Routes, Route } from "react-router-dom";
import "./App.css";
import Header from "./components/Header/Header";
import Main from "./pages/Main/Main";
import AuthPage from "./pages/Auth/AuthPage";
import JobDetails from "./pages/JobDetails/JobDetails";
import ApplicationForm from "./pages/ApplicationForm/ApplicationForm";
import Footer from "./components/Footer/Footer";
import Profile from "./pages/Profile/Profile";
import PostJobOffer from "./pages/PostJobOffer/PostJobOffer";
import Experience from "./pages/Experience/Experience";
import Education from "./pages/Education/Education";

function App() {
  const userRole: "Employee" | "Employer" = "Employer";

  return (
    <BrowserRouter>
      <div className="App">
        <Header />
        <Routes>
          <Route path="/" Component={Main} />
          <Route path="/auth" Component={AuthPage} />
          <Route path="/job/:id" Component={JobDetails} />
          <Route path="/apply/:jobId" Component={ApplicationForm} />
          <Route path="/myprofile" element={<Profile role={userRole} />} />
          <Route path="/post-job-offer" element={<PostJobOffer />} />
          <Route path="myprofile/experience/create" Component={Experience} />
          <Route path="myprofile/education/create" Component={Education} />
          <Route
            path="myprofile/experience/update/:experienceId"
            Component={Experience}
          />
          <Route
            path="myprofile/education/update/:educationId"
            Component={Education}
          />
        </Routes>
        {/* <Footer/> */}
      </div>
    </BrowserRouter>
  );
}

export default App;
