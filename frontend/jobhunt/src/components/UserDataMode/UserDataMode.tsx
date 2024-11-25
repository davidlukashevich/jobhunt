import React, { createContext, useState } from "react";

interface UserDataContextInterface {
    children: React.ReactNode;
}

type ContextType = {
    token: string | null
    userId: string | null
    changeToken: (newToken: string) => void
    changeUserId: (newUserId: string) => void
}

const UserDataContext = createContext<ContextType | undefined>(undefined);

export function UserDataContextProvider (props: UserDataContextInterface) {

    const changeToken = (newToken: string) => {
        localStorage.setItem('token', newToken);
    }

    const changeUserId = (newUserId: string) => {
        localStorage.setItem('userId', newUserId);
    }

    let token = localStorage.getItem('token');
    let userId = localStorage.getItem('userId');


    return (
        <UserDataContext.Provider value={{token, userId, changeToken, changeUserId}}>
            {props.children}
        </UserDataContext.Provider>
    )
}

export default UserDataContext;