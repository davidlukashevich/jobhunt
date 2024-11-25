import axios from "axios";

const jobApplicationApi = {
    getAllJobApplicationsByUserId(userId: string | null, token: string) {
        return axios.get(`https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/jobapplication/createdBy/${userId}`, {
            headers: {
                'Authorization': `Bearer ${token}`
            }
        }).then(response => response.data);
    }
}

export default jobApplicationApi;