import axios from "axios";

const profileApi = {
    getProfile(userId: string | null) {
        return axios.get(`https://jobhuntapi-e8gybug7bcb8h3bq.polandcentral-01.azurewebsites.net/api/profile/${userId}`).then(response => response.data);
    }
}

export default profileApi;