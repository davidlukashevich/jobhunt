import React, { createContext, useState } from "react";

interface UserDataContextInterface {
    children: React.ReactNode;
}

type ContextType = {
    userId: string | null
    name: string | null
    imageUrl: string | null
    profileId: string | null
    changeUserId: (newUserId: string) => void
    changeName: (newName: string) => void
    changeImageUrl: (newImageUrl: string) => void
    changeProfileId: (newProfileId: string) => void
    deleteData: () => void
}

const UserDataContext = createContext<ContextType | undefined>(undefined);

export function UserDataContextProvider (props: UserDataContextInterface) {
    const changeUserId = (newUserId: string) => {
        localStorage.setItem('userId', newUserId);
    }

    const changeName = (newName: string) => {
        localStorage.setItem('name', newName);
    }

    const changeImageUrl = (newImageUrl: string) => {
        localStorage.setItem('imageUrl', newImageUrl);
    }

    const changeProfileId = (newProfileId: string) => {
        localStorage.setItem('profileId', newProfileId);
    }

    const deleteData = () => {
        localStorage.removeItem('userId');
        localStorage.removeItem('name');
        localStorage.removeItem('imageUrl');
        localStorage.removeItem('profileId');
        
    }

    let userId = localStorage.getItem('userId');
    let name = localStorage.getItem('name');
    let imageUrl = localStorage.getItem('imageUrl');
    let profileId = localStorage.getItem('profileId');


    return (
        <UserDataContext.Provider value={{userId, name, imageUrl, profileId, changeUserId, changeName, changeImageUrl, changeProfileId, deleteData}}>
            {props.children}
        </UserDataContext.Provider>
    )
}

export default UserDataContext;