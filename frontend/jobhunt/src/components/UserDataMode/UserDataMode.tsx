import React, { createContext, FC, useState } from "react";

interface UserDataContextInterface {
    children: React.ReactNode;
}

type ContextType = {
    token: string
    userId: string
    changeToken: (newToken: string) => void
    changeUserId: (newUserId: string) => void
}

const UserDataContext = createContext<ContextType | undefined>(undefined);

export function UserDataContextProvider (props: UserDataContextInterface) {
    const [token, setToken] = useState('');
    const [userId, setUserId] = useState('');

    const changeToken = (newToken: string) => {
        setToken(newToken);
    }

    const changeUserId = (newUserId: string) => {
        setUserId(newUserId);
    }

    return (
        <UserDataContext.Provider value={{token, userId, changeToken, changeUserId}}>
            {props.children}
        </UserDataContext.Provider>
    )
}

export default UserDataContext;