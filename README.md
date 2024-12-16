
# JobHunt Application

## Overview

The **JobHunt** application is a job portal that allows users to search for jobs, view detailed job descriptions, and apply for positions. This application includes features such as job search, job filtering, viewing job details, and submitting job applications. It is built with **React** for the frontend, using various hooks such as `useState` and `useParams`, and styled using **CSS**.

## Video for project
- https://drive.google.com/file/d/1LoaX9jQ-3uz8RsNOLLIC11wIoYwLAuxI/view?usp=sharing

## Features

- **Search Jobs**: Users can search for jobs by title.
- **Filter Jobs**: Jobs can be filtered based on the job title.
- **Job Details**: Detailed view of each job, including company information, responsibilities, requirements, and job location.
- **Job Application**: Users can submit applications for jobs, including their personal details, resume, and cover letter.
- **Add and Update Experience and Education**: Users can add and update their experience and education data to their profiles.

## Table of Contents

1. [Installation](#installation)
2. [Usage](#usage)
3. [Project Structure](#project-structure)
4. [Components](#components)
5. [State Management](#state-management)
6. [Routes](#routes)
7. [Technologies Used](#technologies-used)

## Installation

To set up and run the project locally, follow these steps:

1. Clone the repository:
   ```bash
   git clone https://github.com/abzalzhaksylyk/jobhunt.git
   ```

2. Navigate into the project directory:
   ```bash
   cd frontend
   cd jobhunt
   ```

3. Install the dependencies:
   ```bash
   yarn install
   ```

4. Run the application:
   ```bash
   yarn start
   ```

5. Open your browser and go to `http://localhost:3000` to see the application.

## Usage

After setting up the project, you can navigate through the following functionalities:

- **Home Page**: Browse through the available jobs and use the search bar to filter jobs.
- **Job Details**: Click on any job title to view more details about the job, including its description, responsibilities, and requirements.
- **Apply for Jobs**: Fill out the application form to apply for jobs. Include personal details, resume, and a cover letter.
- **Experience and Education Management**: Add or update your experience and education through the profile pages.

## Project Structure

```plaintext
src/
├── components/             # Reusable components such as Form, Card, Container, etc.
│   ├── Card/
│   ├── Container/
│   └── Form/
│   └── Footer/
│   └── Header/
├── pages/                  # Contains the page components for different views
│   ├── AuthPage/
│   ├── ApplicationForm/
│   ├── Education/
│   ├── Experience/
│   └── JobDetails/
│   └── Main/
│   └── PostJobOffer/
│   └── Profile/
├── App.tsx                 # Root component of the app
├── index.tsx               # Entry point for the application
├── App.css
```

### Components

- **Form**: A reusable form component used across different pages (e.g., for job applications, adding experience, etc.).
- **Container**: A wrapper component that provides consistent layout for all pages.
- **Card**: Displays individual job listings with minimal information like the job title.
- **Header**: Displays header.
- **Footer**: Displays footer.

### Pages

- **AuthPage**: Handles authentication and login.
- **JobDetails**: Displays detailed information about a selected job listing.
- **ApplicationForm**: A form for submitting job applications.
- **Experience**: A form for adding or editing professional experience.
- **Education**: A form for adding or editing educational details.
- **Main**: Main page that shows all the job postings. 
- **PostJobOffer**: Page where employees can post their job offers.
- **Profile**: Display profile of a user.

## State Management

The application uses **React's `useState` hook** to manage the following states:

- **Job Search State**: Holds the search query and filtered job results.
- **Job Details State**: Contains detailed information about a selected job.
- **Form Data State**: Manages the data input by the user in forms (e.g., job application, experience, education).

### Key States:

- `searchQuery`: Stores the current job search query entered by the user.
- `filteredJobs`: Stores the list of jobs filtered based on the search query.
- `jobDetails`: Stores detailed data of a selected job, such as responsibilities, requirements, and company information.
- `formData`: Stores the data from forms like job application, experience, and education.

## Routes

This application uses **React Router** for navigation between different views. The key routes are:

- `/` - Home page displaying the job listings.
- `/auth` - User log in/sign up page.
- `/job/:id` - Detailed job page for viewing job details.
- `/apply/:id` - Job application form page for submitting applications for a job.
- `/post-job-offer` - Employee post job offer page.
- `/myprofile` - User profile page to manage experice, education, and job applications.
- `/myprofile/experience/create` - User profile page to manage experience.
- `/myprofile/education/create` - User profile page to manage education.
- `/experience/:experienceId` - Page for adding or updating experience.
- `/education/:educationId` - Page for adding or updating education.

## Technologies Used

- **React**: JavaScript library for building user interfaces.
- **React Router**: For routing between pages.
- **React Icons**: For using icons throughout the application.
- **CSS**: For styling the components and pages.
- **TypeScript**: For type safety and enhanced development experience.
- **Material UI**: For styling.
- **ASP.NET Core Web API**: Framework for building RESTful APIs.
- **Entity Framework Core (EF Core)**: Object-relational mapper for interacting with the database.
- **Microsoft Azure Blob Storage**: For storing and managing files in the cloud.
- **Microsoft Azure Web App**: For hosting and running the application on the Azure platform.
- **Microsoft Azure PostgreSQL Server**: For database management and storage.

