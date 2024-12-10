import React, { createContext, useState } from "react";

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
    title: string
    image: string
    changeRole: (newRole: string) => void
    changeUserId: (newUserId: string) => void
    changeName: (newName: string) => void
    changeImageUrl: (newImageUrl: string) => void
    changeProfileId: (newProfileId: string) => void
    deleteData: () => void
    changeJobData: (newImage: string, newTitle: string) => void
}

const UserDataContext = createContext<ContextType | undefined>(undefined);

export function UserDataContextProvider (props: UserDataContextInterface) {
    const [isLoading, setIsLoading] = useState(false);
    const [image, setImage] = useState('');
    const [title, setTitle] = useState('');

    const changeJobData = (newImage: string, newTitle: string) => {
        setImage(newImage);
        setTitle(newTitle);
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
        setIsLoading(!isLoading);
    }

    let userId = localStorage.getItem('userId');
    let name = localStorage.getItem('name');
    let imageUrl = localStorage.getItem('imageUrl');
    let profileId = localStorage.getItem('profileId');
    let role = localStorage.getItem('role');

    return (
        <UserDataContext.Provider value={{title, image, isLoading, name, userId, imageUrl, profileId, role, changeRole, changeUserId, changeName, changeImageUrl, changeProfileId, deleteData, changeJobData}}>
            {props.children}
        </UserDataContext.Provider>
    )
}

export default UserDataContext;