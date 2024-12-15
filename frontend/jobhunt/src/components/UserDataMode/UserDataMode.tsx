import React, { createContext, Dispatch, SetStateAction, useState } from "react";

interface UserDataContextInterface {
    children: React.ReactNode;
}

type ContextType = {
    userId: string | null
    imageUrl: string | null
    profileId: string | null
    role: string | null
    name: string | null
    isLoading: boolean
    title: string | null
    image: string | null
    experience: dataExperienceType
    education: dataEducationType
    profile: profileType
    jobId: string | null
    changeRole: (newRole: string) => void
    changeUserId: (newUserId: string) => void
    changeName: (newName: string) => void
    changeImageUrl: (newImageUrl: string) => void
    changeProfileId: (newProfileId: string) => void
    deleteData: () => void
    changeJobData: (newImage: string, newTitle: string) => void
    changeExperienceData: (newData: dataExperienceType) => void
    changeEducationData: (newData: dataEducationType) => void
    changeProfile: (newProfile: profileType) => void
    changeJobId: (newJobId: string) => void
}

type dataExperienceType = {
    id: string
    position: string
    companyName: string
    responsibility: string
    workFrom: string
    location: string
    workTo: string
}

type dataEducationType = {
    id: string
    universityName: string
    educationLevel: string
    fieldOfStudy: string
    specialization: string
    studyFrom: string
    studyTo: string
}

type profileType = {
    name: string
    lastName: string
    email: string
    phone: string
    dateOfBirth: string
    country: string
    city: string
    street: string
    profileSummary: string
    specialization: string
    file: string
    addressId: string
    imageId: string
}

const UserDataContext = createContext<ContextType | undefined>(undefined);

export function UserDataContextProvider(props: UserDataContextInterface) {
    const [isLoading, setIsLoading] = useState(false);

    const changeProfile = (newProfile: profileType) => {
        localStorage.setItem('profile', JSON.stringify(newProfile));
        setIsLoading(!isLoading);
    }

    const changeExperienceData = (newData: dataExperienceType) => {
        localStorage.setItem('experience', JSON.stringify(newData));
        setIsLoading(!isLoading);
    }

    const changeJobId = (newJobId: string) => {
        localStorage.setItem('jobId', newJobId);
    }

    const changeEducationData = (newData: dataEducationType) => {
        localStorage.setItem('education', JSON.stringify(newData));
        setIsLoading(!isLoading);
    }

    const changeJobData = (newImage: string, newTitle: string) => {
        localStorage.setItem('image', newImage);
        localStorage.setItem('title', newTitle);
        setIsLoading(!isLoading);
    }

    const changeUserId = (newUserId: string) => {
        localStorage.setItem('userId', newUserId);
        setIsLoading(!isLoading);
    }

    const changeName = (newName: string) => {
        localStorage.setItem('name', newName);
        setIsLoading(!isLoading);
    }

    const changeImageUrl = (newImageUrl: string) => {
        localStorage.setItem('imageUrl', newImageUrl);
    }

    const changeProfileId = (newProfileId: string) => {
        localStorage.setItem('profileId', newProfileId);
    }

    const changeRole = (newRole: string) => {
        localStorage.setItem('role', newRole);
    }

    const deleteData = () => {
        localStorage.removeItem('userId');
        localStorage.removeItem('profileId');
        localStorage.removeItem('role');
        localStorage.removeItem('name');
        localStorage.removeItem('experience');
        localStorage.removeItem('education');
        localStorage.removeItem('profile');
        localStorage.removeItem('loading');
        localStorage.removeItem('image');
        localStorage.removeItem('imageUrl');
        localStorage.removeItem('profileId');
        localStorage.removeItem('title');
        setIsLoading(!isLoading);
    }

    let experience = JSON.parse(localStorage.getItem('experience') as string);
    let education = JSON.parse(localStorage.getItem('education') as string);
    let profile = JSON.parse(localStorage.getItem('profile') as string);
    let title = localStorage.getItem('title');
    let image = localStorage.getItem('image');
    let userId = localStorage.getItem('userId');
    let name = localStorage.getItem('name');
    let imageUrl = localStorage.getItem('imageUrl');
    let profileId = localStorage.getItem('profileId');
    let role = localStorage.getItem('role');
    let jobId = localStorage.getItem('jobId');

    return (
        <UserDataContext.Provider value={{ jobId, profile, education, experience, title, image, isLoading, name, userId, imageUrl, profileId, role, changeEducationData, changeExperienceData, changeRole, changeUserId, changeName, changeImageUrl, changeProfileId, deleteData, changeJobData, changeProfile, changeJobId }}>
            {props.children}
        </UserDataContext.Provider>
    )
}

export default UserDataContext;