import axios from "axios";

const userApi = {
    userRegister(email: string, password: string, username: string, role: string) {
        return axios.post('https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/user/register', {email, password, username, role}, {
            withCredentials: true
        })
        .then(response => response.data);
    },
    userLogin(email: string, password: string) {
        return axios.post('https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/user/login', {email, password}, {
            withCredentials: true
        }).then(response =>response.data);
    },
    userLogout() {
        return axios.delete('https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/user/logout', {
            withCredentials: true
        });
    }
}

export default userApi;